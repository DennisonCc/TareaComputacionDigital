using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionAlgoritmosBasicos.Modelo
{
    internal class DibujarPoligono
    {
        public static List<Point> GenerarVertices(int xc, int yc, int radio, int lados)
        {
            var vertices = new List<Point>();
            for (int i = 0; i < lados; i++)
            {
                double angulo = 2 * Math.PI * i / lados;
                int x = xc + (int)(radio * Math.Cos(angulo));
                int y = yc + (int)(radio * Math.Sin(angulo));
                vertices.Add(new Point(x, y));
            }
            return vertices;
        }
    }
}
