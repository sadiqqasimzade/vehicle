using System;
using System.Collections.Generic;
using System.Text;

namespace objectclass.Model
{
    internal class Student:Person
    {
   
        public int course;

        public Student(int age,  string name, string surname,int course)
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
            this.course = course;
        }
        public Student( string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Student(int age, string name, string surname)
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
        }

    }
}
