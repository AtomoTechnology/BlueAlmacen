using ApplicationView.Forms.Category;
using ApplicationView.Forms.Provider;
using ApplicationView.Share;
using ApplicationView.VariableSeesion;
using BusnessEntities.BE;
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

namespace ApplicationView.Forms.Product
{
    public partial class frmProduct : Form
    {
        private readonly IProductService _repo;
        private readonly ICategoryService _repoCategory;
        private readonly IProviderService _repoProvider;

        private bool Isnuevo = false;
        private bool IsEditar = false;
        int count = 0;
        public frmProduct(IProductService repo, ICategoryService repoCategory, IProviderService repoProvider)
        {
            InitializeComponent();
            _repo = repo;
            _repoCategory = repoCategory;
            _repoProvider = repoProvider;
        }
        private void LoadList()
        {
            this.dataList.DataSource = _repo.GetAll(1, 1, 12, "Id", "asc", "", ref count);
            this.HideColumn();
            this.GetPagination();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

            this.LoadList();
            if (count == 0)
            {
                this.tabControl1.SelectedIndex = 1;
                this.Habilitar(false);
                this.Botones();
                this.btnedit.Enabled = false;
            }
            else
            {
                this.Habilitar(false);
                this.Botones();
                this.btnedit.Enabled = false;
            }
        }
        private void HideColumn()
        {
            this.dataList.Columns["ckdelete"].Visible = false;
            this.dataList.Columns["FinalDate"].Visible = false;
            this.dataList.Columns["CreatedDate"].Visible = false;
            this.dataList.Columns["State"].Visible = false;
            this.dataList.Columns["Account"].Visible = false;
            this.dataList.Columns["AccountId"].Visible = false;
            this.dataList.Columns["Categories"].Visible = false;
            this.dataList.Columns["CategoryId"].Visible = false; 
            //this.dataList.Columns["ExpirationDate"].Visible = false; 
            this.dataList.Columns["Description"].Visible = false;
            this.dataList.Columns["ModifiedDate"].Visible = false;
            this.dataList.Columns["ProviderId"].Visible = false;
        }

        private void CleanBox()
        {
            this.txtproductname.Text = string.Empty;
            this.txtPurchasePrice.Text = string.Empty;
            this.txtcode.Text = string.Empty;
            this.txtproductcode.Text = string.Empty;
            this.txtSalePrice.Text = string.Empty;
            this.txtdescription.Text = string.Empty;
            this.txtcategoryproduct.Text = string.Empty;
            this.txtproviderproduct.Text = string.Empty;
            this.txtproductname.Text = string.Empty;
            this.txtcatproductId.Text = string.Empty;
            this.txtprovproductId.Text = string.Empty;
            this.txtlot.Text = string.Empty;
            this.txtstock.Text = string.Empty;

            this.btnsave.Text = "Guardar";
        }

        private void Habilitar(bool valor)
        {
            this.txtproductname.ReadOnly = !valor;
            this.txtPurchasePrice.ReadOnly = !valor;
            this.txtcode.ReadOnly = !valor;
            this.txtproductcode.ReadOnly = !valor;
            this.txtSalePrice.ReadOnly = !valor;
            this.txtdescription.ReadOnly = !valor;
            this.txtlot.ReadOnly = !valor;
            this.txtstock.ReadOnly = !valor;
            this.btncategory.Enabled = valor;
            this.btnprovider.Enabled = valor;
            this.dtTP.Enabled = valor;
        }

