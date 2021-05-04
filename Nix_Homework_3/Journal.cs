using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_Homework_3
{
    class Journal
    {
        List<StudentGrades> studentGrades;
        public Journal()
        {
            studentGrades = new List<StudentGrades>();
        }
        public void AddStudent(Student student)
        {
            studentGrades.Add(new StudentGrades(student));
        }
        public void AddGradeToStudent(Student student, int grade)
        {
            studentGrades
                .Where(s => s.Student.Equals(student))
                .FirstOrDefault()
                ?.AddGrades(grade);
        }

        public void AvgGradeByStudent(Student student)
        {
            var avgGrade = studentGrades
                .Where(s => s.Student.Equals(student))
                .Select(s => s.Grades)
                .FirstOrDefault()
                .Average();

            Console.WriteLine($"Средняя оценка у студента {student.Surname} {student.Name}, группы {student.Group} - {avgGrade}");
        }

        public void BadStudent()
        {
            var badStudent = studentGrades
                .Where(s => s.Grades
                                .Where(g => g < 60)
                                .Count() > 0)
                .Select(s => s.Student);
            Console.WriteLine("Студенты которые не успевают: ");
            foreach (Student student in badStudent)
            {
                Console.WriteLine($"Студент {student.Surname} {student.Name} из группы {student.Group}");
            }
        }

        public void StudentsAndAvgGrade()
        {
            foreach (StudentGrades studentG in studentGrades)
            {
                Console.WriteLine($"Средняя оценка у студента { studentG.Student.Surname} { studentG.Student.Name}, группы { studentG.Student.Group} - {studentG.Grades?.Average()} ");
            }
        }
    }
}
