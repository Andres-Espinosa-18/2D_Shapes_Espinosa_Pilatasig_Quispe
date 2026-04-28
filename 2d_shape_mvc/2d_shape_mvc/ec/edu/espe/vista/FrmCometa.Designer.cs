namespace _2d_shape_mvc.ec.edu.espe.vista
{
    partial class FrmCometa
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
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblDiagonalHorizontal = new System.Windows.Forms.Label();
            this.txtDiagonal1 = new System.Windows.Forms.TextBox();
            this.lblDiagonalVertical = new System.Windows.Forms.Label();
            this.txtDiagonal2 = new System.Windows.Forms.TextBox();
            this.lblInterseccion = new System.Windows.Forms.Label();
            this.txtInterseccion = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.lblSsalidas = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(34, 27);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(54, 16);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblDiagonalHorizontal
            // 
            this.lblDiagonalHorizontal.AutoSize = true;
            this.lblDiagonalHorizontal.Location = new System.Drawing.Point(43, 66);
            this.lblDiagonalHorizontal.Name = "lblDiagonalHorizontal";
            this.lblDiagonalHorizontal.Size = new System.Drawing.Size(123, 16);
            this.lblDiagonalHorizontal.TabIndex = 1;
            this.lblDiagonalHorizontal.Text = "Digonal Horizontal: ";
            this.lblDiagonalHorizontal.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiagonal1
            // 
            this.txtDiagonal1.Location = new System.Drawing.Point(173, 59);
            this.txtDiagonal1.Name = "txtDiagonal1";
            this.txtDiagonal1.Size = new System.Drawing.Size(100, 22);
            this.txtDiagonal1.TabIndex = 2;
            // 
            // lblDiagonalVertical
            // 
            this.lblDiagonalVertical.AutoSize = true;
            this.lblDiagonalVertical.Location = new System.Drawing.Point(43, 104);
            this.lblDiagonalVertical.Name = "lblDiagonalVertical";
            this.lblDiagonalVertical.Size = new System.Drawing.Size(113, 16);
            this.lblDiagonalVertical.TabIndex = 3;
            this.lblDiagonalVertical.Text = "Diagonal Vertical:";
            // 
            // txtDiagonal2
            // 
            this.txtDiagonal2.Location = new System.Drawing.Point(173, 98);
            this.txtDiagonal2.Name = "txtDiagonal2";
            this.txtDiagonal2.Size = new System.Drawing.Size(100, 22);
            this.txtDiagonal2.TabIndex = 4;
            // 
            // lblInterseccion
            // 
            this.lblInterseccion.AutoSize = true;
            this.lblInterseccion.Location = new System.Drawing.Point(43, 142);
            this.lblInterseccion.Name = "lblInterseccion";
            this.lblInterseccion.Size = new System.Drawing.Size(120, 16);
            this.lblInterseccion.TabIndex = 5;
            this.lblInterseccion.Text = "Intersección (0 - 1): ";
            this.lblInterseccion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtInterseccion
            // 
            this.txtInterseccion.Location = new System.Drawing.Point(173, 139);
            this.txtInterseccion.Name = "txtInterseccion";
            this.txtInterseccion.Size = new System.Drawing.Size(100, 22);
            this.txtInterseccion.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(37, 207);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(145, 207);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 8;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(251, 207);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(75, 23);
            this.btnSalida.TabIndex = 9;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // lblSsalidas
            // 
            this.lblSsalidas.AutoSize = true;
            this.lblSsalidas.Location = new System.Drawing.Point(37, 268);
            this.lblSsalidas.Name = "lblSsalidas";
            this.lblSsalidas.Size = new System.Drawing.Size(53, 16);
            this.lblSsalidas.TabIndex = 10;
            this.lblSsalidas.Text = "Salidas";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(59, 297);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(68, 16);
            this.lblPerimetro.TabIndex = 11;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(59, 329);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 16);
            this.lblArea.TabIndex = 12;
            this.lblArea.Text = "Área:";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(145, 291);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(100, 22);
            this.txtPerimetro.TabIndex = 13;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(145, 326);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 14;
            // 
            // panelDibujo
            // 
            this.panelDibujo.Location = new System.Drawing.Point(372, 39);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(381, 356);
            this.panelDibujo.TabIndex = 15;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(62, 378);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 16;
            // 
            // FrmCometa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.txtInterseccion);
            this.Controls.Add(this.lblInterseccion);
            this.Controls.Add(this.txtDiagonal2);
            this.Controls.Add(this.lblDiagonalVertical);
            this.Controls.Add(this.txtDiagonal1);
            this.Controls.Add(this.lblDiagonalHorizontal);
            this.Controls.Add(this.lblEntrada);
            this.Name = "FrmCometa";
            this.Text = "FrmCometa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblDiagonalHorizontal;
        private System.Windows.Forms.TextBox txtDiagonal1;
        private System.Windows.Forms.Label lblDiagonalVertical;
        private System.Windows.Forms.TextBox txtDiagonal2;
        private System.Windows.Forms.Label lblInterseccion;
        private System.Windows.Forms.TextBox txtInterseccion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Label lblSsalidas;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Label lblMensaje;
    }
}