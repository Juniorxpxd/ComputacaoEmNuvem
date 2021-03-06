﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelDeCarros
{
    public partial class TelaPrecos : Form
    {
        public TelaPrecos()
        {
            InitializeComponent();
        }

        private void btnAssinarPequeno_Click(object sender, EventArgs e)
        {
            CadastroEmpresa cadEmpresa = new CadastroEmpresa();
            cadEmpresa.ShowDialog();
        }

        private void btnAssinarGigante_Click(object sender, EventArgs e)
        {
            CadastroEmpresa cadEmpresa = new CadastroEmpresa();
            cadEmpresa.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
