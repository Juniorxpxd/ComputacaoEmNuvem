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

namespace AluguelDeCarros
{
    public partial class CadastrarPlano : Form
    {
        public CadastrarPlano()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Plano plano = new Plano();
            if (!txtPlano.Text.Equals(""))
            {
                plano.PlanoCarro = txtPlano.Text;
                if(PlanoDAO.BuscarPlanoPorPlano(plano) == null)
                {
                    plano.PlanoCarro = txtPlano.Text;
                    PlanoDAO.Incluir(plano);
                    MessageBox.Show("O cadastro do Plano: " + plano.PlanoCarro + " foi concluido com sucesso", "Cadastrado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Plano já foi Registrado.", "Plano já Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                MessageBox.Show("Nome de Plano já foi Registrado.", "Nome de Plano já Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
