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

namespace ApplicationView.Forms.Provider
{
    public partial class frmlistprovider : Form
    {
        private readonly IProviderService _repo;
        public string ProviderNameProduct { get; set; }
        public string ProviderId { get; set; }
        int count = 0;
        public frmlistprovider(IProviderService repo)
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

        private void HideColumn()
        {
            this.dataList.Columns["FinalDate"].Visible = false;
            this.dataList.Columns["CreatedDate"].Visible = false;
            this.dataList.Columns["State"].Visible = false;
            this.dataList.Columns["Account"].Visible = false;
            this.dataList.Columns["AccountId"].Visible = false;
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

        private void frmlistprovider_Load(object sender, EventArgs e)
        {
            this.LoadList();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.SearchByName();
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

        private void dataList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = this.dataList.SelectedRows[0];
            var provi = (ProviderBE)selectedRow.DataBoundItem;

            this.ProviderId = provi.Id;
            this.ProviderNameProduct = provi.Name;

            this.Close();
        }
    }
}
