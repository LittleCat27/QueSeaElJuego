using QueSeaElJuego.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueSeaElJuego
{
    public partial class FormPrincipal : Form
    {
        private string Username;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FormLogin formLogin = new FormLogin(this);
            formLogin.Show();
            
            this.BackgroundImage = Image.FromFile(Directory.GetParent("..")+@"\Recursos\Fondos\FondoFantasia.png");
            this.tblIzqInterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblIzqInterior.BackgroundImage = Image.FromFile(Directory.GetParent("..") + @"\Recursos\Fondos\maderaFondo.png");
        }

        public void CargarUsuario(string Username)
        {
            this.Username = Username;
        }
        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }


        #region Hacer el Formulario Arrastrable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCrearPersonaje_Click(object sender, EventArgs e)
        {
            new PantallaPhoto(this).Show();
            this.Hide();
        }
    }
}
