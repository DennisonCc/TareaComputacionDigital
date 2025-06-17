using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionAlgoritmosBasicos.Modelo
{
    internal class CoordenadasPixelPintado
    {
        public int X { get; set; }
        public int Y { get; set; }

        public CoordenadasPixelPintado(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }
}
