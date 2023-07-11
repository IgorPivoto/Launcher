using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Launcher : Form
    {
        public Launcher()
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
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximiza_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}
