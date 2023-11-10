using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_10
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Предмет: {Subject}");
        }

        public override string ToString()
        {
            return $"Преподаватель: {base.ToString()}, Предмет: {Subject}";
        }
    }
}
