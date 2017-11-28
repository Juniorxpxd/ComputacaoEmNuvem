using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AluguelDeCarros.DAO
{
    class EmpresaDAO
    {
        private static Entities entities = Singleton.Instance.Entities;
        public static bool Incluir(Empresa Empresa)
        {
            try
            {
                entities.Empresas.Add(Empresa);
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Empresa BuscarEmpresaPorEmailESenha(Empresa Empresa)
        {
            return entities.Empresas.Include("Plano").Include("Cliente").Include("Carro").FirstOrDefault(x => x.Email.Equals(Empresa.Email) && x.Senha.Equals(Empresa.Senha));
        }
        public static Empresa BuscarEmpresaPorId(int? id)
        {
            return entities.Empresas.Find(id);
        }
        public static Empresa BuscarEmpresaPorEmail(Empresa Empresa)
        {
            return entities.Empresas.Include("Plano").Include("Cliente").Include("Carro").FirstOrDefault(x => x.Email.Equals(Empresa.Email));
        }
        public static Empresa BuscarEmpresaPorCNPJ(Empresa Empresa)
        {
            return entities.Empresas.Include("Plano").Include("Cliente").Include("Carro").FirstOrDefault(x => x.CNPJ.Equals(Empresa.CNPJ));
        }
        public static Empresa BuscarEmpresaPorNomeEmpresa(Empresa Empresa)
        {
            return entities.Empresas.Include("Plano").Include("Cliente").Include("Carro").FirstOrDefault(x => x.NomeEmpresa.Equals(Empresa.NomeEmpresa));
        }
    }
}
