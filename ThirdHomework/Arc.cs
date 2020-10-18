using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHWMuholzoev
{
    public class Arc: IFigure
    {
        private int radius;
        private Dot center;
        private Dot startDot;
        private Dot finishtDot;

        public Arc(Dot _center, int _radius, Dot _startDot, Dot _finishDot)
        {
            center = _center;
            radius = _radius;
            startDot = _startDot;
            finishtDot = _finishDot;
        }
    }
}
