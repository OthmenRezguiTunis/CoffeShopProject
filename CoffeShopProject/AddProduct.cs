using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopProject
{
    public partial class AddProduct : MetroFramework.Forms.MetroForm
    {
        private Byte[] byteData;
        private CoffeShopDatabaseEntities cse = new CoffeShopDatabaseEntities();
        public AddProduct()
        {
            InitializeComponent();

            cmbCategory.DataSource = cse.ProductTypes.ToList();
            cmbCategory.DisplayMember = "Description";
            cmbCategory.ValueMember = "ProductType1";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = uploadpicture.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream fs = new FileStream(uploadpicture.FileName , FileMode.Open, FileAccess.Read);
                byteData = new Byte[fs.Length];
                fs.Read(byteData,0, byteData.Length);
                fs.Close();
                fs.Dispose();   

                MemoryStream stream = new MemoryStream(byteData);
                ImageBox.Image = Image.FromStream(stream);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //data validation
            var product = new Product();
            product.Description = txtDescription.Text;
            product.Price =decimal.Parse(txtPrice.Text);
            product.Imagte = byteData;
            product.ProductType = (int)cmbCategory.SelectedValue;

            cse.Products.Add(product);
            cse.SaveChanges();
            MetroFramework.MetroMessageBox.Show(this , "Record Saved !");
        }

        
    }
}
