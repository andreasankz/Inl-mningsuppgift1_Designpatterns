using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy.MessageType
{
    public class SMSMessage : ISMSMessage
    {
        public void Send(string message)
        {
            Console.WriteLine($"{message} sent by SMS!");
        }
    }
}
