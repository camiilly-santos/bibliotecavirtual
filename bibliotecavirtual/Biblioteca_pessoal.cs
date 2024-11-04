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
    }
}
