using Design_Patterns_Assignment.Decorator.Data;
using Design_Patterns_Assignment.Decorator.TextstyleDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.DecoratorApp
{
    public class DecoratorApplication : IDecoratorApplication
    {
        public IInput Input { get; set; }

        public DecoratorApplication(IUserInput input)
        {
            Input = input;
        }
        public void DecoratorProgram()
        {
            

            
            Console.WriteLine("**********************");
            Console.WriteLine("  Decorate your text! ");
            Console.WriteLine("**********************");
            Console.WriteLine("Please enter the text:");
            Input.GetUserInput = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Choose your textstyle!");
            Console.WriteLine("A: Add Bold");
            Console.WriteLine("B: Add Deleted");
            Console.WriteLine("C: Add Emphasized");
            Console.WriteLine("D: Add Important");
            Console.WriteLine("E: Add Inserted");
            Console.WriteLine("F: Add Italic");
            Console.WriteLine("G: Add Marked");
            Console.WriteLine("H: Add Smaller");
            Console.WriteLine("I: Add Subscript");
            Console.WriteLine("J: Add Superscript");
            Console.WriteLine("R: Finished");
            Console.WriteLine("Q: Exit");


            while (true)
            {

                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                        ClearLastLine();
                        Console.WriteLine("Adding Bold");
                        Input = new Bold(Input);
                        break;

                    case 'b' or 'B':
                        ClearLastLine();
                        Console.WriteLine("Adding Deleted");
                        Input = new Deleted(Input);
                        break;

                    case 'c' or 'C':
                        ClearLastLine();
                        Console.WriteLine("Adding Emphasized");
                        Input = new Emphasized(Input);
                        break;

                    case 'd' or 'D':
                        ClearLastLine();
                        Console.WriteLine("Adding Important");
                        Input = new Important(Input);
                        break;

                    case 'e' or 'E':
                        ClearLastLine();
                        Console.WriteLine("Adding Inserted");
                        Input = new Inserted(Input);
                        break;

                    case 'f' or 'F':
                        ClearLastLine();
                        Console.WriteLine("Adding Italic");
                        Input = new Italic(Input);
                        break;

                    case 'g' or 'G':
                        ClearLastLine();
                        Console.WriteLine("Adding Marked");
                        Input = new Marked(Input);
                        break;

                    case 'h' or 'H':
                        ClearLastLine();
                        Console.WriteLine("Adding Smaller");
                        Input = new Smaller(Input);
                        break;

                    case 'i' or 'I':
                        ClearLastLine();
                        Console.WriteLine("Adding Subscript");
                        Input = new SubScript(Input);
                        break;

                    case 'j' or 'J':
                        ClearLastLine();
                        Console.WriteLine("Adding Superscript");
                        Input = new SuperScript(Input);
                        break;

                    case 'r' or 'R':
                        ClearLastLine();
                        Console.WriteLine($"The result is {Input.GetDescription()}");
                        //Input = newInput;
                        break;

                    case 'q' or 'Q':
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Not a valid choice!");
                        break;
                }
            }
        }

        public static void ClearLastLine()
        {
            Console.SetCursorPosition(1, 20);
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
            
        }
    }
}
