using Design_Patterns_Assignment.Decorator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.TextstyleDecorators
{
    public class Deleted : InputDecorator, IDeleted
    {
        public Deleted(IInput input) : base(input)
        {
            Description = "<del> </del>";
        }
    }
}
