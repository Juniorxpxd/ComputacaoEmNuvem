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
    public partial class TelaAlugar : Form
    {
        Carro carro = new Carro();
        Empresa empresa = new Empresa();
        private string email;
        public TelaAlugar(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            if (!txtPlaca.Text.Equals(""))
            {
                try
                {
            
                    carro.Placa = txtPlaca.Text;
                    carro = CarroDAO.obterPlaca(carro);
                    txtMarca.Text = carro.Marca;
                    txtNome.Text = carro.Nome;
                    txtAno.Text = carro.Ano.ToString();
                    txtPortas.Text = carro.Portas.ToString();
                    txtCambio.Text = carro.Cambio;
                    txtQuilometragem.Text = carro.Quilometragem;
                    txtCor.Text = carro.Cor;
                    txtRateApplied.Text = carro.Preco.ToString();
                }
                catch
                {
                    MessageBox.Show("Carro não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPlaca.Clear();
                    txtPlaca.Focus();
                }
            }
        }
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Value = dtpStartDate.Value;
        }
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            int _dias;

            DateTime dteStart = this.dtpStartDate.Value;
            DateTime dteEnd = this.dtpEndDate.Value;

            TimeSpan tme = dteEnd - dteStart;
            _dias = tme.Days;

            if (_dias == 0)
                _dias = 1;

            txtDays.Text = _dias.ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Alugado alugado = new Alugado();
                Carro carro = new Carro();
                Cliente cliente = new Cliente();
                cliente.Email = this.email;
                cliente = ClienteDAO.BuscarCLientePorEmail(cliente);
                alugado.Cliente = cliente;
                alugado = AlugadoDAO.ObterAluguelPorCliente(alugado);
                if (alugado == null)
                {
                    carro.Placa = txtPlaca.Text;
                    carro = CarroDAO.obterPlaca(carro);
                    if (carro != null)
                    {
                        if (carro.EstadoDisp == true)
                        {
                            if (carro.Empresa == cliente.Empresa)
                            {
                                Alugado alugados = new Alugado();
                                carro.EstadoDisp = false;
                                alugados.Cliente = cliente;
                                alugados.Carro = carro;
                                alugados.DiasAlugado = int.Parse(txtDays.Text);
                                alugados.Valor = float.Parse(txtOrderTotal.Text);
                                AlugadoDAO.Incluir(alugados);
                                txtReceiptNumber.Text = alugados.Id.ToString();
                                MessageBox.Show("O carro " + carro.Nome + " foi alugado com sucesso e guarde o seu recibo: #" + alugados.Id + " para devolução", "Alugado");
                            }
                            else
                            {
                                MessageBox.Show("Erro ao alugar - Carro não existe nesta empresa", "Erro");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao alugar - Carro já foi Alugado", "Erro");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alugar - Carro incorreto", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente já alugou um carro", "Erro");
                }
            }
            catch (SqlException c)
            {
                MessageBox.Show(c + "Erro ao alugar", "Erro");
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            carro.Placa = txtPlaca.Text;
            carro = CarroDAO.obterPlaca(carro);
            if (carro != null)
            {
                int Dias = 0;
                double TaxaAplicada = 0.00;
                double SubTotal = 0.00;
                double ValorImposto = 0.00;
                double ValorTotal = 0.00;
                TaxaAplicada = carro.Preco;
                try
                {
                    Dias = int.Parse(this.txtDays.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Número de dias inválido");
                }

                try
                {
                    TaxaAplicada = double.Parse(txtRateApplied.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Valor inválido para a taxa aplicada");
                }

                SubTotal = Dias * TaxaAplicada;
                txtSubTotal.Text = SubTotal.ToString("F");

                ValorTotal = SubTotal + ValorImposto;
                txtOrderTotal.Text = ValorTotal.ToString("F");
            }
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReceiptNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
