namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            exerciciosToolStripMenuItem = new ToolStripMenuItem();
            exercicios1ToolStripMenuItem = new ToolStripMenuItem();
            exercicio2ToolStripMenuItem = new ToolStripMenuItem();
            exercicio3ToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { exerciciosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(359, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // exerciciosToolStripMenuItem
            // 
            exerciciosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exercicios1ToolStripMenuItem, exercicio2ToolStripMenuItem, exercicio3ToolStripMenuItem, sairToolStripMenuItem });
            exerciciosToolStripMenuItem.Name = "exerciciosToolStripMenuItem";
            exerciciosToolStripMenuItem.Size = new Size(71, 20);
            exerciciosToolStripMenuItem.Text = "Exercicios";
            // 
            // exercicios1ToolStripMenuItem
            // 
            exercicios1ToolStripMenuItem.Name = "exercicios1ToolStripMenuItem";
            exercicios1ToolStripMenuItem.Size = new Size(135, 22);
            exercicios1ToolStripMenuItem.Text = "Exercicios 1";
            exercicios1ToolStripMenuItem.Click += exercicios1ToolStripMenuItem_Click;
            // 
            // exercicio2ToolStripMenuItem
            // 
            exercicio2ToolStripMenuItem.Name = "exercicio2ToolStripMenuItem";
            exercicio2ToolStripMenuItem.Size = new Size(135, 22);
            exercicio2ToolStripMenuItem.Text = "Exercicio 2";
            exercicio2ToolStripMenuItem.Click += exercicio2ToolStripMenuItem_Click;
            // 
            // exercicio3ToolStripMenuItem
            // 
            exercicio3ToolStripMenuItem.Name = "exercicio3ToolStripMenuItem";
            exercicio3ToolStripMenuItem.Size = new Size(135, 22);
            exercicio3ToolStripMenuItem.Text = "Exercicio 3";
            exercicio3ToolStripMenuItem.Click += exercicio3ToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(135, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(78, 126);
            label1.Name = "label1";
            label1.Size = new Size(181, 49);
            label1.TabIndex = 4;
            label1.Text = "Atividade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.One_planet_whit_0;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(359, 330);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            ForeColor = Color.DarkGreen;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Atividade";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exerciciosToolStripMenuItem;
        private ToolStripMenuItem exercicios1ToolStripMenuItem;
        private ToolStripMenuItem exercicio2ToolStripMenuItem;
        private ToolStripMenuItem exercicio3ToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Label label1;
    }
}