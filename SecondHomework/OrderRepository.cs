using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHWMuholzoev.SecondHomework
{
    abstract class OrderRepository
    {
        public int orderID { get; set; }
        public OrderRepository(int order)
        {
            orderID = order;
        }
        public virtual Order Load()
        {
            return null;
        }
    }
}
