using Design_Patterns_Assignment.Strategy.MessageType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy.Handler
{
    public class MessageHandler : IMessageHandler
    {
        public IMessage Message { get; set; }

        
        public void Send()
        {
            var message = "This is the message";
            Message.Send(message);
        }
    }
}
