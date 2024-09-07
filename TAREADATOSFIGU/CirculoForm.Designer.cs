namespace TAREADATOSFIGU
{
    partial class CirculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CirculoForm));
            this.TITULO = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtResultadoArea = new System.Windows.Forms.TextBox();
            this.txtResultadoPerimetro = new System.Windows.Forms.TextBox();
            this.BtnCalcularArea = new System.Windows.Forms.Button();
            this.BtnCalcularPerimetro = new System.Windows.Forms.Button();
            this.BtnRegreMenuCirc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRadioPerimetro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.BackColor = System.Drawing.Color.LightGreen;
            this.TITULO.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITULO.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TITULO.Location = new System.Drawing.Point(317, 9);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(110, 37);
            this.TITULO.TabIndex = 3;
            this.TITULO.Text = "Circulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(154, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGreen;
            this.label6.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(494, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Perimetro";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(134, 175);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 22);
            this.txtRadio.TabIndex = 14;
            // 
            // txtResultadoArea
            // 
            this.txtResultadoArea.Location = new System.Drawing.Point(134, 258);
            this.txtResultadoArea.Name = "txtResultadoArea";
            this.txtResultadoArea.ReadOnly = true;
            this.txtResultadoArea.Size = new System.Drawing.Size(100, 22);
            this.txtResultadoArea.TabIndex = 15;
            // 
            // txtResultadoPerimetro
            // 
            this.txtResultadoPerimetro.Location = new System.Drawing.Point(531, 258);
            this.txtResultadoPerimetro.Name = "txtResultadoPerimetro";
            this.txtResultadoPerimetro.ReadOnly = true;
            this.txtResultadoPerimetro.Size = new System.Drawing.Size(100, 22);
            this.txtResultadoPerimetro.TabIndex = 16;
            // 
            // BtnCalcularArea
            // 
            this.BtnCalcularArea.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnCalcularArea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularArea.Location = new System.Drawing.Point(115, 319);
            this.BtnCalcularArea.Name = "BtnCalcularArea";
            this.BtnCalcularArea.Size = new System.Drawing.Size(119, 49);
            this.BtnCalcularArea.TabIndex = 17;
            this.BtnCalcularArea.Text = "Calcular";
            this.BtnCalcularArea.UseVisualStyleBackColor = false;
            this.BtnCalcularArea.Click += new System.EventHandler(this.BtnCalcularArea_Click);
            // 
            // BtnCalcularPerimetro
            // 
            this.BtnCalcularPerimetro.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnCalcularPerimetro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularPerimetro.Location = new System.Drawing.Point(531, 319);
            this.BtnCalcularPerimetro.Name = "BtnCalcularPerimetro";
            this.BtnCalcularPerimetro.Size = new System.Drawing.Size(119, 49);
            this.BtnCalcularPerimetro.TabIndex = 18;
            this.BtnCalcularPerimetro.Text = "Calcular";
            this.BtnCalcularPerimetro.UseVisualStyleBackColor = false;
            this.BtnCalcularPerimetro.Click += new System.EventHandler(this.BtnCalcularPerimetro_Click);
            // 
            // BtnRegreMenuCirc
            // 
            this.BtnRegreMenuCirc.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnRegreMenuCirc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegreMenuCirc.Location = new System.Drawing.Point(669, 389);
            this.BtnRegreMenuCirc.Name = "BtnRegreMenuCirc";
            this.BtnRegreMenuCirc.Size = new System.Drawing.Size(119, 49);
            this.BtnRegreMenuCirc.TabIndex = 19;
            this.BtnRegreMenuCirc.Text = "Regresar";
            this.BtnRegreMenuCirc.UseVisualStyleBackColor = false;
            this.BtnRegreMenuCirc.Click += new System.EventHandler(this.BtnRegreMenuCirc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(39, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Radio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Resultado";
            // 
            // txtRadioPerimetro
            // 
            this.txtRadioPerimetro.Location = new System.Drawing.Point(531, 176);
            this.txtRadioPerimetro.Name = "txtRadioPerimetro";
            this.txtRadioPerimetro.Size = new System.Drawing.Size(100, 22);
            this.txtRadioPerimetro.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(405, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(422, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Radio";
            // 
            // CirculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRadioPerimetro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRegreMenuCirc);
            this.Controls.Add(this.BtnCalcularPerimetro);
            this.Controls.Add(this.BtnCalcularArea);
            this.Controls.Add(this.txtResultadoPerimetro);
            this.Controls.Add(this.txtResultadoArea);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TITULO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CirculoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.CirculoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITULO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtResultadoArea;
        private System.Windows.Forms.TextBox txtResultadoPerimetro;
        private System.Windows.Forms.Button BtnCalcularArea;
        private System.Windows.Forms.Button BtnCalcularPerimetro;
        private System.Windows.Forms.Button BtnRegreMenuCirc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRadioPerimetro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}