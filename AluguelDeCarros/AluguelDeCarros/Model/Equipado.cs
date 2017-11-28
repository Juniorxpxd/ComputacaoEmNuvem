using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.Model
{
    [Table("Equipados")]
    class Equipado
    {
        [Key]
        public Alugado Alugado { get; set; }
        public int Id { get; set; }
        public double ValorTotal { get; set; }
    }
}
