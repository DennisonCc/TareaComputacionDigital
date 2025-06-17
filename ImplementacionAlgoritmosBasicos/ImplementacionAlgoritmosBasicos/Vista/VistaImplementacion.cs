using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImplementacionAlgoritmosBasicos.Modelo;
using ImplementacionAlgoritmosBasicos.Algoritmos;

namespace ImplementacionAlgoritmosBasicos.Vista
{
    public partial class VistaImplementacion : Form
    {
        private Poligono poligonoActual;
        private Bitmap bmp;

        public VistaImplementacion()
        {
            InitializeComponent();
        }

        private void btnDibujarPoligono_Click(object sender, EventArgs e)
        {
            int lados;
            if (string.IsNullOrWhiteSpace(txtNumLados.Text) || !int.TryParse(txtNumLados.Text, out lados) || lados < 3)
            {
                MessageBox.Show("Por favor, ingresa un número de lados válido (mayor o igual a 3) para el polígono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int w = picCanva.Width;
            int h = picCanva.Height;
            int radio = (int)(0.4 * Math.Min(w, h));
            int centroX = w / 2;
            int centroY = h / 2;

            poligonoActual = new Poligono(centroX, centroY, radio, lados);

            bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach (var (a, b) in poligonoActual.LadosComoPares())
                {
                    g.DrawLine(Pens.Black, a, b);
                }
            }
            picCanva.Image = bmp;
            listBox1.Items.Clear();
        }

        private void btnDDA_Click(object sender, EventArgs e)
        {
            int w = picCanva.Width;
            int h = picCanva.Height;
            bmp = new Bitmap(w, h);
            listBox1.Items.Clear();
            var lineaDDA = new LineaDDA();

            if (CamposLineaCompletos())
            {
                // Escala los puntos ingresados
                if (!int.TryParse(txtX0.Text, out int x0) ||
                    !int.TryParse(txtY0.Text, out int y0) ||
                    !int.TryParse(txtX1.Text, out int x1) ||
                    !int.TryParse(txtY1.Text, out int y1))
                {
                    MessageBox.Show("Por favor, ingresa valores numéricos válidos para los puntos de la línea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EscalarPuntosALienzo(x0, y0, x1, y1, bmp.Width, bmp.Height, out int sx0, out int sy0, out int sx1, out int sy1);

                lineaDDA.TrazaLinea(sx0, sy0, sx1, sy1);
                foreach (var p in lineaDDA.Pixeles)
                {
                    if (p.X >= 0 && p.Y >= 0 && p.X < bmp.Width && p.Y < bmp.Height)
                    {
                        bmp.SetPixel(p.X, p.Y, Color.Red);
                        listBox1.Items.Add(p.ToString());
                    }
                }
            }
            else if (poligonoActual != null)
            {
                foreach (var (a, b) in poligonoActual.LadosComoPares())
                {
                    lineaDDA.TrazaLinea(a.X, a.Y, b.X, b.Y);
                    foreach (var p in lineaDDA.Pixeles)
                    {
                        if (p.X >= 0 && p.Y >= 0 && p.X < bmp.Width && p.Y < bmp.Height)
                        {
                            bmp.SetPixel(p.X, p.Y, Color.Red);
                            listBox1.Items.Add(p.ToString());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Dibuja primero un polígono o ingresa puntos para la línea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            picCanva.Image = bmp;
        }

        private void btnBresenham_Click(object sender, EventArgs e)
        {
            int w = picCanva.Width;
            int h = picCanva.Height;
            bmp = new Bitmap(w, h);
            listBox1.Items.Clear();
            var lineaBresenham = new LineaBresenham();

            if (CamposLineaCompletos())
            {
                if (!int.TryParse(txtX0.Text, out int x0) ||
                    !int.TryParse(txtY0.Text, out int y0) ||
                    !int.TryParse(txtX1.Text, out int x1) ||
                    !int.TryParse(txtY1.Text, out int y1))
                {
                    MessageBox.Show("Por favor, ingresa valores numéricos válidos para los puntos de la línea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EscalarPuntosALienzo(x0, y0, x1, y1, bmp.Width, bmp.Height, out int sx0, out int sy0, out int sx1, out int sy1);

                lineaBresenham.TrazaLinea(sx0, sy0, sx1, sy1);
                foreach (var p in lineaBresenham.Pixeles)
                {
                    if (p.X >= 0 && p.Y >= 0 && p.X < bmp.Width && p.Y < bmp.Height)
                    {
                        bmp.SetPixel(p.X, p.Y, Color.Blue);
                        listBox1.Items.Add(p.ToString());
                    }
                }
            }
            else if (poligonoActual != null)
            {
                foreach (var (a, b) in poligonoActual.LadosComoPares())
                {
                    lineaBresenham.TrazaLinea(a.X, a.Y, b.X, b.Y);
                    foreach (var p in lineaBresenham.Pixeles)
                    {
                        if (p.X >= 0 && p.Y >= 0 && p.X < bmp.Width && p.Y < bmp.Height)
                        {
                            bmp.SetPixel(p.X, p.Y, Color.Blue);
                            listBox1.Items.Add(p.ToString());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Dibuja primero un polígono o ingresa puntos para la línea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            picCanva.Image = bmp;
        }

        private void btnCircunferencia_Click(object sender, EventArgs e)
        {
            int w = picCanva.Width;
            int h = picCanva.Height;
            int radio = (int)(0.4 * Math.Min(w, h));
            int centroX = w / 2;
            int centroY = h / 2;
            bmp = new Bitmap(w, h);
            listBox1.Items.Clear();

            var circ = new circuloBresenham();
            circ.TrazaCirculo(centroX, centroY, radio);
            foreach (var p in circ.Pixeles)
            {
                if (p.X >= 0 && p.Y >= 0 && p.X < bmp.Width && p.Y < bmp.Height)
                {
                    bmp.SetPixel(p.X, p.Y, Color.Green);
                    listBox1.Items.Add(p.ToString());
                }
            }
            picCanva.Image = bmp;
        }

        // --- RELLENO CON DELAY ---
        private async void btnRellenar_Click(object sender, EventArgs e)
        {
            if (bmp == null) return;

            int x = bmp.Width / 2;
            int y = bmp.Height / 2;

            Color colorRelleno = Color.Yellow;
            Color colorBorde = Color.Black;
            int delayMs = 1; // Ajusta el delay aquí

            var relleno = new rellenoFigura();
            await relleno.FloodFillAsync(bmp, x, y, colorRelleno, colorBorde, (p) =>
            {
                if (p.X >= 0 && p.Y >= 0 && p.X < bmp.Width && p.Y < bmp.Height)
                {
                    bmp.SetPixel(p.X, p.Y, colorRelleno);
                    picCanva.Image = bmp;
                    Application.DoEvents();
                }
            }, delayMs);
        }

        // --- MÉTODO AUXILIAR PARA CAMPOS DE LÍNEA ---
        private bool CamposLineaCompletos()
        {
            return !string.IsNullOrWhiteSpace(txtX0.Text) &&
                   !string.IsNullOrWhiteSpace(txtY0.Text) &&
                   !string.IsNullOrWhiteSpace(txtX1.Text) &&
                   !string.IsNullOrWhiteSpace(txtY1.Text);
        }

        /// <summary>
        /// Escala y centra los puntos de usuario para que se vean siempre en el canvas.
        /// </summary>
        private void EscalarPuntosALienzo(
            int x0, int y0, int x1, int y1,
            int canvasWidth, int canvasHeight,
            out int sx0, out int sy0, out int sx1, out int sy1,
            int margen = 20)
        {
            int minX = Math.Min(x0, x1);
            int maxX = Math.Max(x0, x1);
            int minY = Math.Min(y0, y1);
            int maxY = Math.Max(y0, y1);

            int deltaX = maxX - minX;
            int deltaY = maxY - minY;

            if (deltaX == 0) deltaX = 1;
            if (deltaY == 0) deltaY = 1;

            float escalaX = (canvasWidth - 2 * margen) / (float)deltaX;
            float escalaY = (canvasHeight - 2 * margen) / (float)deltaY;
            float escala = Math.Min(escalaX, escalaY);

            sx0 = margen + (int)((x0 - minX) * escala);
            sy0 = margen + (int)((y0 - minY) * escala);
            sx1 = margen + (int)((x1 - minX) * escala);
            sy1 = margen + (int)((y1 - minY) * escala);

            // Centrado opcional
            int usedWidth = Math.Abs(sx0 - sx1);
            int usedHeight = Math.Abs(sy0 - sy1);
            int offsetX = (canvasWidth - usedWidth) / 2 - Math.Min(sx0, sx1);
            int offsetY = (canvasHeight - usedHeight) / 2 - Math.Min(sy0, sy1);
            sx0 += offsetX; sx1 += offsetX;
            sy0 += offsetY; sy1 += offsetY;
        }

        // Métodos vacíos por defecto
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtNumLados_TextChanged(object sender, EventArgs e) { }
        private void picCanva_Click(object sender, EventArgs e) { }
        private void VistaImplementacion_Load(object sender, EventArgs e) { }
        private void txtY1_TextChanged(object sender, EventArgs e) { }
        private void txtX0_TextChanged(object sender, EventArgs e) { }
        private void txtY0_TextChanged(object sender, EventArgs e) { }
        private void txtX1_TextChanged(object sender, EventArgs e) { }

        private void btnLineaDDA_Click(object sender, EventArgs e)
        {
            int w = picCanva.Width;
            int h = picCanva.Height;
            bmp = new Bitmap(w, h);
            listBox1.Items.Clear();
            var lineaDDA = new LineaDDA();

            if (CamposLineaCompletos())
            {
                if (!int.TryParse(txtX0.Text, out int x0) ||
                    !int.TryParse(txtY0.Text, out int y0) ||
                    !int.TryParse(txtX1.Text, out int x1) ||
                    !int.TryParse(txtY1.Text, out int y1))
                {
                    MessageBox.Show("Por favor, ingresa valores numéricos válidos para los puntos de la línea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EscalarPuntosALienzo(x0, y0, x1, y1, bmp.Width, bmp.Height, out int sx0, out int sy0, out int sx1, out int sy1);

                lineaDDA.TrazaLinea(sx0, sy0, sx1, sy1);
                foreach (var p in lineaDDA.Pixeles)
                {
                    if (p.X >= 0 && p.Y >= 0 && p.X < bmp.Width && p.Y < bmp.Height)
                    {
                        bmp.SetPixel(p.X, p.Y, Color.Red);
                        listBox1.Items.Add(p.ToString());
                    }
                }
            }
            else if (poligonoActual != null)
            {
                foreach (var (a, b) in poligonoActual.LadosComoPares())
                {
                    lineaDDA.TrazaLinea(a.X, a.Y, b.X, b.Y);
                    foreach (var p in lineaDDA.Pixeles)
                    {
                        if (p.X >= 0 && p.Y >= 0 && p.X < bmp.Width && p.Y < bmp.Height)
                        {
                            bmp.SetPixel(p.X, p.Y, Color.Red);
                            listBox1.Items.Add(p.ToString());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Dibuja primero un polígono o ingresa puntos para la línea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            picCanva.Image = bmp;
        }
    }
}