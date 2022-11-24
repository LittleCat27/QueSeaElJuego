using System.Windows.Forms;

namespace QueSeaElJuego.Forms
{
    partial class PantallaPhoto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.btn_Encender = new System.Windows.Forms.Button();
            this.btn_JugarConFoto = new System.Windows.Forms.Button();
            this.BuscarFoto = new System.Windows.Forms.OpenFileDialog();
            this.ConfirmarSeleccion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Imagen
            // 
            this.Imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Imagen.Location = new System.Drawing.Point(354, 100);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(180, 180);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Imagen.TabIndex = 0;
            this.Imagen.TabStop = false;
            // 
            // btn_Encender
            // 
            this.btn_Encender.FlatAppearance.BorderSize = 3;
            this.btn_Encender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Encender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Encender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Encender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Encender.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_Encender.Location = new System.Drawing.Point(375, 363);
            this.btn_Encender.Name = "btn_Encender";
            this.btn_Encender.Size = new System.Drawing.Size(148, 69);
            this.btn_Encender.TabIndex = 1;
            this.btn_Encender.Text = "Iniciar Camara";
            this.btn_Encender.UseVisualStyleBackColor = true;
            this.btn_Encender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // btn_JugarConFoto
            // 
            this.btn_JugarConFoto.FlatAppearance.BorderSize = 3;
            this.btn_JugarConFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_JugarConFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_JugarConFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JugarConFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JugarConFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_JugarConFoto.Location = new System.Drawing.Point(66, 365);
            this.btn_JugarConFoto.Name = "btn_JugarConFoto";
            this.btn_JugarConFoto.Size = new System.Drawing.Size(184, 67);
            this.btn_JugarConFoto.TabIndex = 3;
            this.btn_JugarConFoto.Text = "Elegir foto del PC";
            this.btn_JugarConFoto.UseVisualStyleBackColor = true;
            this.btn_JugarConFoto.Click += new System.EventHandler(this.btn_JugarConFoto_Click);
            // 
            // BuscarFoto
            // 
            this.BuscarFoto.Filter = "Todos los archivos (*.*)|*.*|Imagen jpg (*.jpg)|*.jpg|Imagen png (*.png)|*.png|Im" +
    "agen jpeg (*.jpeg)|*.jpeg|Imagen tiff (*.tiff)|*.tiff|Imagen de mapa de bits (*." +
    "bmp)|*.bmp";
            this.BuscarFoto.FileOk += new System.ComponentModel.CancelEventHandler(this.BuscarFoto_FileOk);
            // 
            // ConfirmarSeleccion
            // 
            this.ConfirmarSeleccion.FlatAppearance.BorderSize = 3;
            this.ConfirmarSeleccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ConfirmarSeleccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConfirmarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmarSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarSeleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ConfirmarSeleccion.Location = new System.Drawing.Point(620, 363);
            this.ConfirmarSeleccion.Name = "ConfirmarSeleccion";
            this.ConfirmarSeleccion.Size = new System.Drawing.Size(184, 69);
            this.ConfirmarSeleccion.TabIndex = 4;
            this.ConfirmarSeleccion.Text = "Confirmar Seleccion";
            this.ConfirmarSeleccion.UseVisualStyleBackColor = true;
            this.ConfirmarSeleccion.Click += new System.EventHandler(this.ConfirmarSeleccion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalir.Location = new System.Drawing.Point(875, -1);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PantallaPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(905, 487);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.ConfirmarSeleccion);
            this.Controls.Add(this.btn_JugarConFoto);
            this.Controls.Add(this.btn_Encender);
            this.Controls.Add(this.Imagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaPhoto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaPhoto_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox Imagen;
        private Button btn_Encender;
        private Button btn_JugarConFoto;
        private OpenFileDialog BuscarFoto;
        private Button ConfirmarSeleccion;
        private Button btnSalir;
    }
}