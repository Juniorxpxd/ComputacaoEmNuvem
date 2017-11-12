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
                empresa.Nome = txtNome.Text;
                empresa.Celular = mskCel.Text;
                empresa.Cidade = txtCid.Text;
                empresa.CNPJ = mskCNPJ.Text;
                empresa.Email = txtEmail.Text;
                empresa.Estado = txtEst.Text;
                empresa.NomeEmpresa = txtNomeEmpresa.Text;
                empresa.Rua = txtRua.Text;
                empresa.Senha = txtSenha.Text;
                empresa.Telefone = mskTel.Text;
                EmpresaDAO.Incluir(empresa);

                MessageBox.Show("O cadastro da empresa: " + empresa.NomeEmpresa + " foi concluido com sucesso", "Cadastrado");
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
