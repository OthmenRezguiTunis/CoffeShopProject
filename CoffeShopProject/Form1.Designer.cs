namespace CoffeShopProject
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.btnOpentill = new MetroFramework.Controls.MetroButton();
            this.button3 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(52, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(520, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Products";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(52, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(520, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Products";
            this.button2.UseSelectable = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOpentill
            // 
            this.btnOpentill.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOpentill.Location = new System.Drawing.Point(52, 121);
            this.btnOpentill.Name = "btnOpentill";
            this.btnOpentill.Size = new System.Drawing.Size(520, 23);
            this.btnOpentill.TabIndex = 2;
            this.btnOpentill.Text = "Open Pos";
            this.btnOpentill.UseSelectable = true;
            this.btnOpentill.Click += new System.EventHandler(this.btnOpentill_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(52, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(520, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "View Chart";
            this.button3.UseSelectable = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOpentill);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroButton button2;
        private MetroFramework.Controls.MetroButton btnOpentill;
        private MetroFramework.Controls.MetroButton button3;
    }
}

