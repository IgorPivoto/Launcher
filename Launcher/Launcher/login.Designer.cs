namespace Launcher
{
    partial class Login
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
            panel1 = new Panel();
            BtnSair = new Button();
            BtnMinimiza = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LblCriaConta = new LinkLabel();
            LblEsqueceuSenha = new LinkLabel();
            BtnLogin = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(736, 12);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(32, 32);
            BtnSair.TabIndex = 1;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnMinimiza
            // 
            BtnMinimiza.Location = new Point(698, 12);
            BtnMinimiza.Name = "BtnMinimiza";
            BtnMinimiza.Size = new Size(32, 32);
            BtnMinimiza.TabIndex = 2;
            BtnMinimiza.UseVisualStyleBackColor = true;
            BtnMinimiza.Click += BtnMinimiza_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 128);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 200);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "senha:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(335, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(336, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 27);
            textBox2.TabIndex = 6;
            // 
            // LblCriaConta
            // 
            LblCriaConta.AutoSize = true;
            LblCriaConta.Location = new Point(335, 223);
            LblCriaConta.Name = "LblCriaConta";
            LblCriaConta.Size = new Size(81, 20);
            LblCriaConta.TabIndex = 7;
            LblCriaConta.TabStop = true;
            LblCriaConta.Text = "Criar conta";
            LblCriaConta.LinkClicked += LblCriaConta_LinkClicked;
            // 
            // LblEsqueceuSenha
            // 
            LblEsqueceuSenha.AutoSize = true;
            LblEsqueceuSenha.Location = new Point(582, 223);
            LblEsqueceuSenha.Name = "LblEsqueceuSenha";
            LblEsqueceuSenha.Size = new Size(115, 20);
            LblEsqueceuSenha.TabIndex = 8;
            LblEsqueceuSenha.TabStop = true;
            LblEsqueceuSenha.Text = "Esqueceu Senha";
            LblEsqueceuSenha.LinkClicked += LblEsqueceuSenha_LinkClicked;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(455, 280);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(100, 50);
            BtnLogin.TabIndex = 9;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 370);
            Controls.Add(BtnLogin);
            Controls.Add(LblEsqueceuSenha);
            Controls.Add(LblCriaConta);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnMinimiza);
            Controls.Add(BtnSair);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BtnSair;
        private Button BtnMinimiza;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel LblCriaConta;
        private LinkLabel LblEsqueceuSenha;
        private Button BtnLogin;
    }
}