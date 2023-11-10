using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_10
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
        }

        public override string ToString()
        {
            return $"Персона: {Name}, Возраст: {Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Person other = (Person)obj;
            return Name == other.Name && Age == other.Age;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + (Name != null ? Name.GetHashCode() : 0);
            hash = hash * 23 + Age.GetHashCode();
            return hash;
        }

        public static bool operator ==(Person person1, Person person2)
        {
            return person1.Equals(person2);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}
