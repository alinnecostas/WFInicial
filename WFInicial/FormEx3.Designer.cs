namespace WFInicial
{
    partial class FormEx3
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnMaior = new Button();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(57, 126);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(57, 15);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Numero1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(57, 164);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(57, 15);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Numero2";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(141, 118);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(141, 156);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 3;
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(141, 198);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(100, 23);
            btnMaior.TabIndex = 4;
            btnMaior.Text = "Mostrar Maior";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // FormEx3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 318);
            Controls.Add(btnMaior);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "FormEx3";
            Text = "FormEx3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnMaior;
    }
}