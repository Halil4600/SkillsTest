using System.Security.Principal;

namespace SkillsTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(1, "Rami", "Rottweiler", 2011);
            Dog dog2 = new Dog(2, "Ismail", "Dobermann", 2012);
            Dog dog3 = new Dog(3, "Oliver", "Pitbull", 2014);
            Dog dog4 = new Dog(4, "Sture", "Labrador", 2015);
            Dog dog5 = new Dog(5, "Lasse", "Golden Retriever", 2016);

            Console.WriteLine("Hunde i systemet:");
            Console.WriteLine(dog1);
            Console.WriteLine(dog2);
            Console.WriteLine(dog3);
            Console.WriteLine(dog4);
            Console.WriteLine(dog5);

            Member member1 = new Member(1, "Halil", "Parkvej 1", new DateTime(2003, 5, 5), "22334455", "Halil@gmail.com");
            Member member2 = new Member(2, "Daniyal", "Parkvej 2", new DateTime(1993, 1, 1), "33445566", "Daniyal@gmail.com");
            Member member3 = new Member(3, "Andre", "Parkvej 3", new DateTime(1949, 2, 2), "44556677", "Andre@gmail.com");
            Member member4 = new Member(4, "Jonas", "Parkvej 4", new DateTime(1995, 10, 10), "55667788", "Jonas@gmail.com");

            Console.WriteLine("Medlemmer:");
            Console.WriteLine(member1);
            Console.WriteLine(member2);
            Console.WriteLine(member3);
            Console.WriteLine(member4);

            member1.RegisterDog(dog1);
            member2.RegisterDog(dog2);
            member3.RegisterDog(dog3);
            member4.RegisterDog(dog4);
            member4.RegisterDog(dog5);
            Console.WriteLine("Hund tilhørende medlem 1:");
            member1.PrintDogs();
            Console.WriteLine("Hund tilhørende medlem 2:");
            member2.PrintDogs();
            Console.WriteLine("Hund tilhørende medlem 3:");
            member3.PrintDogs();
            Console.WriteLine("Hunde tilhørende medlem 4:");
            member4.PrintDogs();

            member1.RemoveDog(dog1);
            Console.WriteLine("Hund tilhørende medlem 1 fjernes:");
            member1.PrintDogs();

            Console.WriteLine("Alder på medlem 1:");
            Console.WriteLine(member1.Age());
            Console.WriteLine("Alder på medlem 2:");
            Console.WriteLine(member2.Age());
            Console.WriteLine("Alder på medlem 3:");
            Console.WriteLine(member3.Age());
            Console.WriteLine("Alder på medlem 4:");
            Console.WriteLine(member4.Age());

            Console.WriteLine("Pris for medlem 1");
            double fee = member1.MemberFee(1000);
            Console.WriteLine($"Medlemskontingent: {fee} DKK");
            Console.WriteLine("Pris for medlem 2");
            fee = member2.MemberFee(1000);
            Console.WriteLine($"Medlemskontingent: {fee} DKK");
            Console.WriteLine("Pris for medlem 3");
            fee = member3.MemberFee(1000);
            Console.WriteLine($"Medlemskontingent: {fee} DKK");
            Console.WriteLine("Pris for medlem 4");
            fee = member4.MemberFee(1000);
            Console.WriteLine($"Medlemskontingent: {fee} DKK");

            // Test af den første validerings metode
            /*Console.WriteLine("Validering af medlem 6:");
            Member member6 = new Member(6, "Peter", "Parkvej 6", new DateTime(), "55667788", "");
            bool isValid = member6.Validate();
            Console.WriteLine($"Er medlem 6 gyldigt? {isValid}"); */
            
            Console.WriteLine("Validering af medlem 6:");
            try
            {
                Member member6 = new Member(6, "Peter", "Parkvej 6", new DateTime(), "55667788", "");
                bool isValid = member6.Validate();
                Console.WriteLine("Medlemmet er gyldigt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Valideringsfejl: {ex.Message}");
            }

            Console.WriteLine("Beregning af pris af leje:");
            VenueRental rental = new VenueRental(new DateTime(2023, 5, 18));
            DateTime weekdayDate = new DateTime(2023, 5, 18);
            rental.CalculateRentalPrice(weekdayDate, 0, 0);

            DateTime weekendDate = new DateTime(2023, 5, 20);
            rental.CalculateRentalPrice(weekendDate, 0, 0);
        }
    }
}
