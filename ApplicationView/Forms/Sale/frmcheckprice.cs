using DataService.Iservice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApplicationView.Forms.Sale
{
    public partial class frmcheckprice : Form
    {
        private readonly IProductService _repo;
        public frmcheckprice(IProductService repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void txtproductcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var result = _repo.SearchProducByCode(txtproductcode.Text.Trim(), true);
                this.label4.Text = result?.ProductName;
                this.label5.Text = result?.SalePrice.ToString();
                this.label6.Text = result?.Stock.ToString();

                this.txtproductcode.Text = String.Empty;
                this.txtproductcode.Focus();
            }
        }
    }
}
