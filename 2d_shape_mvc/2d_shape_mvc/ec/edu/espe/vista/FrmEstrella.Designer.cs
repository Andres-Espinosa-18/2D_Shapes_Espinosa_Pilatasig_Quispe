namespace _2d_shape_mvc.ec.edu.espe.vista
{
    partial class FrmEstrella
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
            this.lblPuntas = new System.Windows.Forms.Label();
            this.txtNumPuntas = new System.Windows.Forms.TextBox();
            this.lblRadioInterior = new System.Windows.Forms.Label();
            this.txtRadioInterior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadioExterior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
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
            this.lblEntrada.Location = new System.Drawing.Point(96, 139);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(61, 16);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Entradas";
            // 
            // lblPuntas
            // 
            this.lblPuntas.AutoSize = true;
            this.lblPuntas.Location = new System.Drawing.Point(127, 174);
            this.lblPuntas.Name = "lblPuntas";
            this.lblPuntas.Size = new System.Drawing.Size(123, 16);
            this.lblPuntas.TabIndex = 1;
            this.lblPuntas.Text = "Numero de puntas: ";
            this.lblPuntas.Click += new System.EventHandler(this.lblPuntas_Click);
            // 
            // txtNumPuntas
            // 
            this.txtNumPuntas.Location = new System.Drawing.Point(278, 171);
            this.txtNumPuntas.Name = "txtNumPuntas";
            this.txtNumPuntas.Size = new System.Drawing.Size(100, 22);
            this.txtNumPuntas.TabIndex = 2;
            this.txtNumPuntas.TextChanged += new System.EventHandler(this.txtNumPuntas_TextChanged);
            // 
            // lblRadioInterior
            // 
            this.lblRadioInterior.AutoSize = true;
            this.lblRadioInterior.Location = new System.Drawing.Point(160, 206);
            this.lblRadioInterior.Name = "lblRadioInterior";
            this.lblRadioInterior.Size = new System.Drawing.Size(90, 16);
            this.lblRadioInterior.TabIndex = 3;
            this.lblRadioInterior.Text = "Radio interior:";
            this.lblRadioInterior.Click += new System.EventHandler(this.lblRadioInterior_Click);
            // 
            // txtRadioInterior
            // 
            this.txtRadioInterior.Location = new System.Drawing.Point(278, 203);
            this.txtRadioInterior.Name = "txtRadioInterior";
            this.txtRadioInterior.Size = new System.Drawing.Size(100, 22);
            this.txtRadioInterior.TabIndex = 4;
            this.txtRadioInterior.TextChanged += new System.EventHandler(this.txtRadioInterior_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Radio exterior:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRadioExterior
            // 
            this.txtRadioExterior.Location = new System.Drawing.Point(278, 234);
            this.txtRadioExterior.Name = "txtRadioExterior";
            this.txtRadioExterior.Size = new System.Drawing.Size(100, 22);
            this.txtRadioExterior.TabIndex = 6;
            this.txtRadioExterior.TextChanged += new System.EventHandler(this.txtRadioExterior_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Salidas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(446, 515);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(179, 342);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(71, 16);
            this.lblPerimetro.TabIndex = 9;
            this.lblPerimetro.Text = "Perímetro: ";
            this.lblPerimetro.Click += new System.EventHandler(this.lblPerimetro_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(199, 379);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 16);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Área: ";
            this.lblArea.Click += new System.EventHandler(this.lblArea_Click);
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(278, 339);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(100, 22);
            this.txtPerimetro.TabIndex = 11;
            this.txtPerimetro.TextChanged += new System.EventHandler(this.txtPerimetro_TextChanged);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(278, 376);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 12;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(338, 515);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 13;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(223, 515);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelDibujo
            // 
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDibujo.Location = new System.Drawing.Point(830, 52);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(477, 435);
            this.panelDibujo.TabIndex = 15;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(112, 435);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 16;
            // 
            // FrmEstrella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 691);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRadioExterior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadioInterior);
            this.Controls.Add(this.lblRadioInterior);
            this.Controls.Add(this.txtNumPuntas);
            this.Controls.Add(this.lblPuntas);
            this.Controls.Add(this.lblEntrada);
            this.Name = "FrmEstrella";
            this.Text = "Estrella";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblPuntas;
        private System.Windows.Forms.TextBox txtNumPuntas;
        private System.Windows.Forms.Label lblRadioInterior;
        private System.Windows.Forms.TextBox txtRadioInterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadioExterior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Label lblMensaje;
    }
}