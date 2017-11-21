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
    public partial class TelaCarrosCliente : Form
    {
        Carro carro = new Carro();
        Empresa empresa = new Empresa();
        private string email;
        public TelaCarrosCliente(string email)
        {
            this.email = email;
            InitializeComponent();
        }
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnConsultarCarro_Click(object sender, EventArgs e)
        {
            lstCarros.Items.Clear();
            ListViewItem item;
            IOrderedEnumerable<Carro> carros = CarroDAO.ObterCarros(txtInicialCarro.Text);
            foreach (Carro x in carros)
            {
                item = new ListViewItem();
                item.Text = x.Placa;
                item.SubItems.Add(x.Marca);
                item.SubItems.Add(x.Nome);
                item.SubItems.Add(x.Ano.ToString());
                item.SubItems.Add(x.Preco.ToString("C2"));
                string estado = CarroDAO.EstadoDisp(x.EstadoDisp);
                item.SubItems.Add(estado);
                item.SubItems.Add(x.Empresa.Cidade);
                item.SubItems.Add(x.Empresa.NomeEmpresa);
                lstCarros.Items.Add(item);
            }
        }
        private void btnConsultarEmpresa_Click(object sender, EventArgs e)
        {
            lstCarros.Items.Clear();
            ListViewItem item;
            IOrderedEnumerable<Carro> carros = CarroDAO.ObterCarrosEmpresa(txtInicialEmpresa.Text);
            foreach (Carro x in carros)
            {
                item = new ListViewItem();
                item.Text = x.Placa;
                item.SubItems.Add(x.Marca);
                item.SubItems.Add(x.Nome);
                item.SubItems.Add(x.Ano.ToString());
                item.SubItems.Add(x.Preco.ToString("C2"));
                string estado = CarroDAO.EstadoDisp(x.EstadoDisp);
                item.SubItems.Add(estado);
                item.SubItems.Add(x.Empresa.Cidade);
                item.SubItems.Add(x.Empresa.NomeEmpresa);
                lstCarros.Items.Add(item);
            }
        }

        private void btnConsultarCidade_Click(object sender, EventArgs e)
        {
            lstCarros.Items.Clear();
            ListViewItem item;
            IOrderedEnumerable<Carro> carros = CarroDAO.ObterCarrosCidade(txtInicialCidade.Text);
            foreach (Carro x in carros)
            {
                item = new ListViewItem();
                item.Text = x.Placa;
                item.SubItems.Add(x.Marca);
                item.SubItems.Add(x.Nome);
                item.SubItems.Add(x.Ano.ToString());
                item.SubItems.Add(x.Preco.ToString("C2"));
                string estado = CarroDAO.EstadoDisp(x.EstadoDisp);
                item.SubItems.Add(estado);
                item.SubItems.Add(x.Empresa.Cidade);
                item.SubItems.Add(x.Empresa.NomeEmpresa);
                lstCarros.Items.Add(item);
            }
        }
        private void TelaCarro_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            foreach (Carro x in CarroDAO.ObterCarros())
            {
                lista.Add(x.Nome);
            }
            txtInicialCarro.AutoCompleteCustomSource = lista;
        }

        private void lstCarros_BindingContextChanged(object sender, EventArgs e)
        {
            lstCarros.Items.Clear();
            ListViewItem item;
            foreach (Carro i in CarroDAO.ObterCarros())
            {
                item = new ListViewItem();
                item.Text = i.Placa;
                item.SubItems.Add(i.Marca);
                item.SubItems.Add(i.Nome);
                item.SubItems.Add(i.Ano.ToString());
                item.SubItems.Add(i.Preco.ToString("C2"));
                string estado = CarroDAO.EstadoDisp(i.EstadoDisp);
                item.SubItems.Add(estado);
                item.SubItems.Add(i.Empresa.Cidade);
                item.SubItems.Add(i.Empresa.NomeEmpresa);
                lstCarros.Items.Add(item);
            }
        }

        private void lstCarros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
