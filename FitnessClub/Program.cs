using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Domain;
using FitnessClub.Factories;
namespace FitnessClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($">>> Welcome to Fitness Club <<<\n");
            Console.WriteLine($"> Enter the membership type you would like to create <\n");
            Console.WriteLine($"> G - gym");
            Console.WriteLine($"> P - gym + poo");
            Console.WriteLine($"> T - personal training");

            string membershipType = Console.ReadLine();
            MemberyshipFactory factory = GetFactory(membershipType);
            IMembership membership=factory.GetMembership();
            Console.WriteLine("\n  membership you've just create");
            Console.WriteLine($"\t name: {membership.Name}\n"+
                $"\t description: {membership.Description}\n"+
                $"\t price: {membership.GetPrice()} рублей\n"); 

        }
        private static MemberyshipFactory GetFactory(string membershipType)
        {
            membershipType = membershipType.ToLower();
            switch (membershipType)
            {
                case "g": return new GymMembershipFactory(100, "Basic membership");
                case "p": return new GymPlusPoolMembershipFactory(250, "Best price");
                case "t": return new PersonalTrainingMembershipFactory(500, "Personal training");
                default: return null;
                   
            }
        }
    }
}
