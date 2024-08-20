namespace Aula61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            Lb_nome.Text = Tb_1.Text;
        }
    }
}