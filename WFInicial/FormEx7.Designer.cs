namespace WFInicial
{
    partial class FormEx7
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
            lblProduto = new Label();
            lblPrecoProduto = new Label();
            txtNomeProduto = new TextBox();
            txtValorProduto = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(140, 58);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(86, 15);
            lblProduto.TabIndex = 3;
            lblProduto.Text = "Nome Produto";
            // 
            // lblPrecoProduto
            // 
            lblPrecoProduto.AutoSize = true;
            lblPrecoProduto.Location = new Point(140, 126);
            lblPrecoProduto.Name = "lblPrecoProduto";
            lblPrecoProduto.Size = new Size(100, 15);
            lblPrecoProduto.TabIndex = 6;
            lblPrecoProduto.Text = "Preço do Produto";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(140, 76);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(100, 23);
            txtNomeProduto.TabIndex = 7;
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(140, 144);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.Size = new Size(100, 23);
            txtValorProduto.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(140, 193);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 23);
            btnCadastrar.TabIndex = 19;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCalcular_Click;
            // 
            // FormEx7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(txtValorProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblPrecoProduto);
            Controls.Add(lblProduto);
            Name = "FormEx7";
            Text = "FormEx7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduto;
        private Label lblPrecoProduto;
        private TextBox txtNomeProduto;
        private TextBox txtValorProduto;
        private Button btnCadastrar;
    }
}