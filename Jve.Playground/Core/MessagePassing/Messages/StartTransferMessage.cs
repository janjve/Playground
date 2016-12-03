using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace Core.MessagePassing.Messages
{
    public class StartTransferMessage
    {
        public IActorRef Bank { get; private set; }
        public IActorRef From { get; private set; }
        public IActorRef To { get; private set; }

        public StartTransferMessage(IActorRef bankActor, IActorRef fromActor, IActorRef toActor)
        {
            Bank = bankActor;
            From = fromActor;
            To = toActor;
        }
    }
}
