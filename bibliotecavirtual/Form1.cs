namespace bibliotecavirtual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_entrar tela_Entrar = new Tela_entrar();
            this.Visible = false;
            tela_Entrar.ShowDialog();
            this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tel_cadastro tel_Cadastro = new Tel_cadastro();
            this.Visible = false;
            tel_Cadastro.ShowDialog();
            this.Visible = true;
        }
    }
}
