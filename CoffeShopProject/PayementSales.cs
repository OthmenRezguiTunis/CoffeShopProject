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
    public partial class PayementSales : MetroFramework.Forms.MetroForm
    {
        public PayementSales()
        {
            InitializeComponent();
            generategraph();
        }

        private void generategraph()
        {
            using (var coffee = new CoffeShopDatabaseEntities())
            {
                var query = from product in coffee.TransactionItems
                            group product by product.Product.Description into g
                            select new { ProductId = g.Key, TotalUnitsSold = g.Count() };
                chart1.DataSource = query.ToList();
                chart1.Series["Series1"].XValueMember = "ProductId";
                chart1.Series["Series1"].YValueMembers = "TotalUnitsSold";
                chart1.Series["Series1"].Name = "Products";
                chart1.DataBind();
                chart1.Show();
            }
        }
    }
}
