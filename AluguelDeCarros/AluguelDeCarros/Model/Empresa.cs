using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.Model
{
    [Table("Empresas")]
    class Empresa
    {
        [Key]
        public int Id { get; set; }
        public Plano Plano { get; set; }
        public string Nome { get; set; }
        public string NomeEmpresa { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public List<Carro> Carro { get; set; }
        public List<Cliente> Cliente { get; set; }
    }   
}

