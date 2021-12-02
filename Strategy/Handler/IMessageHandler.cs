using Design_Patterns_Assignment.Strategy.MessageType;

namespace Design_Patterns_Assignment.Strategy.Handler
{
    public interface IMessageHandler
    {
        IMessage Message { get; set; }

        public void Send();
    }
}