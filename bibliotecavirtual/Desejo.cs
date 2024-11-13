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
    public partial class Desejo : Form
    {
        public Desejo()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vermelho vermelho = new Vermelho();
            this.Visible = false;
            vermelho.ShowDialog();
            this.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            John john = new John();
            this.Visible = false;
            john.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            E_comeca e_Comeca = new E_comeca();
            this.Visible = false;
            e_Comeca.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Selecao selecao = new Selecao();
            this.Visible = false;
            selecao.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orgulho_preconceito orgulho_Preconceito = new Orgulho_preconceito();
            this.Visible = false;
            orgulho_Preconceito.ShowDialog();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Setembro setembro = new Setembro();
            this.Visible = false;
            setembro.ShowDialog();
            this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hipotese_amor hipotese_Amor = new Hipotese_amor();
            this.Visible = false;
            hipotese_Amor.ShowDialog();
            this.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Teto_dois teto_Dois = new Teto_dois();
            this.Visible = false;
            teto_Dois.ShowDialog();
            this.Visible = true;
        }
    }
}
