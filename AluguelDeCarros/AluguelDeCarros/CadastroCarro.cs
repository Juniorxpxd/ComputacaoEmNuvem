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
        Plano plano = new Plano();
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
                IEnumerable<Carro> carros = CarroDAO.ObterCarrosPelaEmpresa(carro);
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
                                                    if (CarroDAO.obterPlaca(carro) == null)
                                                    { 
                                                        if (carro.Empresa.Plano.PlanoCarro == "Pequeno" || carro.Empresa.Plano.PlanoCarro == "pequeno")
                                                        {
                                                            if (empresa.Carro.Count < 50)
                                                            {
                                                                carro.Placa = txtPlaca.Text;
                                                                carro.Nome = txtNome.Text;
                                                                carro.Cambio = txtCambio.Text;
                                                                carro.Cor = txtCor.Text;
                                                                carro.Marca = txtMarca.Text;
                                                                carro.Quilometragem = txtQuilometragem.Text;
                                                                carro.Portas = int.Parse(txtPorta.Text);
                                                                carro.Ano = int.Parse(txtAno.Text);
                                                                carro.Preco = double.Parse(txtPreco.Text);
                                                                carro.EstadoDisp = true;
                                                                CarroDAO.Incluir(carro);

                                                                MessageBox.Show("O cadastro do carro: " + carro.Nome + " foi concluido com sucesso", "Cadastrado");
                                                                this.Close();
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Limite Atingido de 50 Carros", "Limite Atingido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            carro.Placa = txtPlaca.Text;
                                                            carro.Nome = txtNome.Text;
                                                            carro.Cambio = txtCambio.Text;
                                                            carro.Cor = txtCor.Text;
                                                            carro.Marca = txtMarca.Text;
                                                            carro.Quilometragem = txtQuilometragem.Text;
                                                            carro.Portas = int.Parse(txtPorta.Text);
                                                            carro.Ano = int.Parse(txtAno.Text);
                                                            carro.Preco = double.Parse(txtPreco.Text);
                                                            carro.EstadoDisp = true;
                                                            CarroDAO.Incluir(carro);

                                                            MessageBox.Show("O cadastro do carro: " + carro.Nome + " foi concluido com sucesso", "Cadastrado");
                                                            this.Close();
                                                        }
                                                    }
                                                    else
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

        private void txtPorta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void CadastroCarro_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            empresa.Email = this.email;
            empresa = EmpresaDAO.BuscarEmpresaPorEmail(empresa);
            carro.Empresa = empresa;
            IEnumerable<Carro> carros = CarroDAO.ObterCarrosPelaEmpresa(carro);
            foreach (Carro x in carros)
            {
                lista.Add(x.Nome);
            }
        }
    }
}
