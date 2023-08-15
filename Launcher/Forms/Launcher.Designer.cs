namespace Launcher
{
    partial class Launcher
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
            BtnMaximiza = new Button();
            PnlloginMexe = new Panel();
            BtnPerfil = new Button();
            BtnMostraJogos = new Button();
            BtnTrailers = new Button();
            BtnSobre = new Button();
            PnlConteiner = new Panel();
            SuspendLayout();
            // 
            // BtnMinimiza
            // 
            BtnMinimiza.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimiza.Location = new Point(780, 0);
            BtnMinimiza.Name = "BtnMinimiza";
            BtnMinimiza.Size = new Size(40, 40);
            BtnMinimiza.TabIndex = 4;
            BtnMinimiza.UseVisualStyleBackColor = true;
            BtnMinimiza.Click += BtnMinimiza_Click;
            // 
            // BtnSair
            // 
            BtnSair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSair.Location = new Point(860, 0);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(40, 40);
            BtnSair.TabIndex = 3;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnMaximiza
            // 
            BtnMaximiza.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMaximiza.Location = new Point(820, 0);
            BtnMaximiza.Name = "BtnMaximiza";
            BtnMaximiza.Size = new Size(40, 40);
            BtnMaximiza.TabIndex = 5;
            BtnMaximiza.UseVisualStyleBackColor = true;
            BtnMaximiza.Click += BtnMaximiza_Click;
            // 
            // PnlloginMexe
            // 
            PnlloginMexe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PnlloginMexe.BackColor = SystemColors.ActiveBorder;
            PnlloginMexe.Location = new Point(0, 0);
            PnlloginMexe.Name = "PnlloginMexe";
            PnlloginMexe.Size = new Size(780, 40);
            PnlloginMexe.TabIndex = 11;
            // 
            // BtnPerfil
            // 
            BtnPerfil.Location = new Point(0, 40);
            BtnPerfil.Name = "BtnPerfil";
            BtnPerfil.Size = new Size(100, 100);
            BtnPerfil.TabIndex = 0;
            BtnPerfil.UseVisualStyleBackColor = true;
            BtnPerfil.Click += BtnPerfil_Click;
            // 
            // BtnMostraJogos
            // 
            BtnMostraJogos.Location = new Point(0, 140);
            BtnMostraJogos.Name = "BtnMostraJogos";
            BtnMostraJogos.Size = new Size(100, 50);
            BtnMostraJogos.TabIndex = 14;
            BtnMostraJogos.UseVisualStyleBackColor = true;
            BtnMostraJogos.Click += BtnMostraJogos_Click;
            // 
            // BtnTrailers
            // 
            BtnTrailers.Location = new Point(0, 190);
            BtnTrailers.Name = "BtnTrailers";
            BtnTrailers.Size = new Size(100, 50);
            BtnTrailers.TabIndex = 15;
            BtnTrailers.UseVisualStyleBackColor = true;
            BtnTrailers.Click += BtnTrailers_Click;
            // 
            // BtnSobre
            // 
            BtnSobre.Location = new Point(0, 240);
            BtnSobre.Name = "BtnSobre";
            BtnSobre.Size = new Size(100, 50);
            BtnSobre.TabIndex = 16;
            BtnSobre.UseVisualStyleBackColor = true;
            BtnSobre.Click += BtnSobre_Click;
            // 
            // PnlConteiner
            // 
            PnlConteiner.Location = new Point(100, 40);
            PnlConteiner.Name = "PnlConteiner";
            PnlConteiner.Size = new Size(800, 560);
            PnlConteiner.TabIndex = 17;
            // 
            // Launcher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(900, 600);
            Controls.Add(PnlConteiner);
            Controls.Add(BtnSobre);
            Controls.Add(BtnTrailers);
            Controls.Add(BtnMostraJogos);
            Controls.Add(BtnPerfil);
            Controls.Add(PnlloginMexe);
            Controls.Add(BtnMaximiza);
            Controls.Add(BtnMinimiza);
            Controls.Add(BtnSair);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Launcher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Launcher";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnMinimiza;
        private Button BtnSair;
        private Button BtnMaximiza;
        private Panel PnlloginMexe;
        private Button BtnPerfil;
        private Button BtnMostraJogos;
        private Button BtnTrailers;
        private Button BtnSobre;
        private Panel PnlConteiner;
    }
}