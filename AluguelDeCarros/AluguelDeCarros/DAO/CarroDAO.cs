﻿using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.DAO
{
    class CarroDAO
    {
        private static Entities entities = Singleton.Instance.Entities;
        public static bool Incluir(Carro Carro)
        {
            try
            {
                entities.Carros.Add(Carro);
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static IOrderedEnumerable<Carro> ObterCarros()
        {
            try
            {
                return entities.Carros.ToList().OrderBy(x => x.Placa);
            }
            catch
            {
                return null;
            }
        }
        public static IOrderedEnumerable<Carro> ObterCarros(string iniciais)
        {
            try
            {
                return entities.Carros.Where(x => x.Nome.Contains(iniciais)).ToList().OrderBy(x => x.Placa);
            }
            catch
            {
                return null;
            }
        }
        public static string EstadoDisp(bool EstadoDisp)
        {
            if (EstadoDisp == true)
            {
                return "Disponivel";
            }
            else
            {
                return "Alugado";
            }
        }

        public static Carro BuscarCarroPorPlaca(Carro Carro)
        {
            return entities.Carros.FirstOrDefault(x => x.Placa.Equals(Carro.Placa));
        }
    }
}
