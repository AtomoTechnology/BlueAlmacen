namespace ApplicationView.Forms.Sale
{
    partial class frmautorizedeleteproductsale
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnacept = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtuserpass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnacept);
            this.groupBox2.Controls.Add(this.btncancel);
            this.groupBox2.Location = new System.Drawing.Point(351, 147);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 74);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnacept
            // 
            this.btnacept.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnacept.BackgroundImage = global::ApplicationView.Properties.Resources.images__6_;
            this.btnacept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnacept.Location = new System.Drawing.Point(5, 11);
            this.btnacept.Margin = new System.Windows.Forms.Padding(4);
            this.btnacept.Name = "btnacept";
            this.btnacept.Size = new System.Drawing.Size(100, 62);
            this.btnacept.TabIndex = 3;
            this.btnacept.Text = "Aceptar";
            this.btnacept.UseVisualStyleBackColor = false;
            this.btnacept.Click += new System.EventHandler(this.btnacept_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncancel.BackgroundImage = global::ApplicationView.Properties.Resources.images__20_;
            this.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancel.Location = new System.Drawing.Point(111, 11);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 60);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtuserpass);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(150, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso administrador";
            // 
            // txtuserpass
            // 
            this.txtuserpass.Location = new System.Drawing.Point(143, 87);
            this.txtuserpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtuserpass.Name = "txtuserpass";
            this.txtuserpass.PasswordChar = '*';
            this.txtuserpass.Size = new System.Drawing.Size(265, 27);
            this.txtuserpass.TabIndex = 3;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(143, 47);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(265, 27);
            this.txtusername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplicationView.Properties.Resources.Vista__35_;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 132);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmautorizedeleteproductsale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(572, 223);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmautorizedeleteproductsale";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorizacion para eliminar venta";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnacept;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtuserpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox pictureBox1;
    }
}