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
    public partial class Lista_desejo : Form
    {
        public Lista_desejo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Antes_voce antes_Voce = new Antes_voce();
            this.Visible = false;
            antes_Voce.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            It_coisa it_Coisa = new It_coisa();
            this.Visible = false;
            it_Coisa.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Culpa_minha culpa_Minha = new Culpa_minha();
            this.Visible = false;
            culpa_Minha.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Iniciar_sessao iniciar_Sessao = new Iniciar_sessao();
            this.Visible = false;
            iniciar_Sessao.ShowDialog();
            this.Visible = true;
        }
    }
}
