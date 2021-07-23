using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformLesson3
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static int static_id = 100;
        public Car()
        {
            Id = static_id++;
        }

        public override string ToString()
        {
            return $"{Id}  -  {Name}";
        }
    }
}
