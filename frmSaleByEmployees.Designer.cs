namespace WinForm.Minimart
{
    partial class frmSaleByEmployees
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
            dgvEmployees = new DataGridView();
            dgvSale = new DataGridView();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSale).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 12);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(776, 150);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.CellMouseUp += dgvEmployees_CellMouseUp;
            // 
            // dgvSale
            // 
            dgvSale.AllowUserToAddRows = false;
            dgvSale.AllowUserToDeleteRows = false;
            dgvSale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSale.Location = new Point(12, 191);
            dgvSale.Name = "dgvSale";
            dgvSale.ReadOnly = true;
            dgvSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSale.Size = new Size(776, 247);
            dgvSale.TabIndex = 1;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(350, 160);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(106, 31);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "แสดงทั้งหมด";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // frmSaleByEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowAll);
            Controls.Add(dgvSale);
            Controls.Add(dgvEmployees);
            Name = "frmSaleByEmployees";
            Text = "frmSaleByEmployees";
            Load += frmSaleByEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployees;
        private DataGridView dgvSale;
        private Button btnShowAll;
    }
}