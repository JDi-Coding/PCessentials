﻿namespace PCessentials.Forms
{
    partial class PrintManager
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
            this.cmbPrinters = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lvJobs = new System.Windows.Forms.ListView();
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkDuplex = new System.Windows.Forms.CheckBox();
            this.chkGrayscale = new System.Windows.Forms.CheckBox();
            this.chkLandscape = new System.Windows.Forms.CheckBox();
            this.chkA4 = new System.Windows.Forms.CheckBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.numCopies = new System.Windows.Forms.NumericUpDown();
            this.lbl_PM_Header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPrinters
            // 
            this.cmbPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrinters.Location = new System.Drawing.Point(12, 45);
            this.cmbPrinters.Name = "cmbPrinters";
            this.cmbPrinters.Size = new System.Drawing.Size(360, 21);
            this.cmbPrinters.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 81);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(127, 35);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "PDF(s) auswählen";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 511);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(209, 36);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(442, 511);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(209, 36);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stopp";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lvJobs
            // 
            this.lvJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFile,
            this.colStatus});
            this.lvJobs.FullRowSelect = true;
            this.lvJobs.GridLines = true;
            this.lvJobs.HideSelection = false;
            this.lvJobs.Location = new System.Drawing.Point(83, 218);
            this.lvJobs.Name = "lvJobs";
            this.lvJobs.Size = new System.Drawing.Size(473, 200);
            this.lvJobs.TabIndex = 8;
            this.lvJobs.UseCompatibleStateImageBehavior = false;
            this.lvJobs.View = System.Windows.Forms.View.Details;
            // 
            // colFile
            // 
            this.colFile.Text = "Datei";
            this.colFile.Width = 200;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 150;
            // 
            // chkDuplex
            // 
            this.chkDuplex.AutoSize = true;
            this.chkDuplex.Location = new System.Drawing.Point(16, 136);
            this.chkDuplex.Name = "chkDuplex";
            this.chkDuplex.Size = new System.Drawing.Size(71, 17);
            this.chkDuplex.TabIndex = 2;
            this.chkDuplex.Text = "Beidseitig";
            this.chkDuplex.UseVisualStyleBackColor = true;
            // 
            // chkGrayscale
            // 
            this.chkGrayscale.AutoSize = true;
            this.chkGrayscale.Location = new System.Drawing.Point(15, 176);
            this.chkGrayscale.Name = "chkGrayscale";
            this.chkGrayscale.Size = new System.Drawing.Size(76, 17);
            this.chkGrayscale.TabIndex = 3;
            this.chkGrayscale.Text = "SW-Druck";
            this.chkGrayscale.UseVisualStyleBackColor = true;
            // 
            // chkLandscape
            // 
            this.chkLandscape.AutoSize = true;
            this.chkLandscape.Location = new System.Drawing.Point(162, 136);
            this.chkLandscape.Name = "chkLandscape";
            this.chkLandscape.Size = new System.Drawing.Size(78, 17);
            this.chkLandscape.TabIndex = 4;
            this.chkLandscape.Text = "Querformat";
            this.chkLandscape.UseVisualStyleBackColor = true;
            // 
            // chkA4
            // 
            this.chkA4.AutoSize = true;
            this.chkA4.Location = new System.Drawing.Point(162, 176);
            this.chkA4.Name = "chkA4";
            this.chkA4.Size = new System.Drawing.Size(39, 17);
            this.chkA4.TabIndex = 5;
            this.chkA4.Text = "A4";
            this.chkA4.UseVisualStyleBackColor = true;
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(363, 136);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(43, 13);
            this.lblCopies.TabIndex = 6;
            this.lblCopies.Text = "Kopien:";
            // 
            // numCopies
            // 
            this.numCopies.Location = new System.Drawing.Point(440, 133);
            this.numCopies.Name = "numCopies";
            this.numCopies.Size = new System.Drawing.Size(50, 20);
            this.numCopies.TabIndex = 7;
            // 
            // lbl_PM_Header
            // 
            this.lbl_PM_Header.AutoSize = true;
            this.lbl_PM_Header.Location = new System.Drawing.Point(13, 13);
            this.lbl_PM_Header.Name = "lbl_PM_Header";
            this.lbl_PM_Header.Size = new System.Drawing.Size(35, 13);
            this.lbl_PM_Header.TabIndex = 11;
            this.lbl_PM_Header.Text = "label1";
            // 
            // PrintManager
            // 
            this.ClientSize = new System.Drawing.Size(663, 559);
            this.Controls.Add(this.lbl_PM_Header);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lvJobs);
            this.Controls.Add(this.numCopies);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.chkA4);
            this.Controls.Add(this.chkLandscape);
            this.Controls.Add(this.chkGrayscale);
            this.Controls.Add(this.chkDuplex);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cmbPrinters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintManager";
            this.Text = "Print Manager";
            this.Load += new System.EventHandler(this.PrintManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ComboBox cmbPrinters;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListView lvJobs;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkDuplex;
        private System.Windows.Forms.CheckBox chkGrayscale;
        private System.Windows.Forms.CheckBox chkLandscape;
        private System.Windows.Forms.CheckBox chkA4;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.NumericUpDown numCopies;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblProgressText;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label lblPrinterStatus;
        private System.Windows.Forms.Label lblPrinterStatusText;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblCopiesText;
        private System.Windows.Forms.Label lblCopiesCount;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblFileNameText;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFileSizeText;
        private System.Windows.Forms.Label lblFileSizeValue;
        private System.Windows.Forms.Label lblFileSizeValueText;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.Label lblFileTypeText;
        private System.Windows.Forms.Label lblFileTypeValue;
        private System.Windows.Forms.Label lblFileTypeValueText;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblFilePathText;
        private System.Windows.Forms.Label lblFilePathValue;
        private System.Windows.Forms.Label lblFilePathValueText;
        private System.Windows.Forms.Label lbl_PM_Header;
    }
}