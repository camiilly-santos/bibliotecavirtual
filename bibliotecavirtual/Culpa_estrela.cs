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
            Montar_biblioteca montar_Biblioteca = new Montar_biblioteca();
            this.Visible = false;
            montar_Biblioteca.ShowDialog();
            this.Visible = true;
        }
    }
}
