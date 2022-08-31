using ApplicationView.Forms.Business;
using ApplicationView.Forms.Category;
using ApplicationView.Forms.Roles;
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
        public frmPrincipal(AccountBE be, IRoleService repo, IBusnessService repoBusiness)
        {
            InitializeComponent();
            this._be = be;
            _repo = repo;
            _repoBusiness = repoBusiness;
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
            frmcategory frm = new frmcategory();
            frm.MdiParent = this;
            frm.Show();
            
        }
    }
}
