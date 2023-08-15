namespace Launcher.ControledeUsuario
{
    partial class UC_Perfil
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            PbxImagemPerfil = new PictureBox();
            BtnTrocarImagem = new Button();
            ((System.ComponentModel.ISupportInitialize)PbxImagemPerfil).BeginInit();
            SuspendLayout();
            // 
            // PbxImagemPerfil
            // 
            PbxImagemPerfil.Location = new Point(0, 0);
            PbxImagemPerfil.Name = "PbxImagemPerfil";
            PbxImagemPerfil.Size = new Size(175, 175);
            PbxImagemPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxImagemPerfil.TabIndex = 2;
            PbxImagemPerfil.TabStop = false;
            // 
            // BtnTrocarImagem
            // 
            BtnTrocarImagem.Location = new Point(3, 181);
            BtnTrocarImagem.Name = "BtnTrocarImagem";
            BtnTrocarImagem.Size = new Size(30, 30);
            BtnTrocarImagem.TabIndex = 3;
            BtnTrocarImagem.UseVisualStyleBackColor = true;
            BtnTrocarImagem.Click += BtnTrocarImagem_Click;
            // 
            // UC_Perfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnTrocarImagem);
            Controls.Add(PbxImagemPerfil);
            Name = "UC_Perfil";
            Size = new Size(800, 560);
            ((System.ComponentModel.ISupportInitialize)PbxImagemPerfil).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox PbxImagemPerfil;
        private Button BtnTrocarImagem;
    }
}
