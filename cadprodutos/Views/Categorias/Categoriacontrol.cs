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
    public partial class Categoriacontrol : UserControl
    {
        private Categoria cat;
        FrmListar grid;
        CategoriaPresenter presenter;

        public Categoriacontrol(FrmListar grid, CategoriaPresenter presenter, Categoria cat)
        {
            InitializeComponent();
            this.cat = cat;
            this.presenter = presenter;
            this.grid = grid;

            lblid.Text = $"#{cat.Id}";
            lblnome.Text = cat.Nome;
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Deseja realmente excluir a categoria '{cat.Nome}'?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (presenter.Remover(cat))
                {
                    MessageBox.Show("Categoria Removida!");
                    grid.Atualizar();
                }
                else
                {
                    MessageBox.Show("Erro ao remover categoria!");
                }
            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            FrmEditar f = new FrmEditar(presenter, cat);
            f.ShowDialog();
            grid.Atualizar();
        }
    }
}
