namespace _2d_shape_mvc.ec.edu.espe.vista
{
    partial class FrmTrapecio
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
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBaseMenor = new System.Windows.Forms.TextBox();
            this.txtBaseMayor = new System.Windows.Forms.TextBox();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBaseMenor = new System.Windows.Forms.Label();
            this.lblBasemayor = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(132, 132);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 50;
            // 
            // txtBaseMenor
            // 
            this.txtBaseMenor.Location = new System.Drawing.Point(132, 100);
            this.txtBaseMenor.Name = "txtBaseMenor";
            this.txtBaseMenor.Size = new System.Drawing.Size(100, 22);
            this.txtBaseMenor.TabIndex = 49;
            // 
            // txtBaseMayor
            // 
            this.txtBaseMayor.Location = new System.Drawing.Point(132, 68);
            this.txtBaseMayor.Name = "txtBaseMayor";
            this.txtBaseMayor.Size = new System.Drawing.Size(100, 22);
            this.txtBaseMayor.TabIndex = 48;
            // 
            // panelDibujo
            // 
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDibujo.Location = new System.Drawing.Point(338, 19);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(444, 412);
            this.panelDibujo.TabIndex = 47;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(22, 341);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 46;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(115, 172);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 45;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(115, 294);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 44;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(115, 260);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(100, 22);
            this.txtPerimetro.TabIndex = 43;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(67, 297);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 16);
            this.lblArea.TabIndex = 42;
            this.lblArea.Text = "Área: ";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(40, 263);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(71, 16);
            this.lblPerimetro.TabIndex = 41;
            this.lblPerimetro.Text = "Perimetro: ";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(19, 227);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(53, 16);
            this.lblSalida.TabIndex = 40;
            this.lblSalida.Text = "Salidas";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(22, 172);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 39;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(19, 376);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(286, 55);
            this.lblMensaje.TabIndex = 38;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(79, 135);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(47, 16);
            this.lblAltura.TabIndex = 37;
            this.lblAltura.Text = "Altura: ";
            // 
            // lblBaseMenor
            // 
            this.lblBaseMenor.AutoSize = true;
            this.lblBaseMenor.Location = new System.Drawing.Point(40, 103);
            this.lblBaseMenor.Name = "lblBaseMenor";
            this.lblBaseMenor.Size = new System.Drawing.Size(86, 16);
            this.lblBaseMenor.TabIndex = 36;
            this.lblBaseMenor.Text = "Base Menor: ";
            // 
            // lblBasemayor
            // 
            this.lblBasemayor.AutoSize = true;
            this.lblBasemayor.Location = new System.Drawing.Point(40, 71);
            this.lblBasemayor.Name = "lblBasemayor";
            this.lblBasemayor.Size = new System.Drawing.Size(86, 16);
            this.lblBasemayor.TabIndex = 35;
            this.lblBasemayor.Text = "Base Mayor: ";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(19, 37);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(61, 16);
            this.lblEntrada.TabIndex = 34;
            this.lblEntrada.Text = "Entradas";
            // 
            // FrmTrapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBaseMenor);
            this.Controls.Add(this.txtBaseMayor);
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
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBaseMenor);
            this.Controls.Add(this.lblBasemayor);
            this.Controls.Add(this.lblEntrada);
            this.Name = "FrmTrapecio";
            this.Text = "FrmTrapecio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBaseMenor;
        private System.Windows.Forms.TextBox txtBaseMayor;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBaseMenor;
        private System.Windows.Forms.Label lblBasemayor;
        private System.Windows.Forms.Label lblEntrada;
    }
}