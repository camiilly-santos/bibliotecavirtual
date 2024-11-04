namespace bibliotecavirtual
{
    partial class Lista_desejo
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
            textBox1 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(151, 551);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 0;
            button1.Text = "Saiba mais...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(407, 551);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 1;
            button2.Text = "Saiba mais...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(634, 551);
            button3.Name = "button3";
            button3.Size = new Size(82, 23);
            button3.TabIndex = 2;
            button3.Text = "Saiba mais...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(410, 23);
            textBox1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(855, 581);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Voltar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Lista_desejo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.literatura__13_;
            ClientSize = new Size(942, 616);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Lista_desejo";
            Text = "Lista_desejo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
    }
}