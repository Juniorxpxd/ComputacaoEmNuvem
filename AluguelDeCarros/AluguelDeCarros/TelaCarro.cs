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
    public partial class TelaCarro : Form
    {
        Carro carro = new Carro();
        Empresa empresa = new Empresa();
        private string email;
        public TelaCarro(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstCarros.Items.Clear();
            ListViewItem item;
            empresa.Email = this.email;
            empresa = EmpresaDAO.BuscarEmpresaPorEmail(empresa);
            carro.Empresa = empresa;
            IEnumerable<Carro> carros = CarroDAO.ObterCarrosPelaEmpresa(txtInicialCarro.Text, carro);
            foreach(Carro x in carros)
            {
                item = new ListViewItem();
                item.Text = x.Placa;
                item.SubItems.Add(x.Marca);
                item.SubItems.Add(x.Nome);
                item.SubItems.Add(x.Ano.ToString());
                item.SubItems.Add(x.Preco.ToString("C2"));
                string estado = CarroDAO.EstadoDisp(x.EstadoDisp);
                item.SubItems.Add(estado);
                lstCarros.Items.Add(item);

            }
        }
        private void TelaCarro_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            empresa.Email = this.email;
            empresa = EmpresaDAO.BuscarEmpresaPorEmail(empresa);
            carro.Empresa = empresa;
            IEnumerable<Carro> carros = CarroDAO.ObterCarrosPelaEmpresa(carro);
                foreach (Carro x in carros)
                {
                    lista.Add(x.Nome);
                }
            txtInicialCarro.AutoCompleteCustomSource = lista;
        }

        private void lstCarros_BindingContextChanged(object sender, EventArgs e)
        {
            lstCarros.Items.Clear();
            ListViewItem item;
            empresa.Email = this.email;
            empresa = EmpresaDAO.BuscarEmpresaPorEmail(empresa);
            carro.Empresa = empresa;
            IEnumerable<Carro> carros = CarroDAO.ObterCarrosPelaEmpresa(carro);
            foreach (Carro i in carros)
            {
                item = new ListViewItem();
                item.Text = i.Placa;
                item.SubItems.Add(i.Marca);
                item.SubItems.Add(i.Nome);
                item.SubItems.Add(i.Ano.ToString());
                item.SubItems.Add(i.Preco.ToString("C2"));
                string estado = CarroDAO.EstadoDisp(i.EstadoDisp);
                item.SubItems.Add(estado);
                lstCarros.Items.Add(item);
            }
        }
    }
}
