
namespace QueSeaElJuego
{
    partial class FormPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCrearPersonaje = new System.Windows.Forms.Button();
            this.tablaIzquierda = new System.Windows.Forms.TableLayoutPanel();
            this.tblIzqInterior = new System.Windows.Forms.TableLayoutPanel();
            this.tablaIzquierda.SuspendLayout();
            this.tblIzqInterior.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSalir.Location = new System.Drawing.Point(1170, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCrearPersonaje
            // 
            this.btnCrearPersonaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearPersonaje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCrearPersonaje.FlatAppearance.BorderSize = 3;
            this.btnCrearPersonaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCrearPersonaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCrearPersonaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPersonaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPersonaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCrearPersonaje.Location = new System.Drawing.Point(24, 484);
            this.btnCrearPersonaje.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearPersonaje.Name = "btnCrearPersonaje";
            this.btnCrearPersonaje.Size = new System.Drawing.Size(218, 105);
            this.btnCrearPersonaje.TabIndex = 1;
            this.btnCrearPersonaje.Text = "Comenzar Partida";
            this.btnCrearPersonaje.UseVisualStyleBackColor = true;
            this.btnCrearPersonaje.Click += new System.EventHandler(this.btnCrearPersonaje_Click);
            // 
            // tablaIzquierda
            // 
            this.tablaIzquierda.BackColor = System.Drawing.Color.Transparent;
            this.tablaIzquierda.ColumnCount = 3;
            this.tablaIzquierda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaIzquierda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tablaIzquierda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablaIzquierda.Controls.Add(this.tblIzqInterior, 1, 1);
            this.tablaIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablaIzquierda.Location = new System.Drawing.Point(0, 0);
            this.tablaIzquierda.Name = "tablaIzquierda";
            this.tablaIzquierda.RowCount = 3;
            this.tablaIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 619F));
            this.tablaIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tablaIzquierda.Size = new System.Drawing.Size(306, 720);
            this.tablaIzquierda.TabIndex = 7;
            // 
            // tblIzqInterior
            // 
            this.tblIzqInterior.ColumnCount = 3;
            this.tblIzqInterior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIzqInterior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tblIzqInterior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblIzqInterior.Controls.Add(this.btnCrearPersonaje, 1, 1);
            this.tblIzqInterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblIzqInterior.Location = new System.Drawing.Point(19, 58);
            this.tblIzqInterior.Name = "tblIzqInterior";
            this.tblIzqInterior.RowCount = 2;
            this.tblIzqInterior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIzqInterior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tblIzqInterior.Size = new System.Drawing.Size(264, 613);
            this.tblIzqInterior.TabIndex = 8;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.tablaIzquierda);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.tablaIzquierda.ResumeLayout(false);
            this.tblIzqInterior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCrearPersonaje;
        private System.Windows.Forms.TableLayoutPanel tablaIzquierda;
        private System.Windows.Forms.TableLayoutPanel tblIzqInterior;
    }
}

