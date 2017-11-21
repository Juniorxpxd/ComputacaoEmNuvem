using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.DAO
{
    class AlugadoDAO
    {
        private static Entities entities = Singleton.Instance.Entities;

        public static bool Incluir(Alugado Alugado)
        {
            try
            {
                entities.Alugados.Add(Alugado);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
