﻿using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return entities.Empresas.FirstOrDefault(x => x.Email.Equals(Empresa.Email) && x.Senha.Equals(Empresa.Senha));
        }
    }
}
