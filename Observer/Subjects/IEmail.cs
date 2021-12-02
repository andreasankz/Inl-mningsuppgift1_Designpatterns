namespace Design_Patterns_Assignment.Observer.Subjects
{
    public interface IEmail : ISubject
    {
        public string EmailMessage { get; set; }

        void UpdateEmail();
    }
}