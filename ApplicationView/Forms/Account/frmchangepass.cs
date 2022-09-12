using ApplicationView.VariableSeesion;
using BusnessEntities.BE;
using DataService.Iservice;
using Resolver.HelperError.IExceptions;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ApplicationView.Forms.Account
{
    public partial class frmchangepass : Form
    {
        private readonly IAccountService _repo;
        private readonly IRoleService _repoRole;
        private readonly IBusnessService _repoBusiness;
        private readonly ICategoryService _repoCategory;
        private readonly IProviderService _repoProvider;
        public frmchangepass(IAccountService repo, IRoleService repoRole, IBusnessService repoBusiness, ICategoryService repoCategory,
            IProviderService repoProvider)
        {
            InitializeComponent();
            _repo = repo;
            _repoRole = repoRole;
            _repoBusiness = repoBusiness;
            _repoCategory = repoCategory;
            _repoProvider = repoProvider;
        }

        private void btnacept_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtoldpass.Text == String.Empty)
                {
                    MessageBox.Show("Ingresa la contraseña actual", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtoldpass.Text = String.Empty;
                    txtoldpass.Focus();
                }
                else if (txtoldpass.Text != LoginInfo.Pass)
                {
                    MessageBox.Show("Contraseña es diferente del actual", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtoldpass.Text = String.Empty;
                }
                else if (txtnewpass.Text == String.Empty)
                {
                    MessageBox.Show("Ingresa la nueva contraseña", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnewpass.Text = String.Empty;
                    txtnewpass.Focus();
                }
                else if (txtnewpass.Text.Length >= 50)
                {
                    MessageBox.Show("la contraseña no puede tener mas de 50 caracteres", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnewpass.Text = String.Empty;
                    txtnewpass.Focus();
                }
                else if (txtconfirmpass.Text == String.Empty)
                {
                    MessageBox.Show("Confirmar la nueva contraseña", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtconfirmpass.Text = String.Empty;
                    txtconfirmpass.Focus();
                }
                else if (txtnewpass.Text != txtconfirmpass.Text)
                {
                    MessageBox.Show("Contraseña confirmada es diferente de la nueva contraseña", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtconfirmpass.Text = String.Empty;
                    txtconfirmpass.Focus();
                }
                else
                {
                    var be = new AccountBE()
                    {
                        UserPass = txtnewpass.Text,
                        Confirm = true,
                        Id = LoginInfo.IdAccount,
                    };
                    var result = _repo.ChangePassword(be);
                    if (!string.IsNullOrEmpty(result))
                        MessageBox.Show(result, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    frmPrincipal frm = ((frmPrincipal)this.MdiParent);
                    if (frm != null)
                    {
                        frm.Close();
                    }
                    //Application.Restart();
                    frmlogin frmlog = new frmlogin(_repo, _repoRole, _repoBusiness, _repoCategory, _repoProvider);
                    this.Hide();
                    frmlog.ShowDialog();
                }
            }
            catch (ApiBusinessException ex)
            {
                MessageBox.Show(ex.MessageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el servidor. Compruebe que el nombre de la instancia es correcto.", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            var result = MessageBox.Show("Debes cambiar la contraseña.\nEsta seguro que desees salir del sistema?", "Sistema de ventas",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
