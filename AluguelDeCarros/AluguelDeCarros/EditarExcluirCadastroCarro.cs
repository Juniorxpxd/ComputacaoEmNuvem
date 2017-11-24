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
    public partial class EditarExcluirCadastroCarro : Form
    {
        Carro carro = new Carro();
        private string email;
        public EditarExcluirCadastroCarro(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void EditarExcluirCadastroCarro_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Carro Carro = new Carro();
                carro.Placa = txtPlaca.Text;
                Carro = CarroDAO.obterPlaca(Carro);
                
                carro.Nome = txtNome.Text;
                carro.Cambio = txtCambio.Text;
                carro.Cor = txtCor.Text;
                carro.Marca = txtMarca.Text;
                carro.Quilometragem = txtQuilometragem.Text;

                carro.Portas = int.Parse(txtPorta.Text);
                carro.Ano = int.Parse(txtAno.Text);
                carro.Preco = double.Parse(txtPreco.Text);
                carro.EstadoDisp = true;
                CarroDAO.Editar(carro);
                MessageBox.Show("aterado com sucesso");

            }
            catch 
            {
                MessageBox.Show("nao alterado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtPlaca.Equals(""))
            {
                Carro carro = new Carro();


                try
                {
                    carro.Placa = txtPlaca.Text;
                    carro = CarroDAO.obterPlaca(carro);
                    txtNome.Text = carro.Nome;
                    txtCambio.Text = carro.Cambio;
                    txtCor.Text = carro.Cor;
                    txtMarca.Text = carro.Marca;
                    txtQuilometragem.Text = carro.Quilometragem;
                    txtPorta.Text = carro.Portas.ToString();
                    txtAno.Text = carro.Ano.ToString();
                    txtPreco.Text = carro.Preco.ToString();


                }
                catch
                {
                    MessageBox.Show("Carro não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPlaca.Clear();
                    txtPlaca.Focus();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void lblAno_Click(object sender, EventArgs e)
        {

        }

        private void txtPorta_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                Carro Carro = new Carro();
                Carro.Placa = txtPlaca.Text;
                Carro = CarroDAO.obterPlaca(Carro);
                if (Carro != null)
                {
                    CarroDAO.Excluir(Carro);
                    MessageBox.Show("Carro Excluido", "Excluido");
                }
                else
                {
                    MessageBox.Show("Carro inexistente", "Erro");
                }
            }
            catch
            {

            }
        }
    }
}