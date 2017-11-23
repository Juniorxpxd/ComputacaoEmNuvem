using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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
        public static Alugado ObterAluguelPorId(Alugado Alugado)
        {
            Entities db = Singleton.Instance.Entities;
            try
            {
                return db.Alugados.Include("Carro").Include("Cliente").FirstOrDefault(x => x.Id == Alugado.Id);
            }
            catch
            {
                return null;
            }
        }
        public static bool Excluir(Alugado Alugado)
        {
            Entities db = Singleton.Instance.Entities;
            try
            {
                db.Alugados.Remove(Alugado);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}