using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionAlgoritmosBasicos.Modelo
{
    internal class Poligono
    {
        public List<Point> Vertices { get; private set; }
        public int Lados { get; private set; }

        public Poligono(int centroX, int centroY, int radio, int lados)
        {
            Lados = lados;
            Vertices = new List<Point>();
            double angulo = 2 * Math.PI / lados;
            for (int i = 0; i < lados; i++)
            {
                int x = centroX + (int)(radio * Math.Cos(i * angulo));
                int y = centroY + (int)(radio * Math.Sin(i * angulo));
                Vertices.Add(new Point(x, y));
            }
        }

        public IEnumerable<(Point, Point)> LadosComoPares()
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                yield return (Vertices[i], Vertices[(i + 1) % Vertices.Count]);
            }
        }
    }
}
