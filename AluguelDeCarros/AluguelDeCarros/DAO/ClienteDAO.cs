﻿using AluguelDeCarros.Model;
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

        
    }
}
