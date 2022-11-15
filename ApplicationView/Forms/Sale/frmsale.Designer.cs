namespace ApplicationView.Forms.Sale
{
    partial class frmsale
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
            this.dataList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnpay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtreadcode = new System.Windows.Forms.TextBox();
            this.productqquantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nrofact = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcajeroname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataList
            // 
            this.dataList.AllowUserToAddRows = false;
            this.dataList.AllowUserToDeleteRows = false;
            this.dataList.AllowUserToOrderColumns = true;
            this.dataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.productId,
            this.ProductCode,
            this.ProductName,
            this.SalePrice,
            this.quantity,
            this.SaleId,
            this.InvoiceCode});
            this.dataList.Location = new System.Drawing.Point(12, 138);
            this.dataList.MultiSelect = false;
            this.dataList.Name = "dataList";
            this.dataList.ReadOnly = true;
            this.dataList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataList.RowHeadersWidth = 51;
            this.dataList.RowTemplate.Height = 29;
            this.dataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataList.Size = new System.Drawing.Size(1749, 546);
            this.dataList.TabIndex = 1;
            this.dataList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataList_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Code";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // productId
            // 
            this.productId.DataPropertyName = "productId";
            this.productId.HeaderText = "Codigo producto";
            this.productId.MinimumWidth = 6;
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Código de referencia";
            this.ProductCode.MinimumWidth = 6;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Nombre";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "Precio";
            this.SalePrice.MinimumWidth = 6;
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Cantidad";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // SaleId
            // 
            this.SaleId.DataPropertyName = "SaleId";
            this.SaleId.HeaderText = "codigo venta";
            this.SaleId.MinimumWidth = 6;
            this.SaleId.Name = "SaleId";
            this.SaleId.ReadOnly = true;
            // 
            // InvoiceCode
            // 
            this.InvoiceCode.DataPropertyName = "InvoiceCode";
            this.InvoiceCode.HeaderText = "Nro factura";
            this.InvoiceCode.MinimumWidth = 6;
            this.InvoiceCode.Name = "InvoiceCode";
            this.InvoiceCode.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblStatus);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.btnpay);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtreadcode);
            this.groupBox5.Location = new System.Drawing.Point(12, 690);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1755, 99);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(1097, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(367, 65);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo de venta";
            // 
            // btnpay
            // 
            this.btnpay.ImageKey = "(none)";
            this.btnpay.Location = new System.Drawing.Point(1479, 21);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(261, 64);
            this.btnpay.TabIndex = 5;
            this.btnpay.Text = "Cobrar";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(852, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total a cobrar";
            // 
            // txtreadcode
            // 
            this.txtreadcode.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtreadcode.Location = new System.Drawing.Point(286, 24);
            this.txtreadcode.Multiline = true;
            this.txtreadcode.Name = "txtreadcode";
            this.txtreadcode.Size = new System.Drawing.Size(560, 65);
            this.txtreadcode.TabIndex = 1;
            this.txtreadcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtreadcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // productqquantity
            // 
            this.productqquantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productqquantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productqquantity.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productqquantity.Location = new System.Drawing.Point(1344, 60);
            this.productqquantity.Name = "productqquantity";
            this.productqquantity.Size = new System.Drawing.Size(367, 56);
            this.productqquantity.TabIndex = 9;
            this.productqquantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1338, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad de productos";
            // 
            // nrofact
            // 
            this.nrofact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nrofact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nrofact.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nrofact.Location = new System.Drawing.Point(18, 60);
            this.nrofact.Name = "nrofact";
            this.nrofact.Size = new System.Drawing.Size(367, 56);
            this.nrofact.TabIndex = 11;
            this.nrofact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 45);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nro factura";
            // 
            // txtcajeroname
            // 
            this.txtcajeroname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtcajeroname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtcajeroname.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtcajeroname.Location = new System.Drawing.Point(681, 60);
            this.txtcajeroname.Name = "txtcajeroname";
            this.txtcajeroname.Size = new System.Drawing.Size(367, 56);
            this.txtcajeroname.TabIndex = 13;
            this.txtcajeroname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(696, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 45);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cajero(a)";
            // 
            // frmsale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1773, 796);
            this.Controls.Add(this.txtcajeroname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nrofact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productqquantity);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmsale";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmsale_FormClosing);
            this.Load += new System.EventHandler(this.frmsale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtreadcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label productqquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nrofact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtcajeroname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceCode;
    }
}