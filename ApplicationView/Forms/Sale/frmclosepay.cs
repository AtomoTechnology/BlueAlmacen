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

namespace ApplicationView.Forms.Sale
{
    public partial class frmclosepay : Form
    {
        private readonly ISaleService _repo;
        private readonly String _SaleId;

        public Boolean iscorrectSale = false;
        public frmclosepay(ISaleService repo, string total, String SaleId)
        {
            InitializeComponent();
            _repo = repo;
            this.label7.Text = total; 
            _SaleId = SaleId;

            this.label3.Text = "0";
            this.cbtypePay.SelectedIndex = -1;
            this.cbtypePay.Text = "Seleccione metodo de pago";
        }

        private void LoadList()
        {
            this.cbtypePay.DisplayMember = "PaymentName";
            this.cbtypePay.ValueMember = "Id";
            this.cbtypePay.DataSource = _repo.GetAllPaymentType(1);      
        }

        private void frmclosepay_Load(object sender, EventArgs e)
        {
            this.LoadList();

            this.cbtypePay.SelectedIndex = -1;
            this.cbtypePay.Text = "Seleccione metodo de pago";
        }

        private void txtrol_TextChanged(object sender, EventArgs e)
        {
            if (!this.txtreceive.Text.Equals(""))
            {
                if (Convert.ToDecimal(this.label7.Text) <= Convert.ToDecimal(this.txtreceive.Text))
                    label3.Text = "-" + " " + (Convert.ToDecimal(this.txtreceive.Text) - Convert.ToDecimal(this.label7.Text)).ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbtypePay.Text.ToLower().Equals("Efectivo".ToLower()))
                {
                    if (this.txtreceive.Text.Equals(""))
                    {
                        MessageBox.Show("Ingreso el total recibido", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (cbtypePay.SelectedItem == null || cbtypePay.SelectedItem.Equals("Seleccione metodo de pago"))
                {
                    MessageBox.Show("Debe seleccionar el metodo de pago", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var be = new SaleBE()
                {
                    AccountId = LoginInfo.IdAccount,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    PaymentTypeId = cbtypePay.SelectedValue.ToString(),
                    finalizeSale = true,
                    Total = Convert.ToDecimal(this.label7.Text),
                    state = (Int32)SaleEnum.PayFinished
                };

                _repo.Update(_SaleId, be);
                this.iscorrectSale = true;
                this.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void cbtypePay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtypePay.Text.ToLower().Equals("Efectivo".ToLower()))
            {
                this.txtreceive.Visible = true;
                label2.Visible = true;
            }
            else
            {
                this.txtreceive.Visible = false;
                label2.Visible = false;
                this.label3.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbtypePay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
