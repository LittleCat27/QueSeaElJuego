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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QueSeaElJuego.Forms
{
    public partial class FormRegister : Form
    {
        /*
        private int contadorLetras = 10;
        private float letraSize = 18F;
        private FormPrincipal FPrincipal;
        */
        private string UserName;
        private bool IsRegistered = false;
        private string Password;
        private bool isPasswordValid = false;
        
        private FormLogin login;
        public FormRegister(FormLogin login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            login.Enabled = true;
            this.Close();
            this.Dispose();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if(!this.IsRegistered && this.isPasswordValid)
            {
                QSEJEntities dbContext = new QSEJEntities();
                USER nuevoUsuario = new USER();
                nuevoUsuario.UserPartTotal = 0;
                nuevoUsuario.UserPartPerd = 0;
                nuevoUsuario.UserPartComp = 0;
                nuevoUsuario.UserNivel = 1;
                nuevoUsuario.UserExp = 0;
                nuevoUsuario.UserName = this.UserName.ToLower();
                nuevoUsuario.UserPass = this.Password;
                dbContext.USER.Add(nuevoUsuario);
                dbContext.SaveChanges();
                login.Enabled = true;
                this.Close();
                this.Dispose();
            }

        }

        private async void txtUsuario_Leave(object sender, EventArgs e)
        {
            this.UserName = txtUsuario.Text;


            //Validacion que el usuario no exista
            QSEJEntities dbContext = new QSEJEntities();
            var query = from p in dbContext.USER
                        where p.UserName.ToLower() == UserName.ToLower()
                        select p.UserName;
            if (query.Any())
            {
                lblMensaje.Visible = true;
                IsRegistered = true;
            }
            else
            {
                IsRegistered = false;
                this.UserName = txtUsuario.Text;
                lblMensaje.Visible = false;
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Visible = false;
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text.Length < 4)
            {
                lblMensajeClave.Visible = true;
                isPasswordValid = false;
            }
            else
            {
                isPasswordValid = true;
                lblMensajeClave.Visible = false;
                this.Password = txtClave.Text;
            }
        }
    }
}
