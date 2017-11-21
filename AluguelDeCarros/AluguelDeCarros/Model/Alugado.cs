using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.Model
{
    [Table("Alugados")]
    class Alugado
    {
        [Key]
        public Cliente Cliente { get; set; }
        public Carro Carro { get; set; }
        public int Id { get; set; }
        public int DiasAlugado { get; set; }
        public double Valor { get; set; }
    }
}
