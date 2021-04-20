namespace CollegeList
{
    public class Faculty : CollegeEmployee
    {
        private bool tenured;

        public Faculty(string firstName, string lastName, string address, int zip, int phone, int ssn, decimal salary, bool tenured) : base(firstName, lastName, address, zip, phone, ssn, salary)
        {
            Tenured = tenured;
        }

        public bool Tenured
        {
            get {return tenured;}
            set {
                if(value == true || value == false)
                {
                    tenured = value;
                }
            }
        }

        public override string About()
        {
            return $"{base.ToString()}\nAbout: This is a Faculty member definition detail";
        }

        public override string ToString()
        {
            return $"\n{base.ToString()}\nTenured member: {Tenured}\n";
        } 
    }
}