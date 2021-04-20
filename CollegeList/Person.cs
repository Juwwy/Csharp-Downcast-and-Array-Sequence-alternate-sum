namespace CollegeList
{
    public abstract class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public int Phone { get; set; }

        public Person(string firstName, string lastName, string address, int zip, int phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            ZipCode = zip;
            Phone = phone;
        }

        public abstract string About();

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nAddress: {Address}\nZip Code: {ZipCode}\nTelephone no.: {Phone}"; 
        }
    }
}