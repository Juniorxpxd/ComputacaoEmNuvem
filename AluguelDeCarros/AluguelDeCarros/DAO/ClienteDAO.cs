using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
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
            return entities.Clientes.FirstOrDefault(x => x.Email.Equals(cliente.Email) && x.Senha.Equals(cliente.Senha));
        }

        public static Cliente BuscarClientePorCPF(Cliente Cliente)
        {
            return entities.Clientes.FirstOrDefault(x => x.Cpf.Equals(Cliente.Cpf));
        }

        public static Cliente BuscarClientePorRG(Cliente Cliente)
        {
            return entities.Clientes.FirstOrDefault(x => x.Rg.Equals(Cliente.Rg));
        }
        public static Cliente BuscarCLientePorEmail(Cliente Cliente)
        {
            return entities.Clientes.FirstOrDefault(x => x.Email.Equals(Cliente.Email));
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
                entities.Clientes.Update(Cliente);
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
