using ImplementacionAlgoritmosBasicos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementacionAlgoritmosBasicos.Modelo;

namespace ImplementacionAlgoritmosBasicos.Algoritmos
{
    internal class LineaBresenham
    {
        public List<CoordenadasPixelPintado> Pixeles { get; private set; } = new List<CoordenadasPixelPintado>();

        public void TrazaLinea(int x0, int y0, int x1, int y1)
        {
            Pixeles.Clear();
            int dx = Math.Abs(x1 - x0), dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;
            int x = x0, y = y0;

            while (true)
            {
                Pixeles.Add(new CoordenadasPixelPintado(x, y));
                if (x == x1 && y == y1) break;
                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x += sx; }
                if (e2 < dx) { err += dx; y += sy; }
            }
        }
    }
}
