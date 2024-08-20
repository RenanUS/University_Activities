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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void Btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (string t in Clb_Transportes.CheckedItems)
            {
                txt += t + ", ";
            }

            MessageBox.Show(txt);
        }

        private void Btn_LimparLista_Click(object sender, EventArgs e)
        {
            Clb_Transportes.Items.Clear();
        }

        private void Btn_ResetarLista_Click(object sender, EventArgs e)
        {
            Clb_Transportes.Items.Clear();

            List<string> Tr = new List<string>();
            Tr.Add("Carro");
            Tr.Add("Avião");
            Tr.Add("Navio");
            Tr.Add("Ônibus");
            Tr.Add("Trem");
            Clb_Transportes.Items.AddRange(Tr.ToArray());
        }

        private void Btn_AddNovoTransporte_Click(object sender, EventArgs e)
        {
            if(Tb_NovoTransporte.Text != "") 
            {
                Clb_Transportes.Items.Add(Tb_NovoTransporte.Text);
                Tb_NovoTransporte.Clear();
                Tb_NovoTransporte.Focus();
            }
            else 
            {
                MessageBox.Show("Digite um nome válido");
            }
        }
    }
}
