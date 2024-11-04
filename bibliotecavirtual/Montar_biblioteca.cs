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
    public partial class Montar_biblioteca : Form
    {
        public Montar_biblioteca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            E_acaba e_Acaba = new E_acaba();
            this.Visible = false;
            e_Acaba.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Iniciar_sessao iniciar_Sessao = new Iniciar_sessao();
            this.Visible = false;
            iniciar_Sessao.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Culpa_estrela culpa_Estrela = new Culpa_estrela();
            this.Visible = false;
            culpa_Estrela.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Meia_noite meia_Noite = new Meia_noite();
            this.Visible = false;
            meia_Noite.ShowDialog();
            this.Visible = true;
        }
    }

}
