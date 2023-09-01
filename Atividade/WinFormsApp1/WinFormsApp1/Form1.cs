namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exercicios1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex1 exercicio1 = new Ex1();
            exercicio1.Show();

        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio2 exercicio2 = new Exercicio2();
            exercicio2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio3 exercicio3 = new Exercicio3();
            exercicio3.Show();
        }
    }
}