using Design_Patterns_Assignment.Decorator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.TextstyleDecorators
{
    public class Smaller : InputDecorator, ISmaller
    {
        public Smaller(IInput input) : base(input)
        {
            Description = "<small> </small>";
        }
    }
}
