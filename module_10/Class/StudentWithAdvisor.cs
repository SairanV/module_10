using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_10
{
    public class StudentWithAdvisor : Student
    {
        public Teacher Advisor { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Наставник: {Advisor.Name}");
        }

        public override string ToString()
        {
            return $"Студент с наставником: {base.ToString()}, Наставник: {Advisor.Name}";
        }
    }
}
