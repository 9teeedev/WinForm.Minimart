using Microsoft.Data.SqlClient;
using System.Data;
namespace WinForm.Minimart
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        SqlConnection? conn;
        // ตัวแปรเก็บข้อมูลพนักงานที่เข้าสู่ระบบ
        int employeeID = 0;
        string employeeName = string.Empty;
        string position = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart(); //เรียกใช้ฟังก์ชันเชื่อมต่อฐานข้อมูล
            //showMenuMananer();
            //showMenuSale();
            showMenuStart(); // เริ่มต้นแสดงเมนูสำหรับผู้ที่ยังไม่ได้เข้าสู่ระบบ
           
        }
        private void SetMenuVisible(params ToolStripMenuItem[] menuItems)
        {
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                menuItem.Visible = false;
            }

            foreach (var m in menuItems)
            {
                m.Visible = true;
            }
        }

        private void showMenuStart() // แสดงเมนูสำหรับผู้ที่ยังไม่ได้เข้าสู่ระบบ
        {
            SetMenuVisible(mnuLogin); // แสดงเฉพาะเมนู Login
            this.Text = " - ระบบร้านสะดวกซื้อขนาดเล็ก"; // ตั้งชื่อฟอร์มให้แสดงข้อความสำหรับผู้ที่ยังไม่ได้เข้าสู่ระบบ
        }

        private void showMenuSale() // แสดงเมนูสำหรับพนักงานขาย
        {
            SetMenuVisible(mnuReport, mnuPOS, mnuProducts_By_Category, mnuLogout); // แสดงเฉพาะเมนูที่เกี่ยวข้องกับพนักงานขาย
        }

        private void showMenuManager() // แสดงเมนูสำหรับผู้จัดการ
        {
            SetMenuVisible(mnuCRUD, mnuReport, mnuProducts_By_Category, mnuEmployee_sale, mnuLogout); // แสดงเฉพาะเมนูที่เกี่ยวข้องกับผู้จัดการ
        }

        private void mnuProducts_Click(object sender, EventArgs e)
        {
            // เปิดฟอร์มจัดการข้อมูลสินค้า ห้ามเปิดซ้ำ
            if (Application.OpenForms["frmProducts"] == null)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                frmProducts frm = new frmProducts();
                frm.MdiParent = this; //ตั้งค่า MdiParent เป็น frmMenu
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void mnuEmployees_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEmployees"] == null)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                frmEmployees frm = new frmEmployees();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void mnuCategory_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCategories"] == null)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                frmCategories frm = new frmCategories();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void mnuProducts_By_Category_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmProduct_by_Category"] == null)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                frmProduct_by_Category frm = new frmProduct_by_Category();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void mnuEmployee_sale_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSaleByEmployees"] == null)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                frmSaleByEmployees frm = new frmSaleByEmployees();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void mnuPOS_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPOS"] == null)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                frmPOS frm = new frmPOS();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            employeeID = 0;
            employeeName = string.Empty;
            position = string.Empty;
            foreach (Form childForm in this.MdiChildren) { 
                childForm.Close();
            }
            showMenuStart(); // แสดงเมนูสำหรับผู้ที่ยังไม่ได้เข้าสู่ระบบ
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms["frmLogin"] == null)
            {
                frmLogin frm = new frmLogin();
                
                var result = frm.ShowDialog();
                // หลังจากปิดฟอร์ม Login ให้ตรวจสอบข้อมูลพนักงานที่เข้าสู่ระบบ
                if (result == DialogResult.OK)
                {
                    employeeID = frm.EmployeeID;
                    employeeName = frm.EmployeeName;
                    position = frm.Position;

                    if (position == "Sale Manager")
                    {
                        showMenuManager();
                        this.Text = $" - ผู้ปฏิบัติงาน: {employeeName} (ตำแหน่ง {position})";
                    }
                    else if (position == "Sale Representative")
                    {
                        showMenuSale();
                        this.Text = $" - ผู้ปฏิบัติงาน: {employeeName} (ตำแหน่ง {position})";
                    }
                    else
                    {
                        MessageBox.Show("ตำแหน่งไม่ถูกต้อง");
                    }
                }
                
            }
        }
    }
}
