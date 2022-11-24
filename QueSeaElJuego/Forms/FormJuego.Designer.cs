
namespace QueSeaElJuego.Forms
{
    partial class FormJuego
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
            this.puntero = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblMunicion = new System.Windows.Forms.Label();
            this.lblKillCounter = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMejorarRecarga = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.btnMultiShot = new System.Windows.Forms.Button();
            this.btnMejorarMunicion = new System.Windows.Forms.Button();
            this.pbCara = new System.Windows.Forms.PictureBox();
            this.pbCuerpo = new System.Windows.Forms.PictureBox();
            this.spawnearEnemigo = new System.Windows.Forms.Timer(this.components);
            this.disparar = new System.Windows.Forms.Timer(this.components);
            this.recargar = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCuerpo)).BeginInit();
            this.SuspendLayout();
            // 
            // puntero
            // 
            this.puntero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.puntero.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntero.ForeColor = System.Drawing.Color.Red;
            this.puntero.Location = new System.Drawing.Point(46, 43);
            this.puntero.Name = "puntero";
            this.puntero.Size = new System.Drawing.Size(50, 50);
            this.puntero.TabIndex = 0;
            this.puntero.Text = "(+)";
            this.puntero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.puntero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.puntero_MouseDown);
            this.puntero.MouseMove += new System.Windows.Forms.MouseEventHandler(this.puntero_MouseMove);
            this.puntero.MouseUp += new System.Windows.Forms.MouseEventHandler(this.puntero_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1240, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(40, 720);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 405F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 418F));
            this.tableLayoutPanel2.Controls.Add(this.lblVida, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMunicion, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblKillCounter, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMoney, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1240, 40);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.ForeColor = System.Drawing.Color.Red;
            this.lblVida.Location = new System.Drawing.Point(682, 0);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(131, 37);
            this.lblVida.TabIndex = 6;
            this.lblVida.Text = "♥♥♥";
            // 
            // lblMunicion
            // 
            this.lblMunicion.AutoSize = true;
            this.lblMunicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicion.ForeColor = System.Drawing.Color.Yellow;
            this.lblMunicion.Location = new System.Drawing.Point(45, 0);
            this.lblMunicion.Name = "lblMunicion";
            this.lblMunicion.Size = new System.Drawing.Size(249, 37);
            this.lblMunicion.TabIndex = 0;
            this.lblMunicion.Text = "Municion 20/20";
            // 
            // lblKillCounter
            // 
            this.lblKillCounter.AutoSize = true;
            this.lblKillCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKillCounter.ForeColor = System.Drawing.Color.Red;
            this.lblKillCounter.Location = new System.Drawing.Point(450, 0);
            this.lblKillCounter.Name = "lblKillCounter";
            this.lblKillCounter.Size = new System.Drawing.Size(119, 37);
            this.lblKillCounter.TabIndex = 1;
            this.lblKillCounter.Text = "Kills  0";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Yellow;
            this.lblMoney.Location = new System.Drawing.Point(825, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(412, 40);
            this.lblMoney.TabIndex = 7;
            this.lblMoney.Text = "$0";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(40, 680);
            this.tableLayoutPanel3.TabIndex = 3;
            this.tableLayoutPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.58333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.83333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.75F));
            this.tableLayoutPanel4.Controls.Add(this.btnMejorarRecarga, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPausa, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnMultiShot, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnMejorarMunicion, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(40, 680);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1200, 40);
            this.tableLayoutPanel4.TabIndex = 2;
            this.tableLayoutPanel4.Click += new System.EventHandler(this.btnMultiShot_Click);
            this.tableLayoutPanel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            // 
            // btnMejorarRecarga
            // 
            this.btnMejorarRecarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMejorarRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMejorarRecarga.Location = new System.Drawing.Point(488, 3);
            this.btnMejorarRecarga.Name = "btnMejorarRecarga";
            this.btnMejorarRecarga.Size = new System.Drawing.Size(363, 34);
            this.btnMejorarRecarga.TabIndex = 3;
            this.btnMejorarRecarga.Text = "Recarga Rapida $80";
            this.btnMejorarRecarga.UseVisualStyleBackColor = true;
            this.btnMejorarRecarga.Click += new System.EventHandler(this.btnMejorarRecarga_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausa.Location = new System.Drawing.Point(3, 3);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(113, 34);
            this.btnPausa.TabIndex = 0;
            this.btnPausa.Text = "Pausa";
            this.btnPausa.UseVisualStyleBackColor = true;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // btnMultiShot
            // 
            this.btnMultiShot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiShot.Location = new System.Drawing.Point(857, 3);
            this.btnMultiShot.Name = "btnMultiShot";
            this.btnMultiShot.Size = new System.Drawing.Size(340, 34);
            this.btnMultiShot.TabIndex = 2;
            this.btnMultiShot.Text = "MultiShot $150";
            this.btnMultiShot.UseVisualStyleBackColor = true;
            this.btnMultiShot.Click += new System.EventHandler(this.btnMultiShot_Click);
            // 
            // btnMejorarMunicion
            // 
            this.btnMejorarMunicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMejorarMunicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMejorarMunicion.Location = new System.Drawing.Point(122, 3);
            this.btnMejorarMunicion.Name = "btnMejorarMunicion";
            this.btnMejorarMunicion.Size = new System.Drawing.Size(360, 34);
            this.btnMejorarMunicion.TabIndex = 1;
            this.btnMejorarMunicion.Text = "Mas Municion $10";
            this.btnMejorarMunicion.UseVisualStyleBackColor = true;
            this.btnMejorarMunicion.Click += new System.EventHandler(this.btnMejorarMunicion_Click);
            // 
            // pbCara
            // 
            this.pbCara.Location = new System.Drawing.Point(110, 300);
            this.pbCara.Name = "pbCara";
            this.pbCara.Size = new System.Drawing.Size(50, 50);
            this.pbCara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCara.TabIndex = 4;
            this.pbCara.TabStop = false;
            // 
            // pbCuerpo
            // 
            this.pbCuerpo.Location = new System.Drawing.Point(110, 350);
            this.pbCuerpo.Name = "pbCuerpo";
            this.pbCuerpo.Size = new System.Drawing.Size(50, 50);
            this.pbCuerpo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCuerpo.TabIndex = 5;
            this.pbCuerpo.TabStop = false;
            // 
            // spawnearEnemigo
            // 
            this.spawnearEnemigo.Interval = 1000;
            this.spawnearEnemigo.Tick += new System.EventHandler(this.spawnearEnemigo_Tick);
            // 
            // disparar
            // 
            this.disparar.Interval = 200;
            this.disparar.Tick += new System.EventHandler(this.disparar_Tick);
            // 
            // recargar
            // 
            this.recargar.Interval = 1000;
            this.recargar.Tick += new System.EventHandler(this.recargar_Tick);
            // 
            // FormJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pbCuerpo);
            this.Controls.Add(this.pbCara);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.puntero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJuego";
            this.Load += new System.EventHandler(this.FormJuego_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormJuego_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCuerpo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label puntero;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbCara;
        private System.Windows.Forms.PictureBox pbCuerpo;
        private System.Windows.Forms.Timer spawnearEnemigo;
        private System.Windows.Forms.Timer disparar;
        private System.Windows.Forms.Timer recargar;
        private System.Windows.Forms.Label lblMunicion;
        private System.Windows.Forms.Label lblKillCounter;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnMejorarRecarga;
        private System.Windows.Forms.Button btnMultiShot;
        private System.Windows.Forms.Button btnMejorarMunicion;
    }
}