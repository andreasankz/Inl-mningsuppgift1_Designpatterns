using Design_Patterns_Assignment.Strategy.Handler;
using Design_Patterns_Assignment.Strategy.MessageType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy.StrategyApp
{
    public class StrategyApplication : IStrategyApplication
    {
        public StrategyApplication(IMessageHandler messageHandler, IMessage message, IEmailMessage email, ISMSMessage sMS, IFacebookMessage facebook)
        {
            MessageHandler = messageHandler;
            Message = message;
            Email = email;
            SMS = sMS;
            Facebook = facebook;
            messageHandler.Message = message;
        }

        public IMessageHandler MessageHandler { get; set; }
        public IMessage Message { get; set; }
        public IEmailMessage Email { get; set; }
        public ISMSMessage SMS { get; set; }
        public IFacebookMessage Facebook { get; set; }


        public void StrategyProgram() 
        {
            Console.WriteLine("Welcome To the MessageService!");
            Console.WriteLine("*********************");
            Console.WriteLine("  Select a service  ");
            Console.WriteLine("*********************");
            Console.WriteLine("A: Use Facebook service");
            Console.WriteLine("W: Use SMS service");
            Console.WriteLine("D: Use Email service");
            Console.WriteLine("R: Send message");
            Console.WriteLine("E: Exit Program");

            while (true)
            {
                var userInput = Console.ReadKey(true).KeyChar;
                

                switch (userInput)
                {
                    case 'a' or 'A':
                        ClearLastLine();
                        Console.WriteLine("Using Facebook Service!");
                        MessageHandler.Message = Facebook;
                        break;

                    case 'w' or 'W':
                        ClearLastLine();
                        Console.WriteLine("Using SMS Service!");
                        MessageHandler.Message = SMS;
                        break;

                    case 'd' or 'D':
                        ClearLastLine();
                        Console.WriteLine("Using Email Service!");
                        MessageHandler.Message = Email;
                        break;

                    case 'r' or 'R':
                        ClearLastLine();
                        MessageHandler.Send();
                        break;

                    case 'e' or 'E':
                        Environment.Exit(0);
                        break;

                    default:
                        ClearLastLine();
                        Console.WriteLine("Not a valid choice!");
                        break;
                }
            }
        }

        public static void ClearLastLine()
        {
            Console.SetCursorPosition(1, 9);
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }
    }
}
