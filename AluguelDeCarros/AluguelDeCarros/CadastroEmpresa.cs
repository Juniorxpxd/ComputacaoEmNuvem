using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AluguelDeCarros.Model;
using AluguelDeCarros.DAO;

namespace AluguelDeCarros
{
    public partial class CadastroEmpresa : Form
    {
        Empresa empresa = new Empresa();
        public CadastroEmpresa()
        {
            InitializeComponent();
        }
        public void dbInsert()
        {
            try
            {

                if (!txtNome.Text.Equals(""))
                {
                    if (!mskCel.Text.Equals(""))
                    {
                        if (!txtCid.Text.Equals(""))
                        {
                            if (!mskCNPJ.Text.Equals(""))
                            {
                                if (!txtEmail.Text.Equals(""))
                                {
                                    if (!txtEst.Text.Equals(""))
                                    {
                                        if (!txtNomeEmpresa.Text.Equals(""))
                                        {
                                            if (!txtRua.Text.Equals(""))
                                            {
                                                if (!txtSenha.Text.Equals(""))
                                                {
                                                    if (!mskTel.Text.Equals(""))
                                                    {
                                                        if (!cmbPlano.Text.Equals(""))
                                                        {
                                                            empresa.NomeEmpresa = txtNomeEmpresa.Text;
                                                            if (EmpresaDAO.BuscarEmpresaPorNomeEmpresa(empresa) == null)
                                                            {
                                                                empresa.NomeEmpresa = txtNomeEmpresa.Text;
                                                                empresa.Email = txtEmail.Text;
                                                                if (EmpresaDAO.BuscarEmpresaPorEmail(empresa) == null)
                                                                {
                                                                    empresa.Email = txtEmail.Text;
                                                                    empresa.CNPJ = mskCNPJ.Text;
                                                                    if (EmpresaDAO.BuscarEmpresaPorCNPJ(empresa) == null)
                                                                    {
                                                                        empresa.CNPJ = mskCNPJ.Text;
                                                                        empresa.Nome = txtNome.Text;
                                                                        empresa.Celular = mskCel.Text;
                                                                        empresa.Cidade = txtCid.Text;
                                                                        empresa.Estado = txtEst.Text;
                                                                        empresa.Rua = txtRua.Text;
                                                                        empresa.Senha = txtSenha.Text;
                                                                        empresa.Telefone = mskTel.Text;
                                                                        Plano Plano = new Plano();
                                                                        Plano.PlanoCarro = cmbPlano.Text;
                                                                        Plano = PlanoDAO.NomeMesmo(Plano);
                                                                        empresa.Plano = Plano;
                                                                        EmpresaDAO.Incluir(empresa);

                                                                        MessageBox.Show("O cadastro da empresa: " + empresa.NomeEmpresa + " foi concluido com sucesso", "Cadastrado");
                                                                        this.Close();
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("CNPJ já foi Registrado.", "CNPJ já Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Email já foi Registrado.", "Email já Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Nome de Empresa já foi Registrado.", "Nome de Empresa já Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("O campo Plano é de obrigatória seleção.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("O campo Telefone é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("O campo Senha é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("O campo Rua é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("O campo Nome Empresa é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("O campo Estado é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("O campo Email é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("O campo CNPJ é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("O campo Cidade é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O campo Celular é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void mskCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void mskTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void mskCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {
            foreach (Plano x in PlanoDAO.obterPlanos())
            {
                cmbPlano.Items.Add(x.PlanoCarro);
            }
        }
    }
}
