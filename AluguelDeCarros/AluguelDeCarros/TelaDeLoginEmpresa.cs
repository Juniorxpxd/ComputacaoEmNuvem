using AluguelDeCarros.DAO;
using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelDeCarros
{
    public partial class TelaDeLoginEmpresa : Form
    {
        public TelaDeLoginEmpresa()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            if (!txtEmail.Text.Equals(""))
            {
                if (!txtSenha.Text.Equals(""))
                {
                    empresa.Email = txtEmail.Text;
                    empresa.Senha = txtSenha.Text;
                    if (EmpresaDAO.BuscarEmpresaPorEmailESenha(empresa) != null)
                    {
                        empresa = EmpresaDAO.BuscarEmpresaPorEmailESenha(empresa);
                        this.Close();
                        MenuEmpresa menuEmpresa = new MenuEmpresa(empresa.Email);
                        menuEmpresa.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Login ou Senha Inválida", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
