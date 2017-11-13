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

        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
