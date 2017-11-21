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
        public EditarExcluirCadastroCliente()
        {
            InitializeComponent();
        }
        Cliente cliente = new Cliente();
        private void EditarExcluirCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Email = txtEmail.Text;
                cliente = ClienteDAO.BuscarClientePorEmailESenha(cliente);
                ClienteDAO.Excluir(cliente);

            }catch(SqlException)
            {
                MessageBox.Show("nao deletado");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Equals(""))
            {                
                

                cliente.Email = txtEmail.Text;
                cliente = ClienteDAO.BuscarClientePorEmailESenha(cliente);
                if (cliente != null)
                {
                    cliente.Nome = txtNome.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Senha = txtSenha.Text;
                    cliente.Cpf = mskCPF.Text;
                    cliente.Rg = mskRG.Text;
                    cliente.Telefone = mskTel.Text;
                    cliente.Celular = mskCel.Text;
                    cliente.Rua = txtRua.Text;
                    cliente.Cidade = txtCid.Text;
                    cliente.Estado = txtEst.Text;
                    cliente.Numero = int.Parse(txtNumero.Text);
                }else
                {
                    MessageBox.Show("cliente nao encontrado");
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Nome = txtNome.Text;
                cliente.Email = txtEmail.Text;
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
                MessageBox.Show("alterado com sucesso");
            }
            catch(SqlException)
            {
                MessageBox.Show("não aterado");
            }
        }
    }
}
