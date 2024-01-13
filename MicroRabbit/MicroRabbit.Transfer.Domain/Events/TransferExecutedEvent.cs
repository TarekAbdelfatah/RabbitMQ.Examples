﻿using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Transfer.Domain.Events
{
    internal class TransferExecutedEvent : Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Amount { get; private set; }

        public TransferExecutedEvent(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
