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
    public partial class Form2 : Form
    {
        F_Principal fp;
        public Form2(String V, F_Principal f)
        {
            InitializeComponent();

            Tb_ListaVeículos.Text = V;

            fp = f;
            f.num = 10;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.Tb_ListaVeículos.Text = Tb_ListaVeículos.Text;
        }
    }
}
