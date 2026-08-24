using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cadprodutos.Models
{
    [Table("produtos")]
    public class Produto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; } = "";
        [Column("preco")]
        public double preco { get; set; }

        [Column("cat_id")]
        public int CatId { get; set; }
        [ForeignKey(nameof(CatId))]
        public Categoria Categoria { get; set; }
    }
}

