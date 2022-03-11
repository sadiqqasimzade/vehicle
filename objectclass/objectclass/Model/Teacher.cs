using System;
using System.Collections.Generic;
using System.Text;

namespace objectclass.Model
{
    internal class Teacher:Person
    {

        public int salary;
       
        public Teacher(string name)
        {
            this.name = name;
        }
        public Teacher(string name, string surname) : this(name)
        {
            this.surname = surname;
        }
        public Teacher(int age, string name, string surname):this(name,surname)
        {
            this.age = age;
        }
        public Teacher(int age, string name, string surname,int salary) : this(age, name,surname)
        {
            this.salary = salary;
        }
    }
}
