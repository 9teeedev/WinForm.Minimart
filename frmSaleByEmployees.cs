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
// for using format function in sql query
using System.Globalization;

namespace WinForm.Minimart
{
    public partial class frmSaleByEmployees : Form
    {
        public frmSaleByEmployees()
        {
            InitializeComponent();
        }
        SqlConnection? conn = null;
        int employeeID;
        private void frmSaleByEmployees_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            showEmployees();
            showSales(0);
        }

        private void showEmployees()
        {
            string sql = "select e.EmployeeID, Salename=title+FirstName+space(2)+LastName, SaleRevenue=sum(TotalCash) from Receipts r right outer join Employees e on r.EmployeeID = e.EmployeeID\r\ngroup by e.EmployeeID, title+FirstName+space(2)+LastName";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvEmployees.DataSource = ds.Tables[0];
        }
        private void showSales(int empID)
        {
            SqlCommand cmd;
            if (empID == 0)
            {
                string sql = "select ReceiptID, ReceiptDate, TotalCash AS TotalCash"
                    + " from Receipts r join Employees e on r.EmployeeID = e.EmployeeID"
                    + " order by r.ReceiptID";
                cmd = new SqlCommand(sql, conn);
            }
            else
            {
                string sql = "select ReceiptID, ReceiptDate, TotalCash from Receipts r join Employees e on r.EmployeeID = e.EmployeeID where e.EmployeeID = @empID order by r.ReceiptID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@empID", empID);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvSale.DataSource = ds.Tables[0];
        }

        private void dgvEmployees_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                employeeID = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells[0].Value);
                showSales(employeeID);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showSales(0);
        }
    }
}
