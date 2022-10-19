namespace ApplicationView.Forms.Product
{
    partial class frmProduct
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataList = new System.Windows.Forms.DataGridView();
            this.ckdelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtlot = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtTP = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtprovproductId = new System.Windows.Forms.TextBox();
            this.txtcatproductId = new System.Windows.Forms.TextBox();
            this.btnprovider = new System.Windows.Forms.Button();
            this.btncategory = new System.Windows.Forms.Button();
            this.txtproviderproduct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcategoryproduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtproductcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1274, 688);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.btnprint);
            this.tabPage1.Controls.Add(this.btndelete);
            this.tabPage1.Controls.Add(this.btnsearch);
            this.tabPage1.Controls.Add(this.txtsearch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataList);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1266, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(27, 63);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(85, 24);
            this.chkEliminar.TabIndex = 6;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(852, 19);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(171, 27);
            this.btnprint.TabIndex = 5;
            this.btnprint.Text = "Imprimir";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Visible = false;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(672, 19);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(171, 27);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(492, 19);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(171, 27);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Buscar";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(142, 19);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(344, 27);
            this.txtsearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // dataList
            // 
            this.dataList.AllowUserToAddRows = false;
            this.dataList.AllowUserToDeleteRows = false;
            this.dataList.AllowUserToOrderColumns = true;
            this.dataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ckdelete,
            this.Codigo,
            this.ProductName,
            this.ProductCode,
            this.PurchasePrice,
            this.SalePrice});
            this.dataList.Location = new System.Drawing.Point(6, 90);
            this.dataList.MultiSelect = false;
            this.dataList.Name = "dataList";
            this.dataList.ReadOnly = true;
            this.dataList.RowHeadersWidth = 51;
            this.dataList.RowTemplate.Height = 29;
            this.dataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataList.Size = new System.Drawing.Size(1254, 522);
            this.dataList.TabIndex = 0;
            this.dataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataList_CellContentClick);
            this.dataList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataList_CellDoubleClick);
            // 
            // ckdelete
            // 
            this.ckdelete.HeaderText = "Eliminar";
            this.ckdelete.MinimumWidth = 6;
            this.ckdelete.Name = "ckdelete";
            this.ckdelete.ReadOnly = true;
            this.ckdelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ckdelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Id";
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Nombre";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Codigo de referencia";
            this.ProductCode.MinimumWidth = 6;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.HeaderText = "Precio de Compra";
            this.PurchasePrice.MinimumWidth = 6;
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "Precio de venta";
            this.SalePrice.MinimumWidth = 6;
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 655);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1254, 683);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtlot);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtstock);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtTP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtprovproductId);
            this.groupBox2.Controls.Add(this.txtcatproductId);
            this.groupBox2.Controls.Add(this.btnprovider);
            this.groupBox2.Controls.Add(this.btncategory);
            this.groupBox2.Controls.Add(this.txtproviderproduct);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtcategoryproduct);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtdescription);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSalePrice);
            this.groupBox2.Controls.Add(this.txtproductcode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPurchasePrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtcode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtproductname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1233, 496);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del producto";
            // 
            // txtlot
            // 
            this.txtlot.Location = new System.Drawing.Point(770, 62);
            this.txtlot.MaxLength = 100;
            this.txtlot.Name = "txtlot";
            this.txtlot.Size = new System.Drawing.Size(389, 27);
            this.txtlot.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(700, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Lote";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(765, 99);
            this.txtstock.MaxLength = 20;
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(318, 27);
            this.txtstock.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(603, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Cantidad de producto";
            // 
            // dtTP
            // 
            this.dtTP.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTP.Location = new System.Drawing.Point(179, 132);
            this.dtTP.Name = "dtTP";
            this.dtTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtTP.RightToLeftLayout = true;
            this.dtTP.Size = new System.Drawing.Size(345, 27);
            this.dtTP.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Fecha de vencimiento";
            // 
            // txtprovproductId
            // 
            this.txtprovproductId.Location = new System.Drawing.Point(796, 201);
            this.txtprovproductId.MaxLength = 20;
            this.txtprovproductId.Name = "txtprovproductId";
            this.txtprovproductId.Size = new System.Drawing.Size(318, 27);
            this.txtprovproductId.TabIndex = 32;
            this.txtprovproductId.Visible = false;
            // 
            // txtcatproductId
            // 
            this.txtcatproductId.Location = new System.Drawing.Point(796, 168);
            this.txtcatproductId.MaxLength = 20;
            this.txtcatproductId.Name = "txtcatproductId";
            this.txtcatproductId.Size = new System.Drawing.Size(318, 27);
            this.txtcatproductId.TabIndex = 31;
            this.txtcatproductId.Visible = false;
            // 
            // btnprovider
            // 
            this.btnprovider.Location = new System.Drawing.Point(646, 201);
            this.btnprovider.Name = "btnprovider";
            this.btnprovider.Size = new System.Drawing.Size(48, 29);
            this.btnprovider.TabIndex = 17;
            this.btnprovider.Text = ".....";
            this.btnprovider.UseVisualStyleBackColor = true;
            this.btnprovider.Click += new System.EventHandler(this.btnprovider_Click);
            // 
            // btncategory
            // 
            this.btncategory.Location = new System.Drawing.Point(646, 168);
            this.btncategory.Name = "btncategory";
            this.btncategory.Size = new System.Drawing.Size(48, 29);
            this.btncategory.TabIndex = 16;
            this.btncategory.Text = ".....";
            this.btncategory.UseVisualStyleBackColor = true;
            this.btncategory.Click += new System.EventHandler(this.btncategory_Click);
            // 
            // txtproviderproduct
            // 
            this.txtproviderproduct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtproviderproduct.Enabled = false;
            this.txtproviderproduct.Location = new System.Drawing.Point(179, 202);
            this.txtproviderproduct.MaxLength = 20;
            this.txtproviderproduct.Name = "txtproviderproduct";
            this.txtproviderproduct.ReadOnly = true;
            this.txtproviderproduct.Size = new System.Drawing.Size(464, 27);
            this.txtproviderproduct.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Proveedor";
            // 
            // txtcategoryproduct
            // 
            this.txtcategoryproduct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtcategoryproduct.Enabled = false;
            this.txtcategoryproduct.Location = new System.Drawing.Point(179, 169);
            this.txtcategoryproduct.MaxLength = 20;
            this.txtcategoryproduct.Name = "txtcategoryproduct";
            this.txtcategoryproduct.ReadOnly = true;
            this.txtcategoryproduct.Size = new System.Drawing.Size(464, 27);
            this.txtcategoryproduct.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Categoria";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(179, 313);
            this.txtdescription.MaxLength = 20;
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(843, 153);
            this.txtdescription.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Descripcion";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(179, 279);
            this.txtSalePrice.MaxLength = 20;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(401, 27);
            this.txtSalePrice.TabIndex = 24;
            // 
            // txtproductcode
            // 
            this.txtproductcode.Location = new System.Drawing.Point(179, 97);
            this.txtproductcode.MaxLength = 20;
            this.txtproductcode.Name = "txtproductcode";
            this.txtproductcode.Size = new System.Drawing.Size(318, 27);
            this.txtproductcode.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Codigo del producto";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(179, 241);
            this.txtPurchasePrice.MaxLength = 250;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(680, 27);
            this.txtPurchasePrice.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Precio de compra";
            // 
            // txtcode
            // 
            this.txtcode.Enabled = false;
            this.txtcode.Location = new System.Drawing.Point(179, 29);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(580, 27);
            this.txtcode.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Codigo";
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(179, 62);
            this.txtproductname.MaxLength = 100;
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(503, 27);
            this.txtproductname.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio de venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(1099, 591);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(151, 29);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(932, 591);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(151, 29);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(765, 591);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(151, 29);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(598, 591);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(151, 29);
            this.btnnew.TabIndex = 4;
            this.btnnew.Text = "Nuevo";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.lblTotal);
            this.groupBox5.Controls.Add(this.lblStatus);
            this.groupBox5.Controls.Add(this.btnNext);
            this.groupBox5.Controls.Add(this.btnLast);
            this.groupBox5.Controls.Add(this.btnPrevious);
            this.groupBox5.Controls.Add(this.btnFirst);
            this.groupBox5.Location = new System.Drawing.Point(572, 698);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(705, 63);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(381, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 28);
            this.label12.TabIndex = 8;
            this.label12.Text = " Cantidad de registros";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(547, 23);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(137, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Location = new System.Drawing.Point(76, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(171, 26);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "0 / 0";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(256, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 28);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(288, 19);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(32, 28);
            this.btnLast.TabIndex = 2;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(43, 18);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(32, 28);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(11, 18);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(32, 28);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 768);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantemiento de Productos";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtproductcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ckdelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnprovider;
        private System.Windows.Forms.Button btncategory;
        private System.Windows.Forms.TextBox txtproviderproduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcategoryproduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprovproductId;
        private System.Windows.Forms.TextBox txtcatproductId;
        private System.Windows.Forms.DateTimePicker dtTP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtlot;
        private System.Windows.Forms.Label label13;
    }
}