using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHWMuholzoev
{
    public abstract class EntityBase
    {
        public long Id { get; private set; }

        public EntityBase()
        {
            Id = CalculateId();
        }

        private long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }


    }
}
