using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_10
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public int Course { get; set; } = 1;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"ID студента: {StudentId}, Курс: {Course}");
        }

        public override string ToString()
        {
            return $"Студент: {base.ToString()}, ID студента: {StudentId}, Курс: {Course}";
        }

        public void MoveToNextCourse()
        {
            Course++;
        }
    }

}
