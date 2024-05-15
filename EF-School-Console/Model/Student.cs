using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_School_Console.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }

        public Student() { }

        public Student(string name)
        {
            this.StudentName = name;
        }

        public Student(int id, string name)
        {
            this.Id = id;
            this.StudentName = name;
        }

        public void Print()
        {
            Console.WriteLine(this.StudentName);
        }
    }
}
