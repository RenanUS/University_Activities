namespace Aula62
{
    public partial class F_Principal : Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (Tb_Veículo.Text == "")
            {
                MessageBox.Show("Digite um nome válido");
                Tb_Veículo.Focus();
                return;
            }

            Tb_ListaVeículos.Text += Tb_Veículo.Text + ", ";
            //Tb_ListaVeículos.Text = Tb_ListaVeículos.Text + Tb_Veículo.Text;
            Tb_Veículo.Clear();
            Tb_Veículo.Focus();

        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Tb_ListaVeículos.Clear();
            Tb_Veículo.Clear();
            Tb_Veículo.Focus();
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Tb_ListaVeículos.Text, this);
            form2.ShowDialog();
        }

        private void Btn_ValNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkedLIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }
    }
}