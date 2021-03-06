﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AluguelDeCarros.Model
{
    class Entities : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Alugado> Alugados { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Equipado> Equipados { get; set; }
    }
}