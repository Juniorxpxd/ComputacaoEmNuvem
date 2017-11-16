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
                ClienteDAO.Incluir(cliente);

                MessageBox.Show("O seu cadastro: " + cliente.Nome + " foi concluido com sucesso", "Cadastrado");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
