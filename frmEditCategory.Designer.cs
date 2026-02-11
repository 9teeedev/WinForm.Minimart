namespace WinForm.Minimart
{
    partial class frmEditCategory
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
            btnSave = new Button();
            label7 = new Label();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            txtCategoryName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            label1 = new Label();
            txtCategoryID = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(138, 261);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 26);
            btnSave.TabIndex = 41;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(138, 404);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 43;
            label7.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(261, 261);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 26);
            btnClear.TabIndex = 42;
            btnClear.Text = "ล้างฟอร์ม";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCategoryName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCategoryID);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(480, 230);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "จัดการข้อมูลหมวดหมู่";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(160, 69);
            txtCategoryName.Margin = new Padding(4);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(228, 26);
            txtCategoryName.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 14;
            label3.Text = "รายละเอียด";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 3;
            label2.Text = "ชื่อหมวดหมู่สินค้า";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(160, 106);
            txtDescription.Margin = new Padding(4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.RightToLeft = RightToLeft.No;
            txtDescription.Size = new Size(284, 116);
            txtDescription.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "รหัสหมวดหมู่สินค้า";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(160, 27);
            txtCategoryID.Margin = new Padding(4);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(228, 26);
            txtCategoryID.TabIndex = 0;
            // 
            // frmEditCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(517, 315);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(groupBox1);
            Name = "frmEditCategory";
            Text = "frmEditCaegory";
            Load += frmEditCategory_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label7;
        private Button btnClear;
        private GroupBox groupBox1;
        private TextBox txtCategoryName;
        private Label label3;
        private Label label2;
        private TextBox txtDescription;
        private Label label1;
        private TextBox txtCategoryID;

    }
}