using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Util.Internal;
using Core.MessagePassing.Messages;

namespace Core.MessagePassing
{
    public class ClerkActor : ReceiveActor
    {
        private readonly Random _random;
        public ClerkActor(Random random)
        {
            _random = random;
            Receive<StartTransferMessage>(message =>
            {
                NTransfers(100, message.Bank, message.From, message.To);
            });
        }

        private void NTransfers(int n, IActorRef bankActor, IActorRef fromActor, IActorRef toActor)
        {
            Enumerable.Repeat(0, n).ForEach(_ => bankActor.Tell(new TransferMessage(_random.Next(100), fromActor, toActor)));
        }

        public static Props Props(Random random)
        {
            return Akka.Actor.Props.Create(() => new ClerkActor(random));
        }
    }
}
