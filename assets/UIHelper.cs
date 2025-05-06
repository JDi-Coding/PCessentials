using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PCessentials.assets
{
    /// <summary>
    /// Class for Styling UIElements.
    /// </summary>
    public static class UIHelper
    {
        // Central property to check for DarkMode
        private static bool IsDarkMode => config.isDarkmode();

        #region Forms
        public static void StyleModernMainForm(Form form, Color? borderColor = null)
        {
            // Grund-Layout
            form.BackColor = IsDarkMode ? Color.FromArgb(30, 30, 30) : Color.WhiteSmoke;
            form.ForeColor = IsDarkMode ? Color.White : Color.Black;
            form.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = true;
            form.MinimizeBox = true;
            form.AutoScaleMode = AutoScaleMode.Font;
            form.Padding = new Padding(1);
            Color border = borderColor ?? (IsDarkMode ? Color.DimGray : Color.LightGray);

            // Custom Border
            form.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, form.ClientRectangle,
                                        border, 1, ButtonBorderStyle.Solid,
                                        border, 1, ButtonBorderStyle.Solid,
                                        border, 1, ButtonBorderStyle.Solid,
                                        border, 1, ButtonBorderStyle.Solid);
            };

            try
            {
                form.Region = System.Drawing.Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, form.Width, form.Height, 10, 10));
            }
            catch { /* if W<11 Ignore */ }

            // Event-Handler SizeChanges
            form.Resize += (sender, e) =>
            {
                try
                {
                    form.Region = System.Drawing.Region.FromHrgn(
                        CreateRoundRectRgn(0, 0, form.Width, form.Height, 10, 10));
                }
                catch { /* Ignorieren */ }
                form.Invalidate();
            };

            // activate Form-Styles over the Form- Instance
            if (form is Forms.MainForm mainForm)
            {
                mainForm.EnableFormStyles();
            }
        }

        /// <summary>
        /// Styles a child form to have a modern look.
        /// </summary>
        /// <param name="form"></param>
        public static void StyleModernChildForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            form.BackColor = IsDarkMode ? Color.FromArgb(45, 45, 48) : Color.White;
            form.ForeColor = IsDarkMode ? Color.White : Color.Black;
            form.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        #endregion

        #region FormElements

        /// <summary>
        /// Styles a ListBox to have a modern look.
        /// </summary>
        /// <param name="listBox"></param>
        public static void StyleModernListBox(ListBox listBox)
        {
            if (listBox == null) return;
            // Grund-Einstellungen
            listBox.BorderStyle = BorderStyle.None;
            listBox.DrawMode = DrawMode.OwnerDrawFixed;
            listBox.ItemHeight = 30;
            listBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // Farben je nach Light/Dark Mode
            bool isDarkMode = Properties.Settings.Default.DarkModeEnabled; // <-- direkt hier abgefragt

            listBox.BackColor = isDarkMode ? Color.FromArgb(45, 45, 48) : Color.White;
            listBox.ForeColor = isDarkMode ? Color.White : Color.Black;

            int hoverIndex = -1;

            // Farbschema definieren
            Color selectionColor = isDarkMode ? Color.FromArgb(70, 70, 80) : Color.FromArgb(220, 220, 220);
            Color hoverColor = isDarkMode ? Color.FromArgb(60, 60, 70) : Color.FromArgb(240, 240, 240);
            Color normalTextColor = isDarkMode ? Color.White : Color.Black;
            Color selectedTextColor = isDarkMode ? Color.White : Color.Black;

            // Zeichen-Logik
            listBox.DrawItem += (sender, e) =>
            {
                if (e.Index < 0) return;

                bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
                bool isHover = e.Index == hoverIndex;

                // 1) Hintergrund zeichnen
                Color backgroundColor = isSelected
                    ? selectionColor
                    : isHover
                        ? hoverColor
                        : listBox.BackColor;

                using (var backBrush = new SolidBrush(backgroundColor))
                    e.Graphics.FillRectangle(backBrush, e.Bounds);

                // 2) Text zeichnen
                Color textColor = isSelected ? selectedTextColor : normalTextColor;
                TextRenderer.DrawText(
                    e.Graphics,
                    listBox.Items[e.Index].ToString(),
                    listBox.Font,
                    e.Bounds,
                    textColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

                // 3) Fokus-Rechteck
                e.DrawFocusRectangle();
            };

            // Hover-Handling
            listBox.MouseMove += (sender, e) =>
            {
                int idx = listBox.IndexFromPoint(e.Location);
                if (idx != hoverIndex)
                {
                    hoverIndex = idx;
                    listBox.Invalidate(); // neu zeichnen
                }
            };
            listBox.MouseLeave += (sender, e) =>
            {
                hoverIndex = -1;
                listBox.Invalidate();
            };
        }

        /// <summary>
        /// Applies a modern style to a TextBox.
        /// </summary>
        public static void StyleModernTextBox(TextBox textBox)
        {
            if (textBox == null) return;

            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = IsDarkMode ? Color.FromArgb(30, 30, 30) : Color.White;
            textBox.ForeColor = IsDarkMode ? Color.White : Color.Black;
            textBox.Font = new Font("Segoe UI", 10);
        }

        /// <summary>
        /// Applies a modern style to a Button.
        /// </summary>
        public static void StyleModernButton(Button button)
        {
            if (button == null) return;

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = IsDarkMode ? Color.DimGray : Color.LightGray;
            button.BackColor = IsDarkMode ? Color.FromArgb(50, 50, 50) : Color.WhiteSmoke;
            button.ForeColor = IsDarkMode ? Color.White : Color.Black;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Applies a modern style to a RadioButton.
        /// </summary>
        public static void StyleModernRadioButton(RadioButton radioButton)
        {
            if (radioButton == null) return;

            // FlatStyle für modernen Look
            radioButton.FlatStyle = FlatStyle.Flat;
            radioButton.BackColor = Color.Transparent;

            // Setzt die Textfarbe basierend auf dem DarkMode Status
            radioButton.ForeColor = IsDarkMode ? Color.LightSkyBlue : Color.Black;

            // Setzt den Font für den RadioButton
            radioButton.Font = new Font("Segoe UI", 11);

            // Färbt nur den Kreis je nach Zustand
            radioButton.FlatAppearance.BorderSize = 2; // Dicke des Randes

            radioButton.CheckedChanged += (sender, e) =>
            {
                if (radioButton.Checked)
                {
                    radioButton.FlatAppearance.BorderColor = IsDarkMode ? Color.DarkBlue : Color.DeepSkyBlue;
                }
            };

        }

        /// <summary>
        /// Applies a modern style to a CheckBox.
        /// </summary>
        public static void StyleModernCheckBox(CheckBox checkBox)
        {
            if (checkBox == null) return;

            checkBox.FlatStyle = FlatStyle.Flat;
            checkBox.BackColor = Color.Transparent;
            checkBox.ForeColor = IsDarkMode ? Color.White : Color.Black;
            checkBox.Font = new Font("Segoe UI", 10);
        }

        /// <summary>
        /// Applies a modern style to a Panel.
        /// </summary>
        public static void StyleModernPanel(Panel panel)
        {
            if (panel == null) return;

            panel.BackColor = IsDarkMode ? Color.FromArgb(45, 45, 48) : Color.WhiteSmoke;
            panel.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// Applies a modern style to a Label.
        /// Can optionally be styled as a headline.
        /// </summary>
        public static void StyleModernLabel(Label label, bool isHeadline = false)
        {
            if (label == null) return;

            label.BackColor = Color.Transparent;
            label.ForeColor = IsDarkMode ? Color.White : Color.Black;

            if (isHeadline)
            {
                label.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            else
            {
                label.Font = new Font("Segoe UI", 10);
            }
        }
        /// <summary>
        /// Applies a modern style to a GroupBox.
        /// </summary>
        /// <param name="groupBox"></param>
        public static void StyleModernGroupBox(GroupBox groupBox)
        {
            if (groupBox == null) return;

            groupBox.BackColor = IsDarkMode ? Color.FromArgb(45, 45, 48) : Color.White;
            groupBox.ForeColor = IsDarkMode ? Color.White : Color.Black;
            groupBox.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        /// <summary>
        /// Applies a modern style to a ComboBox.
        /// </summary>
        /// <param name="comboBox"></param>
        public static void StyleModernComboBox(ComboBox comboBox)
        {
            if (comboBox == null) return;

            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.BackColor = IsDarkMode ? Color.FromArgb(30, 30, 30) : Color.White;
            comboBox.ForeColor = IsDarkMode ? Color.White : Color.Black;
            comboBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList; // optional: verhindert Eingaben
        }

        /// <summary>
        /// Applies a modern style to a TrackBar.
        /// </summary>
        /// <param name="trackBar"></param>
        public static void StyleModernTrackBar(TrackBar trackBar)
        {
            if (trackBar == null) return;

            trackBar.BackColor = IsDarkMode ? Color.FromArgb(45, 45, 48) : Color.White;
            trackBar.TickStyle = TickStyle.None; // modernes flaches Aussehen ohne Ticks
        }

        /// <summary>
        /// Applies a modern style to a ProgressBar.
        /// </summary>
        /// <param name="progressBar"></param>
        public static void StyleModernProgressBar(ProgressBar progressBar)
        {
            if (progressBar == null) return;

            progressBar.BackColor = IsDarkMode ? Color.FromArgb(60, 60, 60) : Color.LightGray;
            progressBar.ForeColor = IsDarkMode ? Color.Teal : Color.DeepSkyBlue;
            progressBar.Style = ProgressBarStyle.Continuous;
        }

        #endregion

        #region HelperM
        /// <summary>
        /// Importiert die CreateRoundRectRgn-Funktion aus der gdi32.dll.
        /// Diese Funktion erstellt ein Rechteck mit abgerundeten Ecken.
        /// </summary>
        /// <param name="nLeftRect">Die x-Koordinate der linken oberen Ecke des Rechtecks.</param>
        /// <param name="nTopRect">Die y-Koordinate der linken oberen Ecke des Rechtecks.</param>
        /// <param name="nRightRect">Die x-Koordinate der rechten unteren Ecke des Rechtecks.</param>
        /// <param name="nBottomRect">Die y-Koordinate der rechten unteren Ecke des Rechtecks.</param>
        /// <param name="nWidthEllipse">Die Breite der Ellipse, die die Ecken abrundet.</param>
        /// <param name="nHeightEllipse">Die Höhe der Ellipse, die die Ecken abrundet.</param>
        /// <returns>Ein Handle (IntPtr) auf die erstellte Region.</returns>
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse);

        #endregion
    }
}
