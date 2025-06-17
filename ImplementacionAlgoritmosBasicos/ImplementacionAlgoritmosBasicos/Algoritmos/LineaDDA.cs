using ImplementacionAlgoritmosBasicos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementacionAlgoritmosBasicos.Modelo;
using System.Drawing;

namespace ImplementacionAlgoritmosBasicos.Algoritmos
{
    internal class LineaDDA
    {
        public List<Point> Pixeles { get; private set; }

        public LineaDDA()
        {
            Pixeles = new List<Point>();
        }

        public void TrazaLinea(int x0, int y0, int x1, int y1)
        {
            Pixeles.Clear();

            int dx = x1 - x0;
            int dy = y1 - y0;
            int pasos = System.Math.Max(System.Math.Abs(dx), System.Math.Abs(dy));
            if (pasos == 0)
            {
                Pixeles.Add(new Point(x0, y0));
                return;
            }

            float xInc = dx / (float)pasos;
            float yInc = dy / (float)pasos;
            float x = x0, y = y0;
            for (int i = 0; i <= pasos; i++)
            {
                Pixeles.Add(new Point((int)System.Math.Round(x), (int)System.Math.Round(y)));
                x += xInc;
                y += yInc;
            }
        }
    }
}
