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
            this.gBox_S_lang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_S_Header
            // 
            this.lbl_S_Header.AutoSize = true;
            this.lbl_S_Header.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_S_Header.Location = new System.Drawing.Point(5, 9);
            this.lbl_S_Header.Name = "lbl_S_Header";
            this.lbl_S_Header.Size = new System.Drawing.Size(226, 41);
            this.lbl_S_Header.TabIndex = 0;
            this.lbl_S_Header.Text = "Einstellungen";
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
            this.rBtn_S_lang_eng.Location = new System.Drawing.Point(98, 29);
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
            this.gBox_S_lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBox_S_lang.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_S_lang.Location = new System.Drawing.Point(12, 58);
            this.gBox_S_lang.Name = "gBox_S_lang";
            this.gBox_S_lang.Size = new System.Drawing.Size(194, 86);
            this.gBox_S_lang.TabIndex = 4;
            this.gBox_S_lang.TabStop = false;
            this.gBox_S_lang.Text = "Sprache:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBox_S_lang);
            this.Controls.Add(this.lbl_S_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.gBox_S_lang.ResumeLayout(false);
            this.gBox_S_lang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_S_Header;
        private System.Windows.Forms.RadioButton rBtn_S_lang_de;
        private System.Windows.Forms.RadioButton rBtn_S_lang_eng;
        private System.Windows.Forms.GroupBox gBox_S_lang;
    }
}