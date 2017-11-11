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

namespace AluguelDeCarros
{
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {

            InitializeComponent();


        }

        SqlConnection sqlCon = null;
        private string strCon = ;
        private string strSql = string.Empty;


        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEst_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskCel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "INSERT INTO CadastroEmpresa(Nome, Email, Senha, NomeEmpresa, CNPJ, Telefone, Estado, Cidade, Celular, Rua) values(@Nome, @Email, @Senha, @NomeEmpresa, @CNPJ, @Telefone, @Estado, @Cidade, @Celular, @Rua)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@NomeEmpresa", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Rua", SqlDbType.VarChar).Value = txtNome.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }


        }
    }
}
