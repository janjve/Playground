using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MessagePassing.Messages
{
    public class DepositMessage
    {
        public int Amount { get; private set; }
        public DepositMessage(int amount)
        {
            Amount = amount;
        }
    }
}
