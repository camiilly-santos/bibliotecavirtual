﻿namespace bibliotecavirtual
{
    partial class Amanhecer
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
            button1.Location = new Point(851, 373);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(821, 402);
            button2.Name = "button2";
            button2.Size = new Size(138, 23);
            button2.TabIndex = 1;
            button2.Text = "Adicionar à biblioteca";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(810, 431);
            button3.Name = "button3";
            button3.Size = new Size(159, 23);
            button3.TabIndex = 2;
            button3.Text = "Adicionar à lista de desejo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Amanhecer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.literatura__25_;
            ClientSize = new Size(1009, 478);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Amanhecer";
            Text = "Amanhecer";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}