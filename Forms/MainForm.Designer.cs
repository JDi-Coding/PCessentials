namespace PCessentials
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btn_FormFinanceHelper = new System.Windows.Forms.Button();
            this.btn_FormWebDownloader = new System.Windows.Forms.Button();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnForm1 = new System.Windows.Forms.Button();
            this.btn_FormPrint = new System.Windows.Forms.Button();
            this.pnl_MF_sidebarBottom = new System.Windows.Forms.Panel();
            this.btn_MF_settings = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pnl_MF_Top = new System.Windows.Forms.Panel();
            this.tT_btn_MF_settings = new System.Windows.Forms.ToolTip(this.components);
            this.btn_FormHelp = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.pnl_MF_sidebarBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSidebar.Controls.Add(this.btn_FormFinanceHelper);
            this.panelSidebar.Controls.Add(this.btn_FormWebDownloader);
            this.panelSidebar.Controls.Add(this.btnForm3);
            this.panelSidebar.Controls.Add(this.btnForm2);
            this.panelSidebar.Controls.Add(this.btnForm1);
            this.panelSidebar.Controls.Add(this.btn_FormPrint);
            this.panelSidebar.Controls.Add(this.pnl_MF_sidebarBottom);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(270, 761);
            this.panelSidebar.TabIndex = 0;
            // 
            // btn_FormFinanceHelper
            // 
            this.btn_FormFinanceHelper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FormFinanceHelper.Location = new System.Drawing.Point(0, 250);
            this.btn_FormFinanceHelper.Name = "btn_FormFinanceHelper";
            this.btn_FormFinanceHelper.Size = new System.Drawing.Size(268, 50);
            this.btn_FormFinanceHelper.TabIndex = 5;
            this.btn_FormFinanceHelper.Text = "FinanaceHelper";
            this.btn_FormFinanceHelper.UseVisualStyleBackColor = true;
            // 
            // btn_FormWebDownloader
            // 
            this.btn_FormWebDownloader.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FormWebDownloader.Location = new System.Drawing.Point(0, 200);
            this.btn_FormWebDownloader.Name = "btn_FormWebDownloader";
            this.btn_FormWebDownloader.Size = new System.Drawing.Size(268, 50);
            this.btn_FormWebDownloader.TabIndex = 4;
            this.btn_FormWebDownloader.Text = "WebDownloader";
            this.btn_FormWebDownloader.UseVisualStyleBackColor = true;
            this.btn_FormWebDownloader.Click += new System.EventHandler(this.btn_FormWebDownloader_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForm3.Location = new System.Drawing.Point(0, 150);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(268, 50);
            this.btnForm3.TabIndex = 2;
            this.btnForm3.Text = "Password Manager";
            this.btnForm3.UseVisualStyleBackColor = true;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForm2.Location = new System.Drawing.Point(0, 100);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(268, 50);
            this.btnForm2.TabIndex = 1;
            this.btnForm2.Text = "BotControl";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnForm1
            // 
            this.btnForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForm1.Location = new System.Drawing.Point(0, 50);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(268, 50);
            this.btnForm1.TabIndex = 0;
            this.btnForm1.Text = "DownloadCleaner";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // btn_FormPrint
            // 
            this.btn_FormPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FormPrint.Location = new System.Drawing.Point(0, 0);
            this.btn_FormPrint.Name = "btn_FormPrint";
            this.btn_FormPrint.Size = new System.Drawing.Size(268, 50);
            this.btn_FormPrint.TabIndex = 3;
            this.btn_FormPrint.Text = "Drucken";
            this.btn_FormPrint.UseVisualStyleBackColor = true;
            this.btn_FormPrint.Click += new System.EventHandler(this.btn_FormPrint_Click);
            // 
            // pnl_MF_sidebarBottom
            // 
            this.pnl_MF_sidebarBottom.Controls.Add(this.btn_FormHelp);
            this.pnl_MF_sidebarBottom.Controls.Add(this.btn_MF_settings);
            this.pnl_MF_sidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_MF_sidebarBottom.Location = new System.Drawing.Point(0, 659);
            this.pnl_MF_sidebarBottom.Name = "pnl_MF_sidebarBottom";
            this.pnl_MF_sidebarBottom.Size = new System.Drawing.Size(268, 100);
            this.pnl_MF_sidebarBottom.TabIndex = 0;
            // 
            // btn_MF_settings
            // 
            this.btn_MF_settings.Location = new System.Drawing.Point(11, 66);
            this.btn_MF_settings.Name = "btn_MF_settings";
            this.btn_MF_settings.Size = new System.Drawing.Size(90, 23);
            this.btn_MF_settings.TabIndex = 0;
            this.btn_MF_settings.Text = "Einstellungen";
            this.btn_MF_settings.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.DimGray;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(270, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1534, 761);
            this.panelContainer.TabIndex = 1;
            // 
            // pnl_MF_Top
            // 
            this.pnl_MF_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_MF_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MF_Top.Location = new System.Drawing.Point(270, 0);
            this.pnl_MF_Top.Name = "pnl_MF_Top";
            this.pnl_MF_Top.Size = new System.Drawing.Size(1534, 29);
            this.pnl_MF_Top.TabIndex = 2;
            // 
            // tT_btn_MF_settings
            // 
            this.tT_btn_MF_settings.ToolTipTitle = "HEllo";
            // 
            // btn_FormHelp
            // 
            this.btn_FormHelp.Location = new System.Drawing.Point(130, 66);
            this.btn_FormHelp.Name = "btn_FormHelp";
            this.btn_FormHelp.Size = new System.Drawing.Size(75, 23);
            this.btn_FormHelp.TabIndex = 1;
            this.btn_FormHelp.Text = "Help";
            this.btn_FormHelp.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1804, 761);
            this.Controls.Add(this.pnl_MF_Top);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSidebar);
            this.Name = "MainForm";
            this.Text = "PCessentials";
            this.panelSidebar.ResumeLayout(false);
            this.pnl_MF_sidebarBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnForm3;
        private System.Windows.Forms.Button btn_FormPrint;
        private System.Windows.Forms.Button btn_FormWebDownloader;
        private System.Windows.Forms.Panel pnl_MF_sidebarBottom;
        private System.Windows.Forms.Button btn_MF_settings;
        private System.Windows.Forms.Panel pnl_MF_Top;
        private System.Windows.Forms.ToolTip tT_btn_MF_settings;
        private System.Windows.Forms.Button btn_FormFinanceHelper;
        private System.Windows.Forms.Button btn_FormHelp;
    }
}
