using ApplicationView.Forms.Account;
using ApplicationView.VariableSeesion;
using BusnessEntities.BE;
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
        public frmlogin(IAccountService repo, IRoleService repoRole, IBusnessService repoBusiness, ICategoryService repoCategory)
        {
            InitializeComponent();
            _repo = repo;
            _repoRole = repoRole;
            _repoBusiness = repoBusiness;
            _repoCategory = repoCategory;
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
                string usuario, password;
                usuario = Convert.ToString(this.txtusername.Text);
                password = Convert.ToString(this.txtuserpass.Text);
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
                    AccountBE Datos = _repo.Login(usuario, password);
                    //if (Datos.Rows[0]["confirm"].ToString() != "True")
                    //{
                    //    be.idAccount = Convert.ToInt32(Datos.Rows[0]["idaccout"].ToString());
                    //    be.userPass = Security.PasswordSecurity.PassValidation.GetInstance().DecryptKey(Datos.Rows[0]["userpass"].ToString());

                    //    LoginInfo.idAccount = Convert.ToInt64(Datos.Rows[0]["idaccout"].ToString());
                    //    LoginInfo.pass = Security.PasswordSecurity.PassValidation.GetInstance().DecryptKey(Datos.Rows[0]["userpass"].ToString());
                    //    LoginInfo.idbusiness = Convert.ToInt64(Datos.Rows[0]["idbusiness"].ToString());
                    //    LoginInfo.idemployee = Convert.ToInt64(Datos.Rows[0]["idemployee"].ToString());

                    //    frmchangepass pass = new frmchangepass(be);
                    //    pass.Show();
                    //    this.Hide();
                    //}
                    //else
                    //{
                        //be.idAccount = Convert.ToInt32(Datos.Rows[0]["idaccout"].ToString());
                        ////be.nameresponsible = Datos.Rows[0][2].ToString();
                        //be.access = Datos.Rows[0][3].ToString();
                        //be.userPass = Security.PasswordSecurity.PassValidation.GetInstance().DecryptKey(Datos.Rows[0]["userpass"].ToString());

                        LoginInfo.idAccount = Datos.Id;
                        LoginInfo.idbusiness = Datos.RoleId;
                        //LoginInfo.usuario = Datos.Rows[0]["nombre usuario"].ToString();
                        //LoginInfo.access = Datos.Rows[0]["role"].ToString();

                        frmPrincipal principal = new frmPrincipal(Datos, _repoRole, _repoBusiness, _repoCategory); 

                        principal.Show();
                        this.Hide();
                    //}
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
