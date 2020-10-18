using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHWMuholzoev
{
    public class Line : IFigure
    {
        private Dot firstDot;
        private Dot secondDot;

        public Line(Dot firstDot, Dot secondDot)
        {
            this.firstDot = firstDot;
            this.secondDot = secondDot;
        }
    }
}
