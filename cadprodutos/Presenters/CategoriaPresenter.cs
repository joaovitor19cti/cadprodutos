using cadprodutos.Data;
using cadprodutos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace cadprodutos.Presenters
{
    public class CategoriaPresenter
    {
        Contexto db;
        public CategoriaPresenter(Contexto db)
        {
            this.db = db;
        }

        public List<Categoria> Buscar(String nome)
        {
            return db.Categorias
                .Where(c => c.Nome.ToUpper().Contains(nome.ToUpper())) 
                .ToList();
        }

        public bool Cadastrar(Categoria cat)
        {
            db.Categorias.Add(cat);
            int linhas = db.SaveChanges();
            return linhas == 1;
        }
    }
}