        private void Botones()
        {
            if (this.Isnuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnnew.Enabled = false;
                this.btnsave.Enabled = true;
                this.btnedit.Enabled = false;
                this.btncancel.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnnew.Enabled = true;
                this.btnsave.Enabled = false;
                this.btnedit.Enabled = true;
                this.btncancel.Enabled = false;
            }
        }
        private void SearchByName()
        {
            if (!this.txtsearch.Text.Trim().Equals(""))
            {
                this.dataList.DataSource = _repo.GetAll(1, 1, 12, "Id", "asc", this.txtsearch.Text.Trim(), ref count);
                this.GetPagination();
            }
            else
                this.LoadList();

            this.HideColumn();
            lblTotal.Text = Convert.ToString(count);
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            this.Isnuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.CleanBox();
            this.Habilitar(true);
            this.txtproductname.Focus();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Isnuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.CleanBox();
            this.Habilitar(false);
            this.btnedit.Enabled = false;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (!this.txtcode.Text.Equals(""))
            {
                this.Isnuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                MessageBox.Show("Debe de seleccionar primero el registro a Modificar", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tabControl1.SelectedIndex = 0;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.SearchByName();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean isdelate = false;
                Boolean ischeked = false;

                foreach (DataGridViewRow row in dataList.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        ischeked = true;
                    }
                }
                if (chkEliminar.Checked && ischeked)
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        String Codigo;
                        string resp = "";

                        foreach (DataGridViewRow row in dataList.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = ((ProductBE)row.DataBoundItem).Id;
                                resp = _repo.Delete(Codigo);

                                if (!string.IsNullOrEmpty(resp))
                                {
                                    isdelate = true;
                                }
                                else
                                {
                                    isdelate = false;
                                }
                            }
                        }
                        if (isdelate)
                        {
                            MessageBox.Show(resp, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            chkEliminar.Checked = false;

                        }
                        else
                        {
                            MessageBox.Show("El archivo no fue eliminado", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            chkEliminar.Checked = false;
                        }
                        this.LoadList();
                    }
                }
                else
                    MessageBox.Show("Debe chequear el checkbox eliminar, si deseas eliminar uno o mas registro", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            frmlistcategory frm = new frmlistcategory(_repoCategory);
            frm.ShowDialog();
            this.txtcategoryproduct.Text = frm.CategoryNameProduct;
            this.txtcatproductId.Text = frm.CategoryId;
        }

        private void btnprovider_Click(object sender, EventArgs e)
        {
            frmlistprovider frm = new frmlistprovider(_repoProvider);
            frm.ShowDialog();
            this.txtproviderproduct.Text = frm.ProviderNameProduct;
            this.txtprovproductId.Text = frm.ProviderId;
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String resp = "";
                if (txtproductname.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe ingresar  el nombre del producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtproductname.Text = String.Empty;
                    txtproductname.Focus();
                }
                else if (txtlot.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe ingresar  el lote del producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtlot.Text = String.Empty;
                }
                else if (txtproductcode.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe ingresar  el codigo del producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtproductcode.Text = String.Empty;
                    txtproductcode.Focus();
                }
                else if (txtstock.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe ingresar la cantidad del producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtstock.Text = String.Empty;
                    txtstock.Focus();
                }
                else if (dtTP.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe seleccionar  la fecha del vencimiento del producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtTP.Value = DateTime.Now;
                }
                else if (dtTP.Value <= DateTime.Now)
                {
                    MessageBox.Show("La fecha de vencimiento del producto no puede ser menor que hoy", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtTP.Value = DateTime.Now;
                }
                else if (txtcatproductId.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe seleccionar la categoria del producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcatproductId.Text = String.Empty;
                    txtcatproductId.Focus();

                    txtcategoryproduct.Text = String.Empty;
                    txtcategoryproduct.Focus();
                }
                else if (txtprovproductId.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe seleccionar el proveedor del producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtprovproductId.Text = String.Empty;
                    txtprovproductId.Focus();

                    txtproviderproduct.Text = String.Empty;
                    txtproviderproduct.Focus();
                }
                else if (txtPurchasePrice.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe ingresar el precio de compra del producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPurchasePrice.Text = String.Empty;
                    txtPurchasePrice.Focus();
                }
                else if (txtSalePrice.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe ingresar el precio de venta del producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalePrice.Text = String.Empty;
                    txtSalePrice.Focus();
                }
                else
                {

                    ProductBE be = new ProductBE()
                    {
                        ProductName = txtproductname.Text.Trim(),
                        ProductCode = txtproductcode.Text.Trim(),
                        CategoryId = txtcatproductId.Text.Trim(),
                        Description = txtdescription.Text.Trim(),
                        ProviderId = txtprovproductId.Text.Trim(),
                        state = (Int32)StateEnum.Activeted,
                        CreatedDate = DateTime.Now,
                        AccountId = LoginInfo.IdAccount,
                        Stock = Convert.ToInt32(txtstock.Text),
                        PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                        SalePrice = Convert.ToDecimal(txtSalePrice.Text),
                        Lots = new List<LotBE>()
                        {
                            new LotBE()
                            {
                                ExpiredDate = dtTP.Value,
                                LotCode  = txtlot.Text,
                                CreatedDate = DateTime.Now,
                            }
                        }
                    };

                    if (Isnuevo)
                        resp = _repo.Create(be);
                    else
                    {
                        var lot = _repo.SearchExpiredProductByLotCode(txtlot.Text);
                        if (lot)
                            resp = _repo.Update(txtcode.Text.Trim(), be).ToString();
                    }

                    if (!string.IsNullOrEmpty(resp))
                        MessageBox.Show(resp, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Isnuevo = false;
                    this.IsEditar = false;

                    this.Botones();
                    this.CleanBox();
                    this.LoadList();
                    this.tabControl1.SelectedIndex = 0;
                }

            }
            catch (ApiBusinessException ex)
            {
                if (ex.MessageError.Equals("Debe ingresar la fecha de vencimiento para ese lote"))
                {
                    MessageBox.Show(ex.MessageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtTP.Value = DateTime.Now;
                }
                if (ex.MessageError.Equals("Esta vencido el producto para ese lote"))
                {
                    MessageBox.Show(ex.MessageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtTP.Value = DateTime.Now;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataList.Columns[0].Visible = true;
            }
            else
            {
                foreach (DataGridViewRow row in dataList.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        row.Cells[0].Value = false;
                    }
                }
                this.dataList.Columns[0].Visible = false;
            }
        }

        private void dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataList.Columns["ckdelete"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataList.Rows[e.RowIndex].Cells["ckdelete"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dataList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = this.dataList.SelectedRows[0];
            var product = (ProductBE)selectedRow.DataBoundItem;
            this.txtcode.Text = product.Id;
            this.txtproductname.Text = product.ProductName;
            this.txtproductcode.Text = product.ProductCode;
            this.txtSalePrice.Text = product.SalePrice.ToString();
            this.txtPurchasePrice.Text = product.PurchasePrice.ToString();
            this.dtTP.Value = product.Lots.Count == 0 ? DateTime.Now : product.Lots[0].ExpiredDate;
            //this.txtlot.Text = product.Lots[0].LotCode;
            this.txtdescription.Text = product.Description;
            this.txtstock.Text = product.Stock.ToString();

            var cateser = _repoCategory.GetById(product.CategoryId);
            var proserv = _repoProvider.GetById(product.ProviderId);

            this.txtcatproductId.Text = product.CategoryId.ToString();
            this.txtcategoryproduct.Text = cateser.CategoryName;
            this.txtprovproductId.Text = product.ProviderId.ToString();
            this.txtproviderproduct.Text = proserv.Name;

            this.Habilitar(false);
            this.btnedit.Enabled = true;
            this.btnsave.Enabled = false;
            this.btnnew.Enabled = false;
            this.btnsave.Text = "Modificar";
            this.tabControl1.SelectedIndex = 1;
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
    }
}
