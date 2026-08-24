namespace cadprodutos.Views.Categorias
{
    partial class FrmCadastrar
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
            btsalvar = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // btsalvar
            // 
            btsalvar.Location = new Point(233, 126);
            btsalvar.Name = "btsalvar";
            btsalvar.Size = new Size(75, 23);
            btsalvar.TabIndex = 0;
            btsalvar.Text = "Salvar";
            btsalvar.UseVisualStyleBackColor = true;
            btsalvar.Click += btsalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 59);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(141, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(303, 23);
            txtNome.TabIndex = 2;
            // 
            // FrmCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 161);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(btsalvar);
            Name = "FrmCadastrar";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalvar;
        private Label label1;
        private TextBox txtNome;
    }
}