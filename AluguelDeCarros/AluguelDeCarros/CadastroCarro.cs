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
                if (!txtNome.Text.Equals(""))
                {
                    if (!txtCambio.Text.Equals(""))
                    {
                        if (!txtCor.Text.Equals(""))
                        {
                            if (!txtMarca.Text.Equals(""))
                            {
                                if (!txtQuilometragem.Text.Equals(""))
                                {
                                    if (!txtPlaca.Text.Equals(""))
                                    {
                                        if (!txtPorta.Text.Equals(""))
                                        {
                                            if (!txtAno.Text.Equals(""))
                                            {
                                                if (!txtPreco.Text.Equals(""))
                                                {
                                                    carro.Placa = txtPlaca.Text;
                                                    if (CarroDAO.BuscarCarroPorPlaca(carro) == null)
                                                    {
                                                        carro.Placa = txtPlaca.Text;
                                                        carro.Nome = txtNome.Text;
                                                        carro.Cambio = txtCambio.Text;
                                                        carro.Cor = txtCor.Text;
                                                        carro.Marca = txtMarca.Text;
                                                        carro.Quilometragem = txtQuilometragem.Text;
                                                        carro.Portas = int.Parse(txtPorta.Text);
                                                        carro.Ano = int.Parse(txtAno.Text);
                                                        carro.Preco = txtPreco.Text;
                                                        carro.EstadoDisp = true;
                                                        CarroDAO.Incluir(carro);

                                                        MessageBox.Show("O cadastro do carro: " + carro.Nome + " foi concluido com sucesso", "Cadastrado");
                                                        this.Close();
                                                    }else
                                                    {
                                                        MessageBox.Show("Placa já foi Registrado.", "Placa já Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("O campo Preço é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("O campo Ano é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("O campo Portas é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("O campo Placa é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("O campo Quilometragem é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("O campo Marca é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        else
                        {
                            MessageBox.Show("O campo Cor é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    else
                    {
                        MessageBox.Show("O campo Câmbio é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("O campo Nome é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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
