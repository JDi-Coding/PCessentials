namespace PCessentials.Forms
{
    partial class WebDownloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStatus;

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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbl_WD_Header = new System.Windows.Forms.Label();
            this.pnl_WD_SideBar = new System.Windows.Forms.Panel();
            this.pnl_WD_SidebarTop = new System.Windows.Forms.Panel();
            this.pnl_WD_Top = new System.Windows.Forms.Panel();
            this.pnl_WD_Content = new System.Windows.Forms.Panel();
            this.gBox_WD_content = new System.Windows.Forms.GroupBox();
            this.cBox_WD_Content_Audio = new System.Windows.Forms.CheckBox();
            this.btn_WD_AddAuftrag = new System.Windows.Forms.Button();
            this.lbl_WD_Plattform_ERROR = new System.Windows.Forms.Label();
            this.lbl_WD_URL_ERROR = new System.Windows.Forms.Label();
            this.txt_WD_URL = new System.Windows.Forms.TextBox();
            this.cbox_WD_Plattform = new System.Windows.Forms.ComboBox();
            this.lbl_WD_Plattform = new System.Windows.Forms.Label();
            this.lbl_WD_URL = new System.Windows.Forms.Label();
            this.pnl_WD_ContentRight = new System.Windows.Forms.Panel();
            this.pnl_WD_ContentRightCenter = new System.Windows.Forms.Panel();
            this.lbl_WD_prgs = new System.Windows.Forms.Label();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.lBox_WD_Auftraege = new System.Windows.Forms.ListBox();
            this.pnl_WD_ContentRightBottom = new System.Windows.Forms.Panel();
            this.btn_WD_clearDownloadJobs = new System.Windows.Forms.Button();
            this.btn_WD_StartDownload = new System.Windows.Forms.Button();
            this.gBox_WD_Path = new System.Windows.Forms.GroupBox();
            this.btn_WD_UpdatePath = new System.Windows.Forms.Button();
            this.txtBox_WD_Path = new System.Windows.Forms.TextBox();
            this.lbl_WD_CurrentPath = new System.Windows.Forms.Label();
            this.pnl_WD_SideBar.SuspendLayout();
            this.pnl_WD_SidebarTop.SuspendLayout();
            this.pnl_WD_Content.SuspendLayout();
            this.gBox_WD_content.SuspendLayout();
            this.pnl_WD_ContentRight.SuspendLayout();
            this.pnl_WD_ContentRightCenter.SuspendLayout();
            this.pnl_WD_ContentRightBottom.SuspendLayout();
            this.gBox_WD_Path.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(12, 135);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 5;
            // 
            // lbl_WD_Header
            // 
            this.lbl_WD_Header.AutoSize = true;
            this.lbl_WD_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WD_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_WD_Header.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WD_Header.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_WD_Header.Location = new System.Drawing.Point(0, 0);
            this.lbl_WD_Header.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_WD_Header.Name = "lbl_WD_Header";
            this.lbl_WD_Header.Size = new System.Drawing.Size(200, 30);
            this.lbl_WD_Header.TabIndex = 6;
            this.lbl_WD_Header.Text = "WebDownloader";
            this.lbl_WD_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_WD_SideBar
            // 
            this.pnl_WD_SideBar.BackColor = System.Drawing.Color.Tan;
            this.pnl_WD_SideBar.Controls.Add(this.pnl_WD_SidebarTop);
            this.pnl_WD_SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_WD_SideBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_WD_SideBar.Name = "pnl_WD_SideBar";
            this.pnl_WD_SideBar.Size = new System.Drawing.Size(200, 672);
            this.pnl_WD_SideBar.TabIndex = 7;
            // 
            // pnl_WD_SidebarTop
            // 
            this.pnl_WD_SidebarTop.BackColor = System.Drawing.Color.Tan;
            this.pnl_WD_SidebarTop.Controls.Add(this.lbl_WD_Header);
            this.pnl_WD_SidebarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_WD_SidebarTop.Location = new System.Drawing.Point(0, 0);
            this.pnl_WD_SidebarTop.Name = "pnl_WD_SidebarTop";
            this.pnl_WD_SidebarTop.Size = new System.Drawing.Size(200, 42);
            this.pnl_WD_SidebarTop.TabIndex = 9;
            // 
            // pnl_WD_Top
            // 
            this.pnl_WD_Top.BackColor = System.Drawing.Color.Tan;
            this.pnl_WD_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_WD_Top.Location = new System.Drawing.Point(200, 0);
            this.pnl_WD_Top.Name = "pnl_WD_Top";
            this.pnl_WD_Top.Size = new System.Drawing.Size(1064, 42);
            this.pnl_WD_Top.TabIndex = 8;
            // 
            // pnl_WD_Content
            // 
            this.pnl_WD_Content.BackColor = System.Drawing.Color.Moccasin;
            this.pnl_WD_Content.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_WD_Content.Controls.Add(this.gBox_WD_content);
            this.pnl_WD_Content.Controls.Add(this.pnl_WD_ContentRight);
            this.pnl_WD_Content.Controls.Add(this.gBox_WD_Path);
            this.pnl_WD_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_WD_Content.Location = new System.Drawing.Point(200, 42);
            this.pnl_WD_Content.Name = "pnl_WD_Content";
            this.pnl_WD_Content.Size = new System.Drawing.Size(1064, 630);
            this.pnl_WD_Content.TabIndex = 9;
            // 
            // gBox_WD_content
            // 
            this.gBox_WD_content.Controls.Add(this.cBox_WD_Content_Audio);
            this.gBox_WD_content.Controls.Add(this.btn_WD_AddAuftrag);
            this.gBox_WD_content.Controls.Add(this.lbl_WD_Plattform_ERROR);
            this.gBox_WD_content.Controls.Add(this.lbl_WD_URL_ERROR);
            this.gBox_WD_content.Controls.Add(this.txt_WD_URL);
            this.gBox_WD_content.Controls.Add(this.cbox_WD_Plattform);
            this.gBox_WD_content.Controls.Add(this.lbl_WD_Plattform);
            this.gBox_WD_content.Controls.Add(this.lbl_WD_URL);
            this.gBox_WD_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBox_WD_content.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_WD_content.Location = new System.Drawing.Point(0, 104);
            this.gBox_WD_content.Name = "gBox_WD_content";
            this.gBox_WD_content.Size = new System.Drawing.Size(490, 522);
            this.gBox_WD_content.TabIndex = 11;
            this.gBox_WD_content.TabStop = false;
            this.gBox_WD_content.Text = "Auftrag";
            // 
            // cBox_WD_Content_Audio
            // 
            this.cBox_WD_Content_Audio.AutoSize = true;
            this.cBox_WD_Content_Audio.Location = new System.Drawing.Point(10, 143);
            this.cBox_WD_Content_Audio.Name = "cBox_WD_Content_Audio";
            this.cBox_WD_Content_Audio.Size = new System.Drawing.Size(128, 26);
            this.cBox_WD_Content_Audio.TabIndex = 13;
            this.cBox_WD_Content_Audio.Text = "Audio Only?";
            this.cBox_WD_Content_Audio.UseVisualStyleBackColor = true;
            // 
            // btn_WD_AddAuftrag
            // 
            this.btn_WD_AddAuftrag.Location = new System.Drawing.Point(6, 262);
            this.btn_WD_AddAuftrag.Name = "btn_WD_AddAuftrag";
            this.btn_WD_AddAuftrag.Size = new System.Drawing.Size(106, 34);
            this.btn_WD_AddAuftrag.TabIndex = 12;
            this.btn_WD_AddAuftrag.Text = "Add";
            this.btn_WD_AddAuftrag.UseVisualStyleBackColor = true;
            this.btn_WD_AddAuftrag.Click += new System.EventHandler(this.btn_WD_AddAuftrag_Click);
            // 
            // lbl_WD_Plattform_ERROR
            // 
            this.lbl_WD_Plattform_ERROR.AutoSize = true;
            this.lbl_WD_Plattform_ERROR.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WD_Plattform_ERROR.ForeColor = System.Drawing.Color.Red;
            this.lbl_WD_Plattform_ERROR.Location = new System.Drawing.Point(106, 13);
            this.lbl_WD_Plattform_ERROR.Name = "lbl_WD_Plattform_ERROR";
            this.lbl_WD_Plattform_ERROR.Size = new System.Drawing.Size(51, 19);
            this.lbl_WD_Plattform_ERROR.TabIndex = 11;
            this.lbl_WD_Plattform_ERROR.Text = "ERROR";
            // 
            // lbl_WD_URL_ERROR
            // 
            this.lbl_WD_URL_ERROR.AutoSize = true;
            this.lbl_WD_URL_ERROR.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WD_URL_ERROR.ForeColor = System.Drawing.Color.Red;
            this.lbl_WD_URL_ERROR.Location = new System.Drawing.Point(102, 71);
            this.lbl_WD_URL_ERROR.Name = "lbl_WD_URL_ERROR";
            this.lbl_WD_URL_ERROR.Size = new System.Drawing.Size(51, 19);
            this.lbl_WD_URL_ERROR.TabIndex = 10;
            this.lbl_WD_URL_ERROR.Text = "ERROR";
            // 
            // txt_WD_URL
            // 
            this.txt_WD_URL.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WD_URL.Location = new System.Drawing.Point(106, 93);
            this.txt_WD_URL.Name = "txt_WD_URL";
            this.txt_WD_URL.Size = new System.Drawing.Size(378, 21);
            this.txt_WD_URL.TabIndex = 9;
            // 
            // cbox_WD_Plattform
            // 
            this.cbox_WD_Plattform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_WD_Plattform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_WD_Plattform.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbox_WD_Plattform.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_WD_Plattform.FormattingEnabled = true;
            this.cbox_WD_Plattform.Location = new System.Drawing.Point(106, 35);
            this.cbox_WD_Plattform.Name = "cbox_WD_Plattform";
            this.cbox_WD_Plattform.Size = new System.Drawing.Size(378, 27);
            this.cbox_WD_Plattform.TabIndex = 3;
            // 
            // lbl_WD_Plattform
            // 
            this.lbl_WD_Plattform.AutoSize = true;
            this.lbl_WD_Plattform.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WD_Plattform.Location = new System.Drawing.Point(6, 35);
            this.lbl_WD_Plattform.Name = "lbl_WD_Plattform";
            this.lbl_WD_Plattform.Size = new System.Drawing.Size(94, 22);
            this.lbl_WD_Plattform.TabIndex = 1;
            this.lbl_WD_Plattform.Text = "Plattform:";
            // 
            // lbl_WD_URL
            // 
            this.lbl_WD_URL.AutoSize = true;
            this.lbl_WD_URL.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WD_URL.Location = new System.Drawing.Point(6, 93);
            this.lbl_WD_URL.Name = "lbl_WD_URL";
            this.lbl_WD_URL.Size = new System.Drawing.Size(99, 22);
            this.lbl_WD_URL.TabIndex = 8;
            this.lbl_WD_URL.Text = "Link / URL:";
            // 
            // pnl_WD_ContentRight
            // 
            this.pnl_WD_ContentRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_WD_ContentRight.Controls.Add(this.pnl_WD_ContentRightCenter);
            this.pnl_WD_ContentRight.Controls.Add(this.lBox_WD_Auftraege);
            this.pnl_WD_ContentRight.Controls.Add(this.pnl_WD_ContentRightBottom);
            this.pnl_WD_ContentRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_WD_ContentRight.Location = new System.Drawing.Point(490, 104);
            this.pnl_WD_ContentRight.Name = "pnl_WD_ContentRight";
            this.pnl_WD_ContentRight.Size = new System.Drawing.Size(570, 522);
            this.pnl_WD_ContentRight.TabIndex = 10;
            // 
            // pnl_WD_ContentRightCenter
            // 
            this.pnl_WD_ContentRightCenter.BackColor = System.Drawing.Color.Wheat;
            this.pnl_WD_ContentRightCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_WD_ContentRightCenter.Controls.Add(this.lbl_WD_prgs);
            this.pnl_WD_ContentRightCenter.Controls.Add(this.progressBarDownload);
            this.pnl_WD_ContentRightCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_WD_ContentRightCenter.Location = new System.Drawing.Point(0, 195);
            this.pnl_WD_ContentRightCenter.Name = "pnl_WD_ContentRightCenter";
            this.pnl_WD_ContentRightCenter.Size = new System.Drawing.Size(566, 224);
            this.pnl_WD_ContentRightCenter.TabIndex = 13;
            // 
            // lbl_WD_prgs
            // 
            this.lbl_WD_prgs.AutoSize = true;
            this.lbl_WD_prgs.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_WD_prgs.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WD_prgs.Location = new System.Drawing.Point(0, 0);
            this.lbl_WD_prgs.Name = "lbl_WD_prgs";
            this.lbl_WD_prgs.Size = new System.Drawing.Size(27, 16);
            this.lbl_WD_prgs.TabIndex = 15;
            this.lbl_WD_prgs.Text = "text";
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(1, 36);
            this.progressBarDownload.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(555, 23);
            this.progressBarDownload.TabIndex = 14;
            // 
            // lBox_WD_Auftraege
            // 
            this.lBox_WD_Auftraege.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lBox_WD_Auftraege.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBox_WD_Auftraege.Dock = System.Windows.Forms.DockStyle.Top;
            this.lBox_WD_Auftraege.FormattingEnabled = true;
            this.lBox_WD_Auftraege.Location = new System.Drawing.Point(0, 0);
            this.lBox_WD_Auftraege.Name = "lBox_WD_Auftraege";
            this.lBox_WD_Auftraege.Size = new System.Drawing.Size(566, 195);
            this.lBox_WD_Auftraege.TabIndex = 12;
            // 
            // pnl_WD_ContentRightBottom
            // 
            this.pnl_WD_ContentRightBottom.BackColor = System.Drawing.Color.Moccasin;
            this.pnl_WD_ContentRightBottom.Controls.Add(this.btn_WD_clearDownloadJobs);
            this.pnl_WD_ContentRightBottom.Controls.Add(this.btn_WD_StartDownload);
            this.pnl_WD_ContentRightBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_WD_ContentRightBottom.Location = new System.Drawing.Point(0, 419);
            this.pnl_WD_ContentRightBottom.Name = "pnl_WD_ContentRightBottom";
            this.pnl_WD_ContentRightBottom.Size = new System.Drawing.Size(566, 99);
            this.pnl_WD_ContentRightBottom.TabIndex = 1;
            // 
            // btn_WD_clearDownloadJobs
            // 
            this.btn_WD_clearDownloadJobs.Location = new System.Drawing.Point(281, 44);
            this.btn_WD_clearDownloadJobs.Name = "btn_WD_clearDownloadJobs";
            this.btn_WD_clearDownloadJobs.Size = new System.Drawing.Size(77, 23);
            this.btn_WD_clearDownloadJobs.TabIndex = 1;
            this.btn_WD_clearDownloadJobs.Text = "Clear";
            this.btn_WD_clearDownloadJobs.UseVisualStyleBackColor = true;
            this.btn_WD_clearDownloadJobs.Click += new System.EventHandler(this.btn_WD_clearDownloadJobs_Click);
            // 
            // btn_WD_StartDownload
            // 
            this.btn_WD_StartDownload.Location = new System.Drawing.Point(7, 44);
            this.btn_WD_StartDownload.Name = "btn_WD_StartDownload";
            this.btn_WD_StartDownload.Size = new System.Drawing.Size(77, 23);
            this.btn_WD_StartDownload.TabIndex = 0;
            this.btn_WD_StartDownload.Text = "Start";
            this.btn_WD_StartDownload.UseVisualStyleBackColor = true;
            this.btn_WD_StartDownload.Click += new System.EventHandler(this.btn_WD_StartDownload_Click);
            // 
            // gBox_WD_Path
            // 
            this.gBox_WD_Path.Controls.Add(this.btn_WD_UpdatePath);
            this.gBox_WD_Path.Controls.Add(this.txtBox_WD_Path);
            this.gBox_WD_Path.Controls.Add(this.lbl_WD_CurrentPath);
            this.gBox_WD_Path.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBox_WD_Path.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_WD_Path.Location = new System.Drawing.Point(0, 0);
            this.gBox_WD_Path.Name = "gBox_WD_Path";
            this.gBox_WD_Path.Size = new System.Drawing.Size(1060, 104);
            this.gBox_WD_Path.TabIndex = 7;
            this.gBox_WD_Path.TabStop = false;
            this.gBox_WD_Path.Text = "Path";
            // 
            // btn_WD_UpdatePath
            // 
            this.btn_WD_UpdatePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_WD_UpdatePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WD_UpdatePath.Location = new System.Drawing.Point(3, 68);
            this.btn_WD_UpdatePath.Name = "btn_WD_UpdatePath";
            this.btn_WD_UpdatePath.Size = new System.Drawing.Size(1054, 30);
            this.btn_WD_UpdatePath.TabIndex = 6;
            this.btn_WD_UpdatePath.Text = "Update";
            this.btn_WD_UpdatePath.UseVisualStyleBackColor = true;
            this.btn_WD_UpdatePath.Click += new System.EventHandler(this.btn_WD_UpdatePath_Click);
            // 
            // txtBox_WD_Path
            // 
            this.txtBox_WD_Path.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBox_WD_Path.Location = new System.Drawing.Point(3, 40);
            this.txtBox_WD_Path.Name = "txtBox_WD_Path";
            this.txtBox_WD_Path.Size = new System.Drawing.Size(1054, 28);
            this.txtBox_WD_Path.TabIndex = 2;
            // 
            // lbl_WD_CurrentPath
            // 
            this.lbl_WD_CurrentPath.AutoSize = true;
            this.lbl_WD_CurrentPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_WD_CurrentPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WD_CurrentPath.Location = new System.Drawing.Point(3, 24);
            this.lbl_WD_CurrentPath.Name = "lbl_WD_CurrentPath";
            this.lbl_WD_CurrentPath.Size = new System.Drawing.Size(329, 16);
            this.lbl_WD_CurrentPath.TabIndex = 5;
            this.lbl_WD_CurrentPath.Text = "Selected Path: C:/DUMMY/DUMMY/DUMMY/DUMMY";
            // 
            // WebDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1264, 672);
            this.Controls.Add(this.pnl_WD_Content);
            this.Controls.Add(this.pnl_WD_Top);
            this.Controls.Add(this.pnl_WD_SideBar);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "WebDownloader";
            this.Text = "WebDownloader";
            this.Load += new System.EventHandler(this.WebDownloader_Load);
            this.pnl_WD_SideBar.ResumeLayout(false);
            this.pnl_WD_SidebarTop.ResumeLayout(false);
            this.pnl_WD_SidebarTop.PerformLayout();
            this.pnl_WD_Content.ResumeLayout(false);
            this.gBox_WD_content.ResumeLayout(false);
            this.gBox_WD_content.PerformLayout();
            this.pnl_WD_ContentRight.ResumeLayout(false);
            this.pnl_WD_ContentRightCenter.ResumeLayout(false);
            this.pnl_WD_ContentRightCenter.PerformLayout();
            this.pnl_WD_ContentRightBottom.ResumeLayout(false);
            this.gBox_WD_Path.ResumeLayout(false);
            this.gBox_WD_Path.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WD_Header;
        private System.Windows.Forms.Panel pnl_WD_SideBar;
        private System.Windows.Forms.Panel pnl_WD_SidebarTop;
        private System.Windows.Forms.Panel pnl_WD_Top;
        private System.Windows.Forms.Panel pnl_WD_Content;
        private System.Windows.Forms.Label lbl_WD_CurrentPath;
        private System.Windows.Forms.TextBox txtBox_WD_Path;
        private System.Windows.Forms.Button btn_WD_StartDownload;
        private System.Windows.Forms.GroupBox gBox_WD_Path;
        private System.Windows.Forms.Button btn_WD_UpdatePath;
        private System.Windows.Forms.Label lbl_WD_Plattform;
        private System.Windows.Forms.ComboBox cbox_WD_Plattform;
        private System.Windows.Forms.TextBox txt_WD_URL;
        private System.Windows.Forms.Label lbl_WD_URL;
        private System.Windows.Forms.Panel pnl_WD_ContentRight;
        private System.Windows.Forms.GroupBox gBox_WD_content;
        private System.Windows.Forms.Panel pnl_WD_ContentRightBottom;
        private System.Windows.Forms.Label lbl_WD_URL_ERROR;
        private System.Windows.Forms.Label lbl_WD_Plattform_ERROR;
        private System.Windows.Forms.ListBox lBox_WD_Auftraege;
        private System.Windows.Forms.Button btn_WD_AddAuftrag;
        private System.Windows.Forms.CheckBox cBox_WD_Content_Audio;
        private System.Windows.Forms.Button btn_WD_clearDownloadJobs;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.Label lbl_WD_prgs;
        private System.Windows.Forms.Panel pnl_WD_ContentRightCenter;
    }
}