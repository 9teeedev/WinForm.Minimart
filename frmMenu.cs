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
        int employeeID;
        string employeeName = string.Empty;
        string position = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart(); //เรียกใช้ฟังก์ชันเชื่อมต่อฐานข้อมูล
        }

        private void mnuProducts_Click(object sender, EventArgs e)
        {
            // เปิดฟอร์มจัดการข้อมูลสินค้า ห้ามเปิดซ้ำ
            if (Application.OpenForms["frmProducts"] == null)
            {
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
                frmEmployees frm = new frmEmployees();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuCategory_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCategories"] == null)
            {
                frmCategories frm = new frmCategories();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuProducts_By_Category_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmProduct_by_Category"] == null)
            {
                frmProduct_by_Category frm = new frmProduct_by_Category();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuEmployee_sale_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSaleByEmployees"] == null)
            {
                frmSaleByEmployees frm = new frmSaleByEmployees();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuPOS_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPOS"] == null)
            {
                frmPOS frm = new frmPOS();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmLogin"] == null)
            {
                frmLogin frm = new frmLogin();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
