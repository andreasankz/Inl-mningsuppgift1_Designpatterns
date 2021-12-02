using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Data
{
    public abstract class InputDecorator : IInput
    {
        public IInput Input { get; set; }
        public string Description { get; set; }
        public string GetUserInput { get; set; }

        public InputDecorator(IInput input)
        {
            Input = input;
        }

        public string GetDescription()
        {
            string[] items = Description.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var firstItem = items[0];
            var remainingItems = string.Join(" ", items.Skip(1).ToList());
            return $"{firstItem}{Input.GetDescription()}{remainingItems}";

            //return Input.GetDescription() + ", " + Description;
        }
    }
}
