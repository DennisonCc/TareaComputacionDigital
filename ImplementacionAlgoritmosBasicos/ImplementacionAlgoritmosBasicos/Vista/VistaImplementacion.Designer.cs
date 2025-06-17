namespace ImplementacionAlgoritmosBasicos.Vista
{
    partial class VistaImplementacion
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
            this.picCanva = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLineaDDA = new System.Windows.Forms.Button();
            this.btnBresenham = new System.Windows.Forms.Button();
            this.btnCircunferencia = new System.Windows.Forms.Button();
            this.btnDibujarPoligono = new System.Windows.Forms.Button();
            this.btnRellenar = new System.Windows.Forms.Button();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumLados = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanva)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanva
            // 
            this.picCanva.BackColor = System.Drawing.Color.DarkKhaki;
            this.picCanva.Location = new System.Drawing.Point(12, 252);
            this.picCanva.Name = "picCanva";
            this.picCanva.Size = new System.Drawing.Size(537, 299);
            this.picCanva.TabIndex = 0;
            this.picCanva.TabStop = false;
            this.picCanva.Click += new System.EventHandler(this.picCanva_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(537, 252);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 299);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnLineaDDA
            // 
            this.btnLineaDDA.Font = new System.Drawing.Font("8-bit Operator+ SC", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLineaDDA.Location = new System.Drawing.Point(323, 194);
            this.btnLineaDDA.Name = "btnLineaDDA";
            this.btnLineaDDA.Size = new System.Drawing.Size(124, 37);
            this.btnLineaDDA.TabIndex = 2;
            this.btnLineaDDA.Text = "LINEA DDA";
            this.btnLineaDDA.UseVisualStyleBackColor = true;
            this.btnLineaDDA.Click += new System.EventHandler(this.btnLineaDDA_Click);
            // 
            // btnBresenham
            // 
            this.btnBresenham.Font = new System.Drawing.Font("8-bit Operator+ SC", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBresenham.Location = new System.Drawing.Point(178, 194);
            this.btnBresenham.Name = "btnBresenham";
            this.btnBresenham.Size = new System.Drawing.Size(139, 37);
            this.btnBresenham.TabIndex = 3;
            this.btnBresenham.Text = "BRESENHAM";
            this.btnBresenham.UseVisualStyleBackColor = true;
            this.btnBresenham.Click += new System.EventHandler(this.btnBresenham_Click);
            // 
            // btnCircunferencia
            // 
            this.btnCircunferencia.Font = new System.Drawing.Font("8-bit Operator+ SC", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCircunferencia.Location = new System.Drawing.Point(12, 194);
            this.btnCircunferencia.Name = "btnCircunferencia";
            this.btnCircunferencia.Size = new System.Drawing.Size(160, 37);
            this.btnCircunferencia.TabIndex = 4;
            this.btnCircunferencia.Text = "CIRCUNFERENCIA";
            this.btnCircunferencia.UseVisualStyleBackColor = true;
            this.btnCircunferencia.Click += new System.EventHandler(this.btnCircunferencia_Click);
            // 
            // btnDibujarPoligono
            // 
            this.btnDibujarPoligono.Font = new System.Drawing.Font("8-bit Operator+ SC", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDibujarPoligono.Location = new System.Drawing.Point(578, 194);
            this.btnDibujarPoligono.Name = "btnDibujarPoligono";
            this.btnDibujarPoligono.Size = new System.Drawing.Size(91, 37);
            this.btnDibujarPoligono.TabIndex = 5;
            this.btnDibujarPoligono.Text = "DIBUJAR POLIGONO";
            this.btnDibujarPoligono.UseVisualStyleBackColor = true;
            this.btnDibujarPoligono.Click += new System.EventHandler(this.btnDibujarPoligono_Click);
            // 
            // btnRellenar
            // 
            this.btnRellenar.Font = new System.Drawing.Font("8-bit Operator+ SC", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRellenar.Location = new System.Drawing.Point(453, 194);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(119, 37);
            this.btnRellenar.TabIndex = 6;
            this.btnRellenar.Text = "RELLENAR";
            this.btnRellenar.UseVisualStyleBackColor = true;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(57, 87);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(100, 20);
            this.txtX0.TabIndex = 7;
            this.txtX0.TextChanged += new System.EventHandler(this.txtX0_TextChanged);
            // 
            // txtY0
            // 
            this.txtY0.Location = new System.Drawing.Point(217, 87);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(100, 20);
            this.txtY0.TabIndex = 8;
            this.txtY0.TextChanged += new System.EventHandler(this.txtY0_TextChanged);
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(393, 87);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 20);
            this.txtX1.TabIndex = 9;
            this.txtX1.TextChanged += new System.EventHandler(this.txtX1_TextChanged);
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(581, 87);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 20);
            this.txtY1.TabIndex = 10;
            this.txtY1.TextChanged += new System.EventHandler(this.txtY1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("8-bit Operator+ SC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "X0:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("8-bit Operator+ SC", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(551, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Y1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("8-bit Operator+ SC", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(360, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "X1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("8-bit Operator+ SC", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(186, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Y0:";
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("8-bit Operator+ SC", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(15, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "NUMERO DE LADOS:";
            // 
            // txtNumLados
            // 
            this.txtNumLados.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtNumLados.Location = new System.Drawing.Point(178, 135);
            this.txtNumLados.Name = "txtNumLados";
            this.txtNumLados.Size = new System.Drawing.Size(100, 20);
            this.txtNumLados.TabIndex = 21;
            this.txtNumLados.TextChanged += new System.EventHandler(this.txtNumLados_TextChanged);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("8-bit Operator+ SC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "PUNTOS ARBITRARIOS";
            // 
            // VistaImplementacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(823, 560);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumLados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtY0);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.btnRellenar);
            this.Controls.Add(this.btnDibujarPoligono);
            this.Controls.Add(this.btnCircunferencia);
            this.Controls.Add(this.btnBresenham);
            this.Controls.Add(this.btnLineaDDA);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.picCanva);
            this.Name = "VistaImplementacion";
            this.Text = "VistaImplementacion";
            this.Load += new System.EventHandler(this.VistaImplementacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanva;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLineaDDA;
        private System.Windows.Forms.Button btnBresenham;
        private System.Windows.Forms.Button btnCircunferencia;
        private System.Windows.Forms.Button btnDibujarPoligono;
        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumLados;
        private System.Windows.Forms.Label label5;
    }
}