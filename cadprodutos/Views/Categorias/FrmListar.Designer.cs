namespace cadprodutos.Views.Categorias
{
    partial class FrmListar
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
            btbuscar = new Button();
            txtbusca = new TextBox();
            btcadastrar = new Button();
            flpItens = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btbuscar
            // 
            btbuscar.Location = new Point(403, 12);
            btbuscar.Name = "btbuscar";
            btbuscar.Size = new Size(75, 23);
            btbuscar.TabIndex = 0;
            btbuscar.Text = "Buscar";
            btbuscar.UseVisualStyleBackColor = true;
            btbuscar.Click += btbuscar_Click;
            // 
            // txtbusca
            // 
            txtbusca.Location = new Point(200, 12);
            txtbusca.Name = "txtbusca";
            txtbusca.Size = new Size(197, 23);
            txtbusca.TabIndex = 1;
            // 
            // btcadastrar
            // 
            btcadastrar.Location = new Point(334, 415);
            btcadastrar.Name = "btcadastrar";
            btcadastrar.Size = new Size(75, 23);
            btcadastrar.TabIndex = 2;
            btcadastrar.Text = "Cadastrar";
            btcadastrar.UseVisualStyleBackColor = true;
            btcadastrar.Click += btcadastrar_Click;
            // 
            // flpItens
            // 
            flpItens.AutoScroll = true;
            flpItens.Location = new Point(12, 41);
            flpItens.Name = "flpItens";
            flpItens.Size = new Size(776, 363);
            flpItens.TabIndex = 3;
            // 
            // FrmListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpItens);
            Controls.Add(btcadastrar);
            Controls.Add(txtbusca);
            Controls.Add(btbuscar);
            Name = "FrmListar";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btbuscar;
        private TextBox txtbusca;
        private Button btcadastrar;
        private FlowLayoutPanel flpItens;
    }
}