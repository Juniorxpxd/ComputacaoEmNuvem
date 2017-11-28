using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.DAO
{
    class ClienteDAO
    {
        private static Entities entities = Singleton.Instance.Entities;
        public static bool Incluir(Cliente Cliente)
        {
            try
            {
                entities.Clientes.Add(Cliente);
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Cliente BuscarClientePorEmailESenha(Cliente cliente)
        {
            return entities.Clientes.Include("Empresa").FirstOrDefault(x => x.Email.Equals(cliente.Email) && x.Senha.Equals(cliente.Senha));
        }

        public static Cliente BuscarClientePorCPF(Cliente Cliente)
        {
            return entities.Clientes.Include("Empresa").FirstOrDefault(x => x.Cpf.Equals(Cliente.Cpf));
        }

        public static Cliente BuscarClientePorRG(Cliente Cliente)
        {
            return entities.Clientes.Include("Empresa").FirstOrDefault(x => x.Rg.Equals(Cliente.Rg));
        }
        public static Cliente BuscarCLientePorEmail(Cliente Cliente)
        {
            return entities.Clientes.Include("Empresa").FirstOrDefault(x => x.Email.Equals(Cliente.Email));
        }
        public static Cliente BuscarClientePorEmpresa(Cliente Cliente)
        {
            return entities.Clientes.Include("Empresa").FirstOrDefault(x => x.Empresa.Email.Equals(Cliente.Empresa.Email));
        }
        public static Cliente BuscarCarroPorCliente(Cliente Cliente)
        {
            return entities.Clientes.Include("Empresa").FirstOrDefault(x => x.Empresa.Carro.Equals(Cliente.Empresa));
        }

        public static bool Excluir(Cliente Cliente)
        {
            try
            {
                entities.Clientes.Remove(Cliente);
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Editar(Cliente Cliente)
        { 
            try
            {
                entities.Entry(Cliente).State = EntityState.Modified;
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
