using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FirstHWMuholzoev
{
    public class Dot : IFigure
    {
        private int _x;
        private int _y;

        public Dot(int _x, int _y)
        {
            this._x = _x;
            this._y = _y;
        }

        public int X => _x;
        public int Y => _y;
    }
}
