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
    }
}
