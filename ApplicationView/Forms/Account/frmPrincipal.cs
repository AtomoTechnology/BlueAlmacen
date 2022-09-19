using ApplicationView.Forms.Business;
using ApplicationView.Forms.Category;
using ApplicationView.Forms.Product;
using ApplicationView.Forms.Provider;
using ApplicationView.Forms.Roles;
using ApplicationView.Forms.Sale;
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
        public frmPrincipal(AccountBE be, IRoleService repo, IBusnessService repoBusiness, ICategoryService repoCategory,
            IProviderService repoProvider, IProductService repoProduct, ISaleService repoSale, ISaleDetailService repoSaleDetail)
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
            Application.EnableVisualStyles();
            var result = MessageBox.Show("Esta seguro que desees salir del sistema?", "Sistema de ventas",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct(_repoProduct, _repoCategory, _repoProvider);
            frm.MdiParent = this;
            frm.Show();            
        }

        private void produdosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsale frm = new frmsale(_repoProduct, _repoSale, _repoSaleDetail);
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
