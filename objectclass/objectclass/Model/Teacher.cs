using System;
using System.Collections.Generic;
using System.Text;

namespace objectclass.Model
{
    internal class Teacher:Person
    {

        public int salary;
        public Teacher(int age, string name, string surname,int salary)
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
            this.salary = salary;
        }
        public Teacher( string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Teacher(int age, string name, string surname)
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
        }
    }
}
