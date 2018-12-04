using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopProject
{
    public partial class CoffeShoppPos : MetroFramework.Forms.MetroForm
    {
        private BindingList<Product> Products = new BindingList<Product>();
        private CoffeShopDatabaseEntities cse = new CoffeShopDatabaseEntities();
        private decimal transactionTotal; 
public decimal TransactionTotal
        {
            get
            {
                return transactionTotal;
            }

            set
            {
                transactionTotal = value;
                txttotal.Text = string.Format("{0:c}", transactionTotal);
            }
        }

        public CoffeShoppPos()
        {
            InitializeComponent();

            listProductChosen.DataSource = Products;
            listProductChosen.DisplayMember = "Description";

            CreateTabbedPannel();
            AddProductsToTabbedPannel();
            //CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal? totalPrice = 0;
            foreach (var item in Products)
            {
                totalPrice += item.Price;
            }

            txttotal.Text = string.Format("{0:c}", totalPrice);
        }

        private void CreateTabbedPannel()
        {
            foreach (var pt in cse.ProductTypes.ToList())
            {
                tabControl1.TabPages.Add(pt.ProductType1.ToString(), pt.Description);
            }

        }

        private void AddProductsToTabbedPannel()
        {
            int i = 0;
            foreach (TabPage tp in tabControl1.TabPages)
            {
                var listproducts = cse.Products.ToList().Where(x => x.ProductType == i);
                i++;
                FlowLayoutPanel fop = new FlowLayoutPanel();
                fop.Dock = DockStyle.Fill;
                foreach (var product in listproducts)
                {
                    Button b = new Button();
                    b.Size = new Size(100, 100);
                    b.Text = product.Description;
                    b.Tag = product;
                    b.Click += UpdateProductList;
                    fop.Controls.Add(b);
                }
                tp.Controls.Add(fop);
            }

        }

        private void UpdateProductList(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            var p = (Product)b.Tag;

            Products.Add(p);
            UpdateCustomerInfo(p);
            //CalculateTotal();
            TransactionTotal = TransactionTotal + (decimal)p.Price;
            listProductChosen.SelectedIndex = listProductChosen.Items.Count - 1;

        }

        private void UpdateCustomerInfo(Product product )
        {
            txtinfotile.Text = product.Description.PadRight(30) + "" + string.Format ("{0:c}",product.Price);
        }

        private void formatlistitem(object sender, ListControlConvertEventArgs e)
        {
            string currentDescription = ((Product)e.ListItem).Description;
            string currentPrice = string.Format("{0:c}", ((Product)e.ListItem).Price);

            string currentDescriptionPadded = currentDescription.PadRight(30);
            e.Value = currentDescriptionPadded + currentPrice;
        }

        private void btndeleteitem_Click(object sender, EventArgs e)
        {
            var item = (Product)listProductChosen.SelectedItem; ;
            Products.Remove(item);
            //CalculateTotal();
            TransactionTotal = TransactionTotal - (decimal)item.Price;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var payement = new Payment();
            payement.PaymentAmmount = transactionTotal;
            payement.PayementMade += new Payment.PayementMadeEvent(PaymentSuccess);
            payement.ShowDialog();
            PrintReceipt();



        }

        private void PrintReceipt()
        {

            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courrier New",12);
            float fontHeight = font.GetHashCode();

            int StartX = 10;
            int StartY = 10;
            int Offset = 40;

            graphic.DrawString("welcome to the CoffeeShop ", new Font("Courrier New", 18), new SolidBrush(Color.Black) , StartX , StartY);


            foreach (var Product in Products)
            {

                string ProductDescription = Product.Description.PadRight(30);
                string ProductTotal = string.Format("{0:c}" , Product.Price);
                string ProductLine = ProductDescription + ProductTotal;
                graphic.DrawString(ProductLine, new Font("Courrier New", 18), new SolidBrush(Color.Black), StartX, StartY+Offset);

                Offset += (int)FontHeight + 5;
            }

            Offset+= Offset+ 20;
            graphic.DrawString("Total To Pay".PadRight(30) + string.Format("{0:c}" , transactionTotal), new Font("Courrier New", 18), new SolidBrush(Color.Black), StartX, StartY + Offset);

        }

        private void PaymentSuccess(object sender, PayementMadeEventArgs e)
        {
            var transaction = new Transaction();
            transaction.TransactionDate = DateTime.Now;
            transaction.TransactionItems = new List<TransactionItem>();  
            if (e.PayementSuccess)
            {
                foreach (var item in Products)
                {
                    transaction.TransactionItems.Add(new TransactionItem { ProductId = item.ProductId });
                }

                cse.Transactions.Add(transaction);
                cse.SaveChanges();
                // Save current Transaction
            }
        }
    }
}
