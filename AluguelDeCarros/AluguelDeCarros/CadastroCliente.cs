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
    public partial class CadastroCliente : Form
    {
        Cliente cliente = new Cliente();
        public CadastroCliente()
        {
            InitializeComponent();
        }

        public void dbInsert()
        {
            try
            {
                if (!txtNome.Text.Equals(""))
                {
                    if (!txtEmail.Text.Equals(""))
                    {
                        if (!txtSenha.Text.Equals(""))
                        {
                            if (!mskCPF.Text.Equals(""))
                            {
                                if (!mskRG.Text.Equals(""))
                                {
                                    if (!mskTel.Text.Equals(""))
                                    {
                                        if (!mskCel.Text.Equals(""))
                                        {
                                            if (!txtRua.Text.Equals(""))
                                            {
                                                if (!txtCid.Text.Equals(""))
                                                {
                                                    if (!txtEst.Text.Equals(""))
                                                    {
                                                        if (!txtNumero.Text.Equals(""))
                                                        {
                                                            cliente.Email = txtEmail.Text;
                                                            if (ClienteDAO.BuscarCLientePorEmail(cliente) == null)
                                                            {
                                                                cliente.Email = txtEmail.Text;
                                                                cliente.Cpf = mskCPF.Text;
                                                               
                                                                if (ClienteDAO.BuscarClientePorCPF(cliente) == null)
                                                                {
                                                                    cliente.Cpf = mskCPF.Text;
                                                                    cliente.Rg = mskRG.Text;
                                                                    if (ClienteDAO.BuscarClientePorRG(cliente) == null)
                                                                    {
                                                                        cliente.Rg = mskRG.Text;
                                                                        cliente.Nome = txtNome.Text;

                                                                        cliente.Senha = txtSenha.Text;
                                                                        cliente.Telefone = mskTel.Text;
                                                                        cliente.Celular = mskCel.Text;
                                                                        cliente.Rua = txtRua.Text;
                                                                        cliente.Cidade = txtCid.Text;
                                                                        cliente.Estado = txtEst.Text;
                                                                        cliente.Numero = int.Parse(txtNumero.Text);
                                                                        ClienteDAO.Incluir(cliente);
                                                                        this.Close();

                                                                        MessageBox.Show("O seu cadastro: " + cliente.Nome + " foi concluido com sucesso", "Cadastrado");
                                                                    }else
                                                                    {
                                                                        MessageBox.Show("RG já foi Registrado.", "RG já Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("CPF já foi Registrado.", "CPF já Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                }
                                                            }else
                                                            {
                                                                MessageBox.Show("Email já foi Registrado.", "Email já Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("O campo Número é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("O campo Estado é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("O campo Cidade é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("O campo Rua é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("O campo Celular é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("O campo Telefone é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("O campo RG é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }
                            else
                            {
                                MessageBox.Show("O campo CPF é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }

                        }
                        else
                        {
                            MessageBox.Show("O campo Senha é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("O campo Email é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
