using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHWMuholzoev.SecondHomework
{
    class RepositoryOperations: OrderRepository
    {

        public void Save() 
        {
            int result = orderID;
        }
        public void Update() 
        {
            int result = orderID;
        }
        public void Delete()
        {
            int result = orderID;
        }

        public RepositoryOperations(int orderID): base(orderID)
        {

        }
    }
}
