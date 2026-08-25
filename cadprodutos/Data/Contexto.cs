using cadprodutos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace cadprodutos.Data
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=projetoscti.com.br;" +
                                     "Port=54432;" + 
                                     "Username=ra2557096;" +
                                     "Password=FVzmSDYwur9KAtko;" +
                                     "Database=cti_db;");
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
