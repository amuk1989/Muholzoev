using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FirstHWMuholzoev.SecondHomework
{
    class Clothes: IItem
    {
        private double _discount; 
        private string _promocode;
        private double _price;
        private Color _color;
        private Size _size;
        public void SetDiscount(double discount)
        {
            _discount = discount;
        }
        public void SetPromocode(string promocode)
        {
            _promocode = promocode;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public void SetColor(Color color)
        {
            _color = color;
        }

        public void SetSize(Size size)
        {
            _size = size;
        }
    }
}
