using ApplicationView.VariableSeesion;
using BusnessEntities.BE;
using BusnessEntities.Dtos;
using DataService.Iservice;
using Resolver.Enums;
using Resolver.HelperError.IExceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApplicationView.Forms.Sale
{
    public partial class frmsale : Form
    {
        private readonly IProductService _repoProduct;
        private readonly ISaleService _repo;
        private readonly ISaleDetailService _repoSaleDetail;
        private readonly IIncreasePriceAfterTwelveService _repoIncrease;
        private readonly IAccountService _repoAccount;
        decimal price = 0;
        int count = 0;
        String saleId = "";
        public frmsale(IProductService repoProduct, ISaleService repo, ISaleDetailService repoSaleDetail, IIncreasePriceAfterTwelveService repoIncrease,
            IAccountService repoAccount)
        {
            InitializeComponent();
            Shown += Frmsale_Shown;
            txtreadcode.Focus();
            this.txtcajeroname.Text = LoginInfo.UserName;

            _repoProduct = repoProduct;
            _repo = repo;
            _repoSaleDetail = repoSaleDetail;
            _repoIncrease = repoIncrease;
            _repoAccount = repoAccount;

            this.HideColumn();
            this.SetGrid();
            this.btnpay.Enabled = false;

        }
        private void HideColumn()
        {
            this.dataList.Columns["Id"].Visible = false;
            this.dataList.Columns["productId"].Visible = false;
            this.dataList.Columns["SaleId"].Visible = false;
            this.dataList.Columns["InvoiceCode"].Visible = false;
            
        }

        private void SetGrid()
        {
            this.dataList.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 18);

            this.dataList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dataList.EnableHeadersVisualStyles = false;

            DataGridViewCellStyle column_header_cell_style = new DataGridViewCellStyle();
            column_header_cell_style.BackColor = ColorTranslator.FromHtml("#bfdbff");
            column_header_cell_style.ForeColor = Color.Black;
            //column_header_cell_style.SelectionBackColor = Color.Chocolate;
            column_header_cell_style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            column_header_cell_style.Font = new Font("#bfdbff", 22, FontStyle.Bold);
            this.dataList.ColumnHeadersDefaultCellStyle = column_header_cell_style;
        }
        private void Frmsale_Shown(object sender, EventArgs e)
        {
            txtreadcode.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }

            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                return;
            }
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    var result = _repoProduct.SearchProducByCode(txtreadcode.Text.Trim());
                    if (result != null)
                    {
                        var incr = _repoIncrease.GetAll(1, 1, 12, "Id", "asc", DateTime.Now, DateTime.Now, LoginInfo.IdBusiness, ref count);
                        if (incr.Count > 0){
                            if (IsWithinTime(DateTime.Now.ToLongTimeString(), incr[0].HourFrom.ToLongTimeString(), incr[0].HourTo.ToLongTimeString(), incr[0].IsActive))
                                result.SalePrice = result.SalePrice*(1 + (incr[0].Porcent/100));
                        }
                    }
                   
                    //string IdSale = "";
                    if (dataList.Rows.Count == 0)
                    {
                        var be = new SaleBE()
                        {
                            AccountId = LoginInfo.IdAccount,
                            CreatedDate = DateTime.Now,
                            PaymentTypeId = "f5f737fd-860c-485b-972a-927d385f4ab5",
                            finalizeSale = false,
                            Total = 0,
                            state = (Int32)StateEnum.Activeted,
                            SaleDetail = new List<SaleDetailBE>()
                            {
                                new SaleDetailBE()
                                {
                                    state = (Int32)StateEnum.Activeted,
                                    CreatedDate = DateTime.Now,
                                    price =  result.SalePrice,
                                    productId = result.Id,
                                    quantity = 1
                                }
                            }
                        };

                        this.saleId = _repo.Create(be);
                    }
                    else
                    {
                        var saleid = (SaleDetailDto)dataList.Rows[0].DataBoundItem;
                        var be = new SaleDetailBE()
                        {
                            state = (Int32)StateEnum.Activeted,
                            CreatedDate = DateTime.Now,
                            price =  result.SalePrice,
                            productId = result.Id,
                            quantity = 1,
                            SaleId = saleid.SaleId
                        };
                        this.saleId = _repoSaleDetail.Create(be);
                    }
                    var response = _repoSaleDetail.SearchAllDetailByCode(this.saleId);
                    txtreadcode.Text = String.Empty;
                    txtreadcode.Focus();
                    price = price + result.SalePrice;

                    if (response != null)
                        this.dataList.DataSource = response;
                    this.productqquantity.Text = ((!string.IsNullOrEmpty(this.productqquantity.Text) ? Convert.ToInt32(this.productqquantity.Text) : 0) + 1).ToString();
                    this.lblStatus.Text = price.ToString();
                    this.InvoiceCodeFormat(response[0].InvoiceCode);

                    this.dataList.FirstDisplayedScrollingRowIndex = (this.dataList.Rows.Count - 1);
                    if (this.dataList.Rows.Count > 0)
                    {
                        this.HideColumn();
                        this.SetGrid();
                        this.btnpay.Enabled = true;
                    }
                    this.dataList.ClearSelection();
                    this.dataList.CurrentCell = null;
                }
            }
            catch (ApiBusinessException ex)
            {
                txtreadcode.Text = String.Empty;
                MessageBox.Show(ex.MessageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InvoiceCodeFormat(Int64 InvoiceCode)
        {
            string fmt = "000-0000-00000";
            this.nrofact.Text = InvoiceCode.ToString(fmt);
        }
        public bool IsWithinTime(string stringNowTime, string stringStartTime, string stringEndTime, bool isActive)
        {

            var nowTime = DateTime.Parse(stringNowTime);
            var startTime = DateTime.Parse(stringStartTime);
            var endTime = DateTime.Parse(stringEndTime);

            if ((nowTime <= endTime) && (nowTime >= startTime) && isActive)
            {
                return true;
            }

            return false;
        }
        private void frmsale_Load(object sender, EventArgs e)
        {
            txtreadcode.Focus();
        }
            
        private void btnpay_Click(object sender, EventArgs e)
        {
            frmclosepay frm = new frmclosepay(_repo, this.lblStatus.Text, this.saleId);
            frm.ShowDialog();
            if (frm.iscorrectSale)
            {
                this.dataList.DataSource = new List<SaleDetailDto>();
                this.lblStatus.Text = "";
                this.productqquantity.Text = "";
                this.nrofact.Text = "";
                this.txtreadcode.Focus();
            }
        }

        private void dataList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = this.dataList.SelectedRows[0];
            var sale = (SaleDetailDto)selectedRow.DataBoundItem;
            frmautorizedeleteproductsale frm = new frmautorizedeleteproductsale(_repoAccount, sale.Id, _repo);
            frm.ShowDialog();
            if (frm.isdeleteAdmin)
            {
                var response = _repoSaleDetail.SearchAllDetailByCode(this.saleId);
                txtreadcode.Text = String.Empty;
                txtreadcode.Focus();
                price = price - sale.SalePrice;

                if (response != null)
                    this.dataList.DataSource = response;
                if (response.Count > 0)
                {
                    this.productqquantity.Text = Convert.ToInt32(dataList.RowCount).ToString();
                    this.lblStatus.Text = price.ToString();
                    this.InvoiceCodeFormat(response[0].InvoiceCode);
                }
                else
                {
                    this.productqquantity.Text = "";
                    this.lblStatus.Text = "";
                    this.nrofact.Text = "";
                }
                
            }
        }

        private void frmsale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.saleId.Equals(""))
            {
                var statesale = _repo.GetById(this.saleId);
                if (statesale != null)
                {
                    if (!statesale.finalizeSale)
                    {
                        Application.EnableVisualStyles();
                        var result = MessageBox.Show("Esta venta esta abierta sin cobrar,se eliminar la venta al confirmarla.\n Esta seguro que desees salir la venta?", "Sistema de ventas",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            _repo.RemoveNoneSale(this.saleId, LoginInfo.IdAccount, DeleteSaleEnum.CloseScreen);
                            this.Close();
                        }
                        else
                            e.Cancel = true;
                    }
                }
            }
        }
    }
}
