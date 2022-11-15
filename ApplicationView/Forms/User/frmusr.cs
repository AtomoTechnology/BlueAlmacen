using ApplicationView.Forms.Roles;
using ApplicationView.Share;
using ApplicationView.VariableSeesion;
using BusnessEntities.BE;
using DataService.Iservice;
using Resolver.Enums;
using Resolver.Helper;
using Resolver.HelperError.IExceptions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ApplicationView.Forms.User
{
    public partial class frmusr : Form
    {
        private readonly IUserService _repo;
        private readonly IRoleService _repoRole;
        private bool Isnuevo = false;
        private bool IsEditar = false;
        int count = 0;
        public frmusr(IUserService repo, IRoleService repoRole)
        {
            InitializeComponent();
            _repo = repo;
            _repoRole = repoRole;
            DataListHelper.SetGrid(this.dataList, 14, 12);
        }
        private void LoadList()
        {
            this.dataList.DataSource = _repo.GetAll(1, LoginInfo.pageactual, LoginInfo.pagesize, "Id", "asc","", ref count);
            this.HideColumn();
            this.GetPagination(Convert.ToInt32(dataList.Rows.Count));
        }
        private void GetPagination(int quantity)
        {
            if (quantity > 0)
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

        private void frmusr_Load(object sender, EventArgs e)
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
            this.dataList.Columns["FinalDate"].Visible = false;
            this.dataList.Columns["ModifiedDate"].Visible = false;
            this.dataList.Columns["Business"].Visible = false;
            this.dataList.Columns["BusinessId"].Visible = false;
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            this.Isnuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.CleanBox();
            this.Habilitar(true);
            this.txtfirstname.Focus();
        }

        private void CleanBox()
        {
            this.txtcode.Text = string.Empty;
            this.txtaddress.Text = string.Empty;
            this.txtemail.Text = string.Empty;
            this.txtfirstname.Text = string.Empty;
            this.txtlastname.Text = string.Empty;
            this.txtpassword.Text = string.Empty;
            this.txtphone.Text = string.Empty;
            this.txtusername.Text = string.Empty;

            this.btnsave.Text = "Guardar";
        }

        private void Habilitar(bool valor)
        {
            this.txtaddress.ReadOnly = !valor;
            this.txtemail.ReadOnly = !valor;
            this.txtfirstname.ReadOnly = !valor;
            this.txtlastname.ReadOnly = !valor;
            this.txtpassword.ReadOnly = !valor;
            this.txtphone.ReadOnly = !valor;
            this.txtusername.ReadOnly = !valor;
            this.btnselectplan.Enabled = valor;
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
                this.dataList.DataSource = _repo.GetAll(1, LoginInfo.pageactual, LoginInfo.pagesize, "Id", "asc", this.txtsearch.Text.Trim(), ref count);
                this.GetPagination(Convert.ToInt32(dataList.Rows.Count));
            }
            else
                this.LoadList();

            this.HideColumn();
            lblTotal.Text = Convert.ToString(count);
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
                        foreach (DataGridViewRow row in dataList.Rows)
                        {
                            var be = (UserBE)row.DataBoundItem;
                            if (be.Id == LoginInfo.IdUser)//No esta bien hay q revisarlo
                            {
                                MessageBox.Show("No se puede eliminar el usuario que esta logeado", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (Convert.ToBoolean(row.Cells[0].Value))
                                isdelate = _repo.Delete(be.Id);
                        }
                        if (isdelate)
                        {
                            MessageBox.Show("El usuario fue eliminado", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            chkEliminar.Checked = false;

                        }
                        else
                        {
                            MessageBox.Show("El usuario no fue eliminado", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            chkEliminar.Checked = false;
                        }
                        this.LoadList();
                    }
                }
                else
                    MessageBox.Show("Debe chequear el checkbox eliminar, si deseas eliminar uno o mas registro", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var be = (UserBE)selectedRow.DataBoundItem;

            this.txtcode.Text = be.Id;
            this.txtfirstname.Text = be.FirstName;
            this.txtlastname.Text = be.LastName;
            this.txtemail.Text = be.Email;
            this.txtaddress.Text = be.Address;
            this.txtphone.Text = be.Phone;

            this.Habilitar(false);
            this.btnedit.Enabled = true;
            this.btnsave.Enabled = false;
            this.btnnew.Enabled = false;
            this.btnsave.Text = "Modificar";
            this.HideOShowGroup(false);
            this.tabControl1.SelectedIndex = 1;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Isnuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.CleanBox();
            this.Habilitar(false);
            this.btnedit.Enabled = false;
            this.HideOShowGroup(true);
        }

        private void btnnew_Click_1(object sender, EventArgs e)
        {
            this.Isnuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.CleanBox();
            this.Habilitar(true);
            this.txtfirstname.Focus();
            this.HideOShowGroup(true);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            this.HideOShowGroup(false);
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
        private void HideOShowGroup(Boolean val)
        {
            //this.groupBox3.Visible = val;
            this.groupBox4.Visible = val;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String resp = "";
                if (txtfirstname.Text.Trim().Equals("") && !this.IsEditar)
                {
                    MessageBox.Show("Debe ingresar  el nombre del usuario", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtfirstname.Text = String.Empty;
                    txtfirstname.Focus();
                }
                else if (txtlastname.Text.Trim().Equals("") && !this.IsEditar)
                {
                    MessageBox.Show("Debe ingresar  el apellido del usuario", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtlastname.Text = String.Empty;
                    txtlastname.Focus();
                }
                else if (txtusername.Text.Trim().Equals("") && !this.IsEditar)
                {
                    MessageBox.Show("Debe ingresar  el nombre de usuario del usuario", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Text = String.Empty;
                    txtusername.Focus();
                }
                else if (txtrolename.Text.Trim().Equals("") && !this.IsEditar)
                {
                    MessageBox.Show("Debe seleccion  el rol para el usuario", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtrolename.Text = String.Empty;
                    txtrolename.Focus();
                }
                else if (txtpassword.Text.Trim().Equals("") && !this.IsEditar)
                {
                    MessageBox.Show("Debe ingresar  la contraseña de usuario del usuario", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Text = String.Empty;
                    txtpassword.Focus();
                }
                else
                {
                    UserBE be =  new UserBE()
                    {
                        BusinessId = LoginInfo.IdBusiness,
                        Address = this.txtaddress.Text.Trim(),
                        FirstName = this.txtfirstname.Text.Trim(),
                        LastName = this.txtlastname.Text.Trim(),
                        Email = this.txtemail.Text.Trim(),
                        Phone = this.txtphone.Text.Trim(),
                        state = (Int32)StateEnum.Activeted,
                        CreatedDate = DateTime.Now,
                        Accounts = new List<AccountBE>()
                        {
                            new AccountBE()
                            {
                                UserName = this.txtusername.Text.Trim(),
                                UserPass = this.txtpassword.Text.Trim(),
                                RoleId = this.txtroleid.Text.Trim(),
                                Confirm = false
                            }
                        }
                    };

                    if (Isnuevo)
                        resp = _repo.Create(be);
                    else
                        resp = _repo.Update(txtcode.Text.Trim(), be).ToString();

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
                MessageBox.Show(ex.MessageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnselectplan_Click(object sender, EventArgs e)
        {
            frmrolelist frm = new frmrolelist(_repoRole);
            frm.ShowDialog();
            if (frm.isselectrole)
            {
                this.txtroleid.Text = frm.roleId;
                this.txtrolename.Text = frm.roleName;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol para el usuario", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
