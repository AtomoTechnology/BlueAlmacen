using ApplicationView.Share;
using ApplicationView.VariableSeesion;
using BusnessEntities.BE;
using DataService.Iservice;
using Resolver.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApplicationView.Forms.Business
{
    public partial class frmbusiness : Form
    {
        private readonly IBusnessService _repo;
        private bool Isnuevo = false;
        private bool IsEditar = false;
        int count = 0;
        public frmbusiness(IBusnessService repo)
        {
            InitializeComponent();
            _repo = repo;
        }
        private void LoadList()
        {
            this.dataList.DataSource = _repo.GetAll(1, 1, 12, "Id", "asc", "", ref count);
            this.HideColumn();
            this.GetPagination();
        }

        private void frmbusiness_Load(object sender, EventArgs e)
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
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            this.Isnuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.CleanBox();
            this.Habilitar(true);
            this.txtbusinessname.Focus();
        }

        private void CleanBox()
        {
            this.txtbusinessname.Text = string.Empty;
            this.txtaddress.Text = string.Empty;
            this.txtcode.Text = string.Empty;
            this.txtcuit_cuil.Text = string.Empty;
            this.txtemail.Text = string.Empty;
            this.txtfirstname.Text = string.Empty;
            this.txtlastname.Text = string.Empty;
            this.txtpassword.Text = string.Empty;
            this.txtphone.Text = string.Empty;
            this.txtphoneadmin.Text = string.Empty;
            this.txtusername.Text = string.Empty;
            this.txtaddressbusiness.Text = string.Empty;

            this.btnsave.Text = "Guardar";
        }

        private void Habilitar(bool valor)
        {
            this.txtbusinessname.ReadOnly = !valor;
            this.txtaddress.ReadOnly = !valor;
            this.txtcode.ReadOnly = !valor;
            this.txtcuit_cuil.ReadOnly = !valor;
            this.txtemail.ReadOnly = !valor;
            this.txtfirstname.ReadOnly = !valor;
            this.txtlastname.ReadOnly = !valor;
            this.txtpassword.ReadOnly = !valor;
            this.txtphone.ReadOnly = !valor;
            this.txtphoneadmin.ReadOnly = !valor;
            this.txtusername.ReadOnly = !valor;
            this.txtaddressbusiness.ReadOnly = !valor;
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

        private void btnnew_Click_1(object sender, EventArgs e)
        {
            this.Isnuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.CleanBox();
            this.Habilitar(true);
            this.txtbusinessname.Focus();
            this.HideOShowGroup(true);
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
                                Codigo = Convert.ToString(row.Cells[5].Value);
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
            this.txtcode.Text = Convert.ToString(this.dataList.CurrentRow.Cells[5].Value);
            this.txtbusinessname.Text = Convert.ToString(this.dataList.CurrentRow.Cells[1].Value);
            this.txtcuit_cuil.Text = Convert.ToString(this.dataList.CurrentRow.Cells[2].Value);
            this.txtaddressbusiness.Text = Convert.ToString(this.dataList.CurrentRow.Cells[3].Value);
            this.txtphone.Text = Convert.ToString(this.dataList.CurrentRow.Cells[4].Value);

            this.Habilitar(false);
            this.btnedit.Enabled = true;
            this.btnsave.Enabled = false;
            this.btnnew.Enabled = false;
            this.btnsave.Text = "Modificar";
            this.HideOShowGroup(false);
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String resp = "";
                if (txtbusinessname.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe ingresar  el nombre del negocio", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbusinessname.Text = String.Empty;
                    txtbusinessname.Focus();
                }
                else if (txtfirstname.Text.Trim().Equals("") && !this.IsEditar)
                {
                    MessageBox.Show("Debe ingresar  el nombre del administrador", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtfirstname.Text = String.Empty;
                    txtfirstname.Focus();
                }
                else if (txtlastname.Text.Trim().Equals("") && !this.IsEditar)
                {
                    MessageBox.Show("Debe ingresar  el apellido del administrador", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtlastname.Text = String.Empty;
                    txtlastname.Focus();
                }
                else if (txtusername.Text.Trim().Equals("") && !this.IsEditar)
                {
                    MessageBox.Show("Debe ingresar  el nombre de usuario del administrador", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Text = String.Empty;
                    txtusername.Focus();
                }
                else if (txtpassword.Text.Trim().Equals("") && !this.IsEditar)
                {
                    MessageBox.Show("Debe ingresar  la contraseña de usuario del administrador", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Text = String.Empty;
                    txtpassword.Focus();
                }
                else
                {
                    BusinessBE be = new BusinessBE()
                    {
                        BusinessName = txtbusinessname.Text.Trim(),
                        Address = txtaddressbusiness.Text.Trim(),
                        Cuit_Cuil = txtcuit_cuil.Text.Trim(),
                        Phone = txtphone.Text.Trim(),
                        state = (Int32)StateEnum.Activeted,
                        CreatedDate = DateTime.Now,
                        Users = new List<UserBE>()
                        {
                            new UserBE()
                            {
                                Address = txtaddress.Text.Trim(),
                                FirstName = txtfirstname.Text.Trim(),
                                LastName = txtlastname.Text.Trim(),
                                Email = txtemail.Text.Trim(),
                                Phone = txtphone.Text.Trim(),
                                state = (Int32)StateEnum.Activeted,
                                CreatedDate = DateTime.Now,
                                Accounts = new List<AccountBE>()
                                {
                                    new AccountBE()
                                    {
                                        UserName = txtusername.Text.Trim(),
                                        UserPass = txtpassword.Text.Trim(),
                                        Confirm = false
                                    }
                                }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HideOShowGroup(Boolean val)
        {
            this.groupBox3.Visible = val;
            this.groupBox4.Visible = val;
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
    }
}
