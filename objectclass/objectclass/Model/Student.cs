using System;
using System.Collections.Generic;
using System.Text;

namespace objectclass.Model
{
    internal class Student:Person
    {
   
        public int course;

        
        public Student(string name)
        {
            this.name = name;
        }
        public Student( string name, string surname):this(name)
        {
            this.surname = surname;
        }
        public Student(int age, string name, string surname):this(name,surname)
        {
            this.age = age;
        }
        public Student(int age, string name, string surname, int course):this(age,name,surname)
        {
            this.course = course;
        }

    }
}
