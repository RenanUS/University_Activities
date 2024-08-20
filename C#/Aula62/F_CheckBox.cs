using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula62
{
    public partial class F_CheckBox : Form
    {
        List<CheckBox> Transp = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            Transp.Add(Cb_Carro);
            Transp.Add(Cb_Avião);
            Transp.Add(Cb_Navio);
        }

        private void Btn_Transportes_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (CheckBox T in Transp)
            {
                if (T.Checked)
                {
                    txt += T.Text + ", ";
                }
            }
            if (Cb_Ônibus.Checked)
            {
                txt += Cb_Ônibus.Text + ".";
            }
            MessageBox.Show(txt);
        }

        private void Cb_Patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Patinete.Checked)
            {
                MessageBox.Show("Patinete Marcada");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_FilhoCheckBox f_FilhoCheckBox = new F_FilhoCheckBox();
            f_FilhoCheckBox.ShowDialog();
        }
    }
}
