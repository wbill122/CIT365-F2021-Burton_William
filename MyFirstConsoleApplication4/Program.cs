using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyFirstConsoleApplication4.GlazerApp;

namespace MyFirstConsoleApplication4
{
    class Program
    {
        static void GetUserNameAndLocation()

        {
            Person person = new Person();

            Console.Write("What is your name?  ");
            person.name = Console.ReadLine();

            Console.Write($"Hi {person.name}!  Where are you from?  ");
            person.location = Console.ReadLine();

            Console.WriteLine($"I have never been to {person.location}.  I bet it is nice. ");
            Console.Write("Press any key to continue");

            Console.ReadKey();



        }

        static void ChristmasCountdown(DateTime myDateTime)
        {
            Console.WriteLine($"Today's date is: {myDateTime:d}");
            int daysUntilChristmas = ((TimeSpan)(new DateTime(myDateTime.Year, 12, 25) - myDateTime)).Days;

            Console.WriteLine($"There are {daysUntilChristmas} day until Christmas!");
            Console.WriteLine("Press any key to continue");

            Console.ReadKey();
        }

        static void Main()
        {
            GetUserNameAndLocation();
            ChristmasCountdown(DateTime.Now);
            GlazerApp.RunExample();
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();

        }

    }
}
