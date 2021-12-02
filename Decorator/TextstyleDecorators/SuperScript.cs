using Design_Patterns_Assignment.Decorator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.TextstyleDecorators
{
    public class SuperScript : InputDecorator, ISuperScript
    {
        public SuperScript(IInput input) : base(input)
        {
            Description = "<sup> </sup>";
        }
    }
}
