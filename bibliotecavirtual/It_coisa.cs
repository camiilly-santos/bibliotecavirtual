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
    public partial class It_coisa : Form
    {
        public It_coisa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista_desejo lista_Desejo = new Lista_desejo();
            this.Visible = false;
            lista_Desejo.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Confirmacao confirmacao = new Confirmacao();
            this.Visible = false;
            confirmacao.ShowDialog();
            this.Visible = true;
        }
    }
}
