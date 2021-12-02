using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository.RepositoryData
{
    class DataRepository : IDataRepository
    {
        public string GetAllData()
        {
            return "This is all the data from db one!";
        }

        public string GetAnimalOwner(string owner)
        {
            owner = "This is the specific owner!";
            return $"{owner}";
        }

        public string GetCustomerName(string name)
        {
            name = "This is the specific name!";
            return $"{name}";
        }
    }
}
