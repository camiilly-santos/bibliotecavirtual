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
    public partial class Culpa_estrela : Form
    {
        public Culpa_estrela()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Iniciar_sessao iniciar_Sessao = new Iniciar_sessao();
            this.Visible = false;
            iniciar_Sessao.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Confirmacao confirmacao = new Confirmacao();
            this.Visible = false;
            confirmacao.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Confirmacao confirmacao = new Confirmacao();
            this.Visible = false;
            confirmacao.ShowDialog();
            this.Visible = true;
        }
    }
}
