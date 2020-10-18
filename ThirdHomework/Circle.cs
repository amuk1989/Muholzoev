using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FirstHWMuholzoev
{
    public class Circle : IFigure
    {
        private Arc arc;
        private Dot dot;

        public Circle(Dot center, int radius)
        {
            dot = new Dot(center.X + radius, center.Y);
            arc = new Arc(center, radius, dot, dot);
        }
    }
}
