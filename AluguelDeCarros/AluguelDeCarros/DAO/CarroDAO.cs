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
                return entities.Carros.Include("Empresa").ToList().OrderBy(x => x.Placa);
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
                return entities.Carros.Include("Empresa").Where(x => x.Nome.Contains(iniciais)).ToList().OrderBy(x => x.Placa);
            }
            catch
            {
                return null;
            }
        }
        public static IOrderedEnumerable<Carro> ObterCarrosCidade(string iniciais)
        {
            try
            {
                return entities.Carros.Include("Empresa").Where(x => x.Empresa.Cidade.Contains(iniciais)).ToList().OrderBy(x => x.Placa);
            }
            catch
            {
                return null;
            }
        }
        public static IOrderedEnumerable<Carro> ObterCarrosEmpresa(string iniciais)
        {
            try
            {
                return entities.Carros.Include("Empresa").Where(x => x.Empresa.NomeEmpresa.Contains(iniciais)).ToList().OrderBy(x => x.Placa);
            }
            catch
            {
                return null;
            }
        }
        public static IEnumerable<Carro> ObterCarrosPelaEmpresa(Carro carro)
        {
            try
            {
                return entities.Carros.Include("Empresa").Where(x => x.Empresa.Id == carro.Empresa.Id);
            }
            catch
            {
                return null;
            }
        }
        public static IEnumerable<Carro> ObterCarrosPelaEmpresa(string iniciais, Carro carro)
        {
            try
            {
                return entities.Carros.Include("Empresa").Where(x => x.Empresa.Id == carro.Empresa.Id && x.Nome.Contains(iniciais)).ToList().OrderBy(x => x.Placa);
            }
            catch
            {
                return null;
            }
        }
        public static IEnumerable<Carro> ObterCarrosPelaCidade(string iniciais, Carro carro)
        {
            try
            {
                return entities.Carros.Include("Empresa").Where(x => x.Empresa.Cidade.Equals(carro.Empresa.Cidade) && x.Nome.Contains(iniciais)).ToList().OrderBy(x => x.Placa);
            }
            catch
            {
                return null;
            }
        }
        public static Carro ObterCarroPorEmpresa(Carro carro)
        {

            return entities.Carros.Include("Empresa").FirstOrDefault(x => x.Empresa.Id == carro.Empresa.Id);

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
            return entities.Carros.Include("Empresa").FirstOrDefault (x => x.Placa.Equals(carro.Placa));
        }
        public static bool Excluir(Carro Carro)
        {
            try
            {
                entities.Carros.Remove(Carro);
                entities.SaveChanges();
                return true;
            }
            catch
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
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
