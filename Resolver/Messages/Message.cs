using System;
using System.Collections.Generic;
using System.Text;

namespace Resolver.Messages
{
    public class Message
    {
        #region Constructor
        private static Message _factory;
        public static Message GetInstance()
        {
            if (_factory == null)
                _factory = new Message();
            return _factory;

        }
        #endregion

        //public void MensajeOk(string mensaje)
        //{
        //    MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        ////Mensaje error
        //public void MensajeError(string mensaje)
        //{
        //    MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        //public void MensajeAdvertencia(string mensaje)
        //{
        //    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //}

        //public DialogResult Mensajeconfirmacion(string mensaje)
        //{
        //    return MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    //MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        //public void permitirsoloLetras(System.Windows.Forms.KeyPressEventArgs e)
        //{
        //    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
        //    {
        //        e.Handled = true;
        //        return;
        //    }
        //}

        //public void permitirsoloNumero(System.Windows.Forms.KeyPressEventArgs e)
        //{
        //    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
        //    {
        //        e.Handled = true;
        //        return;
        //    }
        //}

        //public Boolean ValidateTextBox(List<TextBox> tbox, List<String> message)
        //{
        //    Boolean txt = true;
        //    if (tbox.Count() == message.Count())
        //    {
        //        //ErrorMessage.error = new List<string>();
        //        for (int I = 0; I < tbox.Count(); I++)
        //        {
        //            if (tbox[I].Text.Trim().Equals(""))
        //            {
        //                ErrorMessage.error.Add(message[I]);
        //                ErrorMessage.txtactual.Add(tbox[I]);
        //                txt = false;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        ErrorMessage.error.Add("Datos incorrectos");
        //        txt = false;
        //    }

        //    return txt;
        //}

        //public Boolean ValidateTextBoxCondition(List<TextBox> tbox, List<Int32> condition, List<String> message)
        //{
        //    Boolean txt = true;
        //    if (tbox.Count() == message.Count())
        //    {
        //        //ErrorMessage.error = new List<string>();
        //        for (int I = 0; I < tbox.Count(); I++)
        //        {
        //            if (tbox[I].Text.Trim().Length != condition[I])
        //            {
        //                ErrorMessage.error.Add(message[I]);
        //                ErrorMessage.txtactual.Add(tbox[I]);
        //                txt = false;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        ErrorMessage.error.Add("Datos incorrectos");
        //        txt = false;
        //    }

        //    return txt;
        //}

        //public Boolean ValidateUser(List<TextBox> tbox, List<Boolean> condition, List<String> message)
        //{
        //    Boolean txt = true;
        //    if (tbox.Count() == message.Count())
        //    {
        //        for (int I = 0; I < tbox.Count(); I++)
        //        {
        //            if (tbox[I].Text.Trim().Equals("") && condition[I] == false)
        //            {
        //                ErrorMessage.error.Add(message[I]);
        //                ErrorMessage.txtactual.Add(tbox[I]);
        //                txt = false;
        //            }
        //            else if (tbox[1].Text.Trim() != tbox[2].Text.Trim() && condition[I] == false)
        //            {
        //                ErrorMessage.error.Add(message[2]);
        //                ErrorMessage.txtactual.Add(tbox[2]);
        //                txt = false;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        ErrorMessage.error.Add("Datos incorrectos");
        //        txt = false;
        //    }

        //    return txt;
        //}

        //public Boolean ValidateComboBoxNation(List<ComboBox> tbox, List<String> message)
        //{
        //    Boolean txt = true;
        //    //ErrorMessage.error = new List<string>();

        //    if (tbox.Count() == message.Count())
        //    {
        //        for (int I = 0; I < tbox.Count(); I++)
        //        {
        //            if (tbox[I].SelectedItem == null)
        //            {
        //                ErrorMessage.error.Add(message[I]);
        //                txt = false;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        ErrorMessage.error.Add("Datos incorrectos");
        //        txt = false;
        //    }

        //    return txt;
        //}
    }
}
