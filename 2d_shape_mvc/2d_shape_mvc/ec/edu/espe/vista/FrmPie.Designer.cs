namespace _2d_shape_mvc.ec.edu.espe.vista
{
    partial class FrmPie
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
            this.lblEntradas = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblAnguloInicio = new System.Windows.Forms.Label();
            this.lblAnguloFin = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtAnguloInicio = new System.Windows.Forms.TextBox();
            this.txtAnguloFin = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSalidas = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Location = new System.Drawing.Point(92, 104);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(64, 16);
            this.lblEntradas.TabIndex = 0;
            this.lblEntradas.Text = "Entradas:";
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(146, 145);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(50, 16);
            this.lblRadio.TabIndex = 1;
            this.lblRadio.Text = "Radio: ";
            this.lblRadio.Click += new System.EventHandler(this.lblRadio_Click);
            // 
            // lblAnguloInicio
            // 
            this.lblAnguloInicio.AutoSize = true;
            this.lblAnguloInicio.Location = new System.Drawing.Point(146, 180);
            this.lblAnguloInicio.Name = "lblAnguloInicio";
            this.lblAnguloInicio.Size = new System.Drawing.Size(89, 16);
            this.lblAnguloInicio.TabIndex = 2;
            this.lblAnguloInicio.Text = "Ángulo Inicio: ";
            // 
            // lblAnguloFin
            // 
            this.lblAnguloFin.AutoSize = true;
            this.lblAnguloFin.Location = new System.Drawing.Point(146, 218);
            this.lblAnguloFin.Name = "lblAnguloFin";
            this.lblAnguloFin.Size = new System.Drawing.Size(73, 16);
            this.lblAnguloFin.TabIndex = 3;
            this.lblAnguloFin.Text = "Ángulo Fin:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(252, 139);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 22);
            this.txtRadio.TabIndex = 4;
            // 
            // txtAnguloInicio
            // 
            this.txtAnguloInicio.Location = new System.Drawing.Point(252, 174);
            this.txtAnguloInicio.Name = "txtAnguloInicio";
            this.txtAnguloInicio.Size = new System.Drawing.Size(100, 22);
            this.txtAnguloInicio.TabIndex = 5;
            // 
            // txtAnguloFin
            // 
            this.txtAnguloFin.Location = new System.Drawing.Point(252, 212);
            this.txtAnguloFin.Name = "txtAnguloFin";
            this.txtAnguloFin.Size = new System.Drawing.Size(100, 22);
            this.txtAnguloFin.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(235, 510);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(340, 510);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 8;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(447, 510);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSalidas
            // 
            this.lblSalidas.AutoSize = true;
            this.lblSalidas.Location = new System.Drawing.Point(92, 286);
            this.lblSalidas.Name = "lblSalidas";
            this.lblSalidas.Size = new System.Drawing.Size(56, 16);
            this.lblSalidas.TabIndex = 10;
            this.lblSalidas.Text = "Salidas:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(252, 360);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 18;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(252, 325);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(100, 22);
            this.txtPerimetro.TabIndex = 17;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(146, 363);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 16);
            this.lblArea.TabIndex = 16;
            this.lblArea.Text = "Área:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(146, 331);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(68, 16);
            this.lblPerimetro.TabIndex = 15;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // panelDibujo
            // 
            this.panelDibujo.Location = new System.Drawing.Point(724, 64);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(426, 382);
            this.panelDibujo.TabIndex = 19;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(92, 430);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "*Ángulos desde 0  hasta 360";
            // 
            // FrmPie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblSalidas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAnguloFin);
            this.Controls.Add(this.txtAnguloInicio);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblAnguloFin);
            this.Controls.Add(this.lblAnguloInicio);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.lblEntradas);
            this.Name = "FrmPie";
            this.Text = "FrmPie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblAnguloInicio;
        private System.Windows.Forms.Label lblAnguloFin;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtAnguloInicio;
        private System.Windows.Forms.TextBox txtAnguloFin;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSalidas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
    }
}