using System.Windows.Forms;

namespace PCessentials.Forms
{
    partial class PSWManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnRenameCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.dgvEntries = new System.Windows.Forms.DataGridView();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnUpdateEntry = new System.Windows.Forms.Button();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.pnl_ServiceSettings = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_EntrySettings = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEntryName = new System.Windows.Forms.TextBox();
            this.btn_UN_Visibility = new System.Windows.Forms.Button();
            this.btn_OTHER_Visibility = new System.Windows.Forms.Button();
            this.btn_EMAIL_Visibility = new System.Windows.Forms.Button();
            this.btn_TEL_Visibility = new System.Windows.Forms.Button();
            this.btn_PW_Visibility = new System.Windows.Forms.Button();
            this.btn_CopyOther = new System.Windows.Forms.Button();
            this.btn_CopyTel = new System.Windows.Forms.Button();
            this.btn_CopyEMAIL = new System.Windows.Forms.Button();
            this.btn_CopyPW = new System.Windows.Forms.Button();
            this.btn_CopyUN = new System.Windows.Forms.Button();
            this.pnl_EntrySetsBtns = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).BeginInit();
            this.pnl_ServiceSettings.SuspendLayout();
            this.pnl_EntrySettings.SuspendLayout();
            this.pnl_EntrySetsBtns.SuspendLayout();
            this.pnlDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstServices
            // 
            this.lstServices.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstServices.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstServices.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lstServices.ItemHeight = 21;
            this.lstServices.Location = new System.Drawing.Point(0, 0);
            this.lstServices.Margin = new System.Windows.Forms.Padding(0);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(170, 561);
            this.lstServices.TabIndex = 0;
            this.lstServices.SelectedIndexChanged += new System.EventHandler(this.lstServices_SelectedIndexChanged);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(3, 31);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(125, 22);
            this.txtCategoryName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(72, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(389, 18);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.UseSystemPasswordChar = true;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.Color.White;
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelephone.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(72, 107);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(389, 18);
            this.txtTelephone.TabIndex = 7;
            this.txtTelephone.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(72, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(389, 18);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(72, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(389, 18);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtOther
            // 
            this.txtOther.BackColor = System.Drawing.Color.White;
            this.txtOther.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOther.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(72, 136);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(389, 18);
            this.txtOther.TabIndex = 10;
            this.txtOther.UseSystemPasswordChar = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Green;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddCategory.Location = new System.Drawing.Point(6, 90);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(52, 45);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "+";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnRenameCategory
            // 
            this.btnRenameCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRenameCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenameCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRenameCategory.Location = new System.Drawing.Point(76, 90);
            this.btnRenameCategory.Name = "btnRenameCategory";
            this.btnRenameCategory.Size = new System.Drawing.Size(52, 45);
            this.btnRenameCategory.TabIndex = 3;
            this.btnRenameCategory.Text = "✎";
            this.btnRenameCategory.UseVisualStyleBackColor = false;
            this.btnRenameCategory.Click += new System.EventHandler(this.btnRenameCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.Red;
            this.btnRemoveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveCategory.Location = new System.Drawing.Point(6, 166);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(52, 45);
            this.btnRemoveCategory.TabIndex = 4;
            this.btnRemoveCategory.Text = "🗑";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // dgvEntries
            // 
            this.dgvEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntries.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvEntries.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEntries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEntries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEntries.ColumnHeadersHeight = 40;
            this.dgvEntries.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.NullValue = "none";
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntries.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntries.EnableHeadersVisualStyles = false;
            this.dgvEntries.GridColor = System.Drawing.SystemColors.Control;
            this.dgvEntries.Location = new System.Drawing.Point(0, 0);
            this.dgvEntries.Name = "dgvEntries";
            this.dgvEntries.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntries.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntries.Size = new System.Drawing.Size(1044, 355);
            this.dgvEntries.TabIndex = 5;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.BackColor = System.Drawing.Color.Green;
            this.btnAddEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddEntry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddEntry.Location = new System.Drawing.Point(0, 88);
            this.btnAddEntry.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(128, 44);
            this.btnAddEntry.TabIndex = 11;
            this.btnAddEntry.Text = "Hinzufügen";
            this.btnAddEntry.UseVisualStyleBackColor = false;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnUpdateEntry
            // 
            this.btnUpdateEntry.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateEntry.Location = new System.Drawing.Point(0, 44);
            this.btnUpdateEntry.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateEntry.Name = "btnUpdateEntry";
            this.btnUpdateEntry.Size = new System.Drawing.Size(128, 44);
            this.btnUpdateEntry.TabIndex = 12;
            this.btnUpdateEntry.Text = "Ändern";
            this.btnUpdateEntry.UseVisualStyleBackColor = false;
            this.btnUpdateEntry.Click += new System.EventHandler(this.btnUpdateEntry_Click);
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteEntry.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteEntry.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteEntry.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(128, 44);
            this.btnDeleteEntry.TabIndex = 13;
            this.btnDeleteEntry.Text = "Löschen";
            this.btnDeleteEntry.UseVisualStyleBackColor = false;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // pnl_ServiceSettings
            // 
            this.pnl_ServiceSettings.BackColor = System.Drawing.Color.LightGray;
            this.pnl_ServiceSettings.Controls.Add(this.btn_import);
            this.pnl_ServiceSettings.Controls.Add(this.label4);
            this.pnl_ServiceSettings.Controls.Add(this.btn_Export);
            this.pnl_ServiceSettings.Controls.Add(this.label3);
            this.pnl_ServiceSettings.Controls.Add(this.label2);
            this.pnl_ServiceSettings.Controls.Add(this.label1);
            this.pnl_ServiceSettings.Controls.Add(this.txtCategoryName);
            this.pnl_ServiceSettings.Controls.Add(this.btnAddCategory);
            this.pnl_ServiceSettings.Controls.Add(this.btnRemoveCategory);
            this.pnl_ServiceSettings.Controls.Add(this.btnRenameCategory);
            this.pnl_ServiceSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_ServiceSettings.Location = new System.Drawing.Point(170, 0);
            this.pnl_ServiceSettings.Name = "pnl_ServiceSettings";
            this.pnl_ServiceSettings.Size = new System.Drawing.Size(134, 561);
            this.pnl_ServiceSettings.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Servicename";
            // 
            // pnl_EntrySettings
            // 
            this.pnl_EntrySettings.BackColor = System.Drawing.Color.Silver;
            this.pnl_EntrySettings.Controls.Add(this.label10);
            this.pnl_EntrySettings.Controls.Add(this.txtEntryName);
            this.pnl_EntrySettings.Controls.Add(this.btn_UN_Visibility);
            this.pnl_EntrySettings.Controls.Add(this.btn_OTHER_Visibility);
            this.pnl_EntrySettings.Controls.Add(this.btn_EMAIL_Visibility);
            this.pnl_EntrySettings.Controls.Add(this.btn_TEL_Visibility);
            this.pnl_EntrySettings.Controls.Add(this.btn_PW_Visibility);
            this.pnl_EntrySettings.Controls.Add(this.btn_CopyOther);
            this.pnl_EntrySettings.Controls.Add(this.btn_CopyTel);
            this.pnl_EntrySettings.Controls.Add(this.btn_CopyEMAIL);
            this.pnl_EntrySettings.Controls.Add(this.btn_CopyPW);
            this.pnl_EntrySettings.Controls.Add(this.btn_CopyUN);
            this.pnl_EntrySettings.Controls.Add(this.pnl_EntrySetsBtns);
            this.pnl_EntrySettings.Controls.Add(this.label9);
            this.pnl_EntrySettings.Controls.Add(this.label8);
            this.pnl_EntrySettings.Controls.Add(this.label7);
            this.pnl_EntrySettings.Controls.Add(this.label6);
            this.pnl_EntrySettings.Controls.Add(this.label5);
            this.pnl_EntrySettings.Controls.Add(this.txtUsername);
            this.pnl_EntrySettings.Controls.Add(this.txtOther);
            this.pnl_EntrySettings.Controls.Add(this.txtTelephone);
            this.pnl_EntrySettings.Controls.Add(this.txtEmail);
            this.pnl_EntrySettings.Controls.Add(this.txtPassword);
            this.pnl_EntrySettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_EntrySettings.Location = new System.Drawing.Point(304, 358);
            this.pnl_EntrySettings.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_EntrySettings.Name = "pnl_EntrySettings";
            this.pnl_EntrySettings.Size = new System.Drawing.Size(1044, 203);
            this.pnl_EntrySettings.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(638, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Entryname:";
            // 
            // txtEntryName
            // 
            this.txtEntryName.BackColor = System.Drawing.Color.White;
            this.txtEntryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntryName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryName.Location = new System.Drawing.Point(714, 15);
            this.txtEntryName.Name = "txtEntryName";
            this.txtEntryName.Size = new System.Drawing.Size(193, 18);
            this.txtEntryName.TabIndex = 30;
            // 
            // btn_UN_Visibility
            // 
            this.btn_UN_Visibility.Location = new System.Drawing.Point(549, 15);
            this.btn_UN_Visibility.Name = "btn_UN_Visibility";
            this.btn_UN_Visibility.Size = new System.Drawing.Size(75, 23);
            this.btn_UN_Visibility.TabIndex = 29;
            this.btn_UN_Visibility.Text = "Show";
            this.btn_UN_Visibility.UseVisualStyleBackColor = true;
            this.btn_UN_Visibility.Click += new System.EventHandler(this.btn_UN_Visibility_Click);
            // 
            // btn_OTHER_Visibility
            // 
            this.btn_OTHER_Visibility.Location = new System.Drawing.Point(549, 138);
            this.btn_OTHER_Visibility.Name = "btn_OTHER_Visibility";
            this.btn_OTHER_Visibility.Size = new System.Drawing.Size(75, 23);
            this.btn_OTHER_Visibility.TabIndex = 28;
            this.btn_OTHER_Visibility.Text = "Show";
            this.btn_OTHER_Visibility.UseVisualStyleBackColor = true;
            this.btn_OTHER_Visibility.Click += new System.EventHandler(this.btn_OTHER_Visibility_Click);
            // 
            // btn_EMAIL_Visibility
            // 
            this.btn_EMAIL_Visibility.Location = new System.Drawing.Point(549, 80);
            this.btn_EMAIL_Visibility.Name = "btn_EMAIL_Visibility";
            this.btn_EMAIL_Visibility.Size = new System.Drawing.Size(75, 23);
            this.btn_EMAIL_Visibility.TabIndex = 27;
            this.btn_EMAIL_Visibility.Text = "Show";
            this.btn_EMAIL_Visibility.UseVisualStyleBackColor = true;
            this.btn_EMAIL_Visibility.Click += new System.EventHandler(this.btn_EMAIL_Visibility_Click);
            // 
            // btn_TEL_Visibility
            // 
            this.btn_TEL_Visibility.Location = new System.Drawing.Point(549, 109);
            this.btn_TEL_Visibility.Name = "btn_TEL_Visibility";
            this.btn_TEL_Visibility.Size = new System.Drawing.Size(75, 23);
            this.btn_TEL_Visibility.TabIndex = 26;
            this.btn_TEL_Visibility.Text = "Show";
            this.btn_TEL_Visibility.UseVisualStyleBackColor = true;
            this.btn_TEL_Visibility.Click += new System.EventHandler(this.btn_TEL_Visibility_Click);
            // 
            // btn_PW_Visibility
            // 
            this.btn_PW_Visibility.Location = new System.Drawing.Point(549, 49);
            this.btn_PW_Visibility.Name = "btn_PW_Visibility";
            this.btn_PW_Visibility.Size = new System.Drawing.Size(75, 23);
            this.btn_PW_Visibility.TabIndex = 25;
            this.btn_PW_Visibility.Text = "Show";
            this.btn_PW_Visibility.UseVisualStyleBackColor = true;
            this.btn_PW_Visibility.Click += new System.EventHandler(this.btn_PW_Visibility_Click);
            // 
            // btn_CopyOther
            // 
            this.btn_CopyOther.Location = new System.Drawing.Point(468, 136);
            this.btn_CopyOther.Name = "btn_CopyOther";
            this.btn_CopyOther.Size = new System.Drawing.Size(75, 23);
            this.btn_CopyOther.TabIndex = 24;
            this.btn_CopyOther.Text = "Copy";
            this.btn_CopyOther.UseVisualStyleBackColor = true;
            this.btn_CopyOther.Click += new System.EventHandler(this.btn_CopyOther_Click);
            // 
            // btn_CopyTel
            // 
            this.btn_CopyTel.Location = new System.Drawing.Point(468, 107);
            this.btn_CopyTel.Name = "btn_CopyTel";
            this.btn_CopyTel.Size = new System.Drawing.Size(75, 23);
            this.btn_CopyTel.TabIndex = 23;
            this.btn_CopyTel.Text = "Copy";
            this.btn_CopyTel.UseVisualStyleBackColor = true;
            this.btn_CopyTel.Click += new System.EventHandler(this.btn_CopyTel_Click);
            // 
            // btn_CopyEMAIL
            // 
            this.btn_CopyEMAIL.Location = new System.Drawing.Point(468, 78);
            this.btn_CopyEMAIL.Name = "btn_CopyEMAIL";
            this.btn_CopyEMAIL.Size = new System.Drawing.Size(75, 23);
            this.btn_CopyEMAIL.TabIndex = 22;
            this.btn_CopyEMAIL.Text = "Copy";
            this.btn_CopyEMAIL.UseVisualStyleBackColor = true;
            this.btn_CopyEMAIL.Click += new System.EventHandler(this.btn_CopyEMAIL_Click);
            // 
            // btn_CopyPW
            // 
            this.btn_CopyPW.Location = new System.Drawing.Point(468, 48);
            this.btn_CopyPW.Name = "btn_CopyPW";
            this.btn_CopyPW.Size = new System.Drawing.Size(75, 23);
            this.btn_CopyPW.TabIndex = 21;
            this.btn_CopyPW.Text = "Copy";
            this.btn_CopyPW.UseVisualStyleBackColor = true;
            this.btn_CopyPW.Click += new System.EventHandler(this.btn_CopyPW_Click);
            // 
            // btn_CopyUN
            // 
            this.btn_CopyUN.Location = new System.Drawing.Point(468, 15);
            this.btn_CopyUN.Name = "btn_CopyUN";
            this.btn_CopyUN.Size = new System.Drawing.Size(75, 23);
            this.btn_CopyUN.TabIndex = 20;
            this.btn_CopyUN.Text = "Copy";
            this.btn_CopyUN.UseVisualStyleBackColor = true;
            this.btn_CopyUN.Click += new System.EventHandler(this.btn_CopyUN_Click);
            // 
            // pnl_EntrySetsBtns
            // 
            this.pnl_EntrySetsBtns.BackColor = System.Drawing.Color.LightGray;
            this.pnl_EntrySetsBtns.Controls.Add(this.btnAddEntry);
            this.pnl_EntrySetsBtns.Controls.Add(this.btnUpdateEntry);
            this.pnl_EntrySetsBtns.Controls.Add(this.btnDeleteEntry);
            this.pnl_EntrySetsBtns.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_EntrySetsBtns.Location = new System.Drawing.Point(916, 0);
            this.pnl_EntrySetsBtns.Name = "pnl_EntrySetsBtns";
            this.pnl_EntrySetsBtns.Size = new System.Drawing.Size(128, 203);
            this.pnl_EntrySetsBtns.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ohter:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tele:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Username:";
            // 
            // pnlDGV
            // 
            this.pnlDGV.Controls.Add(this.dgvEntries);
            this.pnlDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDGV.Location = new System.Drawing.Point(304, 0);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(1044, 355);
            this.pnlDGV.TabIndex = 16;
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(71, 188);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(60, 23);
            this.btn_Export.TabIndex = 32;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(71, 159);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(60, 23);
            this.btn_import.TabIndex = 33;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // PSWManager
            // 
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1348, 561);
            this.Controls.Add(this.pnlDGV);
            this.Controls.Add(this.pnl_EntrySettings);
            this.Controls.Add(this.pnl_ServiceSettings);
            this.Controls.Add(this.lstServices);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "PSWManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PSWManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).EndInit();
            this.pnl_ServiceSettings.ResumeLayout(false);
            this.pnl_ServiceSettings.PerformLayout();
            this.pnl_EntrySettings.ResumeLayout(false);
            this.pnl_EntrySettings.PerformLayout();
            this.pnl_EntrySetsBtns.ResumeLayout(false);
            this.pnlDGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnRenameCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Button btnUpdateEntry;
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.DataGridView dgvEntries;
        private Panel pnl_ServiceSettings;
        private Panel pnl_EntrySettings;
        private Panel pnlDGV;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel pnl_EntrySetsBtns;
        private Button btn_CopyOther;
        private Button btn_CopyTel;
        private Button btn_CopyEMAIL;
        private Button btn_CopyPW;
        private Button btn_CopyUN;
        private Button btn_EMAIL_Visibility;
        private Button btn_TEL_Visibility;
        private Button btn_PW_Visibility;
        private Button btn_UN_Visibility;
        private Button btn_OTHER_Visibility;
        private Label label10;
        private TextBox txtEntryName;
        private Button btn_import;
        private Button btn_Export;
    }
}