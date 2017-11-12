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
        public MenuEmpresa()
        {
            InitializeComponent();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCliente = new CadastroCliente();
            cadCliente.ShowDialog();
        }

        private void btnCadCarro_Click(object sender, EventArgs e)
        {
            CadastroCarro cadCarro = new CadastroCarro();
            cadCarro.ShowDialog();
        }

        private void btnCadEmpresa_Click(object sender, EventArgs e)
        {
            CadastroEmpresa cadEmpresa = new CadastroEmpresa();
            cadEmpresa.ShowDialog();
        }
    }
}
