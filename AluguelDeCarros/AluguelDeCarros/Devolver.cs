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
        public Devolver()
        {
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
                    MessageBox.Show("Pedido inexistente", "Erro");
                }
            }
            catch (SqlException r)
            {
                MessageBox.Show(r + "Erro ao Devolver Jogo", "Erro");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
