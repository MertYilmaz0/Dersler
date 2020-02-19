using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Hamburgerci
{
    public static class Fonksiyon
    {
        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control ctrl in koleksiyon)
            {
                if(ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    txt.Clear();
                }
                else if(ctrl is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctrl;
                    chk.Checked = false;
                }
                else if(ctrl is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctrl;
                    if (rb.Name == "Küçük")
                    {
                        rb.Checked = true;
                    }
                    else
                    {
                        rb.Checked = false;
                    }
                }
                else if(ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 0;
                }
                else if(ctrl is GroupBox)
                {
                    GroupBox gb = (GroupBox)ctrl;
                    Temizle(gb.Controls);
                }
                else if(ctrl is FlowLayoutPanel)
                {
                    FlowLayoutPanel flw = (FlowLayoutPanel)ctrl;
                    Temizle(flw.Controls);
                }
                else if(ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;
                }
            }
        }
    }
}
