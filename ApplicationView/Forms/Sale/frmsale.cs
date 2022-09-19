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
        decimal price = 0;
        public frmsale(IProductService repoProduct, ISaleService repo, ISaleDetailService repoSaleDetail)
        {
            InitializeComponent();
            Shown += Frmsale_Shown;
            txtreadcode.Focus();
            _repoProduct = repoProduct;
            _repo = repo;
            _repoSaleDetail = repoSaleDetail; 
            this.HideColumn();
            this.SetGrid();

        }
        private void HideColumn()
        {
            this.dataList.Columns["Id"].Visible = false;
            this.dataList.Columns["productId"].Visible = false;
            this.dataList.Columns["SaleId"].Visible = false;
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
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    var result = _repoProduct.SearchProducByCode(txtreadcode.Text.Trim());

                   
                    string IdSale = "";
                    if (dataList.Rows.Count == 0)
                    {
                            var be = new SaleBE()
                            {
                                AccountId = LoginInfo.IdAccount,
                                CreatedDate = DateTime.Now,
                                PaymentTypeId = "b8308592-5de6-49fa-a024-d017f27370e7",
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

                        IdSale = _repo.Create(be);
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
                        IdSale = _repoSaleDetail.Create(be);
                    }
                    var response = _repoSaleDetail.SearchAllDetailByCode(IdSale);
                    txtreadcode.Text = String.Empty;
                    txtreadcode.Focus();
                    price = price + result.SalePrice;

                    if (response != null)
                        this.dataList.DataSource = response;
                    this.productqquantity.Text = ((!string.IsNullOrEmpty(this.productqquantity.Text) ? Convert.ToInt32(this.productqquantity.Text) : 0) + 1).ToString();
                    this.lblStatus.Text = price.ToString();


                    this.dataList.FirstDisplayedScrollingRowIndex = (this.dataList.Rows.Count - 1);
                    this.dataList.ClearSelection();
                    this.dataList.CurrentCell = null;
                }
            }
            catch (ApiBusinessException ex)
            {
                MessageBox.Show(ex.MessageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmsale_Load(object sender, EventArgs e)
        {
            txtreadcode.Focus();
        }
    }
}
