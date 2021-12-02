using Design_Patterns_Assignment.Decorator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.TextstyleDecorators
{
    public class Important : InputDecorator, IImportant
    {
        public Important(IInput input) : base(input)
        {
            Description = "<strong> </strong>";
        }
    }
}
