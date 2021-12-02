using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.Observers
{
    public interface IObserver
    {
        void Update(string email);
    }
}
