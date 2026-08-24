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
    public partial class FrmCadastrar : Form
    {
        CategoriaPresenter presenter;
        public FrmCadastrar(CategoriaPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            CategoriaPresenter nova = new CategoriaPresenter()
            {
                Nome = txtNome.Text
            };
            if (presenter.Cadastrar(nova))
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
