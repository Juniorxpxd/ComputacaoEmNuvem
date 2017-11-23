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

            }
            catch (SqlException)
            {
                MessageBox.Show("nao deletado");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Equals(""))
            {

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
                }
                catch
                {
                    MessageBox.Show("Cliente não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                    txtEmail.Focus();
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
            catch (SqlException)
            {
                MessageBox.Show("não aterado");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void mskTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
