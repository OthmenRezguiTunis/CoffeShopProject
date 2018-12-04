namespace CoffeShopProject
{
    partial class ViewProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProducts));
            this.ProductList = new System.Windows.Forms.DataGridView();
            this.comboBox1filter = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductList.Location = new System.Drawing.Point(23, 54);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(499, 237);
            this.ProductList.TabIndex = 0;
            // 
            // comboBox1filter
            // 
            this.comboBox1filter.FormattingEnabled = true;
            this.comboBox1filter.Location = new System.Drawing.Point(23, 313);
            this.comboBox1filter.Name = "comboBox1filter";
            this.comboBox1filter.Size = new System.Drawing.Size(303, 21);
            this.comboBox1filter.TabIndex = 1;
            this.comboBox1filter.SelectionChangeCommitted += new System.EventHandler(this.comboBox1filter_SelectionChangeCommitted);
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 372);
            this.Controls.Add(this.comboBox1filter);
            this.Controls.Add(this.ProductList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewProducts";
            this.Text = "View Products";
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductList;
        private  MetroFramework.Controls.MetroComboBox comboBox1filter;
    }
}