using System;

namespace CollegeList
{
    class Program
    {
        static void Main(string[] args)
        {
            CollegeEmployee emp1 = new CollegeEmployee("Davies", "Holter", "23, houston, Texas, USA", 75247, 1604326661,5442,75000);
            CollegeEmployee emp2 = new CollegeEmployee("Mitchel", "Paul", "43B, Lekki, Lagos, Nigeria", 75247, 1604326661,5442,75000);

            Faculty member = new Faculty("Micheal", "Adeponle","17, Kajola street, ibadan, oyo", 65211, 0907543729, 44432, 23000, true);
            Faculty member2 = new Faculty("O'neal", "Matthew","Tanke, ilorin", 4321, 0802316432, 5433, 4000, false);

            Student student = new Student("Kolapo", "Abiona", "Lagos hood town, epe, lagos", 2319, 0902874171, "Law", 3.5m);
            Student student2 = new Student("Badiru", "Habeeb", "Kano way, katangoa, Kano", 2542, 090225432, "Agric", 3.8m);

            Person[] list = new Person[]{
                emp1, emp2, member, member2, student, student2
            };

            foreach (var person in list)
            {
                if(person is Student)
                {
                    var studt = (Student)person;
                    studt.Course = "Computer Science";
                    Console.WriteLine(person);
                }else{
                    Console.WriteLine(person);
                }
            }

        }
    }
}
