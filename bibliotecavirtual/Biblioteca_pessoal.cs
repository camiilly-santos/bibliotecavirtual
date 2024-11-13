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
    public partial class Biblioteca_pessoal : Form
    {
        public Biblioteca_pessoal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Iniciar_sessao iniciar_Sessao = new Iniciar_sessao();
            this.Visible = false;
            iniciar_Sessao.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lady_killers lady_Killers = new Lady_killers();
            this.Visible = false;
            lady_Killers.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Amor_gelato amor_gelato = new Amor_gelato();
            this.Visible = false;
            amor_gelato.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Amanhecer amanhecer = new Amanhecer();
            this.Visible = false;
            amanhecer.ShowDialog();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Culpa_minha culpa_Minha = new Culpa_minha();
            this.Visible = false;
            culpa_Minha.ShowDialog();
            this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Meia_noite meia_noite = new Meia_noite();
            this.Visible = false;
            meia_noite.ShowDialog();
            this.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            It_coisa it_Coisa = new It_coisa();
            this.Visible = false;
            it_Coisa.ShowDialog();
            this.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            E_acaba e_Acaba = new E_acaba();
            this.Visible = false;
            e_Acaba.ShowDialog();
            this.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Antes_voce antes_Voce = new Antes_voce();
            this.Visible = false;
            antes_Voce.ShowDialog();
            this.Visible = true;
        }
    }
}
