namespace DBFirstContextProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMin = new TextBox();
            txtMax = new TextBox();
            btnFilter = new Button();
            lblMin = new Label();
            lblMax = new Label();
            dgvProducts = new DataGridView();
            lblName = new Label();
            lblUnitPrice = new Label();
            lblStock = new Label();
            txtProductName = new TextBox();
            txtUnitPrice = new TextBox();
            txtStock = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtMin
            // 
            txtMin.Location = new Point(79, 23);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(202, 23);
            txtMin.TabIndex = 0;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(371, 23);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(208, 23);
            txtMax.TabIndex = 1;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(616, 15);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(161, 37);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(25, 26);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(28, 15);
            lblMin.TabIndex = 3;
            lblMin.Text = "Min";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(311, 26);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(30, 15);
            lblMax.TabIndex = 4;
            lblMax.Text = "Max";
            lblMax.Click += lblMax_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 74);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(605, 404);
            dgvProducts.TabIndex = 5;
            dgvProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(666, 118);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(666, 185);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(55, 15);
            lblUnitPrice.TabIndex = 7;
            lblUnitPrice.Text = "UnitPrice";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(666, 261);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 8;
            lblStock.Text = "Stock";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(761, 110);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(165, 23);
            txtProductName.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(761, 177);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(165, 23);
            txtUnitPrice.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(761, 253);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(165, 23);
            txtStock.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(761, 307);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(165, 46);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 490);
            Controls.Add(btnUpdate);
            Controls.Add(txtStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblStock);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblName);
            Controls.Add(dgvProducts);
            Controls.Add(lblMax);
            Controls.Add(lblMin);
            Controls.Add(btnFilter);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMin;
        private TextBox txtMax;
        private Button btnFilter;
        private Label lblMin;
        private Label lblMax;
        private DataGridView dgvProducts;
        private Label lblName;
        private Label lblUnitPrice;
        private Label lblStock;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private TextBox txtStock;
        private Button btnUpdate;
    }
}
