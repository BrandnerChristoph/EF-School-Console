using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_School_Console.Model
{
    [PrimaryKey(nameof(IdNo))]
    public class Grade
    {
        /*
         * Schulklasse
         */
        public string IdNo { get; set; }

        public string Name { get; set; }

        public IList<Student>? Students { get; set; }


        public Grade() {
            this.Students = new List<Student>();
        }
        public Grade(string name) : this() {
            this.IdNo = name;
            this.Name = name;
        }
    }
}
