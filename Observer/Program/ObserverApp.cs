using Design_Patterns_Assignment.Observer.Observers;
using Design_Patterns_Assignment.Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.Program
{
    public class ObserverApp : IObserverApp
    {
      
        public IEmail Email { get; set; }
        public IEmailWatcher EmailWatcher { get; set; }

        public ObserverApp(IEmail email, IEmailWatcher emailWatcher)
        {
            Email = email;
            EmailWatcher = emailWatcher;
        }


        public void ObserverApplication()
        {
            //// Refactor this code so that it uses the Observer Pattern
            //Console.WriteLine("Observer");
            //var email = "";
            //while (string.IsNullOrEmpty(email))
            //{
            //    email=Email.Check();
            //}            
            //Console.WriteLine(email);
            //Console.WriteLine();

            //Email.RegisterObserver(EmailWatcher);


            // Programmet startar som Unregistered
            Console.WriteLine("**********************");
            Console.WriteLine("       Observer!      ");
            Console.WriteLine("   Select an action   ");
            Console.WriteLine("**********************");
            Console.WriteLine("A: Update Email");
            Console.WriteLine("S: Subscribe/Unsubscribe");
            Console.WriteLine("D: Exit Program");


            while (true)
            {

                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                        Email.UpdateEmail();
                        break;

                    case 's' or 'S':
                        if (Email.Observers.Contains(EmailWatcher))
                        {
                            Email.UnRegisterObserver(EmailWatcher);
                            
                        }
                        else
                        {
                            Email.RegisterObserver(EmailWatcher);
                        }
                        break;

                    case 'd' or 'D':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not a valid choice!");
                        break;
                }
            }
        }
    }
}
