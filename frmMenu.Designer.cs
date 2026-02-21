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
            mnuCRUD = new ToolStripMenuItem();
            mnuProducts = new ToolStripMenuItem();
            mnuEmployees = new ToolStripMenuItem();
            mnuCategory = new ToolStripMenuItem();
            mnuReport = new ToolStripMenuItem();
            mnuProducts_By_Category = new ToolStripMenuItem();
            mnuEmployee_sale = new ToolStripMenuItem();
            mnuPOS = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            mnuLogin = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuCRUD, mnuReport, mnuPOS, mnuLogout, mnuLogin });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 1, 0, 1);
            menuStrip1.Size = new Size(963, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuCRUD
            // 
            mnuCRUD.DropDownItems.AddRange(new ToolStripItem[] { mnuProducts, mnuEmployees, mnuCategory });
            mnuCRUD.Name = "mnuCRUD";
            mnuCRUD.Size = new Size(75, 22);
            mnuCRUD.Text = "จัดการข้อมูล";
            // 
            // mnuProducts
            // 
            mnuProducts.Name = "mnuProducts";
            mnuProducts.Size = new Size(188, 22);
            mnuProducts.Text = "จัดการข้อมูลสินค้า";
            mnuProducts.Click += mnuProducts_Click;
            // 
            // mnuEmployees
            // 
            mnuEmployees.Name = "mnuEmployees";
            mnuEmployees.Size = new Size(188, 22);
            mnuEmployees.Text = "จัดการข้อมูลพนักงาน";
            mnuEmployees.Click += mnuEmployees_Click;
            // 
            // mnuCategory
            // 
            mnuCategory.Name = "mnuCategory";
            mnuCategory.Size = new Size(188, 22);
            mnuCategory.Text = "จัดการข้อมูลประเภทสินค้า";
            mnuCategory.Click += mnuCategory_Click;
            // 
            // mnuReport
            // 
            mnuReport.DropDownItems.AddRange(new ToolStripItem[] { mnuProducts_By_Category, mnuEmployee_sale });
            mnuReport.Name = "mnuReport";
            mnuReport.Size = new Size(69, 22);
            mnuReport.Text = "แสดงข้อมูล";
            // 
            // mnuProducts_By_Category
            // 
            mnuProducts_By_Category.Name = "mnuProducts_By_Category";
            mnuProducts_By_Category.Size = new Size(195, 22);
            mnuProducts_By_Category.Text = "ข้อมูลสินค้าตามประเภท";
            mnuProducts_By_Category.Click += mnuProducts_By_Category_Click;
            // 
            // mnuEmployee_sale
            // 
            mnuEmployee_sale.Name = "mnuEmployee_sale";
            mnuEmployee_sale.Size = new Size(195, 22);
            mnuEmployee_sale.Text = "ข้อมูลยอดขายตามพนักงาน";
            mnuEmployee_sale.Click += mnuEmployee_sale_Click;
            // 
            // mnuPOS
            // 
            mnuPOS.Name = "mnuPOS";
            mnuPOS.Size = new Size(80, 22);
            mnuPOS.Text = "จำหน่ายสินค้า";
            mnuPOS.Click += mnuPOS_Click;
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new Size(79, 22);
            mnuLogout.Text = "ออกจากระบบ";
            mnuLogout.Click += mnuLogout_Click;
            // 
            // mnuLogin
            // 
            mnuLogin.Name = "mnuLogin";
            mnuLogin.Size = new Size(63, 22);
            mnuLogin.Text = "เข้าสู่ระบบ";
            mnuLogin.Click += mnuLogin_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 562);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "ระบบงานร้านสะดวกซื้อขนาดเล็ก";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuPOS;
        private ToolStripMenuItem mnuLogin;
        private ToolStripMenuItem mnuLogout;
        private ToolStripMenuItem mnuCRUD;
        private ToolStripMenuItem mnuProducts;
        private ToolStripMenuItem mnuEmployees;
        private ToolStripMenuItem mnuCategory;
        private ToolStripMenuItem mnuReport;
        private ToolStripMenuItem mnuProducts_By_Category;
        private ToolStripMenuItem mnuEmployee_sale;
    }
}
