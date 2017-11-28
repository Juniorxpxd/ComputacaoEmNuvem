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
    public partial class EditarExcluirCadastroCliente : Form
    {
        private string email;
        public EditarExcluirCadastroCliente(string email)
        {
            this.email = email;
            InitializeComponent();
        }
        Cliente cliente = new Cliente();
        Empresa empresa = new Empresa();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Email = txtEmail.Text;
                cliente = ClienteDAO.BuscarCLientePorEmail(cliente);
                cliente.Nome = txtNome.Text;
                cliente.Senha = txtSenha.Text;
                cliente.Cpf = mskCPF.Text;
                cliente.Rg = mskRG.Text;
                cliente.Telefone = mskTel.Text;
                cliente.Celular = mskCel.Text;
                cliente.Rua = txtRua.Text;
                cliente.Cidade = txtCid.Text;
                cliente.Estado = txtEst.Text;
                cliente.Numero = int.Parse(txtNumero.Text);
                ClienteDAO.Editar(cliente);
                MessageBox.Show("Cadastro do cliente: " + cliente.Nome + " foi alterado !!!", "Alterado");
            }
            catch
            {
                MessageBox.Show(e + "Erro ao Alterar Cadastro", "Erro");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            empresa.Email = this.email;
            empresa = EmpresaDAO.BuscarEmpresaPorEmail(empresa);
            cliente.Empresa = empresa;
            cliente.Email = txtEmail.Text;
            cliente = ClienteDAO.BuscarCLientePorEmail(cliente);
            if (cliente.Empresa == empresa)
            {
                if (!txtEmail.Equals(""))
                {
                    Cliente cliente = new Cliente();
                    try
                    {
                        cliente.Email = txtEmail.Text;
                        cliente = ClienteDAO.BuscarCLientePorEmail(cliente);
                        txtNome.Text = cliente.Nome;
                        txtEmail.Text = cliente.Email;
                        txtSenha.Text = cliente.Senha;
                        mskCPF.Text = cliente.Cpf;
                        mskRG.Text = cliente.Rg;
                        mskTel.Text = cliente.Telefone;
                        mskCel.Text = cliente.Celular;
                        txtRua.Text = cliente.Rua;
                        txtCid.Text = cliente.Cidade;
                        txtEst.Text = cliente.Estado;
                        txtNumero.Text = cliente.Numero.ToString();

                        txtNome.Enabled = true;
                        txtEmail.Enabled = true;
                        txtSenha.Enabled = true;
                        mskCPF.Enabled = true;
                        mskRG.Enabled = true;
                        mskTel.Enabled = true;
                        mskCel.Enabled = true;
                        txtRua.Enabled = true;
                        txtCid.Enabled = true;
                        txtEst.Enabled = true;
                        txtNumero.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Cliente não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Clear();
                        txtEmail.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Cliente não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Email = txtEmail.Text;
                cliente = ClienteDAO.BuscarCLientePorEmail(cliente);
                if (cliente != null)
                {
                    ClienteDAO.Excluir(cliente);
                    MessageBox.Show("Cliente Excluido", "Excluido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cliente inexistente", "Erro");
                }
            }
            catch
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
