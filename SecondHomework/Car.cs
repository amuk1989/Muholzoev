using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHWMuholzoev.SecondHomework
{
    class Car: IItem
    {
        private double _discount;
        private string _promocode;
        private double _price;
        private CarBrands _brand;
        private string _model;

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

        public void SetBrand(CarBrands brand)
        {
            _brand = brand;
        }

        public void SetModel(string model)
        {
            _model = model;
        }
    }
}
