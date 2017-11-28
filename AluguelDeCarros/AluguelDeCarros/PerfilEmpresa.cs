using AluguelDeCarros.DAO;
using AluguelDeCarros.Model;
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
        Empresa empresa = new Empresa();
        Carro carro = new Carro();
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

        private void PerfilEmpresa_Load(object sender, EventArgs e)
        {
            empresa.Email = this.email;
            empresa = EmpresaDAO.BuscarEmpresaPorEmail(empresa);
            carro.Empresa = empresa;
            IEnumerable<Carro> carros = CarroDAO.ObterCarrosPelaEmpresa(carro);
            lblCarros.Text = empresa.Carro.Count.ToString();
        }
    }
}
