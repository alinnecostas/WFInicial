﻿namespace WFInicial
{
    partial class FormEx4
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
            btnMaior = new Button();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            lblNum2 = new Label();
            lblNum1 = new Label();
            lblNum3 = new Label();
            txtNum3 = new TextBox();
            SuspendLayout();
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(188, 209);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(100, 23);
            btnMaior.TabIndex = 9;
            btnMaior.Text = "Mostrar Maior";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(188, 107);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 8;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(188, 69);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 7;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(104, 115);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(57, 15);
            lblNum2.TabIndex = 6;
            lblNum2.Text = "Numero2";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(104, 77);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(57, 15);
            lblNum1.TabIndex = 5;
            lblNum1.Text = "Numero1";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(104, 149);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(60, 15);
            lblNum3.TabIndex = 10;
            lblNum3.Text = "Numero 3";
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(188, 149);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 11;
            // 
            // FormEx4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 313);
            Controls.Add(txtNum3);
            Controls.Add(lblNum3);
            Controls.Add(btnMaior);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "FormEx4";
            Text = "FormEx4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMaior;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private Label lblNum2;
        private Label lblNum1;
        private Label lblNum3;
        private TextBox txtNum3;
    }
}