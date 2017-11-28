using AluguelDeCarros.DAO;
using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelDeCarros
{
    public partial class PerfilCliente : Form
    {
        private string email;
        Empresa empresa = new Empresa();
        Carro carro = new Carro();
        Cliente cliente = new Cliente();
        Alugado alugado = new Alugado();
        Equipado equipado = new Equipado();
        public PerfilCliente(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void PerfilCliente_Load(object sender, EventArgs e)
        {
            cliente.Email = this.email;
            cliente = ClienteDAO.BuscarCLientePorEmail(cliente);
            empresa.Email = cliente.Empresa.Email;
            empresa = EmpresaDAO.BuscarEmpresaPorEmail(empresa);
            lblEmpresa.Text = empresa.NomeEmpresa;
            alugado.Cliente = cliente;
            alugado = AlugadoDAO.ObterAluguelPorCliente(alugado);
            lblCPF.Text = cliente.Cpf;
            lblEmail.Text = cliente.Email;
            lblNome.Text = cliente.Nome;
            if (alugado != null)
            {
                carro.Empresa = empresa;
                carro = CarroDAO.ObterCarroPorEmpresa(carro);
                alugado.Carro = carro;
                lblCarroo.Text = carro.Nome;
                EquipadoDAO.BuscarCarroEquipadoPorRecibo(alugado);
                double total = alugado.Valor + equipado.ValorTotal;
                lblReciboo.Text = alugado.Id.ToString();
                lblTotal.Text = total.ToString("C2");
                lblDataEntrega.Text = alugado.DiasAlugado.ToString();
            }
            else
            {
                lblReciboo.Text = "";
                lblTotal.Text = "";
                lblDataEntrega.Text = "";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
