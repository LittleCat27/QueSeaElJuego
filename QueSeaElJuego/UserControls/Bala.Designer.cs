namespace QueSeaElJuego.UserControls
{
    partial class Bala
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerTiempoVida = new System.Windows.Forms.Timer(this.components);
            this.lblProyectil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerTiempoVida
            // 
            this.timerTiempoVida.Interval = 20;
            this.timerTiempoVida.Tick += new System.EventHandler(this.timerTiempoVida_Tick);
            // 
            // lblProyectil
            // 
            this.lblProyectil.AutoSize = true;
            this.lblProyectil.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProyectil.Location = new System.Drawing.Point(3, 0);
            this.lblProyectil.Name = "lblProyectil";
            this.lblProyectil.Size = new System.Drawing.Size(74, 22);
            this.lblProyectil.TabIndex = 0;
            this.lblProyectil.Text = ">>---->";
            // 
            // Bala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblProyectil);
            this.Name = "Bala";
            this.Size = new System.Drawing.Size(81, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerTiempoVida;
        private System.Windows.Forms.Label lblProyectil;
    }
}
