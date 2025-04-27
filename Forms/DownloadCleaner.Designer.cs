namespace PCessentials.Forms
{
    partial class DownloadCleaner
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
            this.btn_StartCleaning = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_StatusMsg = new System.Windows.Forms.Label();
            this.cbox_StartUp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_DC_Top = new System.Windows.Forms.Panel();
            this.lbl_DC_Header = new System.Windows.Forms.Label();
            this.gBox_DC_cleaner = new System.Windows.Forms.GroupBox();
            this.pnl_DC_Top.SuspendLayout();
            this.gBox_DC_cleaner.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_StartCleaning
            // 
            this.btn_StartCleaning.BackColor = System.Drawing.Color.Silver;
            this.btn_StartCleaning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StartCleaning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_StartCleaning.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_StartCleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartCleaning.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartCleaning.ForeColor = System.Drawing.Color.Black;
            this.btn_StartCleaning.Location = new System.Drawing.Point(3, 252);
            this.btn_StartCleaning.Name = "btn_StartCleaning";
            this.btn_StartCleaning.Size = new System.Drawing.Size(377, 45);
            this.btn_StartCleaning.TabIndex = 0;
            this.btn_StartCleaning.Text = "Start Cleaning";
            this.btn_StartCleaning.UseVisualStyleBackColor = false;
            this.btn_StartCleaning.Click += new System.EventHandler(this.btn_StartCleaning_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(6, 195);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(124, 36);
            this.lbl_Status.TabIndex = 1;
            this.lbl_Status.Text = "Status:  ";
            // 
            // lbl_StatusMsg
            // 
            this.lbl_StatusMsg.AutoSize = true;
            this.lbl_StatusMsg.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusMsg.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_StatusMsg.Location = new System.Drawing.Point(117, 195);
            this.lbl_StatusMsg.Name = "lbl_StatusMsg";
            this.lbl_StatusMsg.Size = new System.Drawing.Size(27, 36);
            this.lbl_StatusMsg.TabIndex = 2;
            this.lbl_StatusMsg.Text = "-";
            // 
            // cbox_StartUp
            // 
            this.cbox_StartUp.AutoSize = true;
            this.cbox_StartUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbox_StartUp.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_StartUp.Location = new System.Drawing.Point(3, 52);
            this.cbox_StartUp.Name = "cbox_StartUp";
            this.cbox_StartUp.Size = new System.Drawing.Size(377, 32);
            this.cbox_StartUp.TabIndex = 3;
            this.cbox_StartUp.Text = "Run on Startup";
            this.cbox_StartUp.UseVisualStyleBackColor = true;
            this.cbox_StartUp.CheckedChanged += new System.EventHandler(this.cbox_StartUp_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Run on Startup";
            // 
            // pnl_DC_Top
            // 
            this.pnl_DC_Top.Controls.Add(this.lbl_DC_Header);
            this.pnl_DC_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_DC_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_DC_Top.Name = "pnl_DC_Top";
            this.pnl_DC_Top.Size = new System.Drawing.Size(500, 28);
            this.pnl_DC_Top.TabIndex = 5;
            // 
            // lbl_DC_Header
            // 
            this.lbl_DC_Header.AutoSize = true;
            this.lbl_DC_Header.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_DC_Header.Location = new System.Drawing.Point(0, 0);
            this.lbl_DC_Header.Name = "lbl_DC_Header";
            this.lbl_DC_Header.Size = new System.Drawing.Size(91, 13);
            this.lbl_DC_Header.TabIndex = 6;
            this.lbl_DC_Header.Text = "DownloadCleaner";
            // 
            // gBox_DC_cleaner
            // 
            this.gBox_DC_cleaner.Controls.Add(this.btn_StartCleaning);
            this.gBox_DC_cleaner.Controls.Add(this.cbox_StartUp);
            this.gBox_DC_cleaner.Controls.Add(this.lbl_StatusMsg);
            this.gBox_DC_cleaner.Controls.Add(this.label1);
            this.gBox_DC_cleaner.Controls.Add(this.lbl_Status);
            this.gBox_DC_cleaner.Location = new System.Drawing.Point(18, 53);
            this.gBox_DC_cleaner.Name = "gBox_DC_cleaner";
            this.gBox_DC_cleaner.Size = new System.Drawing.Size(383, 300);
            this.gBox_DC_cleaner.TabIndex = 6;
            this.gBox_DC_cleaner.TabStop = false;
            this.gBox_DC_cleaner.Text = "Cleaner";
            // 
            // DownloadCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.gBox_DC_cleaner);
            this.Controls.Add(this.pnl_DC_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "DownloadCleaner";
            this.Text = "DownloadCleanerV2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_DC_Top.ResumeLayout(false);
            this.pnl_DC_Top.PerformLayout();
            this.gBox_DC_cleaner.ResumeLayout(false);
            this.gBox_DC_cleaner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_StartCleaning;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_StatusMsg;
        private System.Windows.Forms.CheckBox cbox_StartUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_DC_Top;
        private System.Windows.Forms.Label lbl_DC_Header;
        private System.Windows.Forms.GroupBox gBox_DC_cleaner;
    }
}