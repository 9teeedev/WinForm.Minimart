namespace WinForm.Minimart
{
    partial class frmEditProducts
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

        //#region Windows Form Designer generated code

        ///// <summary>
        ///// Required method for Designer support - do not modify
        ///// the contents of this method with the code editor.
        ///// </summary>
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Text = "frmEditProducts";
        //}

        //#endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            radDiscontinued = new RadioButton();
            radContinued = new RadioButton();
            btnClear = new Button();
            label7 = new Label();
            btnSave = new Button();
            txtProductID = new TextBox();
            label1 = new Label();
            txtUnitPrice = new TextBox();
            label2 = new Label();
            label9 = new Label();
            txtUnitsInStock = new TextBox();
            label3 = new Label();
            label8 = new Label();
            txtProductName = new TextBox();
            cboCategory = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radDiscontinued);
            groupBox2.Controls.Add(radContinued);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.Location = new Point(217, 248);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(298, 101);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "สถานะของสินค้า";
            // 
            // radDiscontinued
            // 
            radDiscontinued.AutoSize = true;
            radDiscontinued.Location = new Point(30, 65);
            radDiscontinued.Margin = new Padding(4);
            radDiscontinued.Name = "radDiscontinued";
            radDiscontinued.Size = new Size(98, 24);
            radDiscontinued.TabIndex = 22;
            radDiscontinued.TabStop = true;
            radDiscontinued.Text = "เลิกจำหน่าย";
            radDiscontinued.UseVisualStyleBackColor = true;
            // 
            // radContinued
            // 
            radContinued.AutoSize = true;
            radContinued.Location = new Point(30, 30);
            radContinued.Margin = new Padding(4);
            radContinued.Name = "radContinued";
            radContinued.Size = new Size(102, 24);
            radContinued.TabIndex = 21;
            radContinued.TabStop = true;
            radContinued.Text = "จำหน่ายปกติ";
            radContinued.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(280, 374);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 26);
            btnClear.TabIndex = 37;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(159, 401);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 38;
            label7.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(163, 374);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 26);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(129, 28);
            txtProductID.Margin = new Padding(4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(162, 26);
            txtProductID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "รหัสสินค้า";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(129, 103);
            txtUnitPrice.Margin = new Padding(4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(102, 26);
            txtUnitPrice.TabIndex = 2;
            txtUnitPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "ชื่อสินค้า";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1, 185);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 3;
            label9.Text = "ประเภทสินค้า";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(129, 140);
            txtUnitsInStock.Margin = new Padding(4);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(102, 26);
            txtUnitsInStock.TabIndex = 3;
            txtUnitsInStock.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 111);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 14;
            label3.Text = "ราคา";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 148);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 15;
            label8.Text = "จำนวน";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(129, 66);
            txtProductName.Margin = new Padding(4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(228, 26);
            txtProductName.TabIndex = 16;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(129, 176);
            cboCategory.Margin = new Padding(4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(228, 28);
            cboCategory.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUnitsInStock);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new Point(34, 10);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(480, 230);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "จัดการข้อมูลสินค้า";
            // 
            // frmEditProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(527, 428);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmEditProducts";
            Text = "แบบฟอร์มข้อมูลสินค้า";
            Load += frmEditProducts_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private RadioButton radDiscontinued;
        private RadioButton radContinued;
        private Button btnClear;
        private Label label7;
        private Button btnSave;
        private TextBox txtProductID;
        private Label label1;
        private TextBox txtUnitPrice;
        private Label label2;
        private Label label9;
        private TextBox txtUnitsInStock;
        private Label label3;
        private Label label8;
        private TextBox txtProductName;
        private ComboBox cboCategory;
        private GroupBox groupBox1;
    }
}