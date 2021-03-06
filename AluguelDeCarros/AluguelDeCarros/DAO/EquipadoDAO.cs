﻿using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.DAO
{
    class EquipadoDAO
    {
        private static Entities entities = Singleton.Instance.Entities;

        public static bool Incluir(Equipado Equipado)
        {
            try
            {
                entities.Equipados.Add(Equipado);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static Alugado BuscarCarroEquipadoPorRecibo(Alugado equipado)
        {
            return entities.Alugados.Find(equipado.Id);
        }

        public static bool Excluir(Equipado Equipado)
        {
            try
            {
                entities.Equipados.Remove(Equipado);
                entities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Equipado ObterEquipadoPorId(Equipado Equipado)
        {

            return entities.Equipados.Include("Alugado").FirstOrDefault(x => x.Id == Equipado.Id);

        }


    }
}
