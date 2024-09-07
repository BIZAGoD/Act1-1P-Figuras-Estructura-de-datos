namespace TAREADATOSFIGU
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.TITULO = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCuadrado = new System.Windows.Forms.Button();
            this.BtnRectangulo = new System.Windows.Forms.Button();
            this.BtnTriangulo = new System.Windows.Forms.Button();
            this.BtnCirculo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.BackColor = System.Drawing.Color.LightGreen;
            this.TITULO.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITULO.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TITULO.Location = new System.Drawing.Point(283, 9);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(266, 37);
            this.TITULO.TabIndex = 0;
            this.TITULO.Text = "Area y Perimetro";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(658, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnSalir.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(22, 399);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(97, 42);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCuadrado
            // 
            this.BtnCuadrado.BackColor = System.Drawing.Color.Red;
            this.BtnCuadrado.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuadrado.Location = new System.Drawing.Point(290, 390);
            this.BtnCuadrado.Name = "BtnCuadrado";
            this.BtnCuadrado.Size = new System.Drawing.Size(112, 51);
            this.BtnCuadrado.TabIndex = 4;
            this.BtnCuadrado.Text = "Cuadrado";
            this.BtnCuadrado.UseVisualStyleBackColor = false;
            this.BtnCuadrado.Click += new System.EventHandler(this.BtnCuadrado_Click);
            // 
            // BtnRectangulo
            // 
            this.BtnRectangulo.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnRectangulo.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRectangulo.Location = new System.Drawing.Point(290, 252);
            this.BtnRectangulo.Name = "BtnRectangulo";
            this.BtnRectangulo.Size = new System.Drawing.Size(112, 51);
            this.BtnRectangulo.TabIndex = 5;
            this.BtnRectangulo.Text = "Rectangulo";
            this.BtnRectangulo.UseVisualStyleBackColor = false;
            this.BtnRectangulo.Click += new System.EventHandler(this.BtnRectangulo_Click);
            // 
            // BtnTriangulo
            // 
            this.BtnTriangulo.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnTriangulo.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTriangulo.Location = new System.Drawing.Point(448, 252);
            this.BtnTriangulo.Name = "BtnTriangulo";
            this.BtnTriangulo.Size = new System.Drawing.Size(106, 51);
            this.BtnTriangulo.TabIndex = 6;
            this.BtnTriangulo.Text = "Triangulo";
            this.BtnTriangulo.UseVisualStyleBackColor = false;
            this.BtnTriangulo.Click += new System.EventHandler(this.BtnTriangulo_Click);
            // 
            // BtnCirculo
            // 
            this.BtnCirculo.BackColor = System.Drawing.Color.Yellow;
            this.BtnCirculo.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCirculo.Location = new System.Drawing.Point(448, 390);
            this.BtnCirculo.Name = "BtnCirculo";
            this.BtnCirculo.Size = new System.Drawing.Size(106, 51);
            this.BtnCirculo.TabIndex = 7;
            this.BtnCirculo.Text = "Circulo";
            this.BtnCirculo.UseVisualStyleBackColor = false;
            this.BtnCirculo.Click += new System.EventHandler(this.BtnCirculo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(315, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 151);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(345, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eliga una figura";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnCirculo);
            this.Controls.Add(this.BtnTriangulo);
            this.Controls.Add(this.BtnRectangulo);
            this.Controls.Add(this.BtnCuadrado);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TITULO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITULO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnCuadrado;
        private System.Windows.Forms.Button BtnRectangulo;
        private System.Windows.Forms.Button BtnTriangulo;
        private System.Windows.Forms.Button BtnCirculo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}

