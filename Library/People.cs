namespace Library
{
    public class People
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Birthday { get; set; }
        public People(string firstName, string lastName, int day, int month, int year) 
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = day.ToString() + "." + month.ToString() + "." + year.ToString();
        }
        public virtual string ShowInfo()
        {            
            return new string($"People\n\tFirst Name: {FirstName}\n\tLast Name: {LastName}\n\tBirthday: {Birthday}\n");
        }
    }
}
