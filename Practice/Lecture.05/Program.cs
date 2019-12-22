using System;

namespace Lecture._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{System.DateTime.Now.TimeOfDay} ");
            TimeSpan time = DateTime.Now.TimeOfDay;

            if (time >= TimeSpan.FromHours(9) && time <= TimeSpan.FromHours(12))
            {
                Console.WriteLine("Good morning, guys");
            }
            else if (time > TimeSpan.FromHours(12) && time <= TimeSpan.FromHours(15))
            {
                Console.WriteLine("Good day, guys");
            }
            else if (time > TimeSpan.FromHours(15) && time <= TimeSpan.FromHours(22))
            {
                Console.WriteLine("Good evening, guys");
            }
            else 
            {
                Console.WriteLine("Nothing");
            }
        }
    }
}
