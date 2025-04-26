namespace PCessentials.Forms
{
    partial class FinanceHelper
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
            this.lbl_FH_Header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_FH_Header
            // 
            this.lbl_FH_Header.AutoSize = true;
            this.lbl_FH_Header.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FH_Header.Location = new System.Drawing.Point(12, 9);
            this.lbl_FH_Header.Name = "lbl_FH_Header";
            this.lbl_FH_Header.Size = new System.Drawing.Size(247, 41);
            this.lbl_FH_Header.TabIndex = 0;
            this.lbl_FH_Header.Text = "Finance Helper";
            // 
            // FinanceHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_FH_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinanceHelper";
            this.Text = "FinanceHelper";
            this.Load += new System.EventHandler(this.FinanceHelper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FH_Header;
    }
}