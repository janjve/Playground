using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Core.MessagePassing.Messages;

namespace Core.MessagePassing
{
    public class AccountActor : ReceiveActor
    {
        public int Balance { get; set; }
        public AccountActor(int balance)
        {
            var initial = balance;
            Balance = balance;
            Receive<DepositMessage>(message => balance += message.Amount);
            Receive<PrintBalanceMessage>(_ => Console.WriteLine($"{balance} \t(diff: {balance - initial})"));
        }

        public static Props Props(int balance)
        {
            return Akka.Actor.Props.Create(() => new AccountActor(balance));
        }
    }
}
