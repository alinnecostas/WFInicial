namespace WFInicial
{
    partial class FormEx6
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
            lblNome = new Label();
            lblHorasTrabalhadas = new Label();
            txtNome = new TextBox();
            txtHoras = new TextBox();
            lblValorHora = new Label();
            txtValorHora = new TextBox();
            btnResultado = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(146, 91);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(60, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Seu nome";
            // 
            // lblHorasTrabalhadas
            // 
            lblHorasTrabalhadas.AutoSize = true;
            lblHorasTrabalhadas.Location = new Point(146, 131);
            lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            lblHorasTrabalhadas.Size = new Size(102, 15);
            lblHorasTrabalhadas.TabIndex = 1;
            lblHorasTrabalhadas.Text = "Horas trabalhadas";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(273, 83);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(275, 120);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 3;
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(146, 166);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(76, 15);
            lblValorHora.TabIndex = 4;
            lblValorHora.Text = "Valor da hora";
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(275, 155);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(100, 23);
            txtValorHora.TabIndex = 5;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(275, 209);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(100, 23);
            btnResultado.TabIndex = 6;
            btnResultado.Text = "Resultado";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnResultado);
            Controls.Add(txtValorHora);
            Controls.Add(lblValorHora);
            Controls.Add(txtHoras);
            Controls.Add(txtNome);
            Controls.Add(lblHorasTrabalhadas);
            Controls.Add(lblNome);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblHorasTrabalhadas;
        private TextBox txtNome;
        private TextBox txtHoras;
        private Label lblValorHora;
        private TextBox txtValorHora;
        private Button btnResultado;
    }
}