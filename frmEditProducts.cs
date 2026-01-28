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
    public partial class frmEditProducts : Form
    {
        public frmEditProducts()
        {
            InitializeComponent();
        }
        public string productID { get; set; }
        public string productName { get; set; }
        public double unitPrice { get; set; }
        public int unitsInStock { get; set; }
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public int discontinued { get; set; }

        public string status { get; set; }  //  insert, update

        SqlConnection? conn;    //ประกาศตัวแปรเชื่อมต่อ

        private void frmEditProducts_Load(object sender, EventArgs e)
        {
            //เชื่อมต่อฐานข้อมูล
            conn = connectDB.ConnectMinimart();
            setCbo();
            //นำข้อมูลที่ถูกส่งมาไปแสดงผลในฟอร์ม
            txtProductID.Text = productID;
            txtProductName.Text = productName;
            txtUnitPrice.Text = unitPrice.ToString();
            txtUnitsInStock.Text = unitsInStock.ToString();
            cboCategory.SelectedValue = categoryID;     //กำหนดให้ ComboBox แสดงผล
            if (discontinued == 1)
            {
                radDiscontinued.Checked = true;
            }
            else
            {
                radContinued.Checked = true;
            }

        }

        private void setCbo()
        {
            string sql = "Select CategoryID,CategoryName from Categories";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cboCategory.DataSource = ds.Tables[0];
            cboCategory.ValueMember = "CategoryID";      //กำหนดคอลัมน์ที่เป็นค่ารหัส
            cboCategory.DisplayMember = "CategoryName";   //กำหนดข้อมูลที่แสดงผล

        }
    }
}
