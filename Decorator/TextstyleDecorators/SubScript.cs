using Design_Patterns_Assignment.Decorator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.TextstyleDecorators
{
    public class SubScript : InputDecorator, ISubScript
    {
        public SubScript(IInput input) : base(input)
        {
            Description = "<sub> </sub>";
        }
    }
}
