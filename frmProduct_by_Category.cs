using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinForm.Minimart
{
    public partial class frmProduct_by_Category : Form
    {
        public frmProduct_by_Category()
        {
            InitializeComponent();
        }
        SqlConnection? conn = null;
        int CategoryID;
        private void frmProduct_by_Category_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            showCategory();
            showProducts(0);
        }

        private void showProducts(int categoryID)
        {
            SqlCommand cmd;
            if (categoryID == 0)
            {
                string sql = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products Order By ProductID";
                cmd = new SqlCommand(sql, conn);
            }
            else
            {
                string sql = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products WHERE CategoryID = @categoryID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@categoryID", categoryID);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvProduct.DataSource = ds.Tables[0];
        }

        private void showCategory()
        {
            string sql = "SELECT categoryID, CategoryName FROM Categories";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCategory.DataSource = ds.Tables[0];
        }

        private void dgvCategory_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // เมื่อคลิกประเภทสินค้าใน dgvCategory ให้แสดงสินค้าที่อยู่ในประเภทนั้นใน dgvProduct
            if (e.RowIndex >= 0) {
                CategoryID = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
                showProducts(CategoryID);
            }
        }
    }
}
