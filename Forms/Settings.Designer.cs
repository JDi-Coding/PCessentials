namespace PCessentials.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_S_Header = new System.Windows.Forms.Label();
            this.rBtn_S_lang_de = new System.Windows.Forms.RadioButton();
            this.rBtn_S_lang_eng = new System.Windows.Forms.RadioButton();
            this.gBox_S_lang = new System.Windows.Forms.GroupBox();
            this.gBox_S_Theme = new System.Windows.Forms.GroupBox();
            this.rbtn_S_ThemeDark = new System.Windows.Forms.RadioButton();
            this.rbtn_S_ThemeLight = new System.Windows.Forms.RadioButton();
            this.pnl_S_Left = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.gBox_S_Forms = new System.Windows.Forms.GroupBox();
            this.gBox_S_lang.SuspendLayout();
            this.gBox_S_Theme.SuspendLayout();
            this.pnl_S_Left.SuspendLayout();
            this.gBox_S_Forms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_S_Header
            // 
            this.lbl_S_Header.AutoSize = true;
            this.lbl_S_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_S_Header.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_S_Header.Location = new System.Drawing.Point(0, 0);
            this.lbl_S_Header.Name = "lbl_S_Header";
            this.lbl_S_Header.Size = new System.Drawing.Size(226, 41);
            this.lbl_S_Header.TabIndex = 0;
            this.lbl_S_Header.Text = "Einstellungen";
            this.lbl_S_Header.Click += new System.EventHandler(this.lbl_S_Header_Click);
            // 
            // rBtn_S_lang_de
            // 
            this.rBtn_S_lang_de.AutoSize = true;
            this.rBtn_S_lang_de.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtn_S_lang_de.Location = new System.Drawing.Point(16, 29);
            this.rBtn_S_lang_de.Name = "rBtn_S_lang_de";
            this.rBtn_S_lang_de.Size = new System.Drawing.Size(78, 23);
            this.rBtn_S_lang_de.TabIndex = 2;
            this.rBtn_S_lang_de.TabStop = true;
            this.rBtn_S_lang_de.Text = "Deutsch";
            this.rBtn_S_lang_de.UseVisualStyleBackColor = true;
            // 
            // rBtn_S_lang_eng
            // 
            this.rBtn_S_lang_eng.AutoSize = true;
            this.rBtn_S_lang_eng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtn_S_lang_eng.Location = new System.Drawing.Point(107, 30);
            this.rBtn_S_lang_eng.Name = "rBtn_S_lang_eng";
            this.rBtn_S_lang_eng.Size = new System.Drawing.Size(77, 23);
            this.rBtn_S_lang_eng.TabIndex = 3;
            this.rBtn_S_lang_eng.TabStop = true;
            this.rBtn_S_lang_eng.Text = "Englisch";
            this.rBtn_S_lang_eng.UseVisualStyleBackColor = true;
            // 
            // gBox_S_lang
            // 
            this.gBox_S_lang.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gBox_S_lang.Controls.Add(this.rBtn_S_lang_de);
            this.gBox_S_lang.Controls.Add(this.rBtn_S_lang_eng);
            this.gBox_S_lang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBox_S_lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBox_S_lang.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_S_lang.Location = new System.Drawing.Point(0, 41);
            this.gBox_S_lang.Name = "gBox_S_lang";
            this.gBox_S_lang.Size = new System.Drawing.Size(246, 59);
            this.gBox_S_lang.TabIndex = 4;
            this.gBox_S_lang.TabStop = false;
            this.gBox_S_lang.Text = "Sprache:";
            // 
            // gBox_S_Theme
            // 
            this.gBox_S_Theme.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gBox_S_Theme.Controls.Add(this.rbtn_S_ThemeDark);
            this.gBox_S_Theme.Controls.Add(this.rbtn_S_ThemeLight);
            this.gBox_S_Theme.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBox_S_Theme.Location = new System.Drawing.Point(0, 100);
            this.gBox_S_Theme.Name = "gBox_S_Theme";
            this.gBox_S_Theme.Size = new System.Drawing.Size(246, 70);
            this.gBox_S_Theme.TabIndex = 5;
            this.gBox_S_Theme.TabStop = false;
            this.gBox_S_Theme.Text = "Theme";
            // 
            // rbtn_S_ThemeDark
            // 
            this.rbtn_S_ThemeDark.AutoSize = true;
            this.rbtn_S_ThemeDark.Location = new System.Drawing.Point(107, 35);
            this.rbtn_S_ThemeDark.Name = "rbtn_S_ThemeDark";
            this.rbtn_S_ThemeDark.Size = new System.Drawing.Size(48, 17);
            this.rbtn_S_ThemeDark.TabIndex = 1;
            this.rbtn_S_ThemeDark.TabStop = true;
            this.rbtn_S_ThemeDark.Text = "Dark";
            this.rbtn_S_ThemeDark.UseVisualStyleBackColor = true;
            this.rbtn_S_ThemeDark.CheckedChanged += new System.EventHandler(this.rbtn_S_ThemeDark_CheckedChanged);
            // 
            // rbtn_S_ThemeLight
            // 
            this.rbtn_S_ThemeLight.AutoSize = true;
            this.rbtn_S_ThemeLight.Location = new System.Drawing.Point(16, 35);
            this.rbtn_S_ThemeLight.Name = "rbtn_S_ThemeLight";
            this.rbtn_S_ThemeLight.Size = new System.Drawing.Size(48, 17);
            this.rbtn_S_ThemeLight.TabIndex = 0;
            this.rbtn_S_ThemeLight.TabStop = true;
            this.rbtn_S_ThemeLight.Text = "Light";
            this.rbtn_S_ThemeLight.UseVisualStyleBackColor = true;
            this.rbtn_S_ThemeLight.CheckedChanged += new System.EventHandler(this.rbtn_S_ThemeLight_CheckedChanged);
            // 
            // pnl_S_Left
            // 
            this.pnl_S_Left.Controls.Add(this.gBox_S_Forms);
            this.pnl_S_Left.Controls.Add(this.gBox_S_Theme);
            this.pnl_S_Left.Controls.Add(this.gBox_S_lang);
            this.pnl_S_Left.Controls.Add(this.lbl_S_Header);
            this.pnl_S_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_S_Left.Location = new System.Drawing.Point(0, 0);
            this.pnl_S_Left.Name = "pnl_S_Left";
            this.pnl_S_Left.Size = new System.Drawing.Size(246, 483);
            this.pnl_S_Left.TabIndex = 6;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 16);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(240, 154);
            this.checkedListBox1.TabIndex = 7;
            // 
            // gBox_S_Forms
            // 
            this.gBox_S_Forms.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gBox_S_Forms.Controls.Add(this.checkedListBox1);
            this.gBox_S_Forms.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBox_S_Forms.Location = new System.Drawing.Point(0, 170);
            this.gBox_S_Forms.Name = "gBox_S_Forms";
            this.gBox_S_Forms.Size = new System.Drawing.Size(246, 205);
            this.gBox_S_Forms.TabIndex = 6;
            this.gBox_S_Forms.TabStop = false;
            this.gBox_S_Forms.Text = "Forms";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.pnl_S_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gBox_S_lang.ResumeLayout(false);
            this.gBox_S_lang.PerformLayout();
            this.gBox_S_Theme.ResumeLayout(false);
            this.gBox_S_Theme.PerformLayout();
            this.pnl_S_Left.ResumeLayout(false);
            this.pnl_S_Left.PerformLayout();
            this.gBox_S_Forms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_S_Header;
        private System.Windows.Forms.RadioButton rBtn_S_lang_de;
        private System.Windows.Forms.RadioButton rBtn_S_lang_eng;
        private System.Windows.Forms.GroupBox gBox_S_lang;
        private System.Windows.Forms.GroupBox gBox_S_Theme;
        private System.Windows.Forms.Panel pnl_S_Left;
        private System.Windows.Forms.RadioButton rbtn_S_ThemeDark;
        private System.Windows.Forms.RadioButton rbtn_S_ThemeLight;
        private System.Windows.Forms.GroupBox gBox_S_Forms;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}