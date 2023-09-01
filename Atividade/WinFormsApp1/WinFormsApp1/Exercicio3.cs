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
    public partial class Exercicio3 : Form
    {
        private List<Aluno> alunos = new List<Aluno>();

        public Exercicio3()
        {
            InitializeComponent();
        }


        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            if (alunos.Count < 10)
            {
                string nome = txtNome.Text;
                double nota1, nota2;

                if (double.TryParse(txtNota2.Text, out nota1) && double.TryParse(txtNota1.Text, out nota2))
                {
                    Aluno aluno = new Aluno(nome, nota1, nota2);
                    alunos.Add(aluno);
                    LimparCampos();
                    MessageBox.Show($"Aluno adicionado com sucesso! Total de alunos: {alunos.Count}");
                }
                else
                {
                    MessageBox.Show("Por favor, insira notas válidas.");
                }
            }
            else
            {
                MessageBox.Show("Você já adicionou 10 alunos.");
            }
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtNota2.Clear();
            txtNota1.Clear();
            txtNome.Focus();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int aprovados = 0;
            int exame = 0;
            int reprovados = 0;
            double mediaClasse = 0;

            foreach (Aluno aluno in alunos)
            {
                double mediaAluno = (aluno.Nota1 + aluno.Nota2) / 2;
                mediaClasse += mediaAluno;

                if (mediaAluno >= 6)
                {
                    aprovados++;
                }
                else if (mediaAluno >= 5)
                {
                    exame++;
                }
                else
                {
                    reprovados++;
                }
            }

            mediaClasse /= alunos.Count;

            MessageBox.Show($"Média da classe: {mediaClasse:F2}\nAprovados: {aprovados}\nExame: {exame}\nReprovados: {reprovados}");
        }
    }

    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        public Aluno(string nome, double nota1, double nota2)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
        }
    }
}