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
    public partial class Payment : MetroFramework.Forms.MetroForm
    {

        public delegate void PayementMadeEvent(object sender, PayementMadeEventArgs e);
        public event PayementMadeEvent PayementMade;
        private decimal paymentAmmount;
        public decimal PaymentAmmount
        {
            get
            {
                return paymentAmmount;
            }

            set
            {
                paymentAmmount = value;
                txtAmountToPay.Text = string.Format("{0:c}", paymentAmmount);
            }
        }
        public Payment()
        {
            InitializeComponent();
            //txtAmountToPay.txt = 
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal? total = 0;
            try
            {
                total = Decimal.Parse(txtAmountToPay.Text.TrimEnd('€')) - Decimal.Parse(txtPayementAmmuont.Text);
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this,"Error Please Enter a valid Number");
                return;
            }
            if (total > 0)
            {

                txtAmountToPay.Text = total.ToString();
            }

            else
            {
                MetroFramework.MetroMessageBox.Show(this , "Please give " + string.Format("{0:c}", -total));
                PayementMade(this, new PayementMadeEventArgs { PayementSuccess = true });
             



            }

           

        }


    }


    public class PayementMadeEventArgs : EventArgs
    {

        private bool payementSuccess;

        public bool PayementSuccess
        {
            get
            {
                return payementSuccess;
            }

            set
            {
                payementSuccess = value;
            }
        }
    }
}
