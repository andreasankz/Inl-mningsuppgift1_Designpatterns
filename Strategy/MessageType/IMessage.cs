using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy.MessageType
{
    public interface IMessage
    {
        public void Send(string message);
    }
}
