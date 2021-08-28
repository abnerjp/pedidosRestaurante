using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicioCruds.Models;

namespace exercicioCruds.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Pais> Paises { get; set; }

        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Cozinha> Cozinhas { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Restaurante> Restaurantes { get; set; }

    }
}
