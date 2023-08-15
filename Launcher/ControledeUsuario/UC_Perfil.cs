using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher.ControledeUsuario
{
    public partial class UC_Perfil : UserControl
    {
        public UC_Perfil()
        {
            InitializeComponent();
        }

        private void BtnTrocarImagem_Click(object sender, EventArgs e)
        {
            string localimagem = "";
            try
            {
                OpenFileDialog dialogo = new OpenFileDialog();
                dialogo.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.PNG)|*.PNG| All files (*.*)|*.*";
                if (dialogo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    localimagem = dialogo.FileName;
                    PbxImagemPerfil.ImageLocation = localimagem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("um erro ocorreu", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
