namespace WinForm.Minimart
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            จดการสนคาToolStripMenuItem = new ToolStripMenuItem();
            จดการหมวดหมToolStripMenuItem = new ToolStripMenuItem();
            เพมสนคาToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { จดการสนคาToolStripMenuItem, จดการหมวดหมToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1034, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // จดการสนคาToolStripMenuItem
            // 
            จดการสนคาToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { เพมสนคาToolStripMenuItem });
            จดการสนคาToolStripMenuItem.Name = "จดการสนคาToolStripMenuItem";
            จดการสนคาToolStripMenuItem.Size = new Size(74, 20);
            จดการสนคาToolStripMenuItem.Text = "จัดการสินค้า";
            จดการสนคาToolStripMenuItem.Click += this.จดการสนคาToolStripMenuItem_Click;
            // 
            // จดการหมวดหมToolStripMenuItem
            // 
            จดการหมวดหมToolStripMenuItem.Name = "จดการหมวดหมToolStripMenuItem";
            จดการหมวดหมToolStripMenuItem.Size = new Size(89, 20);
            จดการหมวดหมToolStripMenuItem.Text = "จัดการหมวดหมู่";
            จดการหมวดหมToolStripMenuItem.Click += this.จดการหมวดหมToolStripMenuItem_Click;
            // 
            // เพมสนคาToolStripMenuItem
            // 
            เพมสนคาToolStripMenuItem.Name = "เพมสนคาToolStripMenuItem";
            เพมสนคาToolStripMenuItem.Size = new Size(180, 22);
            เพมสนคาToolStripMenuItem.Text = "เพิ่มสินค้า";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 624);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmMenu";
            Text = "แสดงข้อมูลจาก Minimart";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem จดการสนคาToolStripMenuItem;
        private ToolStripMenuItem เพมสนคาToolStripMenuItem;
        private ToolStripMenuItem จดการหมวดหมToolStripMenuItem;
    }
}
