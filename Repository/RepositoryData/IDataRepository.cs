namespace Design_Patterns_Assignment.Repository.RepositoryData
{
    public interface IDataRepository
    {
        public string GetAllData();

        public string GetCustomerName(string name);

        public string GetAnimalOwner(string owner);
    }
}