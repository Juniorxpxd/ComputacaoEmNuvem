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
    public partial class PerfilEmpresa : Form
    {
        private string email;
        public PerfilEmpresa(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarExcluirCadastroCarro a = new EditarExcluirCadastroCarro(this.email);
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditarExcluirCadastroCliente b = new EditarExcluirCadastroCliente(this.email);
            b.ShowDialog();
        }
    }
}
