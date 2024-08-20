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
            if (Tb_Ve�culo.Text == "")
            {
                MessageBox.Show("Digite um nome v�lido");
                Tb_Ve�culo.Focus();
                return;
            }

            Tb_ListaVe�culos.Text += Tb_Ve�culo.Text + ", ";
            //Tb_ListaVe�culos.Text = Tb_ListaVe�culos.Text + Tb_Ve�culo.Text;
            Tb_Ve�culo.Clear();
            Tb_Ve�culo.Focus();

        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Tb_ListaVe�culos.Clear();
            Tb_Ve�culo.Clear();
            Tb_Ve�culo.Focus();
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Tb_ListaVe�culos.Text, this);
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