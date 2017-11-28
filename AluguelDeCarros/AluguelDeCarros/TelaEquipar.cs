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
    public partial class TelaEquipar : Form
    {
        Equipado equipado = new Equipado();
        Alugado alugar = new Alugado();
        Cliente cliente = new Cliente();
        double ValorTotal = 0.00;
        private string email;
        public TelaEquipar(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double ValorTotal = 0.00;

            if (cDVDAutomotivo.Checked == true)
            {
                ValorTotal = 50;
                txtValorTotal.Clear();
                txtValorTotal.Text = ValorTotal.ToString();
            }
            else
            {
                ValorTotal = ValorTotal + 0;
                txtValorTotal.Clear();
                txtValorTotal.Text = ValorTotal.ToString();
            }
            if (cSuporteCelular.Checked == true)
            {
                ValorTotal = ValorTotal + 10;
                txtValorTotal.Clear();
                txtValorTotal.Text = ValorTotal.ToString();
            }
            else
            {
                ValorTotal = ValorTotal + 0;
                txtValorTotal.Clear();
                txtValorTotal.Text = ValorTotal.ToString();
            }
            if (cGPS.Checked == true)
            {
                ValorTotal = ValorTotal + 60;
                txtValorTotal.Clear();
                txtValorTotal.Text = ValorTotal.ToString();
            }
            else
            {
                ValorTotal = ValorTotal + 0;
                txtValorTotal.Clear();
                txtValorTotal.Text = ValorTotal.ToString();
            }
            if (ckitferramenta.Checked == true)
            {
                ValorTotal = ValorTotal + 70;
                txtValorTotal.Clear();
                txtValorTotal.Text = ValorTotal.ToString();
            }
            else
            {
                ValorTotal = ValorTotal + 0;
                txtValorTotal.Clear();
                txtValorTotal.Text = ValorTotal.ToString();
            }

            if (cPortacopo.Checked == true)
            {
                ValorTotal = ValorTotal + 15;
                txtValorTotal.Clear();
                txtValorTotal.Text = ValorTotal.ToString();
            }
            else
            {
                ValorTotal = ValorTotal + 0;
                txtValorTotal.Clear();
                txtValorTotal.Text = ValorTotal.ToString();
            }
            if (cCDplayer.Checked == true)
            {
                ValorTotal = ValorTotal + 30;
                txtValorTotal.Clear();
                txtValorTotal.Text = ValorTotal.ToString();

            }
            else
            {
                ValorTotal = ValorTotal + 0;
                txtValorTotal.Clear();
                txtValorTotal.Text = ValorTotal.ToString();
            }


        }

        private void btnEquipar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!txtValorTotal.Text.Equals(""))
                {
                    Equipado equipado = new Equipado();
                    Alugado alugar = new Alugado();
                   
                    alugar = AlugadoDAO.ObterAluguelPorId(alugar);
                    cliente.Email = email;
                    cliente = ClienteDAO.BuscarCLientePorEmail(cliente);

                    if (AlugadoDAO.ObterAluguelPorId(alugar) != null)
                    {

                        equipado.Alugado = alugar;
                        equipado.ValorTotal = double.Parse(txtValorTotal.Text);
                        EquipadoDAO.Incluir(equipado);
                        this.Close();

                        MessageBox.Show("O recibo do equipamento de seu carro: " + equipado.Id + " foi concluido com sucesso", "Cadastrado");

                    }
                    else
                    {
                        MessageBox.Show("Carro já foi Equipado.", "Carro já Equipado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("O campo Valor é de preenchimento obrigatório.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (SqlException r)
            {
                MessageBox.Show(e + "Erro ao cadastrar", "Erro");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Equipado equipado = new Equipado();
                equipado.Id = int.Parse(txtReciboDevolver.Text);
                equipado = EquipadoDAO.ObterEquipadoPorId(equipado);
                if (equipado != null)
                {


                    EquipadoDAO.Excluir(equipado);
                    MessageBox.Show("Equipamento Devolvido", "Devolvido");

                }
                else
                {
                    MessageBox.Show("Equipamento inexistente", "Erro");
                }
            }
            catch (SqlException r)
            {
                MessageBox.Show(r + "Erro ao Devolver Equipamento", "Erro");
            }
        }
    }
}
