using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_Homework_3
{
    class Student
    {
        public Student(string name, string surname, string group)
        {
            Name    = name;
            Surname = surname;
            Group   = group;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Group { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Student student = (Student)obj;
                return (Name == student.Name) && (Surname == student.Surname) && (Group == student.Group);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
