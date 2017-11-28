using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AluguelDeCarros.DAO;
using AluguelDeCarros.Model;
using System.Data.SqlClient;

namespace AluguelDeCarros
{
    public partial class EditarExcluirCadastroCarro : Form
    {
        Carro carro = new Carro();
        Empresa empresa = new Empresa();
        private string email;
        public EditarExcluirCadastroCarro(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtPlaca.Text.Equals(""))
            {
                try
                {

                    Carro carro = new Carro();
                    carro.Placa = txtPlaca.Text;
                    carro = CarroDAO.obterPlaca(carro);
                    carro.Nome = txtNome.Text;
                    carro.Cambio = txtCambio.Text;
                    carro.Cor = txtCor.Text;
                    carro.Marca = txtMarca.Text;
                    carro.Quilometragem = txtQuilometragem.Text;
                    carro.Portas = int.Parse(txtPorta.Text);
                    carro.Ano = int.Parse(txtAno.Text);
                    carro.Preco = double.Parse(txtPreco.Text);
                    carro.EstadoDisp = true;
                    CarroDAO.Editar(carro);
                    MessageBox.Show("Cadastro do carro: " + carro.Nome + " foi alterado !!!", "Alterado");
                }
                catch
                {
                    MessageBox.Show(e + "Erro ao Alterar Cadastro", "Erro");
                }
            }
            else
            {
                MessageBox.Show("O campo Placa é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtPlaca.Text.Equals(""))
            {
                empresa.Email = this.email;
                empresa = EmpresaDAO.BuscarEmpresaPorEmail(empresa);
                carro.Empresa = empresa;
                carro.Placa = txtPlaca.Text;
                carro = CarroDAO.obterPlaca(carro);
                if (carro != null)
                {
                    if (carro.Empresa == empresa)
                    {

                        Carro carro = new Carro();
                        try
                        {
                            carro.Placa = txtPlaca.Text;
                            carro = CarroDAO.obterPlaca(carro);
                            txtNome.Text = carro.Nome;
                            txtCambio.Text = carro.Cambio;
                            txtCor.Text = carro.Cor;
                            txtMarca.Text = carro.Marca;
                            txtQuilometragem.Text = carro.Quilometragem;
                            txtPorta.Text = carro.Portas.ToString();
                            txtAno.Text = carro.Ano.ToString();
                            txtPreco.Text = carro.Preco.ToString();

                            txtNome.Enabled = true;
                            txtCambio.Enabled = true;
                            txtCor.Enabled = true;
                            txtMarca.Enabled = true;
                            txtQuilometragem.Enabled = true;
                            txtPorta.Enabled = true;
                            txtAno.Enabled = true;
                            txtPreco.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Carro não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPlaca.Clear();
                            txtPlaca.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Carro não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Carro não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O campo Placa é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                Carro Carro = new Carro();
                Carro.Placa = txtPlaca.Text;
                Carro = CarroDAO.obterPlaca(Carro);
                if (Carro != null)
                {
                    CarroDAO.Excluir(Carro);
                    MessageBox.Show("Carro Excluido", "Excluido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Carro inexistente", "Erro");
                }
            }
            catch
            {
                MessageBox.Show("Carro inexistente", "Erro");
            }
        }
    }
}