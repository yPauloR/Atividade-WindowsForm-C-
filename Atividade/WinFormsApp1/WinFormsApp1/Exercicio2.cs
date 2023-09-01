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
    public partial class Exercicio2 : Form
    {
        private string[] nomes = new string[20];
        private double[] salarios = new double[20];
        private double[] numFilhos = new double[20];
        private int contador = 0;

        public Exercicio2()
        {
            InitializeComponent();
        }

        private void AdicionarButtom_Click(object sender, EventArgs e)
        {
            if (contador < 5)
            {
                string nome = txtNome.Text;
                double salario, filhos;

                if (double.TryParse(txtSalario.Text, out salario) && double.TryParse(txtFilhos.Text, out filhos))
                {
                    nomes[contador] = nome;
                    salarios[contador] = salario;
                    numFilhos[contador] = filhos;

                    contador++;
                    LimparCampos();
                    MessageBox.Show($"Informações da pessoa {contador} adicionadas com sucesso!");
                }
                else
                {
                    MessageBox.Show("Por favor, insira valores válidos para salário e número de filhos.");
                }
            }
            else
            {
                MessageBox.Show("Você já adicionou informações para 20 pessoas.");
            }
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtSalario.Clear();
            txtFilhos.Clear();
            txtNome.Focus();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MessageBox.Show("Nenhuma informação foi adicionada.");
                return;
            }

            double somaSalarios = 0;
            double somaNumFilhos = 0;
            double maiorSalario = double.MinValue;

            for (int i = 0; i < contador; i++)
            {
                somaSalarios += salarios[i];
                somaNumFilhos += numFilhos[i];

                if (salarios[i] > maiorSalario)
                {
                    maiorSalario = salarios[i];
                }
            }

            double mediaSalarios = somaSalarios / contador;
            double mediaNumFilhos = somaNumFilhos / contador;

            MessageBox.Show($"Média de Salários: {mediaSalarios:F2}\nMédia de Número de Filhos: {mediaNumFilhos:F2}\nMaior Salário: {maiorSalario:F2}");
        }
    }
}





