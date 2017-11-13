using AluguelDeCarros.DAO;
using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelDeCarros
{
    public partial class CadastroCarro : Form
    {
        Carro carro = new Carro();
        Empresa empresa = new Empresa();
        private string email;

        public CadastroCarro(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        public void dbInsert()
        {
            try
            {
                empresa.Email = this.email;
                empresa = EmpresaDAO.BuscarEmpresaPorEmail(empresa);
                carro.Empresa = empresa;
                carro.Nome = txtNome.Text;
                carro.Cambio = txtCambio.Text;
                carro.Cor = txtCor.Text;
                carro.Marca = txtMarca.Text;
                carro.Quilometragem = txtQuilometragem.Text;
                carro.Placa = txtPlaca.Text;
                carro.Portas = int.Parse(txtPorta.Text);
                carro.Ano = int.Parse(txtPorta.Text);
                carro.Preco = txtPreco.Text;
                CarroDAO.Incluir(carro);

                MessageBox.Show("O cadastro do carro: " + carro.Nome + " foi concluido com sucesso", "Cadastrado");
                this.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e + "Erro ao cadastrar", "Erro");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dbInsert();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
