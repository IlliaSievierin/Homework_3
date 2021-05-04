using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_Homework_3
{
    class StudentGrades
    {
        internal Student Student { get; private set; }
        internal List<int> Grades { get; private set; }

        public StudentGrades(Student student)
        {
            Student = new Student(student.Name, student.Surname, student.Group);
            Grades  = new List<int>();
        }

        public void AddGrades(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                Grades.Add(grade);
                Console.WriteLine("Оценка успешно добавлена.");
            }
            else
            {
                Console.WriteLine("Недопустимое значение!");
            }
        }
    }
}
