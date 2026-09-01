namespace cadprodutos.Views.Categorias
{
    partial class FrmEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblID = new Label();
            label2 = new Label();
            label3 = new Label();
            btCadastrarProd = new Button();
            flpProds = new FlowLayoutPanel();
            btSalvar = new Button();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(12, 9);
            lblID.Name = "lblID";
            lblID.Size = new Size(38, 15);
            lblID.TabIndex = 0;
            lblID.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 85);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Produtos:";
            // 
            // btCadastrarProd
            // 
            btCadastrarProd.Location = new Point(191, 81);
            btCadastrarProd.Name = "btCadastrarProd";
            btCadastrarProd.Size = new Size(75, 23);
            btCadastrarProd.TabIndex = 3;
            btCadastrarProd.Text = "Novo Produto";
            btCadastrarProd.UseVisualStyleBackColor = true;
            btCadastrarProd.Click += btCadastrarProd_Click;
            // 
            // flpProds
            // 
            flpProds.AutoScroll = true;
            flpProds.Location = new Point(12, 110);
            flpProds.Name = "flpProds";
            flpProds.Size = new Size(360, 276);
            flpProds.TabIndex = 4;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(148, 392);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 5;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(56, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(324, 23);
            txtNome.TabIndex = 6;
            // 
            // FrmEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 426);
            Controls.Add(txtNome);
            Controls.Add(btSalvar);
            Controls.Add(flpProds);
            Controls.Add(btCadastrarProd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblID);
            Name = "FrmEditar";
            Text = "FrmEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label label2;
        private Label label3;
        private Button btCadastrarProd;
        private FlowLayoutPanel flpProds;
        private Button btSalvar;
        private TextBox txtNome;
    }
}