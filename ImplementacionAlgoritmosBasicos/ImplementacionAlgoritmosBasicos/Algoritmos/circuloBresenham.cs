using ImplementacionAlgoritmosBasicos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementacionAlgoritmosBasicos.Modelo;

namespace ImplementacionAlgoritmosBasicos.Algoritmos
{
    internal class circuloBresenham
    {
        public List<CoordenadasPixelPintado> Pixeles { get; private set; } = new List<CoordenadasPixelPintado>();

        public void TrazaCirculo(int xc, int yc, int radio)
        {
            Pixeles.Clear();
            int x = 0, y = radio;
            int d = 3 - 2 * radio;
            while (y >= x)
            {
                AgregarSimetricos(xc, yc, x, y);
                x++;
                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                {
                    d = d + 4 * x + 6;
                }
            }
        }

        private void AgregarSimetricos(int xc, int yc, int x, int y)
        {
            Pixeles.Add(new CoordenadasPixelPintado(xc + x, yc + y));
            Pixeles.Add(new CoordenadasPixelPintado(xc - x, yc + y));
            Pixeles.Add(new CoordenadasPixelPintado(xc + x, yc - y));
            Pixeles.Add(new CoordenadasPixelPintado(xc - x, yc - y));
            Pixeles.Add(new CoordenadasPixelPintado(xc + y, yc + x));
            Pixeles.Add(new CoordenadasPixelPintado(xc - y, yc + x));
            Pixeles.Add(new CoordenadasPixelPintado(xc + y, yc - x));
            Pixeles.Add(new CoordenadasPixelPintado(xc - y, yc - x));
        }
    }
}
