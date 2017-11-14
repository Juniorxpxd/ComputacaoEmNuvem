using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AluguelDeCarros.Model;
using AluguelDeCarros.DAO;

namespace AluguelDeCarros
{
    public partial class TelaDeLoginCliente : Form
    {
        public TelaDeLoginCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Equals(""))
            {
                if (!txtSenha.Text.Equals(""))
                {
                    Cliente cliente = new Cliente();
                    cliente.Email = txtEmail.Text;
                    cliente.Senha = txtSenha.Text;
                    if (ClienteDAO.BuscarClientePorEmailESenha(cliente) != null)
                    {
                        cliente = ClienteDAO.BuscarClientePorEmailESenha(cliente);
                        this.Close();
                        MenuPrincipalCliente menuPrincipalCliente = new MenuPrincipalCliente(cliente.Email);
                        menuPrincipalCliente.ShowDialog();
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
    }
}
