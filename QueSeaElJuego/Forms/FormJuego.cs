using Microsoft.Win32;
using QueSeaElJuego.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace QueSeaElJuego.Forms
{
    public partial class FormJuego : Form
    {
        private FormPrincipal FPrincipal;
        public List<Enemigo> enemigos;
        public List<Bala> contbalas;
        private int danioActual = 1;
        private int municionActual;
        private int municionRecarga = 10;
        int recarga = 0;
        public int killCounter = 0;
        int vida;
        public int dinero = 0;
        private int cantEnemigo = 12;
        private bool pausa;
        private bool multishot = false;
        private Image caraG;
        private Image caraB;
        private Image caraR;
        private int PrecioMuni = 10;



        #region Contructores
        public FormJuego(FormPrincipal FPrincipal)
        {
            InitializeComponent();
            this.FPrincipal = FPrincipal;
            
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {
            pbCuerpo.Image = Image.FromFile(Directory.GetParent("..") + @"\Recursos\Fondos\cuerpo.png");
            this.enemigos = new List<Enemigo>();
            this.contbalas = new List<Bala>();
            this.municionActual = municionRecarga;
            lblMunicion.Text = $"Municion {municionRecarga}/{municionRecarga}";
            this.vida = 3;
            this.pausa = false;
        }


        

        public void cargarCara(Image cara)
        {
            this.pbCara.Image = cara;
            Bitmap nuevaImagen = new Bitmap(pbCara.Image);
            for (int y = 0; y < nuevaImagen.Height; y++)
            {
                for (int x = 0; x < nuevaImagen.Width; x++)
                {
                    Color p = nuevaImagen.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    nuevaImagen.SetPixel(x, y, Color.FromArgb(a, 30, 30, b));
                }
            }
            this.caraB = nuevaImagen;
            nuevaImagen = new Bitmap(pbCara.Image);
            for (int y = 0; y < nuevaImagen.Height; y++)
            {
                for (int x = 0; x < nuevaImagen.Width; x++)
                {
                    Color p = nuevaImagen.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    nuevaImagen.SetPixel(x, y, Color.FromArgb(a, r, 30, 30));
                }
            }
            this.caraR = nuevaImagen;
            nuevaImagen = new Bitmap(pbCara.Image);
            for (int y = 0; y < nuevaImagen.Height; y++)
            {
                for (int x = 0; x < nuevaImagen.Width; x++)
                {
                    Color p = nuevaImagen.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    nuevaImagen.SetPixel(x, y, Color.FromArgb(a, 30, g, 30));
                }
            }
            this.caraG = nuevaImagen;
            spawnearEnemigo.Start();
        }
        #endregion


        #region Hacer el Formulario Arrastrable ACTIVO

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
            if (!this.pausa)
            {
                const int pixelesBorde = 80; //Con esto se decide hasta donde podra moverse el puntero, el 40 representa 40 pixeles antes de salir del form
                Point supMax = new Point(pixelesBorde, pixelesBorde);
                Point supMin = new Point(this.Size.Width - pixelesBorde, this.Size.Height - pixelesBorde);
                Size tObjeto = this.puntero.Size;//tamaño del objeto
                if (e.X < supMin.X && e.Y < supMin.Y && e.X > supMax.X && e.Y > supMax.Y)
                {
                    Point NuevoPunto = e.Location;
                    NuevoPunto.Y -= tObjeto.Height / 2;
                    NuevoPunto.X -= tObjeto.Width / 2;
                    this.puntero.Location = NuevoPunto;
                    this.pbCara.Location = new Point(this.pbCara.Location.X, this.puntero.Location.Y - 20);
                    this.pbCuerpo.Location = new Point(this.pbCara.Location.X, this.pbCara.Location.Y + 50);
                }
            }
        }

        private void puntero_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this.pausa)
            {
                const int pixelesBorde = 80; //Con esto se decide hasta donde podra moverse el puntero, el 40 representa 40 pixeles antes de salir del form
                Point supMax = new Point(pixelesBorde, pixelesBorde);
                Point supMin = new Point(this.Size.Width - pixelesBorde, this.Size.Height - pixelesBorde);
                Point posicionActual = puntero.Location;
                posicionActual.Y += e.Y;
                posicionActual.X += e.X;
                Size tObjeto = this.puntero.Size;//tamaño del objeto

                if (posicionActual.X < supMin.X && posicionActual.Y < supMin.Y && posicionActual.X > supMax.X && posicionActual.Y > supMax.Y)
                {
                    Point NuevoPunto = this.puntero.Location;
                    NuevoPunto.Y += e.Y - tObjeto.Height / 2;
                    NuevoPunto.X += e.X - tObjeto.Width / 2;
                    this.puntero.Location = NuevoPunto;
                    this.pbCara.Location = new Point(this.pbCara.Location.X, this.puntero.Location.Y - 20);
                    this.pbCuerpo.Location = new Point(this.pbCara.Location.X, this.pbCara.Location.Y + 50);
                }
            }
        }

        public void HitPlayer()
        {
            this.lblVida.Text = "";
            this.vida--;
            for (int i = 0; i < this.vida; i++)
            {
                this.lblVida.Text += "♥";
            }
            if (this.vida <= 0)
            {
                Pausar();
                btnPausa.Enabled = false;
                Label Muerte = new Label();
                Muerte.AutoSize = true;
                Muerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Muerte.ForeColor = System.Drawing.Color.Red;
                Muerte.Location = new System.Drawing.Point(328, 291);
                Muerte.Name = "Muerte";
                Muerte.Size = new System.Drawing.Size(623, 73);
                Muerte.Text = "TE MORISTE PETE";
                Muerte.Parent = this;
                this.enemigos.Clear();
                this.Controls.Add(Muerte);

                Button btnVolverAJugar = new Button();
                btnVolverAJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnVolverAJugar.Location = new System.Drawing.Point(220, 497);
                btnVolverAJugar.Name = "btnVolverAJugar";
                btnVolverAJugar.Size = new System.Drawing.Size(780, 177);
                btnVolverAJugar.TabIndex = 6;
                btnVolverAJugar.Text = "Volver a Jugar";
                btnVolverAJugar.UseVisualStyleBackColor = true;
                btnVolverAJugar.Click += new System.EventHandler(this.btnVolverAJugar_Click);
                this.Controls.Add(btnVolverAJugar);

                foreach (var item in this.Controls)
                {
                    if (item.GetType() == new Enemigo(this).GetType())
                    {
                        Enemigo pepe = item as Enemigo;
                        this.Controls.Remove(pepe);

                    }
                }
            }
        }
        #endregion


        #region Disparos


        /*  Legacy
        private void puntero_Click(object sender, EventArgs e)
        {
            Bala bala = new Bala(this);
            Point posActual = pbCara.Location;
            Point posObjetivo = puntero.Location;
            posActual.X += pbCara.Width / 2;
            posActual.Y += pbCara.Height / 2;
            posObjetivo.X += puntero.Width / 2;
            posObjetivo.Y += puntero.Height / 2;
            bala.objetivo(posObjetivo, posActual, this.danioActual);
            bala.enemigoObjetivo();
            this.Controls.Add(bala);
        }
        */

        private void puntero_MouseDown(object sender, MouseEventArgs e)
        {
            if (!this.pausa)
            {
                if (this.municionActual <= 0)
                {
                    recargar.Start();
                }
                else
                {
                    municionActual--;
                    Bala bala = new Bala(this);
                    Point posActual = pbCara.Location;
                    Point posObjetivo = puntero.Location;
                    posActual.X += pbCara.Width / 2;
                    posActual.Y += pbCara.Height / 2;
                    posObjetivo.X += puntero.Width / 2;
                    posObjetivo.Y += puntero.Height / 2;
                    bala.objetivo(posObjetivo, posActual, this.danioActual);
                    bala.enemigoObjetivo();
                    lblMunicion.Text = $"Municion {municionActual}/{municionRecarga}";
                    this.Controls.Add(bala);
                    contbalas.Add(bala);
                    if (this.multishot)
                    {
                        Bala bala2 = new Bala(this);
                        Bala bala3 = new Bala(this);
                        municionActual--;
                        posActual.X += pbCara.Width / 2;
                        posActual.Y += pbCara.Height / 2 + 100;
                        posObjetivo.X += puntero.Width / 2;
                        posObjetivo.Y += puntero.Height / 2 + 100;
                        bala2.objetivo(posObjetivo, posActual, this.danioActual);
                        bala2.enemigoObjetivo();
                        lblMunicion.Text = $"Municion {municionActual}/{municionRecarga}";
                        this.Controls.Add(bala2);
                        contbalas.Add(bala2);
                        municionActual--;
                        posActual.X += pbCara.Width / 2;
                        posActual.Y += pbCara.Height / 2 - 100;
                        posObjetivo.X += puntero.Width / 2;
                        posObjetivo.Y += puntero.Height / 2 - 100;
                        bala3.objetivo(posObjetivo, posActual, this.danioActual);
                        bala3.enemigoObjetivo();
                        lblMunicion.Text = $"Municion {municionActual}/{municionRecarga}";
                        this.Controls.Add(bala3);
                        contbalas.Add(bala3);
                    }

                }
                disparar.Start();
            }
        }

        private void disparar_Tick(object sender, EventArgs e)
        {
            lblMunicion.Text = $"Municion {municionActual}/{municionRecarga}";
            if (this.municionActual <= 0)
            {
                recargar.Start();
            }
            else
            {
                municionActual--;
                Bala bala = new Bala(this);
                Point posActual = pbCara.Location;
                Point posObjetivo = puntero.Location;
                posActual.X += pbCara.Width / 2;
                posActual.Y += pbCara.Height / 2;
                posObjetivo.X += puntero.Width / 2;
                posObjetivo.Y += puntero.Height / 2;
                bala.objetivo(posObjetivo, posActual, this.danioActual);
                bala.enemigoObjetivo();

                this.Controls.Add(bala);
                contbalas.Add(bala);
            }
        }

        private void puntero_MouseUp(object sender, MouseEventArgs e)
        {
            disparar.Stop();
        }

        private int tiempoRecarga = 3;

        private void recargar_Tick(object sender, EventArgs e)
        {
            lblMunicion.Text = $"Municion recargando/{municionRecarga}";
            recarga++;
            if (recarga >= tiempoRecarga)
            {
                recarga = 0;
                municionActual = municionRecarga;
                lblMunicion.Text = $"Municion {municionActual}/{municionRecarga}";
                recargar.Stop();
            }
        }
        #endregion


        #region Control spawn de enemigos
        private void spawnearEnemigo_Tick(object sender, EventArgs e)
        {

            lblKillCounter.Text = $"Kills {this.killCounter}";
            lblMoney.Text = $"${this.dinero}";
            if(this.killCounter > 30)
            {
               
                if (this.killCounter > 80)
                {
                    spawnearEnemigo.Interval = 300;
                    cantEnemigo = 20;
                }
                else
                {
                    spawnearEnemigo.Interval = 700;
                    cantEnemigo = 15;
                }
            }
            if (this.enemigos.Count < cantEnemigo)
            {
                Enemigo enemigo = new Enemigo(this);
                enemigo.Location = new Point(1300, new Random().Next(80, 600));
                int aux = new Random().Next(1, 8);
                
                switch (aux)
                {
                    case 2:
                        enemigo.generarEnemigo(this.caraR, 3);
                        break;
                    case 3:
                        enemigo.generarEnemigo(this.caraB, 2);
                        break;
                    default:
                        enemigo.generarEnemigo(this.caraG, 1);
                        break;
                }
                
                this.enemigos.Add(enemigo);
                this.Controls.Add(enemigo);
            }
        }

        #endregion


        #region Botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pausar()
        {
            this.pausa = !this.pausa;

            if (this.pausa)
            {
                spawnearEnemigo.Stop();
            }
            else
            {
                spawnearEnemigo.Start();
            }


            foreach (Enemigo enemigo in enemigos)
            {
                enemigo.Pausa(this.pausa);
            }
            foreach (var bala in this.Controls)
            {
                if (bala.GetType() == new Bala(this).GetType())
                {
                    Bala baldy = bala as Bala;
                    baldy.Pausa(this.pausa);
                }
            }
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {

            Pausar();
        }


        
        private void btnMejorarMunicion_Click(object sender, EventArgs e)
        {
            if(this.dinero >= PrecioMuni)
            {
                this.dinero -= PrecioMuni;
                PrecioMuni += 10;
                this.municionRecarga += 5;
                lblMoney.Text = $"${this.dinero}";
                lblMunicion.Text = $"Municion {municionActual}/{municionRecarga}";
                btnMejorarMunicion.Text = "Mas Municion $" + PrecioMuni;
            }
            if(this.municionRecarga >= 60)
            {
                btnMejorarMunicion.Enabled = false;
            }
        }

        private void btnMultiShot_Click(object sender, EventArgs e)
        {
            if (this.dinero >= 150)
            {
                this.dinero -= 150;
                lblMoney.Text = $"${this.dinero}";
                this.multishot = true;
                btnMultiShot.Enabled = false;
            }
        }

        private void btnMejorarRecarga_Click(object sender, EventArgs e)
        {
            if (this.dinero >= 80)
            {
                this.dinero -= 80;
                lblMoney.Text = $"${this.dinero}";
                this.tiempoRecarga = 1;
                btnMejorarRecarga.Enabled = false;
            }
        }


        #endregion

        private void btnVolverAJugar_Click(object sender, EventArgs e)
        {
            FormJuego fj = new FormJuego(this.FPrincipal);
            fj.cargarCara(this.pbCara.Image);
            fj.Show();
            this.Dispose();
        }
    }
}
