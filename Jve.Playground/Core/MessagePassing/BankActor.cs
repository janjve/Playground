using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Core.MessagePassing.Messages;

namespace Core.MessagePassing
{
    public class BankActor : ReceiveActor
    {
        public BankActor()
        {
            Receive<TransferMessage>(message =>
            {
                message.From.Tell(new DepositMessage(-1 * message.Amount));
                message.To.Tell(new DepositMessage(message.Amount));
            });
        }
    }
}
