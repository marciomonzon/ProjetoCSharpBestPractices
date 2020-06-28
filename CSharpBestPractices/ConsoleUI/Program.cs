using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Capturing a number os users of people's names
// Loop through and say hi to them.
namespace ConsoleUI
{
    class Program
    {
        private static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            // 4º passo
            SetUpData();
            LoopThrougData();
        }

        private static void SetUpData()
        {
            people.Add(new Person { FirstName = "Marcio", LastName = "Monzon" });
            people.Add(new Person { FirstName = "Jose", LastName = "Monzon" });
            people.Add(new Person { FirstName = "Garcia", LastName = "Monzon" });
            people.Add(new Person { FirstName = "Tio", LastName = "Monzon" });
        }

        private static void LoopThrougData()
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Hello {person.FirstName } { person.LastName }");
            }

            Console.ReadKey();
        }
    }
}
