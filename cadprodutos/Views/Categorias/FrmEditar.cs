using cadprodutos.Models;
using cadprodutos.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cadprodutos.Views.Categorias
{
    public partial class FrmEditar : Form
    {
        CategoriaPresenter presenter;
        Categoria cat;
        public FrmEditar(CategoriaPresenter presenter, Categoria cat)
        {
            InitializeComponent();
            this.presenter = presenter;
            this.cat = cat;

            lblID.Text = $"#{cat.Id}";
            txtNome.Text = cat.Nome;

            foreach (Produto p in cat.Produtos)
            {
                ProdControl prodControl = new ProdControl(this, p);
                flpProds.Controls.Add(prodControl);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            cat.Nome = txtNome.Text;
            if (presenter.Editar(cat))
            {
                MessageBox.Show("Sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }
        public void ExcluirProduto(ProdControl ctrl, Produto prod)
        {
            cat.Produtos.Remove(prod);
            flpProds.Controls.Remove(ctrl);
        }

        private void btCadastrarProd_Click(object sender, EventArgs e)
        {
            Produto p = new Produto()
            {
                Nome = "",
                preco = 0
            };
            cat.Produtos.Add(p);
            flpProds.Controls.Add(new ProdControl(this, p));

        }
    }
}
