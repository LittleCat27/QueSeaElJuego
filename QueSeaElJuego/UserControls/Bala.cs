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

namespace QueSeaElJuego.UserControls
{
    public partial class Bala : UserControl
    {

        private Point objetivoFinal;
        private Point lugarActual;
        private int danio;
        private int contador = 0;
        private const int movimiento = 20; //Esto tiene que ser par, decide velocidad de la bala
        private FormJuego fj;
        public Bala(FormJuego formJuego)
        {
            InitializeComponent();
            this.fj = formJuego;
        }

        public void objetivo(Point objetivo, Point lugarInicial, int danio)
        {
            this.objetivoFinal = objetivoFinalArreglado(objetivo);
            int x = lugarInicial.X;
            int y = lugarInicial.Y;
            while(x % movimiento != 0)
            {
                x++;
            }
            while (y % movimiento != 0)
            {
                y++;
            }
            this.lugarActual = new Point(x,y); ;
            this.Location = this.lugarActual;
            this.danio = danio;
            timerTiempoVida.Start();
            if (fj.contbalas.Count > 15)
            {
                this.Hide();
            }
        }


        public void Pausa(bool p)
        {
            if(p)
            {
                timerTiempoVida.Stop();
            }
            else
            {
                timerTiempoVida.Start();
            }
        }

        private Point objetivoFinalArreglado(Point objetivo)
        {
            objetivo.X = 1240;
            if (objetivo.X % movimiento != 0)
            {
                objetivo.X++;
                return objetivoFinalArreglado(objetivo);
            }
            else if (objetivo.Y % movimiento != 0)
            {
                objetivo.Y++;
                return objetivoFinalArreglado(objetivo);
            }

                return objetivo;
        }

        

        public void enemigoObjetivo()
        {
            int x = 1240;

            for (int i = 0; i < fj.enemigos.Count; i++)
            {
                if (fj.enemigos[i].Location.Y < this.objetivoFinal.Y && fj.enemigos[i].Location.Y > this.objetivoFinal.Y - 100)
                {
                    x = fj.enemigos[i].Location.X - 100;
                    break;
                }
            }
            
             
            while(x % movimiento != 0)
            {
                x++;
            }

            this.objetivoFinal = new Point(x, objetivoFinal.Y);
        }
        private void timerTiempoVida_Tick(object sender, EventArgs e)
        {
            this.contador++;
            if (contador > 160)
            {
                this.fj.Controls.Remove(this);
                this.Dispose();
            }

            #region CalculoMovimientoDisparo
            if (this.lugarActual.X > this.objetivoFinal.X)
            {
                this.lugarActual.X -= movimiento;
            }

            if (this.lugarActual.X < this.objetivoFinal.X)
            {
                this.lugarActual.X += movimiento;
            }
            /* Legacy
            if (this.lugarActual.Y > this.objetivoFinal.Y)
            {
                int valor1 = this.lugarActual.Y - this.objetivoFinal.Y;
                valor1 = Math.Abs(valor1);
                int valor2 = this.lugarActual.X - this.objetivoFinal.X;
                valor2 = Math.Abs(valor1);
                if (valor1 > valor2)
                this.lugarActual.Y -= movimiento * 2;
                else
                {
                    this.lugarActual.Y -= movimiento / 4;
                }
            }

            if (this.lugarActual.Y < this.objetivoFinal.Y)
            {
                int valor1 = this.lugarActual.Y - this.objetivoFinal.Y;
                valor1 = Math.Abs(valor1);
                int valor2 = this.lugarActual.X - this.objetivoFinal.X;
                valor2 = Math.Abs(valor1);
                if (valor1 > valor2)
                    this.lugarActual.Y += movimiento * 2;
                else
                {
                    this.lugarActual.Y += movimiento / 4;
                }
            }*/
            #endregion

            this.Location = this.lugarActual;
            if(this.lugarActual.X >= this.objetivoFinal.X)
            {
                if(this.objetivoFinal.X != 1240)
                {
                    for (int i = 0; i < fj.enemigos.Count; i++)
                    {
                        if (this.fj.enemigos[i].Location.Y < this.objetivoFinal.Y && this.fj.enemigos[i].Location.Y > this.objetivoFinal.Y - 100)
                        {
                            this.fj.enemigos[i].Hit(1);
                            break;
                        }
                    }
                }
                this.lblProyectil.Dispose();
                this.fj.Controls.Remove(this);
                this.fj.contbalas.Remove(this);
                this.Dispose();
            }

        }
    }
}
