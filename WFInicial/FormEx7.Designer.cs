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
            txtProd1 = new TextBox();
            txtPreçoProd1 = new TextBox();
            txtPreçoProd5 = new TextBox();
            txtProd5 = new TextBox();
            txtPreçoProd4 = new TextBox();
            txtProd4 = new TextBox();
            txtPreçoProd3 = new TextBox();
            txtProd3 = new TextBox();
            txtPreçoProd2 = new TextBox();
            txtProd2 = new TextBox();
            txtPreçoProd6 = new TextBox();
            txtProd6 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(152, 47);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(86, 15);
            lblProduto.TabIndex = 3;
            lblProduto.Text = "Nome Produto";
            // 
            // lblPrecoProduto
            // 
            lblPrecoProduto.AutoSize = true;
            lblPrecoProduto.Location = new Point(289, 47);
            lblPrecoProduto.Name = "lblPrecoProduto";
            lblPrecoProduto.Size = new Size(100, 15);
            lblPrecoProduto.TabIndex = 6;
            lblPrecoProduto.Text = "Preço do Produto";
            // 
            // txtProd1
            // 
            txtProd1.Location = new Point(140, 76);
            txtProd1.Name = "txtProd1";
            txtProd1.Size = new Size(100, 23);
            txtProd1.TabIndex = 7;
            // 
            // txtPreçoProd1
            // 
            txtPreçoProd1.Location = new Point(289, 76);
            txtPreçoProd1.Name = "txtPreçoProd1";
            txtPreçoProd1.Size = new Size(100, 23);
            txtPreçoProd1.TabIndex = 8;
            // 
            // txtPreçoProd5
            // 
            txtPreçoProd5.Location = new Point(293, 192);
            txtPreçoProd5.Name = "txtPreçoProd5";
            txtPreçoProd5.Size = new Size(100, 23);
            txtPreçoProd5.TabIndex = 10;
            // 
            // txtProd5
            // 
            txtProd5.Location = new Point(140, 192);
            txtProd5.Name = "txtProd5";
            txtProd5.Size = new Size(100, 23);
            txtProd5.TabIndex = 9;
            // 
            // txtPreçoProd4
            // 
            txtPreçoProd4.Location = new Point(291, 163);
            txtPreçoProd4.Name = "txtPreçoProd4";
            txtPreçoProd4.Size = new Size(100, 23);
            txtPreçoProd4.TabIndex = 12;
            // 
            // txtProd4
            // 
            txtProd4.Location = new Point(140, 163);
            txtProd4.Name = "txtProd4";
            txtProd4.Size = new Size(100, 23);
            txtProd4.TabIndex = 11;
            // 
            // txtPreçoProd3
            // 
            txtPreçoProd3.Location = new Point(291, 134);
            txtPreçoProd3.Name = "txtPreçoProd3";
            txtPreçoProd3.Size = new Size(100, 23);
            txtPreçoProd3.TabIndex = 14;
            // 
            // txtProd3
            // 
            txtProd3.Location = new Point(140, 134);
            txtProd3.Name = "txtProd3";
            txtProd3.Size = new Size(100, 23);
            txtProd3.TabIndex = 13;
            // 
            // txtPreçoProd2
            // 
            txtPreçoProd2.Location = new Point(289, 105);
            txtPreçoProd2.Name = "txtPreçoProd2";
            txtPreçoProd2.Size = new Size(100, 23);
            txtPreçoProd2.TabIndex = 16;
            // 
            // txtProd2
            // 
            txtProd2.Location = new Point(140, 105);
            txtProd2.Name = "txtProd2";
            txtProd2.Size = new Size(100, 23);
            txtProd2.TabIndex = 15;
            // 
            // txtPreçoProd6
            // 
            txtPreçoProd6.Location = new Point(293, 221);
            txtPreçoProd6.Name = "txtPreçoProd6";
            txtPreçoProd6.Size = new Size(100, 23);
            txtPreçoProd6.TabIndex = 18;
            // 
            // txtProd6
            // 
            txtProd6.Location = new Point(140, 221);
            txtProd6.Name = "txtProd6";
            txtProd6.Size = new Size(100, 23);
            txtProd6.TabIndex = 17;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(138, 272);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(253, 23);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormEx7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtPreçoProd6);
            Controls.Add(txtProd6);
            Controls.Add(txtPreçoProd2);
            Controls.Add(txtProd2);
            Controls.Add(txtPreçoProd3);
            Controls.Add(txtProd3);
            Controls.Add(txtPreçoProd4);
            Controls.Add(txtProd4);
            Controls.Add(txtPreçoProd5);
            Controls.Add(txtProd5);
            Controls.Add(txtPreçoProd1);
            Controls.Add(txtProd1);
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
        private TextBox txtProd1;
        private TextBox txtPreçoProd1;
        private TextBox txtPreçoProd5;
        private TextBox txtProd5;
        private TextBox txtPreçoProd4;
        private TextBox txtProd4;
        private TextBox txtPreçoProd3;
        private TextBox txtProd3;
        private TextBox txtPreçoProd2;
        private TextBox txtProd2;
        private TextBox txtPreçoProd6;
        private TextBox txtProd6;
        private Button btnCalcular;
    }
}