using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Data
{
    public class UserInput : IUserInput
    {
        public string Description { get; set; }

        public string GetUserInput { get; set; }
        public UserInput()
        {
            Description = GetUserInput;
        }

        
        public string GetDescription()
        {
            return GetUserInput;
        }
    }
}
