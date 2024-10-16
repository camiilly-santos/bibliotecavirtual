﻿using System;
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
    public partial class Iniciar_sessao : Form
    {
        public Iniciar_sessao()
        {
            InitializeComponent();
        }

        private void Iniciar_sessao_Load(object sender, EventArgs e)
        {

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
            Montar_biblioteca montar_Biblioteca = new Montar_biblioteca();
            this.Visible = false;
            montar_Biblioteca.ShowDialog();
            this.Visible = true;
        }
    }
}