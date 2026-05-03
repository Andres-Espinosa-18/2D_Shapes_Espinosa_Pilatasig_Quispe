namespace _2d_shape_mvc.ec.edu.espe.vista
{
    partial class FrmRombo
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblSsalidas = new System.Windows.Forms.Label();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtDiagonal2 = new System.Windows.Forms.TextBox();
            this.lblDiagonalVertical = new System.Windows.Forms.Label();
            this.txtDiagonal1 = new System.Windows.Forms.TextBox();
            this.lblDiagonalHorizontal = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(120, 413);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 33;
            // 
            // panelDibujo
            // 
            this.panelDibujo.Location = new System.Drawing.Point(749, 73);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(381, 356);
            this.panelDibujo.TabIndex = 32;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(312, 346);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 31;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(312, 311);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(100, 22);
            this.txtPerimetro.TabIndex = 30;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(189, 352);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 16);
            this.lblArea.TabIndex = 29;
            this.lblArea.Text = "Área:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(189, 320);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(68, 16);
            this.lblPerimetro.TabIndex = 28;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblSsalidas
            // 
            this.lblSsalidas.AutoSize = true;
            this.lblSsalidas.Location = new System.Drawing.Point(120, 291);
            this.lblSsalidas.Name = "lblSsalidas";
            this.lblSsalidas.Size = new System.Drawing.Size(53, 16);
            this.lblSsalidas.TabIndex = 27;
            this.lblSsalidas.Text = "Salidas";
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(458, 510);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(75, 23);
            this.btnSalida.TabIndex = 26;
            this.btnSalida.Text = "Salir";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(352, 510);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 25;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(244, 510);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDiagonal2
            // 
            this.txtDiagonal2.Location = new System.Drawing.Point(312, 214);
            this.txtDiagonal2.Name = "txtDiagonal2";
            this.txtDiagonal2.Size = new System.Drawing.Size(100, 22);
            this.txtDiagonal2.TabIndex = 21;
            // 
            // lblDiagonalVertical
            // 
            this.lblDiagonalVertical.AutoSize = true;
            this.lblDiagonalVertical.Location = new System.Drawing.Point(167, 220);
            this.lblDiagonalVertical.Name = "lblDiagonalVertical";
            this.lblDiagonalVertical.Size = new System.Drawing.Size(113, 16);
            this.lblDiagonalVertical.TabIndex = 20;
            this.lblDiagonalVertical.Text = "Diagonal Vertical:";
            // 
            // txtDiagonal1
            // 
            this.txtDiagonal1.Location = new System.Drawing.Point(312, 175);
            this.txtDiagonal1.Name = "txtDiagonal1";
            this.txtDiagonal1.Size = new System.Drawing.Size(100, 22);
            this.txtDiagonal1.TabIndex = 19;
            // 
            // lblDiagonalHorizontal
            // 
            this.lblDiagonalHorizontal.AutoSize = true;
            this.lblDiagonalHorizontal.Location = new System.Drawing.Point(167, 182);
            this.lblDiagonalHorizontal.Name = "lblDiagonalHorizontal";
            this.lblDiagonalHorizontal.Size = new System.Drawing.Size(123, 16);
            this.lblDiagonalHorizontal.TabIndex = 18;
            this.lblDiagonalHorizontal.Text = "Digonal Horizontal: ";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(120, 143);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(54, 16);
            this.lblEntrada.TabIndex = 17;
            this.lblEntrada.Text = "Entrada";
            this.lblEntrada.Click += new System.EventHandler(this.lblEntrada_Click);
            // 
            // FrmRombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 662);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblSsalidas);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDiagonal2);
            this.Controls.Add(this.lblDiagonalVertical);
            this.Controls.Add(this.txtDiagonal1);
            this.Controls.Add(this.lblDiagonalHorizontal);
            this.Controls.Add(this.lblEntrada);
            this.Name = "FrmRombo";
            this.Text = "Rombo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblSsalidas;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDiagonal2;
        private System.Windows.Forms.Label lblDiagonalVertical;
        private System.Windows.Forms.TextBox txtDiagonal1;
        private System.Windows.Forms.Label lblDiagonalHorizontal;
        private System.Windows.Forms.Label lblEntrada;
    }
}