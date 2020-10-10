using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHWMuholzoev
{
    public static class IdHelper
    {
        public static long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
}
