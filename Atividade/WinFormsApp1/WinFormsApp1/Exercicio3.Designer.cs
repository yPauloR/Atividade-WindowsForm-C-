namespace WinFormsApp1
{
    partial class Exercicio3
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
            groupBox1 = new GroupBox();
            txtNota1 = new TextBox();
            label1 = new Label();
            txtNota2 = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            AdicionarButton = new Button();
            y = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNota1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNota2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(40, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(112, 74);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 25);
            txtNota1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 42);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 11;
            label1.Text = "Nome do Aluno:";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(112, 105);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 25);
            txtNota2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 73);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 12;
            label2.Text = "1° Nota:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(112, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 25);
            txtNome.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 105);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 13;
            label3.Text = "2° Nota:";
            // 
            // AdicionarButton
            // 
            AdicionarButton.Location = new Point(40, 250);
            AdicionarButton.Name = "AdicionarButton";
            AdicionarButton.Size = new Size(111, 34);
            AdicionarButton.TabIndex = 2;
            AdicionarButton.Text = "Adicionar";
            AdicionarButton.UseVisualStyleBackColor = true;
            AdicionarButton.Click += CalcularButton_Click;
            // 
            // y
            // 
            y.Location = new Point(213, 250);
            y.Name = "y";
            y.Size = new Size(111, 34);
            y.TabIndex = 3;
            y.Text = "Calcular";
            y.UseVisualStyleBackColor = true;
            y.Click += AdicionarButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(124, 24);
            label4.Name = "label4";
            label4.Size = new Size(94, 17);
            label4.TabIndex = 4;
            label4.Text = "Calcula Média";
            // 
            // Exercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(label4);
            Controls.Add(y);
            Controls.Add(AdicionarButton);
            Controls.Add(groupBox1);
            Name = "Exercicio3";
            Text = "Exercicio3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNota1;
        private Label label1;
        private TextBox txtNota2;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private Button AdicionarButton;
        private Button y;
        private Label label4;
    }
}