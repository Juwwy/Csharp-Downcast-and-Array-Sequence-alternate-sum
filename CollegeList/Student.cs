using System;
namespace CollegeList
{
    public class Student : Person
    {
        public string Course { get; set; }

        private decimal gradePointAvg;

        public Student(string firstName, string lastName, string address, int zip, int phone, string course, decimal grade) : base(firstName, lastName, address, zip, phone)
        {
            Course = course;
            GradePointAvg = grade;
        }
        public decimal GradePointAvg
        {
            get { 
                
                if(gradePointAvg > 0.0m && gradePointAvg <= 4.0m)
                {
                    return gradePointAvg;
                }else{
                    return 0.0m;
                }
            }

            set{
                if(value > 0.0m && value <= 4.0m)
                {
                    gradePointAvg = value;


                }
                }
        }

        public override string About()
        {
            return $"{base.ToString()}\nAbout: This is a Student detail";
        }


        public override string ToString()
        {
            return $"\n{base.ToString()}\nCourse: {Course}\nGrade Point: {GradePointAvg}\n";
        }
        

        


    }
}