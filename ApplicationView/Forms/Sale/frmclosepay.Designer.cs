namespace ApplicationView.Forms.Sale
{
    partial class frmclosepay
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbtypePay = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtreceive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbtypePay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.txtreceive);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label7.Location = new System.Drawing.Point(185, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 48);
            this.label7.TabIndex = 15;
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cbtypePay
            // 
            this.cbtypePay.FormattingEnabled = true;
            this.cbtypePay.Items.AddRange(new object[] {
            "Seleccione metodo de pago"});
            this.cbtypePay.Location = new System.Drawing.Point(185, 147);
            this.cbtypePay.Name = "cbtypePay";
            this.cbtypePay.Size = new System.Drawing.Size(331, 28);
            this.cbtypePay.TabIndex = 14;
            this.cbtypePay.Tag = "";
            this.cbtypePay.Text = "Seleccione metodo de pago";
            this.cbtypePay.SelectedIndexChanged += new System.EventHandler(this.cbtypePay_SelectedIndexChanged);
            this.cbtypePay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbtypePay_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mode de pago";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(185, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 48);
            this.label3.TabIndex = 12;
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vuelto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Monto total";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(212, 232);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(151, 29);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Aceptar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtreceive
            // 
            this.txtreceive.Location = new System.Drawing.Point(185, 181);
            this.txtreceive.Name = "txtreceive";
            this.txtreceive.Size = new System.Drawing.Size(331, 27);
            this.txtreceive.TabIndex = 2;
            this.txtreceive.TextChanged += new System.EventHandler(this.txtrol_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Recibido";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 325);
            this.tabControl1.TabIndex = 1;
            // 
            // frmclosepay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 331);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmclosepay";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar ventas";
            this.Load += new System.EventHandler(this.frmclosepay_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtreceive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbtypePay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}