namespace PCessentials.Forms
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
            this.pnl_MF_Sidebar = new System.Windows.Forms.Panel();
            this.listBoxForms = new System.Windows.Forms.ListBox();
            this.pnl_MF_SidebarBottom = new System.Windows.Forms.Panel();
            this.btn_MF_Help = new System.Windows.Forms.Button();
            this.btn_MF_Settings = new System.Windows.Forms.Button();
            this.pnl_MF_Content = new System.Windows.Forms.Panel();
            this.pnl_MF_Top = new System.Windows.Forms.Panel();
            this.pnl_MF_SidebarTopLogo = new System.Windows.Forms.Panel();
            this.tt_MF = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_MF_FormList = new System.Windows.Forms.Panel();
            this.pnl_MF_Sidebar.SuspendLayout();
            this.pnl_MF_SidebarBottom.SuspendLayout();
            this.pnl_MF_FormList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_MF_Sidebar
            // 
            this.pnl_MF_Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_MF_Sidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_MF_Sidebar.Controls.Add(this.pnl_MF_FormList);
            this.pnl_MF_Sidebar.Controls.Add(this.pnl_MF_SidebarBottom);
            this.pnl_MF_Sidebar.Controls.Add(this.pnl_MF_SidebarTopLogo);
            this.pnl_MF_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_MF_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_MF_Sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_MF_Sidebar.Name = "pnl_MF_Sidebar";
            this.pnl_MF_Sidebar.Size = new System.Drawing.Size(345, 861);
            this.pnl_MF_Sidebar.TabIndex = 0;
            // 
            // listBoxForms
            // 
            this.listBoxForms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxForms.FormattingEnabled = true;
            this.listBoxForms.Location = new System.Drawing.Point(10, 10);
            this.listBoxForms.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxForms.Name = "listBoxForms";
            this.listBoxForms.Size = new System.Drawing.Size(305, 662);
            this.listBoxForms.TabIndex = 4;
            // 
            // pnl_MF_SidebarBottom
            // 
            this.pnl_MF_SidebarBottom.Controls.Add(this.btn_MF_Help);
            this.pnl_MF_SidebarBottom.Controls.Add(this.btn_MF_Settings);
            this.pnl_MF_SidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_MF_SidebarBottom.Location = new System.Drawing.Point(0, 755);
            this.pnl_MF_SidebarBottom.Name = "pnl_MF_SidebarBottom";
            this.pnl_MF_SidebarBottom.Size = new System.Drawing.Size(343, 104);
            this.pnl_MF_SidebarBottom.TabIndex = 0;
            // 
            // btn_MF_Help
            // 
            this.btn_MF_Help.Location = new System.Drawing.Point(130, 66);
            this.btn_MF_Help.Name = "btn_MF_Help";
            this.btn_MF_Help.Size = new System.Drawing.Size(75, 23);
            this.btn_MF_Help.TabIndex = 1;
            this.btn_MF_Help.Text = "Help";
            this.btn_MF_Help.UseVisualStyleBackColor = true;
            // 
            // btn_MF_Settings
            // 
            this.btn_MF_Settings.Location = new System.Drawing.Point(11, 66);
            this.btn_MF_Settings.Name = "btn_MF_Settings";
            this.btn_MF_Settings.Size = new System.Drawing.Size(90, 23);
            this.btn_MF_Settings.TabIndex = 0;
            this.btn_MF_Settings.Text = "Einstellungen";
            this.btn_MF_Settings.UseVisualStyleBackColor = true;
            // 
            // pnl_MF_Content
            // 
            this.pnl_MF_Content.BackColor = System.Drawing.Color.DimGray;
            this.pnl_MF_Content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_MF_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MF_Content.Location = new System.Drawing.Point(345, 74);
            this.pnl_MF_Content.Name = "pnl_MF_Content";
            this.pnl_MF_Content.Size = new System.Drawing.Size(1459, 787);
            this.pnl_MF_Content.TabIndex = 1;
            // 
            // pnl_MF_Top
            // 
            this.pnl_MF_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_MF_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_MF_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MF_Top.Location = new System.Drawing.Point(345, 0);
            this.pnl_MF_Top.Name = "pnl_MF_Top";
            this.pnl_MF_Top.Size = new System.Drawing.Size(1459, 74);
            this.pnl_MF_Top.TabIndex = 2;
            // 
            // pnl_MF_SidebarTopLogo
            // 
            this.pnl_MF_SidebarTopLogo.BackgroundImage = global::PCessentials.Properties.Resources.NT_3;
            this.pnl_MF_SidebarTopLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_MF_SidebarTopLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MF_SidebarTopLogo.Location = new System.Drawing.Point(0, 0);
            this.pnl_MF_SidebarTopLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_MF_SidebarTopLogo.Name = "pnl_MF_SidebarTopLogo";
            this.pnl_MF_SidebarTopLogo.Size = new System.Drawing.Size(343, 73);
            this.pnl_MF_SidebarTopLogo.TabIndex = 1;
            // 
            // tt_MF
            // 
            this.tt_MF.ToolTipTitle = "-";
            // 
            // pnl_MF_FormList
            // 
            this.pnl_MF_FormList.Controls.Add(this.listBoxForms);
            this.pnl_MF_FormList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_MF_FormList.Location = new System.Drawing.Point(0, 73);
            this.pnl_MF_FormList.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.pnl_MF_FormList.Name = "pnl_MF_FormList";
            this.pnl_MF_FormList.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_MF_FormList.Size = new System.Drawing.Size(325, 682);
            this.pnl_MF_FormList.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1804, 861);
            this.Controls.Add(this.pnl_MF_Content);
            this.Controls.Add(this.pnl_MF_Top);
            this.Controls.Add(this.pnl_MF_Sidebar);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.Text = "PCessentials";
            this.pnl_MF_Sidebar.ResumeLayout(false);
            this.pnl_MF_SidebarBottom.ResumeLayout(false);
            this.pnl_MF_FormList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MF_Sidebar;
        private System.Windows.Forms.Panel pnl_MF_Content;
        private System.Windows.Forms.Panel pnl_MF_SidebarBottom;
        private System.Windows.Forms.Button btn_MF_Settings;
        private System.Windows.Forms.Panel pnl_MF_Top;
        private System.Windows.Forms.ToolTip tt_MF;
        private System.Windows.Forms.Button btn_MF_Help;
        private System.Windows.Forms.Panel pnl_MF_SidebarTopLogo;
        private System.Windows.Forms.ListBox listBoxForms;
        private System.Windows.Forms.Panel pnl_MF_FormList;
    }
}
