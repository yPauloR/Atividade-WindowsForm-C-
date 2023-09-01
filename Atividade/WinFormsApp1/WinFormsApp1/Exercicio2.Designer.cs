namespace WinFormsApp1
{
    partial class Exercicio2
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
            AdicionarButtom = new Button();
            btnCalcular = new Button();
            groupBox1 = new GroupBox();
            txtFilhos = new TextBox();
            txtSalario = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AdicionarButtom
            // 
            AdicionarButtom.Anchor = AnchorStyles.None;
            AdicionarButtom.Location = new Point(13, 268);
            AdicionarButtom.Name = "AdicionarButtom";
            AdicionarButtom.Size = new Size(111, 34);
            AdicionarButtom.TabIndex = 8;
            AdicionarButtom.Text = "Adicionar";
            AdicionarButtom.UseVisualStyleBackColor = true;
            AdicionarButtom.Click += btnCalcular_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.None;
            btnCalcular.Location = new Point(202, 268);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(111, 34);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += AdicionarButtom_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFilhos);
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 200);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // txtFilhos
            // 
            txtFilhos.Location = new Point(106, 155);
            txtFilhos.Name = "txtFilhos";
            txtFilhos.Size = new Size(100, 25);
            txtFilhos.TabIndex = 13;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(106, 112);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 25);
            txtSalario.TabIndex = 12;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(106, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 25);
            txtNome.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 161);
            label3.Name = "label3";
            label3.Size = new Size(87, 17);
            label3.TabIndex = 9;
            label3.Text = "N° de Filhos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 112);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 8;
            label2.Text = "Salário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 66);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(124, 24);
            label4.Name = "label4";
            label4.Size = new Size(92, 17);
            label4.TabIndex = 10;
            label4.Text = "Media Sálario";
            // 
            // Exercicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(groupBox1);
            Controls.Add(btnCalcular);
            Controls.Add(AdicionarButtom);
            Controls.Add(label4);
            Name = "Exercicio2";
            Text = "Exercicio2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AdicionarButtom;
        private Button btnCalcular;
        private GroupBox groupBox1;
        private TextBox txtFilhos;
        private TextBox txtSalario;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}