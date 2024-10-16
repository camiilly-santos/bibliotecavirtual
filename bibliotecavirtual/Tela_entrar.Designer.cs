namespace bibliotecavirtual
{
    partial class Tela_entrar
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
            txbUser = new TextBox();
            txbPass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txbUser
            // 
            txbUser.Location = new Point(231, 272);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(185, 23);
            txbUser.TabIndex = 0;
            txbUser.TextChanged += textBox1_TextChanged;
            // 
            // txbPass
            // 
            txbPass.Location = new Point(231, 373);
            txbPass.Name = "txbPass";
            txbPass.Size = new Size(185, 23);
            txbPass.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(521, 449);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 2;
            button1.Text = "Iniciar sessão...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Tela_entrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.literatura__1_1;
            ClientSize = new Size(646, 484);
            Controls.Add(button1);
            Controls.Add(txbPass);
            Controls.Add(txbUser);
            Name = "Tela_entrar";
            Text = "Tela_entrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbUser;
        private TextBox txbPass;
        private Button button1;
    }
}