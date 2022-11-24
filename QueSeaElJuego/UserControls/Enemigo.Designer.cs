namespace QueSeaElJuego.UserControls
{
    partial class Enemigo
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
            this.pbCuerpo = new System.Windows.Forms.PictureBox();
            this.pbCara = new System.Windows.Forms.PictureBox();
            this.tiempoMovimiento = new System.Windows.Forms.Timer(this.components);
            this.tiempoMovimientoVertical = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCuerpo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCara)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCuerpo
            // 
            this.pbCuerpo.Location = new System.Drawing.Point(0, 50);
            this.pbCuerpo.Name = "pbCuerpo";
            this.pbCuerpo.Size = new System.Drawing.Size(50, 50);
            this.pbCuerpo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCuerpo.TabIndex = 7;
            this.pbCuerpo.TabStop = false;
            // 
            // pbCara
            // 
            this.pbCara.Location = new System.Drawing.Point(0, 0);
            this.pbCara.Name = "pbCara";
            this.pbCara.Size = new System.Drawing.Size(50, 50);
            this.pbCara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCara.TabIndex = 6;
            this.pbCara.TabStop = false;
            // 
            // tiempoMovimiento
            // 
            this.tiempoMovimiento.Tick += new System.EventHandler(this.tiempoMovimiento_Tick);
            // 
            // tiempoMovimientoVertical
            // 
            this.tiempoMovimientoVertical.Tick += new System.EventHandler(this.tiempoMovimientoVertical_Tick);
            // 
            // Enemigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbCuerpo);
            this.Controls.Add(this.pbCara);
            this.Name = "Enemigo";
            this.Size = new System.Drawing.Size(51, 101);
            this.Load += new System.EventHandler(this.Enemigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCuerpo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCuerpo;
        private System.Windows.Forms.PictureBox pbCara;
        private System.Windows.Forms.Timer tiempoMovimiento;
        private System.Windows.Forms.Timer tiempoMovimientoVertical;
    }
}
