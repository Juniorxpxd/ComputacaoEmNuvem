using AluguelDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public static string Plano(int Plano)
        {
          
            if (Plano == 1)
            {
                return "Pequeno";
            }
            else
            {
                return "Grande";
            }
        }
        public static Carro obterPlaca(Carro carro)
        {
            return entities.Carros.FirstOrDefault (x => x.Placa.Equals(carro.Placa));
        }
        public static bool Excluir(Carro Carro)
        {
            try
            {
                entities.Carros.Remove(Carro);
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Editar(Carro Carro)
        {
            try
            {
                entities.Entry(Carro).State = EntityState.Modified;
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
