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
    }
}
