using cadprodutos.Data;
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
    public partial class FrmListar : Form
    {
        Contexto db;
        CategoriaPresenter Presenter;
        public FrmListar()
        {
            InitializeComponent();
            db = new Contexto();
            Presenter = new CategoriaPresenter(db);
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }/*dsd*/    

        public void Atualizar()
        {
            List<Categoria> lista = Presenter.Buscar(txtbusca.Text);

            flpItens.Controls.Clear();
            foreach (Categoria c in lista)
            {
                Categoriacontrol ctr = new Categoriacontrol(this, Presenter, c);
                flpItens.Controls.Add(ctr);
            }
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrar f = new FrmCadastrar(Presenter);
            f.ShowDialog();
            Atualizar();
        }
    }
}
