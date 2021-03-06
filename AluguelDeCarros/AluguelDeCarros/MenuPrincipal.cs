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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnPlanos_Click(object sender, EventArgs e)
        {
            TelaPrecos precos = new TelaPrecos();
            precos.ShowDialog();
        }

        private void btnLoginEmpresa_Click(object sender, EventArgs e)
        {
            TelaDeLoginEmpresa loginEmpresa = new TelaDeLoginEmpresa();
            loginEmpresa.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            TelaDeLoginCliente loginCliente = new TelaDeLoginCliente();
            loginCliente.ShowDialog();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CadastrarPlano CadastrarPlano = new CadastrarPlano();
            CadastrarPlano.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
