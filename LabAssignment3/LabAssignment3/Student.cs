using System;

namespace LabAssignment3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string name, Instructor teacher)
        {
            Name = name;
            Teacher = teacher;
            Grade = 0;
        }

        public void SetGrade(int grade)
        {
            Grade = grade;
        }

        public string StudentGrade()
        {
            return "Student: " + Name.PadRight(8) + " Grade: " + Grade;
        }

        public void PrintGradeTeacher()
        {
            Console.WriteLine(StudentGrade() + " ".PadRight(8) + Teacher.Course());
        }
    }
}
