using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAnos.Text, out int idade))
            {
                // Calcula a idade em dias
                int idadeEmDias = idade * 365 + (idade / 12) * 30;

                // Exibe a idade em dias na label de saída
                lblDias.Text = idadeEmDias + " Dias";
            }
            else
            {
                // Se a entrada não for um número válido, exibe uma mensagem de erro
                MessageBox.Show("Por favor, insira uma idade válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}