using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.Observers
{
    public class EmailWatcher : IEmailWatcher
    {
        public void Update(string email)
        {
            Console.WriteLine(email);
        }
    }
}
