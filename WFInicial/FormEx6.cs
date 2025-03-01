using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx6 : Form
    {
        public FormEx6()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

            string nome = (txtNome.Text);
            int quantidadeHoras = int.Parse(txtHoras.Text);
            int valorHora = int.Parse(txtValorHora.Text);

            int resultado = quantidadeHoras * valorHora;

            string mensagem = $"A renda total de {nome} é R${resultado:F2}";

            MessageBox.Show(mensagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
