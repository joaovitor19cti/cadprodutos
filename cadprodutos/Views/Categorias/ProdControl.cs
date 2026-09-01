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
    public partial class ProdControl : UserControl
    {
        Produto prod;
        FrmEditar form;
        bool pronto = false;
        public ProdControl(FrmEditar form, Produto prod)
        {
            InitializeComponent();
            this.form = form;
            this.prod = prod;

            lblID.Text = $"#{(prod.Id == null ? "--" : prod.Id)}";
            txtNome.Text = prod.Nome;
            numPreco.Value = (decimal)prod.preco;
        }
        void EditarProduto()
        {
            if (!pronto) return;
            prod.Nome = txtNome.Text;
            prod.preco = (double)numPreco.Value;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Deseja mesmo excluir o produto '{prod.Nome}'?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                form.ExcluirProduto(this, prod);
            }
        }
    }
}
