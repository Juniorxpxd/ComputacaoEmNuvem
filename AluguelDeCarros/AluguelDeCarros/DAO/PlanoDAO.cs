﻿using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.DAO
{
    class PlanoDAO
    {
        private static Entities entities = Singleton.Instance.Entities;
        public static bool Incluir(Plano Plano)
        {
            try
            {
                entities.Planos.Add(Plano);
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Plano BuscarPlanoPorPlano(Plano Plano)
        {
            return entities.Planos.FirstOrDefault(x => x.PlanoCarro.Equals(Plano.PlanoCarro));
        }

        public static IOrderedEnumerable<Plano> obterPlanos()
        {
            return entities.Planos.ToList().OrderBy(x => x.PlanoCarro);
        }

        public static Plano NomeMesmo(Plano Plano)
        {
            return entities.Planos.FirstOrDefault(x => x.PlanoCarro.Equals(Plano.PlanoCarro));
        }
        //public static IEnumerable<Plano> ObterPlanosPelaEmpresa(Plano Plano)
        //{
        //    try
        //    {
        //        return entities.Planos.Include("Empresa").Where(x => x.empresa.Id == Plano.empresa.Id);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
    }
}
