namespace WinFormsApp1
{
    partial class Ex1
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
            label2 = new Label();
            btnCalcular = new Button();
            groupBox1 = new GroupBox();
            lblDias = new Label();
            label3 = new Label();
            txtAnos = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(124, 24);
            label2.Name = "label2";
            label2.Size = new Size(152, 17);
            label2.TabIndex = 2;
            label2.Text = "Converte Anos em Dias";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(124, 256);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(111, 34);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDias);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAnos);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 130);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // lblDias
            // 
            lblDias.BackColor = SystemColors.ActiveBorder;
            lblDias.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDias.Location = new Point(137, 74);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(100, 23);
            lblDias.TabIndex = 9;
            lblDias.Text = "\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 74);
            label3.Name = "label3";
            label3.Size = new Size(126, 17);
            label3.TabIndex = 8;
            label3.Text = "Sua idade em Dias:";
            // 
            // txtAnos
            // 
            txtAnos.Location = new Point(137, 31);
            txtAnos.Name = "txtAnos";
            txtAnos.Size = new Size(100, 25);
            txtAnos.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(108, 17);
            label1.TabIndex = 6;
            label1.Text = "Idade em Anos: ";
            // 
            // Ex1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(groupBox1);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Name = "Ex1";
            Text = "Ex1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnCalcular;
        private GroupBox groupBox1;
        private Label lblDias;
        private Label label3;
        private TextBox txtAnos;
        private Label label1;
    }
}