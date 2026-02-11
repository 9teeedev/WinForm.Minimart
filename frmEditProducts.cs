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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "insert")
            {
                insertData();
            }
            else if (status == "update")
            {
                updateData();
            }
            this.Close(); //เมื่อเพิ่มหรือแก ้ไขแล้วควรปิดหน้าต่างฟอร์มออกไป
        }

        private void updateData()
        {
            conn = connectDB.ConnectMinimart();
            //เขียนตรวจสอบข ้อมูล
            if (!checkInputData())
            {
                return; //หมายความว่า ถ ้า checkInputData() มีค่าเป็น False จะจบโค้ดตรงนี้
            }
            string sql = "update products set productName = @productName, UnitPrice= @unitPrice,"
            + " UnitsInStock =@UnitsInStock,CategoryID=@CategoryID,Discontinued = @Discontinued" + " where productID = @productID";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@productID", txtProductID.Text.Trim());
            comm.Parameters.AddWithValue("@productName", txtProductName.Text.Trim());
            comm.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
            comm.Parameters.AddWithValue("@UnitsInStock", txtUnitsInStock.Text);

            comm.Parameters.AddWithValue("@CategoryID", cboCategory.SelectedValue); // เอาค่ารหัสที่ได้ จากการเลือกใน comboBox
            if (radContinued.Checked)
            {
                comm.Parameters.AddWithValue("@Discontinued", 0);
            }
            else if (radDiscontinued.Checked)
            {
                comm.Parameters.AddWithValue("@Discontinued", 1);
            }
            
            try
            {
                comm.ExecuteNonQuery(); //สงั่ ใหก้ ารเพมิ่ ขอมลู ท างาน
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg, "เกิดข้อผิดพลาด");
            }
            conn.Close(); //ปิดการเชอื่ มตอ่
        }

        private void insertData()
        {
            conn = connectDB.ConnectMinimart();
            //เขยีนโคด้ ตรวจสอบขอ้มลู รหัสสนิ คา้ ชอื่ สนิ คา้ ตอ้ งไมเ่ ป็นทวี่ า่ ง ราคา ตอ้ งเป็นตัวเลข จ านวนตอ้ งเป็นตัวเลข
            if (!checkInputData())
            {
                return; //หมายความว่า ถ ้า checkInputData() มีค่าเป็น False จะจบโค้ดตรงนี้
            }
            string sql = "insert into Products " + "values(@productID, @productName, @unitPrice, @UnitsInStock, @CategoryID, @Discontinued)";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@productID", txtProductID.Text.Trim());
            comm.Parameters.AddWithValue("@productName", txtProductName.Text.Trim());
            comm.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
            comm.Parameters.AddWithValue("@UnitsInStock", txtUnitsInStock.Text);
            comm.Parameters.AddWithValue("@CategoryID", cboCategory.SelectedValue); //เอาค่ารหัสที่ได้จากการเลือกใน comboBox
            if (radContinued.Checked)
            {
                comm.Parameters.AddWithValue("@Discontinued", 0);
            }
            else if (radDiscontinued.Checked)
            {
                comm.Parameters.AddWithValue("@Discontinued", 1);
            }

            try
            {
                comm.ExecuteNonQuery(); //สงั่ ใหก้ ารเพมิ่ ขอมลู ท างาน
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg, "เกิดข้อผิดพลาด");
            }
            conn.Close(); //ปิดการเชอื่ มตอ่
        }
        private bool checkInputData() //ถ ้าคืนค่าเป็น true ท างานต่อ แต่ถ ้าคืนค่าเป็น False ข ้อมูลมีข ้อผิดพลาด
        {

            //ตรวจสอบรหัสสนิ คา้ ไมใ่ หเ้ป็นทวี่ า่ ง
            if (txtProductID.Text.Trim() == "")
            {
                MessageBox.Show("รหัสสินค้าต้องไม่เป็นค่าว่าง", "เกิดข้อผิดพลาด");
                return false;
            }
            //ตรวจสอบชอื่ สนิ คา้
            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show("ชื่อสินค้าต้องไม่เป็นค่าว่าง", "เกิดข้อผิดพลาด");
                return false;
            }
            //ตรวจสอบราคากรอกเป็นตัวเลขหรือไม่
            double x = 0.00;
            if (!double.TryParse(txtUnitPrice.Text, out x))
            {
                MessageBox.Show("ราคาสินค้าผิดพลาด", "เกิดข้อผิดพลาด");
                return false;
            }
            //ตรวจสอบจ านวนว่าเป็นจ านวนเต็มหรือไม่
            int y = 0;
            if (!int.TryParse(txtUnitsInStock.Text, out y))
            {
                MessageBox.Show("จำนวนสินค้าผิดพลาด", "เกิดข้อผิดพลาด");
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //เคลียร์ข้อมูลในฟอร์ม
            txtProductID.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtUnitsInStock.Clear();
            cboCategory.SelectedIndex = -1; //กำหนดให้ comboBox ไม่มีการเลือก
            radContinued.Checked = false;
            radDiscontinued.Checked = false;
            radDiscontinued.Enabled = false;
        }
    }
}
