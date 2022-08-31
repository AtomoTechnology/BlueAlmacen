using ApplicationView.VariableSeesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationView.Share
{
    public class ShareMethod
    {
        #region Constructor
        private static ShareMethod _factory;
        public static ShareMethod GetInstance()
        {
            if (_factory == null)
                _factory = new ShareMethod();
            return _factory;

        }
        #endregion

        public void goFirst()
        {
            LoginInfo.pageactual = Convert.ToInt32(1);
            LoginInfo.skipamount = Convert.ToInt32(1);
        }

        public void goNext()
        {
            LoginInfo.skipamount++;
            LoginInfo.pageactual++;
        }

        public void goLast(Int32 amount)
        {
            LoginInfo.pageamount = amount;
            LoginInfo.page = Math.Ceiling(LoginInfo.pageamount / LoginInfo.pagesize);
            LoginInfo.pageactual = Convert.ToInt32(LoginInfo.page);
            LoginInfo.skipamount = Convert.ToInt32(LoginInfo.page);
        }

        public void goPrevious()
        {
            LoginInfo.pageactual--;
            LoginInfo.skipamount--;
        }

        public void HabilitarBtnPagination(List<Button> btn, Boolean val)
        {
            foreach (var item in btn)
            {
                item.Enabled = val;
            }
        }

        public void HabilityTextBox(List<TextBox> txt, Boolean val)
        {
            foreach (var item in txt)
            {
                item.Enabled = val;
            }
        }

        public void HabilityComboBox(List<ComboBox> txt, Boolean val)
        {
            foreach (var item in txt)
            {
                item.Enabled = val;
            }
        }

        public void HabilityPagenation(List<Button> btn, List<Label> lbl, Boolean val)
        {
            if (btn.Count() > 0)
            {
                for (int I = 0; I < btn.Count(); I++)
                {
                    btn[I].Visible = val;
                    if (I < 3)
                        lbl[I].Visible = val;
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
