using BusnessEntities.BE;
using BusnessEntities.Dtos;
using DataService.Iservice;
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
    public partial class frmautorizedeleteproductsale : Form
    {
        private readonly IAccountService _repo;
        private readonly ISaleService _repoSale;
        private readonly string _saleidDetail;
        public Boolean isdeleteAdmin = false;
        public frmautorizedeleteproductsale(IAccountService repo, string saleidDetail, ISaleService repoSale)
        {
            InitializeComponent();
            _repo = repo;
            _saleidDetail = saleidDetail;
            _repoSale = repoSale;
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
                    AccountDTO Datos = _repo.Login(usuario, password);

                    if (Datos.RoleName.ToLower() == "Admin".ToLower())
                    {
                        try
                        {
                            _repoSale.RemoveNoneSale(_saleidDetail, Datos.Id, Resolver.Enums.DeleteSaleEnum.Admin);
                            this.isdeleteAdmin = true;
                            this.Close();
                        }
                        catch (Exception)
                        {
                            this.isdeleteAdmin = false;
                            this.Close();
                        }                       
                    }
                    else
                    {
                        MessageBox.Show("No tiene acceso administrador", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
