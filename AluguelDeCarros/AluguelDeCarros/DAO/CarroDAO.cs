using AluguelDeCarros.Model;
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
    }
}
