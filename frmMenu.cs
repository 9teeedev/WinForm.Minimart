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
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart(); //เรียกใช้ฟังก์ชันเชื่อมต่อฐานข้อมูล

        }

        private void showdata1(string sql, DataGridView dgv)
        {
            SqlCommand cmd = new SqlCommand(sql, conn); //สร้างคำสั่ง SQL
            SqlDataAdapter da = new SqlDataAdapter(cmd); //สร้างตัวดึงข้อมูล
            DataSet ds = new DataSet(); //สร้างตัวเก็บข้อมูล
            da.Fill(ds, "products"); //ดึงข้อมูลใส่ตัวเก็บข้อมูล
            dgv.DataSource = ds.Tables["products"]; //แสดงข้อมูลใน DataGridView
        }



        private void จดการสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // เปิดฟอร์มจัดการสินค้า ได้ 1 อัน
            frmProducts f = new frmProducts();
            f.MdiParent = this; // กำหนดฟอร์มแม่
            f.Show();


        }

        private void จดการหมวดหมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // เปิดฟอร์มจัดการหมวดหมู่
            frmCategories f = new frmCategories();
            f.MdiParent = this; // กำหนดฟอร์มแม่
            f.Show();
        }

        private void จดการพนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployees f = new frmEmployees();
            f.MdiParent = this; // กำหนดฟอร์มแม่
            f.Show();
        }
    }
}
