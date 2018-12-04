namespace CoffeShopProject
{
    partial class CoffeShoppPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeShoppPos));
            this.listProductChosen = new System.Windows.Forms.ListBox();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.txtinfotile = new MetroFramework.Controls.MetroTextBox();
            this.btndeleteitem = new MetroFramework.Controls.MetroButton();
            this.btnPay = new MetroFramework.Controls.MetroButton();
            this.txttotal = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // listProductChosen
            // 
            this.listProductChosen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProductChosen.FormattingEnabled = true;
            this.listProductChosen.ItemHeight = 14;
            this.listProductChosen.Location = new System.Drawing.Point(554, 60);
            this.listProductChosen.Name = "listProductChosen";
            this.listProductChosen.Size = new System.Drawing.Size(247, 270);
            this.listProductChosen.TabIndex = 0;
            this.listProductChosen.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.formatlistitem);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(30, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 245);
            this.tabControl1.TabIndex = 2;
            // 
            // txtinfotile
            // 
            this.txtinfotile.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinfotile.Location = new System.Drawing.Point(30, 57);
            this.txtinfotile.Name = "txtinfotile";
            this.txtinfotile.Size = new System.Drawing.Size(509, 22);
            this.txtinfotile.TabIndex = 3;
            this.txtinfotile.Text = "Next Customer";
            // 
            // btndeleteitem
            // 
            this.btndeleteitem.BackColor = System.Drawing.Color.Red;
            this.btndeleteitem.Location = new System.Drawing.Point(554, 346);
            this.btndeleteitem.Name = "btndeleteitem";
            this.btndeleteitem.Size = new System.Drawing.Size(75, 35);
            this.btndeleteitem.TabIndex = 4;
            this.btndeleteitem.Text = "Delete";
            this.btndeleteitem.UseSelectable = true;
            this.btndeleteitem.Click += new System.EventHandler(this.btndeleteitem_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPay.Location = new System.Drawing.Point(23, 346);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(509, 35);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Pay";
            this.btnPay.UseSelectable = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(644, 354);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(146, 20);
            this.txttotal.TabIndex = 6;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
       
            // metroTabControl1
            // 
       
            // 
            // CoffeShoppPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 415);
     
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btndeleteitem);
            this.Controls.Add(this.txtinfotile);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listProductChosen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoffeShoppPos";
            this.Text = "Welcome to The CoffeShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProductChosen;
        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTextBox txtinfotile;
        private MetroFramework.Controls.MetroTextBox txttotal;
        private MetroFramework.Controls.MetroButton btndeleteitem;
        private MetroFramework.Controls.MetroButton btnPay;

    }
}