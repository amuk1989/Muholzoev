using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHWMuholzoev
{
    public class Polygon : IFigure
    {
        private Line[] lines;

        public Polygon(Line[] lines)
        {
            this.lines = lines;

        }
    }
}
