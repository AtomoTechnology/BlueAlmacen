using ApplicationView.Forms.Business;
using ApplicationView.Forms.Category;
using ApplicationView.Forms.Configurations;
using ApplicationView.Forms.Product;
using ApplicationView.Forms.Provider;
using ApplicationView.Forms.Roles;
using ApplicationView.Forms.Sale;
using ApplicationView.VariableSeesion;
using BusnessEntities.BE;
using DataService.Iservice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApplicationView.Forms.Account
{
    public partial class frmPrincipal : Form
    {
        AccountBE _be;
        private readonly IRoleService _repo;
        private readonly IBusnessService _repoBusiness;
        private readonly ICategoryService _repoCategory;
        private readonly IProviderService _repoProvider;
        private readonly IProductService _repoProduct;
        private readonly ISaleService _repoSale;
        private readonly ISaleDetailService _repoSaleDetail;
        private readonly IIncreasePriceAfterTwelveService _repoIncrease;
        private readonly IAccountService _repoAccount;
        public frmPrincipal(AccountBE be, IRoleService repo, IBusnessService repoBusiness, ICategoryService repoCategory,
            IProviderService repoProvider, IProductService repoProduct, ISaleService repoSale, ISaleDetailService repoSaleDetail,
            IIncreasePriceAfterTwelveService repoIncrease, IAccountService repoAccount)
        {
            InitializeComponent();
            this._be = be;
            _repo = repo;
            _repoBusiness = repoBusiness;
            _repoCategory = repoCategory;
            _repoProvider = repoProvider;
            _repoProduct = repoProduct;
            _repoSale = repoSale;
            _repoSaleDetail = repoSaleDetail;
            _repoIncrease = repoIncrease;
            _repoAccount = repoAccount;
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrole frm = new frmrole(_repo);
            frm.MdiParent = this;
            frm.Show();
        }

        private void gestionarNegocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbusiness frm = new frmbusiness(_repoBusiness);
            frm.MdiParent = this;
            frm.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcategory frm = new frmcategory(_repoCategory);
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmprovider frm = new frmprovider(_repoProvider);
            frm.MdiParent = this;
            frm.Show();            
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginInfo.ischange = false;
            LoginInfo.changesession = false;
            foreach (Form frmlog in Application.OpenForms)
            {
                if (frmlog.GetType() == typeof(frmPrincipal))
                {
                    frmlog.Close();
                    break;
                }
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct(_repoProduct, _repoCategory, _repoProvider);
            frm.MdiParent = this;
            frm.Show();            
        }

        private void produdosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsale frm = new frmsale(_repoProduct, _repoSale, _repoSaleDetail, _repoIncrease, _repoAccount);
            frm.MdiParent = this;
            frm.Show();

        }

        private void incrementoDespuesDeLas12PMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncreasePriceAfterTwelve frm = new frmIncreasePriceAfterTwelve(_repoIncrease);
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LoginInfo.ischange != true)
            {
                String message = "Esta seguro que desees salir del sistema?";
                String captacion = "Salir";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, captacion, buttons);

                if (result == System.Windows.Forms.DialogResult.No)
                    e.Cancel = true;
                else
                {
                    LoginInfo.ischange = true;
                    LoginInfo.changesession = false;
                    Application.Exit();
                }
            }
            else if (LoginInfo.changesession == true && LoginInfo.ischange == true)
            {
                String message = "Estas seguro quieres cambiar session";
                String captacion = "Cambiar session";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, captacion, buttons);

                if (result == System.Windows.Forms.DialogResult.No)
                    e.Cancel = true;
                else
                {
                    frmlogin frm = new frmlogin(_repoAccount,_repo, _repoBusiness, _repoCategory, _repoProvider, _repoProduct, _repoSale, _repoSaleDetail, _repoIncrease);
                    frm.groupBox1.Text = "Cambiar sessión";
                    frm.Show();
                }
            }
        }

        private void cambiarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginInfo.ischange = true;
            LoginInfo.changesession = true;
            this.Close();
        }

        private void actualizarPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmupdateprice frm = new frmupdateprice(_repoProduct);
            frm.Show();
        }
    }
}
