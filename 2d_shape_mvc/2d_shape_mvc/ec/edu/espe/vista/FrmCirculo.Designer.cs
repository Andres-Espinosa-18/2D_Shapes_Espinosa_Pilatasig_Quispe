namespace _2d_shape_mvc.ec.edu.espe.vista
{
    partial class FrmCirculo
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
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(12, 9);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(54, 16);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(26, 58);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(50, 16);
            this.lblRadio.TabIndex = 1;
            this.lblRadio.Text = "Radio: ";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(82, 55);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 22);
            this.txtRadio.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(12, 163);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(53, 16);
            this.lblSalida.TabIndex = 4;
            this.lblSalida.Text = "Salidas";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(26, 201);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(71, 16);
            this.lblPerimetro.TabIndex = 5;
            this.lblPerimetro.Text = "Perimetro: ";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(103, 198);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(100, 22);
            this.txtPerimetro.TabIndex = 6;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(55, 240);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 16);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "Área: ";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(103, 237);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 8;
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(15, 291);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 9;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(117, 291);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelDibujo
            // 
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDibujo.Location = new System.Drawing.Point(313, 13);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(470, 424);
            this.panelDibujo.TabIndex = 11;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(12, 343);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(280, 94);
            this.lblMensaje.TabIndex = 12;
            // 
            // FrmCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.lblEntrada);
            this.Name = "FrmCirculo";
            this.Text = "FrmCirculo";
            this.Load += new System.EventHandler(this.FrmCirculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Label lblMensaje;
    }
}