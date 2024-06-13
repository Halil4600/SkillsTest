using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Member
    {
        List<Dog> dogList;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }

        public Member(int id, string name, string adress, DateTime birthDate, string phoneNumber, string email)
        {
            dogList = new List<Dog>();
            Id = id;
            Name = name;
            Adress = adress;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void RegisterDog(Dog dog)
        {
            dogList.Add(dog);
        }

        public void PrintDogs()
        {
            foreach (var dog in dogList)
            {
                Console.WriteLine(dog);
            }
        }

        public void RemoveDog(Dog dog)
        {
            dogList.Remove(dog);
        }

        public int Age()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public double MemberFee(double baseFee)
        {

            if (Age() > 65)
            {
                return 500;
            }

            if (dogList.Count > 0)
            {
                double fee = 1000;
                if (dogList.Count > 1)
                {
                    fee += (dogList.Count - 1) * 500;
                }
                return fee;
            }
            return 0;
        }

        //Den første Validerings metode
        /*public bool Validate()
        {
            if (Age() < 18)
            {
                Console.WriteLine("Medlemmet skal være minds 18 år");
                return false;
            }

            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Navn er påkrævet");
                return false;
            }
            if (string.IsNullOrEmpty(Adress)) 
            {
                Console.WriteLine("Adresse er påkrævet");
                return false;
            }

            if (string.IsNullOrEmpty(PhoneNumber))
            {
                Console.WriteLine("Telefonnummer er påkrævet");
                return false;
            }

            if (string.IsNullOrEmpty(Email))
            {
                Console.WriteLine("Email er påkrævet");
                return false;
            }

            return true;
        }*/

        public bool Validate()
        {
            if (Age() < 18)
            {
                throw new Exception("Medlemmet skal være mindst 18 år");
            }

            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Navn er påkrævet");
            }
            if (string.IsNullOrEmpty(Adress))
            {
                throw new Exception("Adresse er påkrævet");
            }

            if (string.IsNullOrEmpty(PhoneNumber))
            {
               throw new Exception("Telefonnummer er påkrævet");
            }

            if (string.IsNullOrEmpty(Email))
            {
                throw new Exception("Email er påkrævet");
            }

            return true;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Adress: {Adress}, BirthDate: {BirthDate}, PhoneNumber: {PhoneNumber}, Email: {Email}";
        }
    }
}
