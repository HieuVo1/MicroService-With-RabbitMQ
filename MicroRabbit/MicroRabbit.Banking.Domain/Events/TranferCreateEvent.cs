using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TranferCreateEvent : Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Ammount { get; private set; }

        public TranferCreateEvent(int from, int to, decimal ammount)
        {
            From = from;
            To = to;
            Ammount = ammount;
        }
    }
}
