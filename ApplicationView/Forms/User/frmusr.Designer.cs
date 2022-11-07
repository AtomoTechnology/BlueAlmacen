namespace ApplicationView.Forms.User
{
    partial class frmusr
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataList = new System.Windows.Forms.DataGridView();
            this.ckdelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnselectplan = new System.Windows.Forms.Button();
            this.txtroleid = new System.Windows.Forms.TextBox();
            this.txtrolename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1274, 625);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
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
            this.tabPage1.Size = new System.Drawing.Size(1266, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.groupBox5.Location = new System.Drawing.Point(555, 515);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(705, 63);
            this.groupBox5.TabIndex = 8;
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
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(288, 19);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(32, 28);
            this.btnLast.TabIndex = 2;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(43, 18);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(32, 28);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(11, 18);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(32, 28);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(24, 60);
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
            this.label1.Location = new System.Drawing.Point(24, 25);
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
            this.FirstName,
            this.LastName,
            this.Address,
            this.Phone});
            this.dataList.Location = new System.Drawing.Point(6, 90);
            this.dataList.MultiSelect = false;
            this.dataList.Name = "dataList";
            this.dataList.ReadOnly = true;
            this.dataList.RowHeadersWidth = 51;
            this.dataList.RowTemplate.Height = 29;
            this.dataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataList.Size = new System.Drawing.Size(1254, 419);
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
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Nombre";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Apellido";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Dirección";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Telefono";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Location = new System.Drawing.Point(6, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1254, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnselectplan);
            this.groupBox4.Controls.Add(this.txtroleid);
            this.groupBox4.Controls.Add(this.txtrolename);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtusername);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtpassword);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(6, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1233, 165);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del usuario";
            // 
            // btnselectplan
            // 
            this.btnselectplan.Location = new System.Drawing.Point(608, 71);
            this.btnselectplan.Name = "btnselectplan";
            this.btnselectplan.Size = new System.Drawing.Size(61, 29);
            this.btnselectplan.TabIndex = 6;
            this.btnselectplan.Text = "......";
            this.btnselectplan.UseVisualStyleBackColor = true;
            this.btnselectplan.Click += new System.EventHandler(this.btnselectplan_Click);
            // 
            // txtroleid
            // 
            this.txtroleid.Location = new System.Drawing.Point(1065, 71);
            this.txtroleid.MaxLength = 50;
            this.txtroleid.Name = "txtroleid";
            this.txtroleid.PasswordChar = '*';
            this.txtroleid.Size = new System.Drawing.Size(136, 27);
            this.txtroleid.TabIndex = 22;
            this.txtroleid.Visible = false;
            // 
            // txtrolename
            // 
            this.txtrolename.Enabled = false;
            this.txtrolename.Location = new System.Drawing.Point(179, 71);
            this.txtrolename.MaxLength = 50;
            this.txtrolename.Name = "txtrolename";
            this.txtrolename.ReadOnly = true;
            this.txtrolename.Size = new System.Drawing.Size(425, 27);
            this.txtrolename.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rol";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(179, 29);
            this.txtusername.MaxLength = 50;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(580, 27);
            this.txtusername.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Usuario";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(179, 104);
            this.txtpassword.MaxLength = 50;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(580, 27);
            this.txtpassword.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "Contraseña";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtcode);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtphone);
            this.groupBox3.Controls.Add(this.txtemail);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtaddress);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtfirstname);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtlastname);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(6, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1233, 258);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del administrador";
            // 
            // txtcode
            // 
            this.txtcode.Enabled = false;
            this.txtcode.Location = new System.Drawing.Point(181, 29);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(580, 27);
            this.txtcode.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Codigo";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(181, 207);
            this.txtphone.MaxLength = 15;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(401, 27);
            this.txtphone.TabIndex = 4;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(181, 136);
            this.txtemail.MaxLength = 100;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(318, 27);
            this.txtemail.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Email";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(181, 169);
            this.txtaddress.MaxLength = 250;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(680, 27);
            this.txtaddress.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Direccion";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(181, 62);
            this.txtfirstname.MaxLength = 150;
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(580, 27);
            this.txtfirstname.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nombre";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(181, 95);
            this.txtlastname.MaxLength = 150;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(580, 27);
            this.txtlastname.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Telefono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Apellido";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(1088, 461);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(151, 29);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(921, 461);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(151, 29);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(754, 461);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(151, 29);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(587, 461);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(151, 29);
            this.btnnew.TabIndex = 11;
            this.btnnew.Text = "Nuevo";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click_1);
            // 
            // frmusr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 644);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmusr";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantemiento de usuario";
            this.Load += new System.EventHandler(this.frmusr_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnselectplan;
        private System.Windows.Forms.TextBox txtroleid;
        private System.Windows.Forms.TextBox txtrolename;
        private System.Windows.Forms.Label label2;
    }
}