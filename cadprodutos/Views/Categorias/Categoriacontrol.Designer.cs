namespace cadprodutos.Views.Categorias
{
    partial class Categoriacontrol
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
            bteditar = new Button();
            btexcluir = new Button();
            lblid = new Label();
            lblnome = new Label();
            SuspendLayout();
            // 
            // bteditar
            // 
            bteditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bteditar.Location = new Point(322, 19);
            bteditar.Name = "bteditar";
            bteditar.Size = new Size(75, 23);
            bteditar.TabIndex = 0;
            bteditar.Text = "Editar";
            bteditar.UseVisualStyleBackColor = true;
            bteditar.Click += bteditar_Click;
            // 
            // btexcluir
            // 
            btexcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btexcluir.Location = new Point(322, 66);
            btexcluir.Name = "btexcluir";
            btexcluir.Size = new Size(75, 23);
            btexcluir.TabIndex = 1;
            btexcluir.Text = "Excluir";
            btexcluir.UseVisualStyleBackColor = true;
            btexcluir.Click += btexcluir_Click;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(36, 25);
            lblid.Name = "lblid";
            lblid.Size = new Size(37, 15);
            lblid.TabIndex = 2;
            lblid.Text = "LBLID";
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(36, 72);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(61, 15);
            lblnome.TabIndex = 3;
            lblnome.Text = "LBLNOME";
            // 
            // Categoriacontrol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblnome);
            Controls.Add(lblid);
            Controls.Add(btexcluir);
            Controls.Add(bteditar);
            Name = "Categoriacontrol";
            Size = new Size(425, 109);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bteditar;
        private Button btexcluir;
        private Label lblid;
        private Label lblnome;
    }
}
