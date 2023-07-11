using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Google.Cloud.Firestore;
using Launcher.Classes;

namespace Launcher
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            PnlloginMexe.MouseDown += Cursorbaixo;
            PnlloginMexe.MouseMove += Cursormove;
            PnlloginMexe.MouseUp += Cursorcima;
        }

        private bool estaSegurando = false;
        private Point lastCursorPosition;

        public void Cursorbaixo(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                estaSegurando = true;
                lastCursorPosition = Control.MousePosition;
            }
        }

        public void Cursormove(object sender, MouseEventArgs e)
        {
            if (estaSegurando)
            {
                int deltaX = Control.MousePosition.X - lastCursorPosition.X;
                int deltaY = Control.MousePosition.Y - lastCursorPosition.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
                lastCursorPosition = Control.MousePosition;
            }
        }

        public void Cursorcima(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                estaSegurando = false;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnverSenha1_Click(object sender, EventArgs e)
        {
            if (TbxSenha.UseSystemPasswordChar == true)
            {
                TbxSenha.UseSystemPasswordChar = false;
            }
            else
            {
                TbxSenha.UseSystemPasswordChar = true;
            }
        }

        private void BtnconfimarSenha_Click(object sender, EventArgs e)
        {
            if (TbxconfirmaSenha.UseSystemPasswordChar == true)
            {
                TbxconfirmaSenha.UseSystemPasswordChar = false;
            }
            else
            {
                TbxconfirmaSenha.UseSystemPasswordChar = true;
            }
        }

        private void BtnCriarConta_Click(object sender, EventArgs e)
        {
            if (TbxSenha.Text == TbxconfirmaSenha.Text)
            {
                var db = Firestorehelper.Database;

                if (ChecaSeUsarioExite())
                {
                    MessageBox.Show("Esse usuario já existe");
                    return;
                }

                var data = Pegardados();
                DocumentReference documentReference = db.Collection("DadosdoUsuario").Document(data.Email);
                documentReference.SetAsync(data);
                MessageBox.Show("gg");
            }
            else
            {
                LblAviso.Text = "Senhas diferentes";
            }
            /*var db = Firestorehelper.Database;

            if (ChecaSeUsarioExite())
            {
                MessageBox.Show("Esse usuario já existe");
                return;
            }

            var data = Pegardados();
            DocumentReference documentReference = db.Collection("DadosdoUsuario").Document(data.Email);
            documentReference.SetAsync(data);
            MessageBox.Show("gg");*/
        }

        private void BtnvoltarLogin_Click(object sender, EventArgs e)
        {
            Login logindocadastro = new Login();
            logindocadastro.Show();
            this.Hide();
        }

        private DadosdoUsuario Pegardados()
        {



            string nome = Tbxnome.Text.Trim();
            string email = TbxEmail.Text.Trim();
            string senha = TbxSenha.Text;
            string confimarsenha = TbxconfirmaSenha.Text.Trim();

            return new DadosdoUsuario()
            {
                Nome = nome,
                Email = email,
                Senha = senha,
                ConfirmaSenha = confimarsenha
            };
        }

        private bool ChecaSeUsarioExite()
        {
            string email = TbxEmail.Text.Trim();

            var db = Firestorehelper.Database;
            DocumentReference documentReference = db.Collection("DadosdoUsuario").Document(email);
            DadosdoUsuario data = documentReference.GetSnapshotAsync().Result.ConvertTo<DadosdoUsuario>();

            if (data != null)
            {
                return true;
            }
            return false;
        }

        private void LblAviso_Click(object sender, EventArgs e)
        {

        }
    }
}
