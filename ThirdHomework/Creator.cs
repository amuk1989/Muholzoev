using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHWMuholzoev
{
    public class Creator
    {
        private Dot _centerDot;
        private Dot _startDot;
        private Dot _finishtDot;
        public Arc Arc(int _centerX, int _centerY, int _radius, int _startDotX, int _startDotY, int _finishDotX, int _finishDotY)
        {
            _centerDot = new Dot(_centerX, _centerY);
            _startDot = new Dot(_startDotX, _startDotY);
            _finishtDot = new Dot(_finishDotX, _finishDotY);
            return new Arc(_centerDot, _radius, _startDot, _finishtDot);
        }

        public Circle Circle(int _centerX, int _centerY,int _radius)
        {
            _centerDot = new Dot(_centerX, _centerY);
            return new Circle(_centerDot, _radius);
        }

        public Dot Dot(int _X, int _Y)
        {
            return new Dot(_X, _Y);
        }

        public Line Line(int _startDotX, int _startDotY, int _finishDotX, int _finishDotY)
        {
            _startDot = new Dot(_startDotX, _startDotY);
            _finishtDot = new Dot(_finishDotX, _finishDotY);
            return new Line(_startDot, _finishtDot);
        }
    }
}
