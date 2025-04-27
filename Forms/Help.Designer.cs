namespace PCessentials.Forms
{
    partial class Help
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
            this.lbl_H_Header = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnl_H_LeftSidebar = new System.Windows.Forms.Panel();
            this.pnl_H_SidebarLeftHeaderContainer = new System.Windows.Forms.Panel();
            this.pnl_H_LeftSidebar.SuspendLayout();
            this.pnl_H_SidebarLeftHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_H_Header
            // 
            this.lbl_H_Header.AutoSize = true;
            this.lbl_H_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_H_Header.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_H_Header.Location = new System.Drawing.Point(0, 0);
            this.lbl_H_Header.Name = "lbl_H_Header";
            this.lbl_H_Header.Size = new System.Drawing.Size(56, 28);
            this.lbl_H_Header.TabIndex = 0;
            this.lbl_H_Header.Text = "Help";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 31);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(282, 399);
            this.listBox1.TabIndex = 1;
            // 
            // pnl_H_LeftSidebar
            // 
            this.pnl_H_LeftSidebar.Controls.Add(this.listBox1);
            this.pnl_H_LeftSidebar.Controls.Add(this.pnl_H_SidebarLeftHeaderContainer);
            this.pnl_H_LeftSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_H_LeftSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_H_LeftSidebar.Name = "pnl_H_LeftSidebar";
            this.pnl_H_LeftSidebar.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.pnl_H_LeftSidebar.Size = new System.Drawing.Size(322, 450);
            this.pnl_H_LeftSidebar.TabIndex = 2;
            // 
            // pnl_H_SidebarLeftHeaderContainer
            // 
            this.pnl_H_SidebarLeftHeaderContainer.Controls.Add(this.lbl_H_Header);
            this.pnl_H_SidebarLeftHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_H_SidebarLeftHeaderContainer.Location = new System.Drawing.Point(20, 0);
            this.pnl_H_SidebarLeftHeaderContainer.Name = "pnl_H_SidebarLeftHeaderContainer";
            this.pnl_H_SidebarLeftHeaderContainer.Size = new System.Drawing.Size(282, 31);
            this.pnl_H_SidebarLeftHeaderContainer.TabIndex = 3;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_H_LeftSidebar);
            this.Name = "Help";
            this.Text = "Help";
            this.pnl_H_LeftSidebar.ResumeLayout(false);
            this.pnl_H_SidebarLeftHeaderContainer.ResumeLayout(false);
            this.pnl_H_SidebarLeftHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_H_Header;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel pnl_H_LeftSidebar;
        private System.Windows.Forms.Panel pnl_H_SidebarLeftHeaderContainer;
    }
}