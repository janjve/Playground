using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Core.MessagePassing.Messages;

namespace Core.MessagePassing
{
    /// <summary>
    /// Not actually an Akka actor.
    /// </summary>
    public class MainActor
    {
        public static void Start()
        {
            var system = ActorSystem.Create("ABC");
            var random = new Random();

            var c1 = system.ActorOf(ClerkActor.Props(new Random(random.Next())), "C1");
            var c2 = system.ActorOf(ClerkActor.Props(new Random(random.Next())), "C2");
            var b1 = system.ActorOf<BankActor>("B1");
            var b2 = system.ActorOf<BankActor>("B2");
            var a1 = system.ActorOf(AccountActor.Props(100), "A1");
            var a2 = system.ActorOf(AccountActor.Props(100), "A2");

            c1.Tell(new StartTransferMessage(b1, a1, a2));
            c2.Tell(new StartTransferMessage(b2, a2, a1));

            Console.WriteLine("Press return to inspect...");
            Console.ReadLine();

            a1.Tell(new PrintBalanceMessage());
            a2.Tell(new PrintBalanceMessage());

            Console.WriteLine("Press return to terminate...");
            Console.ReadLine();

            system.Terminate();
        }
    }
}
