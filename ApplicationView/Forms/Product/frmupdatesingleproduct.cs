using ApplicationView.VariableSeesion;
using BusnessEntities.BE;
using DataService.Iservice;
using Resolver.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApplicationView.Forms.Product
{
    public partial class frmupdatesingleproduct : Form
    {
        private readonly IProductService _repo;
        ProductBE _be;
        public Boolean IsUpdateprice = false;
        public string msg = string.Empty;
        public frmupdatesingleproduct(IProductService repo,ProductBE be)
        {
            InitializeComponent();
            _repo = repo;
            _be = be;

            this.label3.Text = be.ProductName;
            this.lblTotal.Text = be.SalePrice.ToString();
            this.txtpurchaseprice.Text = be.PurchasePrice.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtsaleprice.Text))
            {
                MessageBox.Show("Debe ingresar el porcentaje de aumento de precio de venta para ese producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsaleprice.Text = String.Empty;
                txtsaleprice.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtpurchaseprice.Text) && this.chkpurchase.Checked)
            {
                MessageBox.Show("Debe ingresar el porcentaje de aumento de precio de compra para ese producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpurchaseprice.Text = String.Empty;
                txtpurchaseprice.Focus();
            }
            else
            {
                decimal purchase = !string.IsNullOrEmpty(txtpurchaseprice.Text) ? Convert.ToDecimal(txtpurchaseprice.Text) : 0;
                this.msg = _repo.UpdatePrices(_be.Id, LoginInfo.IdAccount, Convert.ToDecimal(this.txtsaleprice.Text), purchase, UpdatePriceEnum.ForProduct, this.chkpurchase.Checked);                
                this.IsUpdateprice = true;
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpurchase.Checked)
            {
                this.txtpurchaseprice.Enabled = true;
                this.txtpurchaseprice.BackColor = SystemColors.Window;
                this.txtpurchaseprice.Text = string.Empty;
                this.label6.Text = "Porcentaje de compra";
            }
            else
            {
                this.txtpurchaseprice.Enabled = false;
                this.txtpurchaseprice.BackColor = SystemColors.MenuBar;
                this.txtpurchaseprice.Text = _be.PurchasePrice.ToString();
                this.label6.Text = "Precio de  compra actual";
            }
        }
    }
}
