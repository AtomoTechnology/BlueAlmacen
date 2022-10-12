using ApplicationView.Share;
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
    public partial class frmupdateprice : Form
    {
        private readonly IProductService _repo;
        int count = 0;
        public frmupdateprice(IProductService repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void cboptionupdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboptionupdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboptionupdate.Text.ToLower().Equals("Seleccionar opcion de actualizacion".ToLower()))
            {
                this.groupBox2.Visible = false;
                this.btnsave.Visible = false;
                this.btncancel.Visible = false;
                label2.Visible = false;
                this.txtporcent.Visible = false;
                this.Height = 170;
            }
            else if (cboptionupdate.Text.ToLower().Equals("Todos".ToLower()))
            {
                this.groupBox2.Visible = false;
                this.btnsave.Visible = true;
                this.btncancel.Visible = true;
                label2.Visible = true;
                this.txtporcent.Visible = true;
                this.Height = 170;
            }
            else
            {
                this.groupBox2.Visible = true;
                this.btnsave.Visible = false;
                this.btncancel.Visible = false;
                label2.Visible = false;
                this.txtporcent.Visible = false;
                this.Height = 709;
                this.LoadList();
            }
        }

        private void frmupdateprice_Load(object sender, EventArgs e)
        {
            if (cboptionupdate.Text.ToLower().Equals("Seleccionar opcion de actualizacion".ToLower()))
            {
                this.groupBox2.Visible = false;
                label2.Visible = false;
                this.txtporcent.Visible = false;
                this.btnsave.Visible = false;
                this.btncancel.Visible = false;
                this.Height = 170;
            }
        }

        private void LoadList()
        {
            this.dataList.DataSource = _repo.GetAll(1, 1, 12, "Id", "asc", "", ref count);
            this.HideColumn();
            this.GetPagination();
        }

        private void HideColumn()
        {
            this.dataList.Columns["Stock"].Visible = false;
            this.dataList.Columns["FinalDate"].Visible = false;
            this.dataList.Columns["CreatedDate"].Visible = false;
            this.dataList.Columns["State"].Visible = false;
            this.dataList.Columns["Account"].Visible = false;
            this.dataList.Columns["AccountId"].Visible = false;
            this.dataList.Columns["Categories"].Visible = false;
            this.dataList.Columns["CategoryId"].Visible = false;
            this.dataList.Columns["ProductCode"].Visible = false; 
            this.dataList.Columns["Description"].Visible = false;
            this.dataList.Columns["ModifiedDate"].Visible = false;
            this.dataList.Columns["ProviderId"].Visible = false;
        }


        private void GetPagination()
        {
            if (count > 0)
            {
                LoginInfo.pageamount = count;
                LoginInfo.page = Math.Ceiling(LoginInfo.pageamount / LoginInfo.pagesize);

                this.lblStatus.Text = (LoginInfo.skipamount).ToString() + " / " + LoginInfo.page.ToString();
                this.lblTotal.Text = LoginInfo.pageamount.ToString();

                if (Convert.ToInt32(LoginInfo.skipamount) < Convert.ToInt32(LoginInfo.page))
                {
                    ShareMethod.GetInstance().HabilitarBtnPagination(new List<Button> { btnNext, btnLast }, true);
                }
                else
                {
                    ShareMethod.GetInstance().HabilitarBtnPagination(new List<Button> { btnNext, btnLast }, false);
                }

                if (LoginInfo.skipamount > 1)
                {
                    ShareMethod.GetInstance().HabilitarBtnPagination(new List<Button> { btnPrevious, btnFirst }, true);
                }
                else
                {
                    ShareMethod.GetInstance().HabilitarBtnPagination(new List<Button> { btnPrevious, btnFirst }, false);
                }
            }
            else
            {
                this.lblStatus.Text = (0 + " / " + 0);
                this.lblTotal.Text = (0).ToString();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            ShareMethod.GetInstance().goFirst();
            LoadList();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ShareMethod.GetInstance().goPrevious();
            LoadList();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            ShareMethod.GetInstance().goNext();
            LoadList();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            ShareMethod.GetInstance().goLast(this.count);
            LoadList();
        }

        private void dataList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Application.EnableVisualStyles();
            var result = MessageBox.Show("Esta seguro que desees actualizar el precio de ese producto?", "Sistema de ventas",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var selectedRow = this.dataList.SelectedRows[0];
                var product = (ProductBE)selectedRow.DataBoundItem;
                frmupdatesingleproduct frm = new frmupdatesingleproduct(_repo, product);
                frm.ShowDialog();
                if (frm.IsUpdateprice)
                {
                    var updateprice = MessageBox.Show(frm.msg, "Sistema de ventas",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (updateprice == DialogResult.No)
                        this.Close();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtporcent.Text))
            {
                MessageBox.Show("Debe ingresar el porcentaje de aumento de precio de venta para ese producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtporcent.Text = String.Empty;
                txtporcent.Focus();
            }
            else
            {
                string msg = _repo.UpdatePrices("", LoginInfo.IdAccount, Convert.ToDecimal(this.txtporcent.Text), UpdatePriceEnum.All);
                MessageBox.Show(msg, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
