using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHWMuholzoev.SecondHomework
{
    interface IItem
    {
        void SetDiscount(double discount);
        void SetPromocode(string promocode);
        void SetPrice(double price);
    }
}
