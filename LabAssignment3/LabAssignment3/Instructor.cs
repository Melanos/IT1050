using System;

namespace LabAssignment3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string name, string coursename)
        {
            Name = name;
            CourseName = coursename;
        }
        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public string Course()
        {
            return "Instructor: " + Name.PadRight(8) + " Course: " + CourseName;
        }

        public void PrintCourse()
        {
            Console.WriteLine(Course());
        }
    }
}
