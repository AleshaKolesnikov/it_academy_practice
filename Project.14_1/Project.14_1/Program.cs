using System;

namespace Project._14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello World";

            //using FIRST option
            Console.WriteLine(firstString.AddEllipsis("anything"));

            //using SECOND option
            Console.WriteLine(firstString.StringChange(123123));

            //using THIRD option
            Console.WriteLine(firstString.Changing("..."));
        }
    }
}
