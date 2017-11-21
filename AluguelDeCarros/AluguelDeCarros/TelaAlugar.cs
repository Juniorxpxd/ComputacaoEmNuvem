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
                    txtPreco.Text = carro.Preco.ToString("C2");
                    txtQuilometragem.Text = carro.Quilometragem;
                    txtCor.Text = carro.Cor;
                }
                catch
                {
                    MessageBox.Show("Carro não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPlaca.Clear();
                    txtPlaca.Focus();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
