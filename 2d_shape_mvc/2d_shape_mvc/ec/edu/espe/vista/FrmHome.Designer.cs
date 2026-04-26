namespace _2d_shape_mvc.ec.edu.espe.vista
{
    partial class FrmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miTrianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miTrebolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCrecienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCruzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSemicirculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRectanguloToolStripMenuItem,
            this.miTrianguloToolStripMenuItem,
            this.hexagonoToolStripMenuItem,
            this.miTrebolToolStripMenuItem,
            this.miCrecienteToolStripMenuItem,
            this.miCruzToolStripMenuItem,
            this.miSemicirculoToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.shapeToolStripMenuItem.Text = "Shapes";
            this.shapeToolStripMenuItem.Click += new System.EventHandler(this.shapeToolStripMenuItem_Click);
            // 
            // miRectanguloToolStripMenuItem
            // 
            this.miRectanguloToolStripMenuItem.Name = "miRectanguloToolStripMenuItem";
            this.miRectanguloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.miRectanguloToolStripMenuItem.Text = "Rectangulo";
            this.miRectanguloToolStripMenuItem.Click += new System.EventHandler(this.miRectanguloToolStripMenuItem_Click);
            // 
            // miTrianguloToolStripMenuItem
            // 
            this.miTrianguloToolStripMenuItem.Name = "miTrianguloToolStripMenuItem";
            this.miTrianguloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.miTrianguloToolStripMenuItem.Text = "Triangulo";
            this.miTrianguloToolStripMenuItem.Click += new System.EventHandler(this.miTrianguloToolStripMenuItem_Click);
            // 
            // hexagonoToolStripMenuItem
            // 
            this.hexagonoToolStripMenuItem.Name = "hexagonoToolStripMenuItem";
            this.hexagonoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hexagonoToolStripMenuItem.Text = "Hexagono";
            this.hexagonoToolStripMenuItem.Click += new System.EventHandler(this.hexagonoToolStripMenuItem_Click);
            // 
            // miTrebolToolStripMenuItem
            // 
            this.miTrebolToolStripMenuItem.Name = "miTrebolToolStripMenuItem";
            this.miTrebolToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.miTrebolToolStripMenuItem.Text = "Trebol";
            this.miTrebolToolStripMenuItem.Click += new System.EventHandler(this.miTrebolToolStripMenuItem_Click);
            // 
            // miCrecienteToolStripMenuItem
            // 
            this.miCrecienteToolStripMenuItem.Name = "miCrecienteToolStripMenuItem";
            this.miCrecienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.miCrecienteToolStripMenuItem.Text = "Creciente";
            this.miCrecienteToolStripMenuItem.Click += new System.EventHandler(this.miCrecienteToolStripMenuItem_Click);
            // 
            // miCruzToolStripMenuItem
            // 
            this.miCruzToolStripMenuItem.Name = "miCruzToolStripMenuItem";
            this.miCruzToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.miCruzToolStripMenuItem.Text = "Cruz";
            this.miCruzToolStripMenuItem.Click += new System.EventHandler(this.miCruzToolStripMenuItem_Click);
            // 
            // miSemicirculoToolStripMenuItem
            // 
            this.miSemicirculoToolStripMenuItem.Name = "miSemicirculoToolStripMenuItem";
            this.miSemicirculoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.miSemicirculoToolStripMenuItem.Text = "Semicirculo";
            this.miSemicirculoToolStripMenuItem.Click += new System.EventHandler(this.miSemicirculoToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHome";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miRectanguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miTrianguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexagonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miTrebolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCrecienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCruzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miSemicirculoToolStripMenuItem;
    }
}