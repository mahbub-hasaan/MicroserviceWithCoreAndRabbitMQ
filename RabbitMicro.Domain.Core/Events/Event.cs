using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMicro.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime TimeStemp { get; protected set; }
        protected Event()
        {
            TimeStemp = DateTime.Now;
        }
    }
}
