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
    public partial class Tel_cadastro : Form
    {
        public Tel_cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            this.Visible = false;
            perfil.ShowDialog();
            this.Visible = true;
        }
    }
}
