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
    public partial class frmEditCategory : Form
    {
        public frmEditCategory()
        {
            InitializeComponent();
        }
        SqlConnection? conn;

        public string status { get; set; }
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }

        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            txtCategoryID.Text = categoryId.ToString();
            txtCategoryName.Text = categoryName;
            txtDescription.Text = description;
            txtCategoryID.Enabled = false;
            txtCategoryName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "insert")
            {
                insert_data();
            }
            else if (status == "update")
            {
                update_data();
            }
            this.Close();
        }
        private void update_data()
        {
            conn = connectDB.ConnectMinimart();
            if (!checkInputData())
            {
                return;
            }
            string sql = "Update Categories Set CategoryName=@CategoryName, " +
                    "Description=@Description Where CategoryID=@CategoryID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CategoryID", txtCategoryID.Text.Trim());
            cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการแก้ไขข้อมูล: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insert_data()
        {
            conn = connectDB.ConnectMinimart();
            if (!checkInputData())
            {
                return;
            }
            string sql = "Insert into Categories (CategoryName,Description) " +
                "Values(@CategoryName,@Description)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการเพิ่มข้อมูล: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool checkInputData() //ถ ้าคืนค่าเป็น true ท างานต่อ แต่ถ ้าคืนค่าเป็น False ข ้อมูลมีข ้อผิดพลาด
        {

            //ตรวจสอบรหัสสนิ คา้ ไมใ่ หเ้ป็นทวี่ า่ ง
            if (txtCategoryID.Text.Trim() == "")
            {
                MessageBox.Show("รหัสหมวดหมู่าต้องไม่เป็นค่าว่าง", "เกิดข้อผิดพลาด");
                return false;
            }
            //ตรวจสอบชอื่ สนิ คา้
            if (txtCategoryName.Text.Trim() == "")
            {
                MessageBox.Show("ชื่อหมวดหมู่ต้องไม่เป็นค่าว่าง", "เกิดข้อผิดพลาด");
                return false;
            }
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("รายละเอียดต้องไม่เป็นค่าว่าง", "เกิดข้อผิดพลาด");
                return false;
            }
            return true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (status == "insert")
            {
                txtCategoryID.Text = string.Empty;
                txtCategoryName.Text = string.Empty;
                txtDescription.Text = string.Empty;
            }
            else if (status == "update")
            {
                txtCategoryID.Text = categoryId.ToString();
                txtCategoryName.Text = categoryName;
                txtDescription.Text = description;
            }
        }
    }
}
