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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddProduct addProduct = new AddProduct();
            addProduct.Show();
               
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewProducts Product = new ViewProducts();
            Product.Show();
        }

        private void btnOpentill_Click(object sender, EventArgs e)
        {
            CoffeShoppPos Pos = new CoffeShoppPos();
            Pos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var paymentsale = new PayementSales();
            paymentsale.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
