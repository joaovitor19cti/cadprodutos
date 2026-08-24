using cadprodutos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cadprodutos.Views.Categorias
{
    public partial class Categoriacontrol : UserControl
    {
        private Categoria cat;
        public Categoriacontrol(Categoria cat)
        {
            InitializeComponent();
            this.cat = cat;

            lblid.Text = $"#{cat.Id}";
            lblnome.Text = cat.Nome;
        }
    }
}
