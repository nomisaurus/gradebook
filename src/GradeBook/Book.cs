using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        string name;
        List<double> grades;

        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}