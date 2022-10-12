namespace ApplicationView.Forms.Product
{
    partial class frmupdatesingleproduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsaleprice = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkpurchase = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio de venta actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Porcentaje";
            // 
            // txtsaleprice
            // 
            this.txtsaleprice.Location = new System.Drawing.Point(354, 156);
            this.txtsaleprice.Name = "txtsaleprice";
            this.txtsaleprice.Size = new System.Drawing.Size(137, 27);
            this.txtsaleprice.TabIndex = 6;
            this.txtsaleprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(354, 53);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(137, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(183, 198);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(151, 29);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Actualizar precio";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(218, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 20);
            this.label3.TabIndex = 20;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre del producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Precio de  compra actual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "¿Deseas actualizar precio de compra?";
            // 
            // chkpurchase
            // 
            this.chkpurchase.AutoSize = true;
            this.chkpurchase.Location = new System.Drawing.Point(467, 94);
            this.chkpurchase.Name = "chkpurchase";
            this.chkpurchase.Size = new System.Drawing.Size(18, 17);
            this.chkpurchase.TabIndex = 24;
            this.chkpurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkpurchase.UseVisualStyleBackColor = true;
            this.chkpurchase.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(354, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 25;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmupdatesingleproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 242);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkpurchase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsaleprice);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmupdatesingleproduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actulizacion de precio de producto unico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsaleprice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkpurchase;
        private System.Windows.Forms.Label label5;
    }
}