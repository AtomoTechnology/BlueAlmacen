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
            this.label5.Text = be.PurchasePrice.ToString();

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
            else
            {
                this.msg = _repo.UpdatePrices(_be.Id, LoginInfo.IdAccount, Convert.ToDecimal(this.txtsaleprice.Text), UpdatePriceEnum.ForProduct, this.chkpurchase.Checked);                
                this.IsUpdateprice = true;
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {           
        }
    }
}
