using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace Core.MessagePassing.Messages
{
    public class TransferMessage
    {
        public int Amount { get; private set; }
        public IActorRef From { get; private set; }
        public IActorRef To { get; private set; }

        public TransferMessage(int amount, IActorRef fromActor, IActorRef toActor)
        {
            Amount = amount;
            From = fromActor;
            To = toActor;
        }
    }
}
