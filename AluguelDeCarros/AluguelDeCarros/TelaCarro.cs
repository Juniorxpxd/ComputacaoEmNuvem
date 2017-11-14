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
        public TelaCarro()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

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
            IOrderedEnumerable<Carro> carros = CarroDAO.ObterCarros(txtInicialCarro.Text);
            foreach (Carro i in CarroDAO.ObterCarros())
            {
                item = new ListViewItem();
                item.Text = i.Placa;
                item.SubItems.Add(i.Marca);
                item.SubItems.Add(i.Nome);
                item.SubItems.Add(i.Ano.ToString());
                item.SubItems.Add(i.Preco.ToString());
                string estado = CarroDAO.EstadoDisp(i.EstadoDisp);
                item.SubItems.Add(estado);
                lstCarros.Items.Add(item);
            }
        }
    }
}
