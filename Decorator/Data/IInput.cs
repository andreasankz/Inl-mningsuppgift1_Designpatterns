using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Data
{
    public interface IInput
    {
        public string GetUserInput { get; set; }
        public string GetDescription();
    }
}
