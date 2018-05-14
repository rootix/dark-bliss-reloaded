namespace BusinessLayer
{
    class Person
    {
        public Person(string firstName, string lastName): this(firstName, lastName, DateTime.Now)
        {
        }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = birthDate;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public DateTime DateOfBirth { get; set; }

        public string GetFullName() {
            return $"{FirstName} {LastName}";
        }
    }
}