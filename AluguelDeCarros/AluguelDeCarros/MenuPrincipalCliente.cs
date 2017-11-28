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
    public partial class MenuPrincipalCliente : Form
    {
        private string email;

        public MenuPrincipalCliente(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            TelaCarrosCliente listaCarro = new TelaCarrosCliente(this.email);
            listaCarro.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            TelaAlugar alugarCarro = new TelaAlugar(this.email);
            alugarCarro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Devolver devolver = new Devolver(this.email);
            devolver.ShowDialog();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            PerfilCliente perfil = new PerfilCliente(this.email);
            perfil.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaEquipar telaEquipar = new TelaEquipar(this.email);
            telaEquipar.ShowDialog();
        }
    }
}
