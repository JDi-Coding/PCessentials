using PCessentials.assets;
using PCessentials.assets.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCessentials.Forms
{
    public partial class MainForm : Form
    {
        private readonly FormService _formService;
        private Color defaultButtonColor = SystemColors.Control;
        private Color activeButtonColor = Color.LightBlue;
        private Button currentButton;
        private string currentFormKey;
        private bool isFullscreen = false;


        public void EnableFormStyles()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        private void StyleForm()
        {
            // Apply modern styling
            UIHelper.StyleModernMainForm(this, Color.DodgerBlue);
            UIHelper.StyleModernListBox(listBoxForms);
            //UIHelper.StyleModernPanel(pnl_MF_Content);
            UIHelper.StyleModernPanel(pnl_MF_Top);
            UIHelper.StyleModernPanel(pnl_MF_TopLeft);
            UIHelper.StyleModernPanel(pnl_MF_Sidebar);
            UIHelper.StyleModernPanel(pnl_MF_SidebarBottom);
        }

        public MainForm()
        {
            InitializeComponent();
            EnableFormStyles();
            StyleForm();
            config.DarkModeChanged += StyleForm;


            //mouse events for dragging and Resizing the MainForm
            this.FormBorderStyle = FormBorderStyle.None;
            // Wire up MouseDown on the entire form to allow dragging
            this.MouseDown += MainForm_WindowMoveAndResize;
            // Optionally, if you have a title bar panel:
            this.pnl_MF_Top.MouseDown += MainForm_WindowMoveAndResize;

            // Instantiate the logic class
            _formService = new FormService();

            // Fill ListBox with all available form names
            listBoxForms.DataSource = _formService.getFormNames().ToList();
            listBoxForms.SelectedIndexChanged += ListBoxForms_SelectedIndexChanged;

            // Timer für Fade-In/Out
            _fadeTimer = new Timer { Interval = FadeInterval };
            _fadeTimer.Tick += FadeTimer_Tick;

            // Dragging
            this.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
                }
            };

            // Resize/Restore Animation Timer
            _resizeTimer = new Timer { Interval = 15 };
            _resizeTimer.Tick += ResizeTimer_Tick;

            // Track previous state for restore detection
            _prevWindowState = this.WindowState;
            this.Resize += MainForm_Resize;
        }

        #region Form Resize and Moving
        // Hit-test messages & codes for moving and resizing
        private const int WM_NCHITTEST = 0x84;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        // P/Invoke for dragging
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST)
            {
                // lParam enthält Screen-Koordinaten
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() >> 16) & 0xFFFF);
                Point pt = this.PointToClient(new Point(x, y));

                // DPI-korrigierte Grip-Größe (hier 24px @96dpi)
                int gripSize = (int)(24 * this.DeviceDpi / 96f);

                // Ecken zuerst
                if (pt.X <= gripSize && pt.Y <= gripSize)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (pt.X >= this.ClientSize.Width - gripSize && pt.Y <= gripSize)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (pt.X <= gripSize && pt.Y >= this.ClientSize.Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (pt.X >= this.ClientSize.Width - gripSize && pt.Y >= this.ClientSize.Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                // dann Kanten
                else if (pt.X <= gripSize)
                    m.Result = (IntPtr)HTLEFT;
                else if (pt.X >= this.ClientSize.Width - gripSize)
                    m.Result = (IntPtr)HTRIGHT;
                else if (pt.Y <= gripSize)
                    m.Result = (IntPtr)HTTOP;
                else if (pt.Y >= this.ClientSize.Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOM;
                else
                    m.Result = (IntPtr)HTCLIENT;

                return; // wir haben das Hit-Test-Ergebnis gesetzt
            }

            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void MainForm_WindowMoveAndResize(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
            }
        }

        

        #endregion

        #region Child Form Management

        /// <summary>
        /// Closes and disposes the currently active child form.
        /// </summary>
        private void CloseActiveForm()
        {
            pnl_MF_Content.SuspendLayout();
            try
            {
                foreach (Control ctrl in pnl_MF_Content.Controls)
                {
                    if (ctrl is Form f)
                    {
                        f.Close();   // Closes the form (calls OnClosing, OnClosed, etc.)
                        f.Dispose(); // Important: Frees all unmanaged resources
                    }
                }
                pnl_MF_Content.Controls.Clear();
                pnl_MF_Content.Tag = null;
            }
            finally
            {
                pnl_MF_Content.ResumeLayout();
            }
        }

        /// <summary>
        /// Opens the given child form inside our content panel.
        /// Button color change only happens if a button is passed.
        /// </summary>
        private void OpenChildForm(Form childForm, Button senderButton)
        {
            if (senderButton != null)
            {
                if (currentButton != null)
                {
                    currentButton.BackColor = defaultButtonColor;
                }

                currentButton = senderButton;
                currentButton.BackColor = activeButtonColor;
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_MF_Content.Controls.Add(childForm);
            pnl_MF_Content.Tag = childForm;
            UIHelper.StyleModernChildForm(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>
        /// Switches the form based on the selected item in the ListBox.
        /// If the same item is selected again, the current form will simply be closed.
        /// </summary>
        private void ListBoxForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(listBoxForms.SelectedItem is string formKey))
            {
                return;
            }

            if (string.Equals(currentFormKey, formKey, StringComparison.Ordinal))
            {
                CloseActiveForm();
                currentFormKey = null;
                return;
            }

            CloseActiveForm();
            var form = _formService.createForm(formKey);
            OpenChildForm(form, null);
            currentFormKey = formKey;
        }


        #endregion

        #region Application Control Buttons
        // Animation-Timer
        private Timer _fadeTimer;
        private Timer _resizeTimer;

        //Close/Minimize Animation
        private double _fadeProgress;
        private const int FadeInterval = 20;    // ms per Step
        private const int FadeDuration = 140;   // ms in total

        //Fullscreen Toggle Animation
        private Rectangle _resizeStart;
        private Rectangle _resizeTarget;
        private double _resizeProgress;
        private const int ResizeInterval = 20;   // ms per Step
        private const int ResizeDuration = 260;  // ms in total
        private Rectangle _normalBounds;
        private FormWindowState _prevWindowState;

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Detect restore from minimize
            if (_prevWindowState == FormWindowState.Minimized && this.WindowState == FormWindowState.Normal)
            {
                // Animate expand from bottom
                _resizeStart = new Rectangle(
                    _normalBounds.X,
                    Screen.FromControl(this).WorkingArea.Bottom - 50,
                    _normalBounds.Width,
                    50);
                _resizeTarget = _normalBounds;
                _resizeProgress = 0;
                _resizeTimer.Tag = "restore";
                // Immediately set to start
                this.Bounds = _resizeStart;
                _resizeTimer.Start();
            }
            _prevWindowState = this.WindowState;
        }

        #region Close Animation

        private void btn_MF_Close_Click(object sender, EventArgs e)
        {
            // Starte die Fade-Out-Animation
            _fadeProgress = 0;
            _fadeTimer.Tag = "close";
            _fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            _fadeProgress += (double)FadeInterval / FadeDuration;
            this.Opacity = 1.0 - _fadeProgress;

            if (_fadeProgress >= 1.0)
            {
                _fadeTimer.Stop();
                var action = (string)_fadeTimer.Tag;
                if (action == "close")
                    this.Close();
                else if (action == "minimize")
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.Opacity = 1.0; // zurücksetzen
                }
            }
        }

        #endregion

        #region Minimize Animation

        private void btn_MF_Minimize_Click(object sender, EventArgs e)
        {
            // Store normal bounds for restore
            _normalBounds = this.Bounds;

            // Prepare shrink animation
            _resizeStart = this.Bounds;
            _resizeTarget = new Rectangle(
                this.Bounds.X,
                Screen.FromControl(this).WorkingArea.Bottom - 50,
                this.Bounds.Width,
                50);

            _resizeProgress = 0;
            _resizeTimer.Tag = "minimize";
            _resizeTimer.Start();
            // Fade-Out vor Minimize
            _fadeProgress = 0;
            _fadeTimer.Tag = "minimize";
            _fadeTimer.Start();
        }

        #endregion

        #region Fullscreen Toggle Animation

        private void btn_MF_WindowState_Click(object sender, EventArgs e)
        {
            // Ziel setzen
            if (!isFullscreen)
            {
                // Merke aktuelle Bounds
                _normalBounds = this.Bounds;
                _resizeStart = this.Bounds;
                _resizeTarget = Screen.FromControl(this).WorkingArea; // Vollbild ohne Taskbar
            }
            else
            {
                _resizeStart = this.Bounds;
                _resizeTarget = _normalBounds;
            }

            // Icon umschalten
            btn_MF_WindowState.BackgroundImage = !isFullscreen
                ? PCessentials.Properties.Resources.WindowScreen
                : PCessentials.Properties.Resources.FullScreen;

            _resizeProgress = 0;
            _resizeTimer.Start();
            isFullscreen = !isFullscreen;
        }

        private void ResizeTimer_Tick(object sender, EventArgs e)
        {
            _resizeProgress += (double)ResizeInterval / ResizeDuration; // 300ms total
            if (_resizeProgress > 1.0) _resizeProgress = 1.0;

            // Interpolate bounds
            int x = (int)(_resizeStart.X + (_resizeTarget.X - _resizeStart.X) * _resizeProgress);
            int y = (int)(_resizeStart.Y + (_resizeTarget.Y - _resizeStart.Y) * _resizeProgress);
            int w = (int)(_resizeStart.Width + (_resizeTarget.Width - _resizeStart.Width) * _resizeProgress);
            int h = (int)(_resizeStart.Height + (_resizeTarget.Height - _resizeStart.Height) * _resizeProgress);
            this.Bounds = new Rectangle(x, y, w, h);

            // On complete
            if (_resizeProgress >= 1.0)
            {
                _resizeTimer.Stop();
                var action = (string)_resizeTimer.Tag;
                if (action == "minimize")
                {
                    this.WindowState = FormWindowState.Minimized;
                }
            }
        }

        #endregion

        #endregion
    }
}
