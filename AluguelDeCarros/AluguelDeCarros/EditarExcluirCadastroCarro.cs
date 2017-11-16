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

        public EditarExcluirCadastroCarro()
        {
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtPlaca.Equals(""))
            {
                Carro carro = new Carro();

                carro.Placa = txtPlaca.Text;
                carro = CarroDAO.obterPlaca(carro);
                if(carro !=null)
                {
                    carro.Nome = txtNome.Text;
                    carro.Cambio = txtCambio.Text;
                    carro.Cor = txtCor.Text;
                    carro.Marca = txtMarca.Text;
                    carro.Quilometragem = txtQuilometragem.Text;
                    carro.Placa = txtPlaca.Text;
                    carro.Portas = int.Parse(txtPorta.Text);
                    carro.Ano = int.Parse(txtAno.Text);
                    carro.Preco = txtPreco.Text;
                    carro.EstadoDisp = true;
                }
                else
                {
                    MessageBox.Show("carro nao encontrado");
                }
            }
        }
  
    }
}
