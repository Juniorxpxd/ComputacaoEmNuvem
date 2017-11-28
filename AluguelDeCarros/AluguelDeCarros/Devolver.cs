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
    public partial class Devolver : Form
    {
        private string email;
        public Devolver(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                Alugado alugar = new Alugado();
                alugar.Id = int.Parse(txtRecibo.Text);
                alugar = AlugadoDAO.ObterAluguelPorId(alugar);
                if (alugar != null)
                {
                    if (alugar.Carro.EstadoDisp == false)
                    {
                        alugar.Carro.EstadoDisp = true;
                        AlugadoDAO.Excluir(alugar);
                        MessageBox.Show("Carro Devolvido", "Devolvido");
                    }
                    else
                    {
                        MessageBox.Show("O Carro não esta locado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Carro inexistente", "Erro");
                }
            }
            catch (SqlException r)
            {
                MessageBox.Show(r + "Erro ao Devolver Carro", "Erro");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRecibo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRecibo_Click(object sender, EventArgs e)
        {

        }

        private void btnDevolver_Leave(object sender, EventArgs e)
        {

        }

        private void Devolver_Leave(object sender, EventArgs e)
        {

        }

        private void panel1_Leave(object sender, EventArgs e)
        {

        }

        private void txtRecibo_Leave(object sender, EventArgs e)
        {
            Alugado alugado = new Alugado();
            if (!txtRecibo.Text.Equals(""))
            {
                try
                {
                    alugado.Id = int.Parse(txtRecibo.Text);
                    AlugadoDAO.ObterAluguelPorId(alugado);
                }
                catch
                {
                    MessageBox.Show("Carro não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRecibo.Clear();
                    txtRecibo.Focus();
                }
            }
        }
    }
}