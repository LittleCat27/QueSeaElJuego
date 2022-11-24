using Emgu.CV.Structure;
using QueSeaElJuego.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueSeaElJuego.UserControls
{
    public partial class Enemigo : UserControl
    {
        private FormJuego fj;
        public Enemigo(FormJuego fj)
        {
            InitializeComponent();
            this.fj = fj;
        }

        private int timeVida = 200;
        private int posX;
        private int posY;
        private static int velocidadMax = 6;
        private void Enemigo_Load(object sender, EventArgs e)
        {
            this.pbCuerpo.Image = Image.FromFile(Directory.GetParent("..") + @"\Recursos\Fondos\enemigo.png");

        }

        public void generarEnemigo(Image cara, int tipo)
        {

            Bitmap nuevaImagen = new Bitmap(cara);
            switch (tipo)
            {
                case 2:
                    this.chunkyBoi += 3;
                    break;
                case 3:
                tiempoMovimientoVertical.Start();
                    break;
                default:
                    break;
            }
           

            if (this.fj.killCounter > 200)
            {
                chunkyBoi += 3;
                velocidad += 12;

            }
            if (this.fj.killCounter > 500)
            {
                chunkyBoi += 3;
                velocidad += 12;

            }

            this.velocidad = velocidadMax;
            this.posX = this.Location.X;
            this.posY = this.Location.Y;
            
            this.pbCara.Image = cara;
            tiempoMovimiento.Start();
        }
        private int chunkyBoi = 0;

        public void Hit(int danio)
        {
            if (chunkyBoi <= 0)
            {
                fj.dinero += 2;
                fj.killCounter++;
                fj.enemigos.Remove(this);
                fj.Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                fj.dinero += 1;
                chunkyBoi--;
            }
        }

        public void Pausa(bool Pausar)
        {
            if (Pausar)
            {
                tiempoMovimiento.Stop();
            }
            else
            {
                tiempoMovimiento.Start();
            }    
        }

        private int kills = 0;
        private int velocidad = 6;

        private void tiempoMovimiento_Tick(object sender, EventArgs e)
        {
            timeVida -= 1;
            if (timeVida <= 0)
            {
                fj.HitPlayer();
                fj.enemigos.Remove(this);
                fj.Controls.Remove(this);
                this.Dispose();
            }

            if (this.Location.X <= 100)
            {
                fj.HitPlayer();
                fj.enemigos.Remove(this);
                fj.Controls.Remove(this);
                this.Dispose();
            }


            if (fj.killCounter > this.kills + 5)
            {
                this.kills = fj.killCounter;
                velocidad += 2;
            }
            else
            {
                posX -= velocidad;
            }
            this.Location = new Point(posX, posY);
        }

        private bool irArriba = false;
        private void tiempoMovimientoVertical_Tick(object sender, EventArgs e)
        {
            if(irArriba)
            {
                if (posY > 60)
                {
                    this.posY -= 25;
                }
                else
                {
                    irArriba = !irArriba;
                }
                
            }
            else
            {
                if (posY < this.fj.Height - 150)
                {
                    this.posY += 25;
                }
                else
                {
                    irArriba = !irArriba;
                }
            }
        }
    }
}
