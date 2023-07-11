namespace Launcher
{
    partial class EsqueceuSenha
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
            BtnRedefinirSenha = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // BtnMinimiza
            // 
            BtnMinimiza.Location = new Point(518, 12);
            BtnMinimiza.Name = "BtnMinimiza";
            BtnMinimiza.Size = new Size(32, 32);
            BtnMinimiza.TabIndex = 4;
            BtnMinimiza.UseVisualStyleBackColor = true;
            BtnMinimiza.Click += BtnMinimiza_Click;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(556, 12);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(32, 32);
            BtnSair.TabIndex = 3;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnRedefinirSenha
            // 
            BtnRedefinirSenha.Location = new Point(250, 150);
            BtnRedefinirSenha.Name = "BtnRedefinirSenha";
            BtnRedefinirSenha.Size = new Size(100, 40);
            BtnRedefinirSenha.TabIndex = 5;
            BtnRedefinirSenha.Text = "Redefinir";
            BtnRedefinirSenha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 80);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "email:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 27);
            textBox1.TabIndex = 7;
            // 
            // EsqueceuSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 200);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(BtnRedefinirSenha);
            Controls.Add(BtnMinimiza);
            Controls.Add(BtnSair);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EsqueceuSenha";
            Text = "EsqueceuSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMinimiza;
        private Button BtnSair;
        private Button BtnRedefinirSenha;
        private Label label1;
        private TextBox textBox1;
    }
}