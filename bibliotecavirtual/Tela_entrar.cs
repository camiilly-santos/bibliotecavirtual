using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotecavirtual
{
    public partial class Tela_entrar : Form
    {
        public Tela_entrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbUser.Text == "Camilly Caetano" && txbPass.Text == "081807")
            {
                txbUser.Text = String.Empty;
                txbPass.Text = String.Empty;
                txbUser.Focus();
                Iniciar_sessao iniciar_Sessao = new Iniciar_sessao();
                this.Visible = false;
                iniciar_Sessao.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos",
                    "ERRO NO LOGIN",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
