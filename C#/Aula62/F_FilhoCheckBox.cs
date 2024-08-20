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
    public partial class F_FilhoCheckBox : Form
    {
        public F_CheckBox fcb;
        public F_FilhoCheckBox()
        {
            InitializeComponent();
            try 
            {
                fcb = Application.OpenForms["F_CheckBox"] as F_CheckBox;
                Cb_Carro.Checked = fcb.Cb_Carro.Checked;
                Cb_Avião.Checked = fcb.Cb_Avião.Checked;
                Cb_Navio.Checked = fcb.Cb_Navio.Checked;
                Cb_Ônibus.Checked = fcb.Cb_Ônibus.Checked;
            }
            catch 
            {
                MessageBox.Show("Erro ao abrir o formulário");
            }
        }

        private void Cb_Carro_CheckedChanged(object sender, EventArgs e)
        {
            fcb.Cb_Carro.Checked = Cb_Carro.Checked;
        }

        private void Cb_Avião_CheckedChanged(object sender, EventArgs e)
        {
            fcb.Cb_Avião.Checked = Cb_Avião.Checked;
        }

        private void Cb_Navio_CheckedChanged(object sender, EventArgs e)
        {
            fcb.Cb_Navio.Checked = Cb_Navio.Checked;
        }

        private void Cb_Ônibus_CheckedChanged(object sender, EventArgs e)
        {
            fcb.Cb_Ônibus.Checked = Cb_Ônibus.Checked;
        }
    }
}