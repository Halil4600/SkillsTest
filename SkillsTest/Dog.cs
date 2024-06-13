using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Dog
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Race { get; private set; }
        public int YearOfBirth { get; private set; }

        public Dog(int id, string name, string race, int yearOfBirth)
        {
            Id = id;
            Name = name;
            Race = race;
            YearOfBirth = yearOfBirth;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Race: {Race}, YearOfBirth: {YearOfBirth}";
        }
    }
}
