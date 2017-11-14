using System;
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
    public partial class MenuEmpresa : Form
    {
        private string email;

        public MenuEmpresa(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCliente = new CadastroCliente();
            cadCliente.ShowDialog();
        }

        private void btnCadCarro_Click(object sender, EventArgs e)
        {
            CadastroCarro cadCarro = new CadastroCarro(this.email);
            cadCarro.ShowDialog();
        }

        private void btnCadEmpresa_Click(object sender, EventArgs e)
        {
            CadastroEmpresa cadEmpresa = new CadastroEmpresa();
            cadEmpresa.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            TelaCarro listaCarro = new TelaCarro();
            listaCarro.ShowDialog();
        }
    }
}
