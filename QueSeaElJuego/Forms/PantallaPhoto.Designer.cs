﻿using System.Windows.Forms;

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
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_JugarConFoto = new System.Windows.Forms.Button();
            this.BuscarFoto = new System.Windows.Forms.OpenFileDialog();
            this.ConfirmarSeleccion = new System.Windows.Forms.Button();
            this.TimerCamara = new System.Windows.Forms.Timer(this.components);
            this.labelAvatars = new System.Windows.Forms.Label();
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
            this.Imagen.Location = new System.Drawing.Point(74, 70);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(230, 170);
            this.Imagen.TabIndex = 0;
            this.Imagen.TabStop = false;
            // 
            // btn_Encender
            // 
            this.btn_Encender.Location = new System.Drawing.Point(348, 419);
            this.btn_Encender.Name = "btn_Encender";
            this.btn_Encender.Size = new System.Drawing.Size(173, 80);
            this.btn_Encender.TabIndex = 1;
            this.btn_Encender.Text = "Sacar Foto";
            this.btn_Encender.UseVisualStyleBackColor = true;
            this.btn_Encender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.Location = new System.Drawing.Point(555, 420);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(173, 80);
            this.btn_Apagar.TabIndex = 2;
            this.btn_Apagar.Text = "Jugar con Camara";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            this.btn_Apagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btn_JugarConFoto
            // 
            this.btn_JugarConFoto.Location = new System.Drawing.Point(74, 422);
            this.btn_JugarConFoto.Name = "btn_JugarConFoto";
            this.btn_JugarConFoto.Size = new System.Drawing.Size(215, 77);
            this.btn_JugarConFoto.TabIndex = 3;
            this.btn_JugarConFoto.Text = "Elegir foto del PC";
            this.btn_JugarConFoto.UseVisualStyleBackColor = true;
            this.btn_JugarConFoto.Click += new System.EventHandler(this.btn_JugarConFoto_Click);
            // 
            // BuscarFoto
            // 
            this.BuscarFoto.Filter = "Imagen jpg (*.jpg)|*.jpg|Imagen png (*.png)|*.png|Imagen jpeg (*.jpeg)|*.jpeg|Ima" +
    "gen tiff (*.tiff)|*.tiff|Imagen de mapa de bits (*.bmp)|*.bmp|Todos los archivos" +
    " (*.*)|*.*";
            this.BuscarFoto.FileOk += new System.ComponentModel.CancelEventHandler(this.BuscarFoto_FileOk);
            // 
            // ConfirmarSeleccion
            // 
            this.ConfirmarSeleccion.Location = new System.Drawing.Point(781, 423);
            this.ConfirmarSeleccion.Name = "ConfirmarSeleccion";
            this.ConfirmarSeleccion.Size = new System.Drawing.Size(215, 77);
            this.ConfirmarSeleccion.TabIndex = 4;
            this.ConfirmarSeleccion.Text = "Confirmar Seleccion";
            this.ConfirmarSeleccion.UseVisualStyleBackColor = true;
            this.ConfirmarSeleccion.Click += new System.EventHandler(this.ConfirmarSeleccion_Click);
            // 
            // TimerCamara
            // 
            this.TimerCamara.Tick += new System.EventHandler(this.TimerCamara_Tick);
            // 
            // labelAvatars
            // 
            this.labelAvatars.AutoSize = true;
            this.labelAvatars.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAvatars.Location = new System.Drawing.Point(526, 26);
            this.labelAvatars.Name = "labelAvatars";
            this.labelAvatars.Size = new System.Drawing.Size(254, 32);
            this.labelAvatars.TabIndex = 5;
            this.labelAvatars.Text = "Avatars Seleccionables";
            // 
            // PantallaPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 562);
            this.Controls.Add(this.labelAvatars);
            this.Controls.Add(this.ConfirmarSeleccion);
            this.Controls.Add(this.btn_JugarConFoto);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Encender);
            this.Controls.Add(this.Imagen);
            this.Name = "PantallaPhoto";
            this.Text = "PantallaPhoto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaPhoto_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox Imagen;
        private Button btn_Encender;
        private Button btn_Apagar;
        private Button btn_JugarConFoto;
        private OpenFileDialog BuscarFoto;
        private Button ConfirmarSeleccion;
        private System.Windows.Forms.Timer TimerCamara;
        private Label labelAvatars;
    }
}