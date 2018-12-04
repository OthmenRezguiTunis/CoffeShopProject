using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopProject
{
    public partial class ViewProducts : MetroFramework.Forms.MetroForm
    {
        private CoffeShopDatabaseEntities cse = new CoffeShopDatabaseEntities();
        public ViewProducts()
        {
            InitializeComponent();

            ProductList.DataSource = cse.Products.ToList();
            ProductList.Columns["ProductType1"].Visible = false;
            ProductList.Columns["TransactionItems"].Visible = false;
            comboBox1filter.DataSource = cse.ProductTypes.ToList();
            comboBox1filter.DisplayMember = "Description";
            comboBox1filter.ValueMember = "ProductType1";
        }

   

        private void comboBox1filter_SelectionChangeCommitted(object sender, EventArgs e)
        {

            var Id = (int)comboBox1filter.SelectedValue;
            var products = cse.Products.ToList().Where(x => x.ProductType == Id);
            ProductList.DataSource = products.ToList();

        }
    }
}
