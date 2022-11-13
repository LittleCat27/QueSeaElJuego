using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using QueSeaElJuego.Forms;

namespace QueSeaElJuego.Forms
{
    public partial class PantallaPhoto : Form
    {
        private VideoCapture camara;
        private Mat frame;
        private int contador;
        private FormPrincipal FPrincipal;

        public PantallaPhoto(FormPrincipal FPrincipal)
        {
            InitializeComponent();
            this.FPrincipal = FPrincipal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {   

            frame = new Mat();

            //106 a la derecha y hacia abajo -- 421; 70 posicion inicial
            int x = 421, y = 70, c = 1;
            string path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
            for (int i = 0; i < 5; i++)
            {
                /*
                for (int j = 0; j < 3; j++)
                {
                    PictureBox avatar = new PictureBox();
                    avatar.Location = new System.Drawing.Point(x, y);
                    avatar.Name = "avatar" + c;
                    avatar.Size = new System.Drawing.Size(100, 70);
                    avatar.Image = resizeImage(Image.FromFile(path + @"\Recursos\Avatars\" + avatar.Name + ".png"), new Size(100, 70));
                    avatar.Click += new EventHandler(this.clickAvatar);
                    avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.Controls.Add(avatar);
                    c++;
                    y += 106;
                }
                x += 106;
                y = 70;
                */
            }
            

        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            if(camara != null) camara.Dispose();
            camara = new VideoCapture();
            this.contador = 0;
            camara.Start();
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }
            timer1.Start();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.contador++;   
            camara.Read(frame);
            if (camara.IsOpened)
            {
                Imagen.Image = frame.ToBitmap();
                if (contador == 20)
                {
                    camara.Stop();
                    timer1.Stop();
                    camara.Dispose();
                }
            }
            else
            {
                camara.Stop();
                timer1.Stop();
                camara.Dispose();
                MessageBox.Show("Usted no tiene camara :v");
            }

        }

        private void PantallaPhoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_JugarConFoto_Click(object sender, EventArgs e)
        {
            BuscarFoto.ShowDialog();
        }

        private void BuscarFoto_FileOk(object sender, CancelEventArgs e)
        {
            Image ImagenRecibida = Image.FromFile(BuscarFoto.FileName);
            int maxSizeY = 180;
            int maxSizeX = 180;


            if (ImagenRecibida.Size.Width > maxSizeX || ImagenRecibida.Size.Height > maxSizeY)
            {
                MessageBox.Show($"La imagen tiene que tener el tamaño de {maxSizeX}x{maxSizeY} o menor");
            }
            else
            {
                Image imagenProcesada = resizeImage(ImagenRecibida, Imagen.Size);

                Imagen.Image = imagenProcesada;
            }
        }

        #region Metodo para ajustar tamaño de la imagen
        static Image resizeImage(Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }


        #endregion

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

        private void ConfirmarSeleccion_Click(object sender, EventArgs e)
        {
            FormJuego fJuego = new FormJuego(this.FPrincipal);
            fJuego.Show();

            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.FPrincipal.Show();
            this.Dispose();
        }
    }
}