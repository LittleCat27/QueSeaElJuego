using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QueSeaElJuego.Models;

namespace QueSeaElJuego.Forms
{
    public partial class FormLogin : Form
    {
        private int contadorLetras = 10;
        private float letraSize = 18F;
        private FormPrincipal FPrincipal;
        private string UserName;
        private string Password;
        public FormLogin(FormPrincipal FPrincipal)
        {
            InitializeComponent();
            this.FPrincipal = FPrincipal;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.FPrincipal.Hide();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            intentarLogin();
        }

        private void intentarLogin()
        {
            QueSeaElJuegoEntities dbContext = new QueSeaElJuegoEntities();
            var query = from p in dbContext.USER
                        where p.UserName.ToLower() == this.UserName.ToLower()
                        select p.UserPass;
            if (query.Count() > 0)
            {
                if (query.Single().Trim() == txtClave.Text.Trim())
                {
                    FPrincipal.CargarUsuario(this.UserName.ToLower());
                    FPrincipal.Show();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }
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

        private void lblRegistrase_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormRegister fRegistro = new FormRegister(this);
            fRegistro.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            this.UserName = txtUsuario.Text;
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            this.Password = txtClave.Text;
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                intentarLogin();
            }
        }

        private void jugarSinDB_Click(object sender, EventArgs e)
        {
            PantallaPhoto pantallaPhoto = new PantallaPhoto(this.FPrincipal);
            pantallaPhoto.Show();
            this.Dispose();
        }
    }
}
