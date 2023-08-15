using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Google.Cloud.Firestore;
using Launcher.Classes;

namespace Launcher
{
    public partial class Login : Form
    {
        private bool estaSegurando = false;
        private Point lastCursorPosition;

        public Login()
        {
            InitializeComponent();

            PnlloginMexe.MouseDown += Cursorbaixo;
            PnlloginMexe.MouseMove += Cursormove;
            PnlloginMexe.MouseUp += Cursorcima;
        }

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

        private void LblCriaConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void LblEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueceuSenha esqueceuSenha = new EsqueceuSenha();
            esqueceuSenha.Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {



            string email = TbxEmail.Text.Trim();
            string senha = TbxSenha.Text;
            email = Criptografiaa(email);
            senha = Criptografiaa(senha);
            var db = Firestorehelper.Database;
            DocumentReference documentReference = db.Collection("DadosdoUsuario").Document(email);
            DadosdoUsuario data = documentReference.GetSnapshotAsync().Result.ConvertTo<DadosdoUsuario>();

            if (data != null)
            {
                if (senha == data.Senha)
                {
                    Launcher launcher = new Launcher();
                    launcher.Show();
                }

                else
                {
                    MessageBox.Show("not gg");
                }
            }

            else
            {
                MessageBox.Show("not gg");
            }

            /*if (TbxEmail.Text == "admin" && TbxSenha.Text == "admin")
            {
                Launcher launcher = new Launcher();
                launcher.Show();
            }
            else
            {
                MessageBox.Show("erro");
                Application.Exit();
            }*/


            this.Hide();
        }

        private void PnlloginMexe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnverSenha_Click(object sender, EventArgs e)
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

        private void BtnDev_Click(object sender, EventArgs e)
        {
            Launcher launcher = new Launcher();
            launcher.Show();
        }
        private static string Criptografiaa(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] info = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < info.Length; i++)
                {
                    sb.Append(info[i].ToString("x2"));
                }
                return sb.ToString();


            }
        }
    }
}