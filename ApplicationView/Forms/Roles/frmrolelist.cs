using ApplicationView.Share;
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

namespace ApplicationView.Forms.Roles
{
    public partial class frmrolelist : Form
    {
        public string roleName = string.Empty;
        public string roleId = string.Empty;
        public bool isselectrole = false;
        int count = 0;
        private readonly IRoleService _repo;
        public frmrolelist(IRoleService repo)
        {
            InitializeComponent();
            _repo = repo;
            this.isselectrole = false;
        }
        private void LoadList()
        {

            this.dataList.DataSource = _repo.GetAll(1, LoginInfo.pageactual, LoginInfo.pagesize, "Id", "asc", "", ref count);
            this.HideColumn();
            this.GetPagination(Convert.ToInt32(dataList.Rows.Count));
        }
        private void HideColumn()
        {
            this.dataList.Columns["State"].Visible = false;
            this.dataList.Columns["FinalDate"].Visible = false;
            this.dataList.Columns["ModifiedDate"].Visible = false;
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

        private void frmrolelist_Load(object sender, EventArgs e)
        {
            this.LoadList();
        }

        private void dataList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = this.dataList.SelectedRows[0];
            var cate = (RoleBE)selectedRow.DataBoundItem;

            this.roleId = cate.Id;
            this.roleName = cate.RoleName;
            this.isselectrole = true;

            this.Close();
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
    }
}
