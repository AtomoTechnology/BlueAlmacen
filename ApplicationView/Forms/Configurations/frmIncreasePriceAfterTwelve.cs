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

namespace ApplicationView.Forms.Configurations
{
    public partial class frmIncreasePriceAfterTwelve : Form
    {
        private readonly IIncreasePriceAfterTwelveService _repo;
        private bool Isnuevo = false;
        private bool IsEditar = false;
        int count = 0;
        public frmIncreasePriceAfterTwelve(IIncreasePriceAfterTwelveService repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            this.Isnuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.CleanBox();
            this.Habilitar(true);
            //this.txtrol.Focus();
        }

        private void CleanBox()
        {
            this.txtcode.Text = string.Empty;
            this.txtporcent.Text = string.Empty;
            this.dtpfrom.Value = DateTime.Now;
            this.dtpto.Value = DateTime.Now;
            this.chbisactive.Checked = false;
            this.btnsave.Text = "Guardar";
        }

        private void Habilitar(bool valor)
        {
            this.dtpto.Enabled = valor;
            this.dtpfrom.Enabled = valor;
            this.txtporcent.ReadOnly = !valor;
            this.chbisactive.Enabled = valor;
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
            //this.CleanBox();
            this.Habilitar(false);
            if (count == 0)
                this.btnedit.Enabled = false;
            else
                this.btnedit.Enabled = true;
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
        private void HideColumn()
        {
            this.dataList.Columns["ckdelete"].Visible = false;
            this.dataList.Columns["FinalDate"].Visible = false;
            this.dataList.Columns["Account"].Visible = false;
            this.dataList.Columns["ModifiedDate"].Visible = false; 
            this.dataList.Columns["AccountId"].Visible = false;
            this.dataList.Columns["CreatedDate"].Visible = false;
            this.dataList.Columns["State"].Visible = false;
            this.dataList.Columns["IsActive"].Visible = false;
        }
        private void LoadList()
        {
            List<IncreasePriceAfterTwelveBE> be = _repo.GetAll(1, 1, 12, "Id", "asc", DateTime.Now, DateTime.Now, LoginInfo.IdBusiness, ref count);
            this.dataList.DataSource = be;
            if (be.Count > 0)
            {
                this.txtcode.Text = be[0].Id;
                this.dtpfrom.Value = be[0].HourFrom;
                this.dtpto.Value = be[0].HourTo;
                this.txtporcent.Text = be[0].Porcent.ToString();
                this.chbisactive.Checked = be[0].IsActive;

                this.btnedit.Enabled = true;
                this.btnsave.Text = "Modificar";
            }
            this.HideColumn();
        }

        private void frmIncreasePriceAfterTwelve_Load(object sender, EventArgs e)
        {
            this.LoadList();
            if (count == 0)
            {
                this.tabControl1.SelectedIndex = 1;
                this.Habilitar(false);
                this.Botones();
                this.btnedit.Enabled = false;
                this.btnnew.Visible = true;
            }
            else
            {
                this.Habilitar(false);
                this.Botones();
                this.btnedit.Enabled = true;
                this.btnnew.Visible = false;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String resp = "";
                if (dtpfrom.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe ingresar la hora desde que el incremento va a empezar", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.dtpfrom.Value = DateTime.Now;
                }
                else if (dtpto.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe ingresar  la hora desde que el incremento va a terminar", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.dtpto.Value = DateTime.Now;
                }
                else if (txtporcent.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe ingresar el porcentaje del aumento", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtporcent.Text = String.Empty;
                    this.txtporcent.Focus();
                }
                else if (dtpfrom.Text.Equals(dtpto.Text))
                {
                    MessageBox.Show("La hora desde no puede se igual a la hora hasta", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.dtpto.Value = DateTime.Now.AddHours(6);
                }
                else if (!chbisactive.Checked)
                {
                    MessageBox.Show("Se debe chequear el check de activado", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.dtpto.Value = DateTime.Now.AddHours(6);
                }
                else
                {
                    IncreasePriceAfterTwelveBE be = new IncreasePriceAfterTwelveBE()
                    {
                        AccountId = LoginInfo.IdAccount,
                        CreatedDate = DateTime.Now,
                        HourFrom = Convert.ToDateTime(dtpfrom.Value),
                        HourTo = Convert.ToDateTime(dtpto.Value),
                        IsActive = chbisactive.Checked,
                        Porcent = Convert.ToDecimal(txtporcent.Text),
                        ModifiedDate = DateTime.Now,
                        state = 1
                    };

                    if (Isnuevo)
                        resp = _repo.Create(be);
                    else
                        resp = _repo.Update(txtcode.Text.Trim(), be).ToString();

                    if (!string.IsNullOrEmpty(resp))
                        MessageBox.Show(resp.Split('-')[0], "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            var be = (IncreasePriceAfterTwelveBE)selectedRow.DataBoundItem;

            this.txtcode.Text = be.Id;
            this.dtpfrom.Value = be.HourFrom;
            this.dtpto.Value = be.HourTo;
            this.txtporcent.Text = be.Porcent.ToString();
            this.chbisactive.Checked = be.IsActive;

            this.Habilitar(false);
            this.btnedit.Enabled = true;
            this.btnsave.Enabled = false;
            this.btnnew.Enabled = false;
            this.btnsave.Text = "Modificar";
            this.tabControl1.SelectedIndex = 1;
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
                                Codigo = ((IncreasePriceAfterTwelveBE)row.DataBoundItem).Id;
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
    }
}
