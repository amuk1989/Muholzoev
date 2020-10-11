using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHWMuholzoev.SecondHomework
{
    class Book: IItem
    {
        private double _discount;
        private string _promocode;
        private double _price;
        private string _author;
        private string _name;

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

        public void SetAuthor(string author)
        {
            _author = author;
        }

        public void SetName(string name)
        {
            _name = name;
        }
    }
}
