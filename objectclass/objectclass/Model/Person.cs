using System;
using System.Collections.Generic;
using System.Text;

namespace objectclass.Model
{
    internal class Person
    {
        public int age;
        public string name;
        public string surname;
        
        


        public void getData()
        {
            Console.WriteLine($"{name} {surname} yasi:{age}");
        }
        public void getFullName()
        {
            Console.WriteLine($"{name} {surname}");
        }
    }
}
