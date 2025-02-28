namespace WFInicial
{
    partial class FormEx2
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
            IblDiaSemana = new Label();
            txtDiaSemana = new TextBox();
            btnEscolher = new Button();
            SuspendLayout();
            // 
            // IblDiaSemana
            // 
            IblDiaSemana.AutoSize = true;
            IblDiaSemana.Location = new Point(189, 96);
            IblDiaSemana.Name = "IblDiaSemana";
            IblDiaSemana.Size = new Size(88, 15);
            IblDiaSemana.TabIndex = 0;
            IblDiaSemana.Text = "Dia da Semana ";
            // 
            // txtDiaSemana
            // 
            txtDiaSemana.Location = new Point(283, 93);
            txtDiaSemana.Name = "txtDiaSemana";
            txtDiaSemana.Size = new Size(100, 23);
            txtDiaSemana.TabIndex = 1;
            // 
            // btnEscolher
            // 
            btnEscolher.Location = new Point(401, 92);
            btnEscolher.Name = "btnEscolher";
            btnEscolher.Size = new Size(75, 23);
            btnEscolher.TabIndex = 2;
            btnEscolher.Text = "Escolher";
            btnEscolher.UseVisualStyleBackColor = true;
            btnEscolher.Click += btnEscolher_Click;
            // 
            // FormEx2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEscolher);
            Controls.Add(txtDiaSemana);
            Controls.Add(IblDiaSemana);
            Name = "FormEx2";
            Text = "FormEx2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IblDiaSemana;
        private TextBox txtDiaSemana;
        private Button btnEscolher;
    }
}