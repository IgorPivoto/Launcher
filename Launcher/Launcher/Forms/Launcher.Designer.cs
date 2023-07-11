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
            splitContainer1 = new SplitContainer();
            BtnPerfil = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 40);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnPerfil);
            splitContainer1.Size = new Size(900, 560);
            splitContainer1.SplitterDistance = 100;
            splitContainer1.TabIndex = 12;
            // 
            // BtnPerfil
            // 
            BtnPerfil.Location = new Point(0, 0);
            BtnPerfil.Name = "BtnPerfil";
            BtnPerfil.Size = new Size(100, 100);
            BtnPerfil.TabIndex = 0;
            BtnPerfil.UseVisualStyleBackColor = true;
            BtnPerfil.Click += BtnPerfil_Click;
            // 
            // Launcher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(900, 600);
            Controls.Add(splitContainer1);
            Controls.Add(PnlloginMexe);
            Controls.Add(BtnMaximiza);
            Controls.Add(BtnMinimiza);
            Controls.Add(BtnSair);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Launcher";
            Text = "Launcher";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnMinimiza;
        private Button BtnSair;
        private Button BtnMaximiza;
        private Panel PnlloginMexe;
        private SplitContainer splitContainer1;
        private Button BtnPerfil;
    }
}