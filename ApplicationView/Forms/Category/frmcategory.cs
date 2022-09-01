﻿using ApplicationView.Share;
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

namespace ApplicationView.Forms.Category
{
    public partial class frmcategory : Form
    {
        private readonly ICategoryService _repo;
        private bool Isnuevo = false;
        private bool IsEditar = false;
        int count = 0;
        public frmcategory(ICategoryService repo)
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
        private void HideColumn()
        {
            this.dataList.Columns["ckdelete"].Visible = false;
            this.dataList.Columns["AccountId"].Visible = false;
            this.dataList.Columns["State"].Visible = false;
            this.dataList.Columns["Account"].Visible = false;
            this.dataList.Columns["FinalDate"].Visible = false;
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
        private void frmcategory_Load(object sender, EventArgs e)
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
        private void CleanBox()
        {
            this.txtcategoryname.Text = string.Empty;
            this.txtdescription.Text = string.Empty;
            this.txtcode.Text = string.Empty;
            this.btnsave.Text = "Guardar";
        }

        private void Habilitar(bool valor)
        {
            this.txtcategoryname.ReadOnly = !valor;
            this.txtcategoryname.ReadOnly = !valor;
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
                                Codigo = Convert.ToString(row.Cells[3].Value);
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Isnuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.CleanBox();
            this.Habilitar(false);
            this.btnedit.Enabled = false;
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            this.Isnuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.CleanBox();
            this.Habilitar(true);
            this.txtcategoryname.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String resp = "";
                if (txtcategoryname.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Debe ingresar  el nombre de la categoria", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtrol.Text = String.Empty;
                    txtrol.Focus();
                }
                else
                {
                    CategoryBE be = new CategoryBE()
                    {
                        CategoryName = txtcategoryname.Text.Trim(),
                        Description = txtdescription.Text.Trim()
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
            this.txtcategoryname.Text = Convert.ToString(this.dataList.CurrentRow.Cells[2].Value);
            this.txtdescription.Text = Convert.ToString(this.dataList.CurrentRow.Cells[3].Value);

            this.Habilitar(false);
            this.btnedit.Enabled = true;
            this.btnsave.Enabled = false;
            this.btnnew.Enabled = false;
            this.btnsave.Text = "Modificar";
            this.tabControl1.SelectedIndex = 1;
        }
    }
}
