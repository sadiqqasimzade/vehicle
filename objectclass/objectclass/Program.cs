using System;
using objectclass.Model;
namespace objectclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(21,"Sadiq","Qasimzade",3);
            Teacher teacher1 = new Teacher(99,"Qaqsimzade]", "Sadiq");

            teacher1.getFullName();
            teacher1.getData();
            student1.getFullName();
            student1.getData();
        }
    }
}
