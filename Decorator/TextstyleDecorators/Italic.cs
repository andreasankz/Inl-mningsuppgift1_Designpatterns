using Design_Patterns_Assignment.Decorator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.TextstyleDecorators
{
    public class Italic : InputDecorator, IItalic
    {
        public Italic(IInput input) : base(input)
        {
            Description = "<i> </i>";
        }
    }
}
