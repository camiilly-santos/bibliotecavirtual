namespace bibliotecavirtual
{
    partial class Culpa_estrela
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(739, 406);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(705, 435);
            button2.Name = "button2";
            button2.Size = new Size(133, 23);
            button2.TabIndex = 1;
            button2.Text = "Adicionar à biblioteca";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(688, 464);
            button3.Name = "button3";
            button3.Size = new Size(165, 23);
            button3.TabIndex = 2;
            button3.Text = "Adicionar à lista de desejo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Culpa_estrela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.literatura__10_;
            ClientSize = new Size(879, 516);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Culpa_estrela";
            Text = "Culpa_estrela";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}