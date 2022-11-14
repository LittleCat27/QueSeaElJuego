using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueSeaElJuego.UserControls
{
    public partial class Bala : UserControl
    {

        private Point objetivoFinal;
        private Point lugarActual;
        public Bala()
        {
            InitializeComponent();
        }

        public void objetivo(Point objetivo, Point lugarInicial)
        {


            
            this.objetivoFinal = objetivoFinalArreglado(objetivo);
            this.lugarActual = lugarInicial;
            this.Location = this.lugarActual;
            timerTiempoVida.Start();
        }
        private Point objetivoFinalArreglado(Point objetivo)
        {
            if (objetivo.X % 5 != 0)
            {
                objetivo.X++;
                return objetivoFinalArreglado(objetivo);
            }
            else if (objetivo.Y % 5 != 0)
            {
                objetivo.Y++;
                return objetivoFinalArreglado(objetivo);
            }

                return objetivo;
        }
        private void timerTiempoVida_Tick(object sender, EventArgs e)
        {
            if(this.lugarActual.X > this.objetivoFinal.X)
            {
                this.lugarActual.X -= 5;
            }

            if (this.lugarActual.X < this.objetivoFinal.X)
            {
                this.lugarActual.X += 5;
            }

            if (this.lugarActual.Y > this.objetivoFinal.Y)
            {
                this.lugarActual.Y -= 5;
            }

            if (this.lugarActual.Y < this.objetivoFinal.Y)
            {
                this.lugarActual.Y += 5;
            }


            this.Location = this.lugarActual;
            if(this.lugarActual == this.objetivoFinal)
            {
                this.Dispose();
            }

        }
    }
}
