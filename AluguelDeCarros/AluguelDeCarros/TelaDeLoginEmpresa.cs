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
            empresa.Email = txtEmail.Text;
            empresa.Senha = txtSenha.Text;
            if(EmpresaDAO.BuscarEmpresaPorEmailESenha(empresa) != null)
            {
                MenuEmpresa menuEmpresa = new MenuEmpresa();
                menuEmpresa.ShowDialog();
            }
        }
    }
}
