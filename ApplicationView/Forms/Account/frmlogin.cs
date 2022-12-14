using ApplicationView.Forms.Account;
using ApplicationView.VariableSeesion;
using BusnessEntities.BE;
using BusnessEntities.Dtos;
using DataService.Iservice;
using Resolver.HelperError.IExceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationView
{
    public partial class frmlogin : Form
    {
        private readonly IAccountService _repo;
        private readonly IRoleService _repoRole;
        private readonly IBusnessService _repoBusiness; 
        private readonly ICategoryService _repoCategory;
        private readonly IProviderService _repoProvider;
        private readonly IProductService _repoProduct;
        private readonly ISaleService _repoSale;
        private readonly ISaleDetailService _repoSaleDetail;
        private readonly IIncreasePriceAfterTwelveService _repoIncrease;
        private readonly IUserService _repoUser;
        public frmlogin(IAccountService repo, IRoleService repoRole, IBusnessService repoBusiness, ICategoryService repoCategory,
            IProviderService repoProvider, IProductService repoProduct, ISaleService repoSale, ISaleDetailService repoSaleDetail,
            IIncreasePriceAfterTwelveService repoIncrease, IUserService repoUser)
        {
            InitializeComponent();
            _repo = repo;
            _repoRole = repoRole;
            _repoBusiness = repoBusiness;
            _repoCategory = repoCategory;
            _repoProvider = repoProvider;
            _repoProduct = repoProduct;
            _repoSale = repoSale;
            _repoSaleDetail = repoSaleDetail;
            _repoIncrease = repoIncrease;
            _repoUser  = repoUser;

            if (LoginInfo.ischange == true)
            {
                this.txtusername.Text = String.Empty;
                this.txtuserpass.Text = String.Empty;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString(); // hora actual 
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            foreach (Form frmlog in Application.OpenForms)
            {
                if (frmlog.GetType() == typeof(frmPrincipal))
                {
                    frmlog.Close();
                    break;
                }
                else
                {
                    frmlog.Close();
                    break;
                }
            }
        }

        private void btnacept_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = Convert.ToString(this.txtusername.Text);
                string password = Convert.ToString(this.txtuserpass.Text);
                if (string.IsNullOrEmpty(usuario))
                {
                    MessageBox.Show("Ingrese el nombre de usuario", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtusername.Text = String.Empty;
                    this.txtusername.Focus();
                }
                else if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Ingresa la contraseña", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtuserpass.Text = String.Empty;
                    this.txtuserpass.Focus();

                }
                else
                {
                    AccountDTO Datos = _repo.Login(usuario, password);                

                    if (Datos.Confirm == false)
                    {
                        LoginInfo.IdAccount = Datos.Id;
                        LoginInfo.IdUser = Datos.UserId;
                        LoginInfo.IdRole = Datos.RoleId;
                        LoginInfo.UserName = Datos.UserName;
                        LoginInfo.Pass = Datos.UserPass;
                        LoginInfo.Access = Datos.RoleName;
                        LoginInfo.IdBusiness = Datos.BusinessId;

                        LoginInfo.isChangeCancelPass = true;
                        frmchangepass pass = new frmchangepass(_repo, _repoRole, _repoBusiness, _repoCategory, _repoProvider, _repoProduct, _repoSale, _repoSaleDetail, _repoIncrease, _repoUser);
                        pass.Show();
                        //this.Close();
                    }
                    else
                    {
                        LoginInfo.IdAccount = Datos.Id;
                        LoginInfo.IdUser = Datos.UserId;
                        LoginInfo.IdRole = Datos.RoleId;
                        LoginInfo.UserName = Datos.UserName;
                        LoginInfo.Pass = Datos.UserPass;
                        LoginInfo.Access = Datos.RoleName;
                        LoginInfo.IdBusiness = Datos.BusinessId;
                        LoginInfo.isChangeCancelPass = false;

                        frmPrincipal principal = new frmPrincipal(Datos, _repoRole, _repoBusiness, _repoCategory, _repoProvider, _repoProduct, _repoSale, _repoSaleDetail, _repoIncrease, _repo, _repoUser);

                        principal.Show();
                        this.Hide();
                    }
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
    }
}
