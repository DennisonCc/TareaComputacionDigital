using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementacionAlgoritmosBasicos.Modelo;

namespace ImplementacionAlgoritmosBasicos.Algoritmos
{
    internal class rellenoFigura
    {
        public async Task FloodFillAsync(Bitmap bmp, int x, int y, Color colorRelleno, Color colorBorde, Action<Point> onPixelPainted, int delayMs)
        {
            Color colorOrigen = bmp.GetPixel(x, y);
            if (colorOrigen.ToArgb() == colorRelleno.ToArgb() || colorOrigen.ToArgb() == colorBorde.ToArgb())
                return;

            Queue<Point> cola = new Queue<Point>();
            cola.Enqueue(new Point(x, y));
            int w = bmp.Width, h = bmp.Height;

            while (cola.Count > 0)
            {
                Point p = cola.Dequeue();
                if (p.X < 0 || p.X >= w || p.Y < 0 || p.Y >= h)
                    continue;

                Color actual = bmp.GetPixel(p.X, p.Y);
                if (actual.ToArgb() == colorRelleno.ToArgb() || actual.ToArgb() == colorBorde.ToArgb())
                    continue;

                onPixelPainted(p);
                await Task.Delay(delayMs);

                cola.Enqueue(new Point(p.X + 1, p.Y));
                cola.Enqueue(new Point(p.X - 1, p.Y));
                cola.Enqueue(new Point(p.X, p.Y + 1));
                cola.Enqueue(new Point(p.X, p.Y - 1));
            }
        }
    }
}
