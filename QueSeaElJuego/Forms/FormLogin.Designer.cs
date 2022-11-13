
namespace QueSeaElJuego.Forms
{
    partial class FormLogin
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblRegistrase = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.Location = new System.Drawing.Point(282, 107);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.MaxLength = 40;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(202, 35);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblUsuario.Location = new System.Drawing.Point(90, 116);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(113, 25);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblClave.Location = new System.Drawing.Point(90, 164);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(167, 25);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "CONTRASEÑA";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(116, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(333, 39);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "INICIO DE SESION";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalir.Location = new System.Drawing.Point(535, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIngresar.Location = new System.Drawing.Point(282, 211);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(202, 29);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblRegistrase
            // 
            this.lblRegistrase.AutoSize = true;
            this.lblRegistrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRegistrase.Location = new System.Drawing.Point(340, 254);
            this.lblRegistrase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistrase.Name = "lblRegistrase";
            this.lblRegistrase.Size = new System.Drawing.Size(91, 20);
            this.lblRegistrase.TabIndex = 3;
            this.lblRegistrase.Text = "Registrarse";
            this.lblRegistrase.Click += new System.EventHandler(this.lblRegistrase_Click);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClave.Location = new System.Drawing.Point(282, 156);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave.MaxLength = 30;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(202, 35);
            this.txtClave.TabIndex = 1;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(566, 295);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblRegistrase);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblRegistrase;
        private System.Windows.Forms.TextBox txtClave;
    }
}