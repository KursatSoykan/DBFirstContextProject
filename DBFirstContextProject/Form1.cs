using DBFirstContextProject.Models;

namespace DBFirstContextProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMax_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwndContext Db = new NorthwndContext();
            var products = Db.Products.ToList();
            dgvProducts.DataSource = products;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NorthwndContext db = new NorthwndContext();
            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
            Product products = db.Products.FirstOrDefault(x => x.ProductId == id);

            if (products != null)
            {
                txtProductName.Text = products.ProductName;
                txtUnitPrice.Text = products.UnitPrice.ToString();
                txtStock.Text = products.UnitsInStock.ToString();

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            NorthwndContext db = new NorthwndContext();
            var Min = Convert.ToInt32(txtMin.Text);
            var Max = Convert.ToInt32(txtMax.Text);

            List<Product> products = db.Products.Where(x => x.UnitPrice >= Min && x.UnitPrice <= Max).ToList();
            dgvProducts.DataSource = products;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NorthwndContext db = new NorthwndContext();
            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
            Product products = db.Products.FirstOrDefault(x => x.ProductId == id);

            products.ProductName= txtProductName.Text;
            products.UnitPrice= Convert.ToDecimal(txtUnitPrice.Text);
            products.UnitsInStock = Convert.ToInt16(txtStock.Text);

            if (products.UnitsInStock < 0 || products.UnitsInStock > 100)
            {
                MessageBox.Show("Please enter numbers between 0 and 100");
                return;
            }

        }
    }
}
