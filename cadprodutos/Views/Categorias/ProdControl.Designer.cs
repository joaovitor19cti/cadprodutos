namespace cadprodutos.Views.Categorias
{
    partial class ProdControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblID = new Label();
            lblNome = new Label();
            btExcluir = new Button();
            lblPreco = new Label();
            txtNome = new TextBox();
            numPreco = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numPreco).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(11, 7);
            lblID.Name = "lblID";
            lblID.Size = new Size(38, 15);
            lblID.TabIndex = 0;
            lblID.Text = "label1";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(26, 64);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(134, 245);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 2;
            btExcluir.Text = "Excloi";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(11, 125);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(59, 15);
            lblPreco.TabIndex = 3;
            lblPreco.Text = "Preço:  R$";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 61);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(253, 23);
            txtNome.TabIndex = 4;
            // 
            // numPreco
            // 
            numPreco.DecimalPlaces = 2;
            numPreco.Location = new Point(70, 123);
            numPreco.Maximum = new decimal(new int[] { 268435455, 1042612833, 542101086, 0 });
            numPreco.Name = "numPreco";
            numPreco.Size = new Size(253, 23);
            numPreco.TabIndex = 5;
            // 
            // ProdControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numPreco);
            Controls.Add(txtNome);
            Controls.Add(lblPreco);
            Controls.Add(btExcluir);
            Controls.Add(lblNome);
            Controls.Add(lblID);
            Name = "ProdControl";
            Size = new Size(355, 271);
            ((System.ComponentModel.ISupportInitialize)numPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblNome;
        private Button btExcluir;
        private Label lblPreco;
        private TextBox txtNome;
        private NumericUpDown numPreco;
    }
}
