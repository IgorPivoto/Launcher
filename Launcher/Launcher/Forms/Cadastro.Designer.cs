namespace Launcher
{
    partial class Cadastro
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
            BtnMinimiza = new Button();
            BtnSair = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Tbxnome = new TextBox();
            TbxEmail = new TextBox();
            TbxSenha = new TextBox();
            TbxconfirmaSenha = new TextBox();
            BtnCriarConta = new Button();
            PnlloginMexe = new Panel();
            BtnverSenha1 = new Button();
            BtnconfimarSenha = new Button();
            BtnvoltarLogin = new Button();
            LblAviso = new Label();
            SuspendLayout();
            // 
            // BtnMinimiza
            // 
            BtnMinimiza.Location = new Point(370, 0);
            BtnMinimiza.Name = "BtnMinimiza";
            BtnMinimiza.Size = new Size(40, 40);
            BtnMinimiza.TabIndex = 4;
            BtnMinimiza.UseVisualStyleBackColor = true;
            BtnMinimiza.Click += BtnMinimiza_Click;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(410, 0);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(40, 40);
            BtnSair.TabIndex = 3;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 60);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 5;
            label1.Text = "Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 130);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 200);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 270);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 8;
            label4.Text = "Senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 340);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 9;
            label5.Text = "Conrfirmar senha";
            // 
            // Tbxnome
            // 
            Tbxnome.Location = new Point(65, 153);
            Tbxnome.Name = "Tbxnome";
            Tbxnome.Size = new Size(320, 27);
            Tbxnome.TabIndex = 10;
            // 
            // TbxEmail
            // 
            TbxEmail.Location = new Point(65, 223);
            TbxEmail.Name = "TbxEmail";
            TbxEmail.Size = new Size(320, 27);
            TbxEmail.TabIndex = 11;
            // 
            // TbxSenha
            // 
            TbxSenha.Location = new Point(65, 293);
            TbxSenha.Name = "TbxSenha";
            TbxSenha.Size = new Size(320, 27);
            TbxSenha.TabIndex = 12;
            TbxSenha.UseSystemPasswordChar = true;
            // 
            // TbxconfirmaSenha
            // 
            TbxconfirmaSenha.Location = new Point(65, 363);
            TbxconfirmaSenha.Name = "TbxconfirmaSenha";
            TbxconfirmaSenha.Size = new Size(320, 27);
            TbxconfirmaSenha.TabIndex = 13;
            TbxconfirmaSenha.UseSystemPasswordChar = true;
            // 
            // BtnCriarConta
            // 
            BtnCriarConta.Location = new Point(175, 430);
            BtnCriarConta.Name = "BtnCriarConta";
            BtnCriarConta.Size = new Size(94, 29);
            BtnCriarConta.TabIndex = 16;
            BtnCriarConta.Text = "Criar conta";
            BtnCriarConta.UseVisualStyleBackColor = true;
            BtnCriarConta.Click += BtnCriarConta_Click;
            // 
            // PnlloginMexe
            // 
            PnlloginMexe.BackColor = SystemColors.ActiveBorder;
            PnlloginMexe.Location = new Point(0, 0);
            PnlloginMexe.Name = "PnlloginMexe";
            PnlloginMexe.Size = new Size(370, 40);
            PnlloginMexe.TabIndex = 17;
            // 
            // BtnverSenha1
            // 
            BtnverSenha1.Location = new Point(391, 293);
            BtnverSenha1.Name = "BtnverSenha1";
            BtnverSenha1.Size = new Size(30, 30);
            BtnverSenha1.TabIndex = 18;
            BtnverSenha1.UseVisualStyleBackColor = true;
            BtnverSenha1.Click += BtnverSenha1_Click;
            // 
            // BtnconfimarSenha
            // 
            BtnconfimarSenha.Location = new Point(391, 363);
            BtnconfimarSenha.Name = "BtnconfimarSenha";
            BtnconfimarSenha.Size = new Size(30, 30);
            BtnconfimarSenha.TabIndex = 19;
            BtnconfimarSenha.UseVisualStyleBackColor = true;
            BtnconfimarSenha.Click += BtnconfimarSenha_Click;
            // 
            // BtnvoltarLogin
            // 
            BtnvoltarLogin.Location = new Point(12, 459);
            BtnvoltarLogin.Name = "BtnvoltarLogin";
            BtnvoltarLogin.Size = new Size(94, 29);
            BtnvoltarLogin.TabIndex = 20;
            BtnvoltarLogin.Text = "Login";
            BtnvoltarLogin.UseVisualStyleBackColor = true;
            BtnvoltarLogin.Click += BtnvoltarLogin_Click;
            // 
            // LblAviso
            // 
            LblAviso.AutoSize = true;
            LblAviso.ForeColor = Color.Red;
            LblAviso.Location = new Point(219, 471);
            LblAviso.Name = "LblAviso";
            LblAviso.Size = new Size(0, 20);
            LblAviso.TabIndex = 21;
            LblAviso.Click += LblAviso_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 500);
            Controls.Add(LblAviso);
            Controls.Add(BtnvoltarLogin);
            Controls.Add(BtnconfimarSenha);
            Controls.Add(BtnverSenha1);
            Controls.Add(PnlloginMexe);
            Controls.Add(BtnCriarConta);
            Controls.Add(TbxconfirmaSenha);
            Controls.Add(TbxSenha);
            Controls.Add(TbxEmail);
            Controls.Add(Tbxnome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnMinimiza);
            Controls.Add(BtnSair);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMinimiza;
        private Button BtnSair;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Tbxnome;
        private TextBox TbxEmail;
        private TextBox TbxSenha;
        private TextBox TbxconfirmaSenha;
        private Button BtnCriarConta;
        private Panel PnlloginMexe;
        private Button BtnverSenha1;
        private Button BtnconfimarSenha;
        private Button BtnvoltarLogin;
        private Label LblAviso;
    }
}