namespace Sahlgrenska.app.classes
{
    public class Patient
    {
        public int Id { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Patient(int id, int socialSecurityNumber, string firstName, string lastName)
        {
            Id = id;
            SocialSecurityNumber = socialSecurityNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}