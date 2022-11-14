using QueSeaElJuego.UserControls;
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

namespace QueSeaElJuego.Forms
{
    public partial class FormJuego : Form
    {
        private FormPrincipal FPrincipal;
        public FormJuego(FormPrincipal FPrincipal)
        {
            InitializeComponent();
            this.FPrincipal = FPrincipal;
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {
            pbCuerpo.Image = Image.FromFile(Directory.GetParent("..") + @"\Recursos\Fondos\cuerpo.png");
        }
        
        public void cargarCara(Image cara)
        {
            this.pbCara.Image = cara;
        }


        #region Hacer el Formulario Arrastrable (ACTUALMENTE DESACTIVADO)

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

        #region Movimiento de Puntero

        private void FormJuego_MouseMove(object sender, MouseEventArgs e)
        {
            const int pixelesBorde = 50; //Con esto se decide hasta donde podra moverse el puntero, el 40 representa 40 pixeles antes de salir del form
            Point supMax = new Point(pixelesBorde, pixelesBorde);
            Point supMin = new Point(this.Size.Width - pixelesBorde, this.Size.Height - pixelesBorde);
            Size tObjeto = this.puntero.Size;//tamaño del objeto
            if (e.X < supMin.X && e.Y < supMin.Y && e.X > supMax.X && e.Y > supMax.Y)
            {
                Point NuevoPunto = e.Location;
                NuevoPunto.Y -= tObjeto.Height/2;
                NuevoPunto.X -= tObjeto.Width/2;
                this.puntero.Location = NuevoPunto;
            }
        }

        private void puntero_MouseMove(object sender, MouseEventArgs e)
        {
            const int pixelesBorde = 50; //Con esto se decide hasta donde podra moverse el puntero, el 40 representa 40 pixeles antes de salir del form
            Point supMax = new Point(pixelesBorde, pixelesBorde);
            Point supMin = new Point(this.Size.Width - pixelesBorde, this.Size.Height - pixelesBorde);
            Point posicionActual = puntero.Location;
            posicionActual.Y += e.Y;
            posicionActual.X += e.X;
            Size tObjeto = this.puntero.Size;//tamaño del objeto

            if (posicionActual.X < supMin.X && posicionActual.Y < supMin.Y && posicionActual.X > supMax.X && posicionActual.Y > supMax.Y)
            {
                Point NuevoPunto = this.puntero.Location;
                NuevoPunto.Y += e.Y - tObjeto.Height/2;
                NuevoPunto.X += e.X - tObjeto.Width/2;
                this.puntero.Location = NuevoPunto;
            }
        }

        #endregion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void puntero_Click(object sender, EventArgs e)
        {
            Bala bala = new Bala();
            Point posActual = pbCara.Location;
            Point posObjetivo = puntero.Location;
            posActual.X += pbCara.Width / 2;
            posActual.Y += pbCara.Height / 2;
            posObjetivo.X += puntero.Width / 2;
            posObjetivo.Y += puntero.Height / 2;
            bala.objetivo(posObjetivo, posActual);
            this.Controls.Add(bala);
        }
    }
}
