namespace WFInicial
{
    partial class FormEx5
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
            txtNum3 = new TextBox();
            lblNum3 = new Label();
            btnMaiorEMenor = new Button();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            lblNum2 = new Label();
            lblNum1 = new Label();
            SuspendLayout();
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(207, 160);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(129, 23);
            txtNum3.TabIndex = 18;
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(123, 160);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(60, 15);
            lblNum3.TabIndex = 17;
            lblNum3.Text = "Numero 3";
            // 
            // btnMaiorEMenor
            // 
            btnMaiorEMenor.Location = new Point(207, 220);
            btnMaiorEMenor.Name = "btnMaiorEMenor";
            btnMaiorEMenor.Size = new Size(129, 46);
            btnMaiorEMenor.TabIndex = 16;
            btnMaiorEMenor.Text = "Mostrar Maior e Menor";
            btnMaiorEMenor.UseVisualStyleBackColor = true;
            btnMaiorEMenor.Click += btnMaiorEMenor_Click;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(207, 118);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(129, 23);
            txtNum2.TabIndex = 15;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(207, 80);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(129, 23);
            txtNum1.TabIndex = 14;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(123, 126);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(57, 15);
            lblNum2.TabIndex = 13;
            lblNum2.Text = "Numero2";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(123, 88);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(57, 15);
            lblNum1.TabIndex = 12;
            lblNum1.Text = "Numero1";
            // 
            // FormEx5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 421);
            Controls.Add(txtNum3);
            Controls.Add(lblNum3);
            Controls.Add(btnMaiorEMenor);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "FormEx5";
            Text = "FormEx5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum3;
        private Label lblNum3;
        private Button btnMaiorEMenor;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private Label lblNum2;
        private Label lblNum1;
    }
}