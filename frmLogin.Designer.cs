namespace WinForm.Minimart
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            txtErrorMsg = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 29);
            label1.Name = "label1";
            label1.Size = new Size(196, 30);
            label1.TabIndex = 0;
            label1.Text = "ร้านสะดวกซื้อขนาดเล็ก";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 78);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(34, 102);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(283, 23);
            txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 143);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(34, 167);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(283, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 255, 255);
            btnLogin.Location = new Point(85, 234);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(77, 36);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "เข้าสู่ระบบ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtErrorMsg
            // 
            txtErrorMsg.AutoSize = true;
            txtErrorMsg.ForeColor = Color.Red;
            txtErrorMsg.Location = new Point(34, 202);
            txtErrorMsg.Name = "txtErrorMsg";
            txtErrorMsg.Size = new Size(12, 15);
            txtErrorMsg.TabIndex = 6;
            txtErrorMsg.Text = "*";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 192);
            btnCancel.Location = new Point(183, 234);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            CancelButton = btnCancel;
            ClientSize = new Size(355, 319);
            Controls.Add(btnCancel);
            Controls.Add(txtErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label txtErrorMsg;
        private Button btnCancel;
    }
}