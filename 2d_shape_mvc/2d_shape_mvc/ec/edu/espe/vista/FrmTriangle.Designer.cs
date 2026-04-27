namespace _2d_shape_mvc.ec.edu.espe.vista
{
    partial class FrmTriangle
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
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(13, 39);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(61, 16);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Entradas";
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(34, 73);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(54, 16);
            this.lblLado1.TabIndex = 1;
            this.lblLado1.Text = "Lado 1: ";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(34, 105);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(54, 16);
            this.lblLado2.TabIndex = 2;
            this.lblLado2.Text = "Lado 2: ";
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(34, 137);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(54, 16);
            this.lblLado3.TabIndex = 3;
            this.lblLado3.Text = "Lado 3: ";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(94, 70);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 22);
            this.txtLado1.TabIndex = 4;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(94, 102);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 22);
            this.txtLado2.TabIndex = 5;
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(94, 134);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 22);
            this.txtLado3.TabIndex = 6;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(13, 378);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(286, 55);
            this.lblMensaje.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 174);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(13, 229);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(53, 16);
            this.lblSalida.TabIndex = 9;
            this.lblSalida.Text = "Salidas";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(34, 265);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(71, 16);
            this.lblPerimetro.TabIndex = 10;
            this.lblPerimetro.Text = "Perimetro: ";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(61, 299);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 16);
            this.lblArea.TabIndex = 11;
            this.lblArea.Text = "Área: ";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(109, 262);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(100, 22);
            this.txtPerimetro.TabIndex = 12;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(109, 296);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 13;
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(109, 174);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 14;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(16, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelDibujo
            // 
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDibujo.Location = new System.Drawing.Point(332, 21);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(444, 412);
            this.panelDibujo.TabIndex = 16;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // FrmTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.lblEntrada);
            this.Name = "FrmTriangle";
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelDibujo;
    }
}