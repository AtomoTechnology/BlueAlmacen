namespace ApplicationView.Forms.Configurations
{
    partial class frmIncreasePriceAfterTwelve
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
            this.btndelete = new System.Windows.Forms.Button();
            this.dataList = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbisactive = new System.Windows.Forms.CheckBox();
            this.txtporcent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ckdelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 303);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.btndelete);
            this.tabPage1.Controls.Add(this.dataList);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(32, 19);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(85, 24);
            this.chkEliminar.TabIndex = 6;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(158, 14);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(171, 29);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
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
            this.HourFrom,
            this.HourTo});
            this.dataList.Location = new System.Drawing.Point(6, 49);
            this.dataList.MultiSelect = false;
            this.dataList.Name = "dataList";
            this.dataList.ReadOnly = true;
            this.dataList.RowHeadersWidth = 51;
            this.dataList.RowTemplate.Height = 29;
            this.dataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataList.Size = new System.Drawing.Size(944, 198);
            this.dataList.TabIndex = 0;
            this.dataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataList_CellContentClick);
            this.dataList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataList_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(956, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbisactive);
            this.groupBox1.Controls.Add(this.txtporcent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpto);
            this.groupBox1.Controls.Add(this.dtpfrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chbisactive
            // 
            this.chbisactive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbisactive.Location = new System.Drawing.Point(540, 121);
            this.chbisactive.Name = "chbisactive";
            this.chbisactive.Size = new System.Drawing.Size(148, 30);
            this.chbisactive.TabIndex = 16;
            this.chbisactive.Text = "Activado";
            this.chbisactive.UseVisualStyleBackColor = true;
            // 
            // txtporcent
            // 
            this.txtporcent.Location = new System.Drawing.Point(258, 115);
            this.txtporcent.Name = "txtporcent";
            this.txtporcent.Size = new System.Drawing.Size(161, 27);
            this.txtporcent.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Porcentaje del aumento";
            // 
            // dtpto
            // 
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpto.Location = new System.Drawing.Point(675, 78);
            this.dtpto.Name = "dtpto";
            this.dtpto.ShowUpDown = true;
            this.dtpto.Size = new System.Drawing.Size(250, 27);
            this.dtpto.TabIndex = 12;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpfrom.Location = new System.Drawing.Point(258, 78);
            this.dtpfrom.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.ShowUpDown = true;
            this.dtpfrom.Size = new System.Drawing.Size(250, 27);
            this.dtpfrom.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hora Hasta";
            // 
            // txtcode
            // 
            this.txtcode.Enabled = false;
            this.txtcode.Location = new System.Drawing.Point(258, 40);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(580, 27);
            this.txtcode.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Codigo";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(764, 188);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(151, 29);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(597, 188);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(151, 29);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(430, 188);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(151, 29);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(263, 188);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(151, 29);
            this.btnnew.TabIndex = 4;
            this.btnnew.Text = "Nuevo";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hora desde";
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
            // HourFrom
            // 
            this.HourFrom.DataPropertyName = "HourFrom";
            this.HourFrom.HeaderText = "Fecha desde";
            this.HourFrom.MinimumWidth = 6;
            this.HourFrom.Name = "HourFrom";
            this.HourFrom.ReadOnly = true;
            // 
            // HourTo
            // 
            this.HourTo.DataPropertyName = "HourTo";
            this.HourTo.HeaderText = "Fecha hasta";
            this.HourTo.MinimumWidth = 6;
            this.HourTo.Name = "HourTo";
            this.HourTo.ReadOnly = true;
            // 
            // frmIncreasePriceAfterTwelve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 319);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmIncreasePriceAfterTwelve";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantemiento de actualizacion de precio despues de las 12 de la noche";
            this.Load += new System.EventHandler(this.frmIncreasePriceAfterTwelve_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbisactive;
        private System.Windows.Forms.TextBox txtporcent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ckdelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourTo;
    }
}