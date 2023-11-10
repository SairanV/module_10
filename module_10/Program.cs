using module_10.Class;
using module_10.Interface;
using System;
using System.Collections.Generic;

namespace module_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов Person
            Person person1 = new Person { Name = "Джон", Age = 30 };
            Student student1 = new Student { Name = "Алиса", Age = 20, StudentId = 101 };
            Teacher teacher1 = new Teacher { Name = "Профессор Смит", Age = 45, Subject = "Математика" };

            student1.Teachers.Add(teacher1);
            teacher1.Students.Add(student1);

            Console.WriteLine(person1.ToString());
            Console.WriteLine(student1.ToString());
            Console.WriteLine(teacher1.ToString());

            // Использование интерфейса ICalculatable
            ICalculatable simpleCalculator = new SimpleCalculator();
            ICalculatable advancedCalculator = new AdvancedCalculator();

            Console.WriteLine("Простой калькулятор:");
            Console.WriteLine($"Сложение: {simpleCalculator.Add(5, 3)}");
            Console.WriteLine($"Вычитание: {simpleCalculator.Subtract(5, 3)}");
            Console.WriteLine($"Умножение: {simpleCalculator.Multiply(5, 3)}");
            Console.WriteLine($"Деление: {simpleCalculator.Divide(6, 2)}");

            Console.WriteLine("\nРасширенный калькулятор:");
            Console.WriteLine($"Возведение в степень: {advancedCalculator.Power(2, 3)}");
            Console.WriteLine($"Квадратный корень: {advancedCalculator.SquareRoot(25)}");

            // Использование интерфейса IStorable
            IStorable storableCalculator = new AdvancedCalculator();
            storableCalculator.SaveState("calculator_state.txt");
            storableCalculator.LoadState("calculator_state.txt");

            // Проверка типов с использованием is, as, GetType
            Person[] people = { person1, student1, teacher1 };

            int personCount = 0, studentCount = 0, teacherCount = 0;

            foreach (var person in people)
            {
                if (person is Student)
                    studentCount++;
                else if (person is Teacher)
                    teacherCount++;
                else if (person is Person)
                    personCount++;
            }

            Console.WriteLine($"\nКоличество людей: {personCount}, Количество студентов: {studentCount}, Количество преподавателей: {teacherCount}");

            // Перевести всех студентов на следующий курс
            foreach (var person in people)
            {
                if (person is Student student)
                {
                    Console.WriteLine($"Перевод студента {student.Name} на следующий курс.");
                    student.MoveToNextCourse();
                }
            }
        }
    }
}
