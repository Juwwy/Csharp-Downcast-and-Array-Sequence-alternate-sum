using System;
namespace CollegeList
{
    public class CollegeEmployee : Person
    {
        public int SocialSecurityNumber { get; set; }
        private decimal salary;

        public CollegeEmployee(string firstName, string lastName, string address, int zip, int phone, int ssn, decimal salary) : base(firstName, lastName, address, zip, phone)
        {
            SocialSecurityNumber = ssn;
            Salary = salary;
        }

        public decimal Salary
        {
            get { return salary; }
            private set {
                if(value > 0.0M)
                {
                    salary = value;
                }else {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public override string About()
        {
            return $"{base.ToString()}\nAbout: This is an Employee detail";
        }

        public override string ToString()
        {
            return $"\n{base.ToString()}\nSocial Security Number: {SocialSecurityNumber}\nSalary: {Salary}\n";
        }
    }
}