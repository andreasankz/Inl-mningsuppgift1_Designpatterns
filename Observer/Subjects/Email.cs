using Design_Patterns_Assignment.Observer.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.Subjects
{
    public class Email : IEmail
    {
        public List<IObserver> Observers { get; set; }
        public string EmailMessage { get; set; }


        public Email()
        {
            Observers = new();
        }

        public void NotifyObserver()
        {
            foreach(var observer in Observers)
            {
                observer.Update(EmailMessage);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
            Console.WriteLine("Registered!");
        }

        public void UnRegisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
            Console.WriteLine("Unregistered!");
        }

        public void UpdateEmail()
        {
            EmailMessage = "new notifycation";
            NotifyObserver();
        }
    }
}
