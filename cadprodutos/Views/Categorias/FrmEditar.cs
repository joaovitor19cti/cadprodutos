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

            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            cat.Nome = txtNome.Text;
            if(presenter.Editar(cat))
            {
                MessageBox.Show("Sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }
    }
}
