using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Minimart
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }
        SqlConnection? conn;

        int categoryId = 0;
        string categoryName = string.Empty;
        string description = string.Empty;

        private void frmCategories_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart(); //เรียกใช้ฟังก์ชันเชื่อมต่อฐานข้อมูล
            showdata("");
        }

        private void showdata(string str)
        {
            string query = "Select * from Categories Where CategoryName like @search" +
                " OR Description LIKE @search";
            SqlCommand cmd = new SqlCommand(query, conn); //สร้างคำสั่ง SQL
            cmd.Parameters.AddWithValue("@search", "%" + str + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd); //สร้างตัวดึงข้อมูล
            DataSet ds = new DataSet(); //สร้างตัวเก็บข้อมูล
            da.Fill(ds); //ดึงข้อมูลใส่ตัวเก็บข้อมูล
            dgvCategory.DataSource = ds.Tables[0]; //แสดงข้อมูลใน DataGridView
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            categoryName = txtSearch.Text;
            showdata(categoryName);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmEditCategory f = new frmEditCategory();
            f.categoryId = 0;
            f.categoryName = string.Empty;
            f.description = string.Empty;
            f.status = "insert";
            f.ShowDialog();

            showdata("");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (categoryId == 0)
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบ");
                return;
            }
            DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่", "ยืนยันการลบ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string query = "Delete from Categories Where CategoryID=@id";
                    SqlCommand cmd = new SqlCommand(query, conn); //สร้างคำสั่ง SQL
                    cmd.Parameters.AddWithValue("@id", categoryId);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบข้อมูลได้");
                    }
                    showdata("");
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    MessageBox.Show("ไม่สามารถลบข้อมูลได้ เนื่องจากมีข้อมูลในตารางอื่นอ้างอิง \n", "เกิดข้อผิดพลาด");
                }
                
            }

        }

        private void dgvCategory_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            categoryId = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells[0].Value);
            categoryName = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString() ?? string.Empty;
            description = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString() ?? string.Empty;
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditCategory f = new frmEditCategory();
            f.categoryId = categoryId;
            f.categoryName = categoryName;
            f.description = description;
            f.status = "update";
            f.ShowDialog();

            showdata("");
        }
    }
}
