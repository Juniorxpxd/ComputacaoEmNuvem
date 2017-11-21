using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.Model
{
    [Table("Carros")]
    class Carro
    {
        [Key]
        public int Id { get; set; }
        public Empresa Empresa { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Quilometragem { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public string Cambio { get; set; }
        public int Ano { get; set; }
        public int Portas { get; set; }
        public double Preco { get; set; }
        public bool EstadoDisp { get; set; }
    }
}
