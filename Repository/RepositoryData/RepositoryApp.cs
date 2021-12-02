using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository.RepositoryData
{
    class RepositoryApp : IRepositoryApp
    {
        private IDataRepository DataRepository;

        public RepositoryApp(IDataRepository dataRepository)
        {
            DataRepository = dataRepository;
        }

        public void RepositoryApplication()
        {
            Console.WriteLine("********************");
            Console.WriteLine("  Repository!  ");
            Console.WriteLine("  Select an action  ");
            Console.WriteLine("********************");
            Console.WriteLine("A: Get all data");
            Console.WriteLine("S: Get Specific Customer");
            Console.WriteLine("D: Get Specific Owner");
            Console.WriteLine("F: Exit Program");

            while (true)
            {
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                        Console.WriteLine(DataRepository.GetAllData());
                        break;
                    case 's' or 'S':
                        Console.WriteLine(DataRepository.GetCustomerName("userinput"));
                        break;
                    case 'd' or 'D':
                        Console.WriteLine(DataRepository.GetAnimalOwner("userinput"));
                        break;
                    case 'f' or 'F':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            }
        }
    }
}
