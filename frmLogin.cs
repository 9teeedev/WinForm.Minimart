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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection? conn;
        public int EmployeeID { get; private set; }
        public string EmployeeName { get; private set; } = string.Empty;
        public string Position { get; private set; } = string.Empty;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart(); //เรียกใช้ฟังก์ชันเชื่อมต่อฐานข้อมูล
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            conn = connectDB.ConnectMinimart(); //เรียกใช้ฟังก์ชันเชื่อมต่อฐานข้อมูล
            if (ConnectionState.Open == conn.State){
                {
                    string sql = "SELECT EmployeeID, Salename = title+FirstName+space(2)+LastName, Position FROM Employees WHERE Username = @username AND Password = @password";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        EmployeeID = reader.GetInt32(0);
                        EmployeeName = reader.GetString(1);
                        Position = reader.GetString(2);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง.", "เข้าศู่ระบบไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
