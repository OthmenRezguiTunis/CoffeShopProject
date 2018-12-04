namespace CoffeShopProject
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.txtAmountToPay = new MetroFramework.Controls.MetroTextBox();
            this.txtPayementAmmuont = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.btnPay = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtAmountToPay
            // 
            // 
            // 
            // 
            this.txtAmountToPay.CustomButton.Image = null;
            this.txtAmountToPay.CustomButton.Location = new System.Drawing.Point(117, 2);
            this.txtAmountToPay.CustomButton.Name = "";
            this.txtAmountToPay.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtAmountToPay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmountToPay.CustomButton.TabIndex = 1;
            this.txtAmountToPay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmountToPay.CustomButton.UseSelectable = true;
            this.txtAmountToPay.CustomButton.Visible = false;
            this.txtAmountToPay.Lines = new string[0];
            this.txtAmountToPay.Location = new System.Drawing.Point(185, 74);
            this.txtAmountToPay.MaxLength = 32767;
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.PasswordChar = '\0';
            this.txtAmountToPay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmountToPay.SelectedText = "";
            this.txtAmountToPay.SelectionLength = 0;
            this.txtAmountToPay.SelectionStart = 0;
            this.txtAmountToPay.ShortcutsEnabled = true;
            this.txtAmountToPay.Size = new System.Drawing.Size(135, 20);
            this.txtAmountToPay.TabIndex = 0;
            this.txtAmountToPay.UseSelectable = true;
            this.txtAmountToPay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmountToPay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPayementAmmuont
            // 
            // 
            // 
            // 
            this.txtPayementAmmuont.CustomButton.Image = null;
            this.txtPayementAmmuont.CustomButton.Location = new System.Drawing.Point(117, 2);
            this.txtPayementAmmuont.CustomButton.Name = "";
            this.txtPayementAmmuont.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPayementAmmuont.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPayementAmmuont.CustomButton.TabIndex = 1;
            this.txtPayementAmmuont.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPayementAmmuont.CustomButton.UseSelectable = true;
            this.txtPayementAmmuont.CustomButton.Visible = false;
            this.txtPayementAmmuont.Lines = new string[0];
            this.txtPayementAmmuont.Location = new System.Drawing.Point(185, 130);
            this.txtPayementAmmuont.MaxLength = 32767;
            this.txtPayementAmmuont.Name = "txtPayementAmmuont";
            this.txtPayementAmmuont.PasswordChar = '\0';
            this.txtPayementAmmuont.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPayementAmmuont.SelectedText = "";
            this.txtPayementAmmuont.SelectionLength = 0;
            this.txtPayementAmmuont.SelectionStart = 0;
            this.txtPayementAmmuont.ShortcutsEnabled = true;
            this.txtPayementAmmuont.Size = new System.Drawing.Size(135, 20);
            this.txtPayementAmmuont.TabIndex = 2;
            this.txtPayementAmmuont.UseSelectable = true;
            this.txtPayementAmmuont.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPayementAmmuont.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ammount To pay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Payment Ammount";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(185, 183);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(135, 23);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Pay";
            this.btnPay.UseSelectable = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayementAmmuont);
            this.Controls.Add(this.txtAmountToPay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtAmountToPay;
        private MetroFramework.Controls.MetroTextBox txtPayementAmmuont;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroButton btnPay;
    }
}