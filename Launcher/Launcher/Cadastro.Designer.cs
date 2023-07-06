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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            BtnMinimizaCAD = new Button();
            BtnSair2 = new Button();
            BtnCriarConta = new Button();
            SuspendLayout();
            // 
            // BtnMinimiza
            // 
            BtnMinimiza.Location = new Point(718, 12);
            BtnMinimiza.Name = "BtnMinimiza";
            BtnMinimiza.Size = new Size(32, 32);
            BtnMinimiza.TabIndex = 4;
            BtnMinimiza.UseVisualStyleBackColor = true;
            BtnMinimiza.Click += BtnMinimiza_Click;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(756, 12);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(32, 32);
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
            // textBox1
            // 
            textBox1.Location = new Point(65, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 293);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(65, 363);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(320, 27);
            textBox4.TabIndex = 13;
            // 
            // BtnMinimizaCAD
            // 
            BtnMinimizaCAD.Location = new Point(368, 12);
            BtnMinimizaCAD.Name = "BtnMinimizaCAD";
            BtnMinimizaCAD.Size = new Size(32, 32);
            BtnMinimizaCAD.TabIndex = 15;
            BtnMinimizaCAD.UseVisualStyleBackColor = true;
            BtnMinimizaCAD.Click += BtnMinimizaCAD_Click;
            // 
            // BtnSair2
            // 
            BtnSair2.Location = new Point(406, 12);
            BtnSair2.Name = "BtnSair2";
            BtnSair2.Size = new Size(32, 32);
            BtnSair2.TabIndex = 14;
            BtnSair2.UseVisualStyleBackColor = true;
            BtnSair2.Click += button2_Click;
            // 
            // BtnCriarConta
            // 
            BtnCriarConta.Location = new Point(175, 430);
            BtnCriarConta.Name = "BtnCriarConta";
            BtnCriarConta.Size = new Size(94, 29);
            BtnCriarConta.TabIndex = 16;
            BtnCriarConta.Text = "Criar conta";
            BtnCriarConta.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 500);
            Controls.Add(BtnCriarConta);
            Controls.Add(BtnMinimizaCAD);
            Controls.Add(BtnSair2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnMinimiza);
            Controls.Add(BtnSair);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cadastro";
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button BtnMinimizaCAD;
        private Button BtnSair2;
        private Button BtnCriarConta;
    }
}