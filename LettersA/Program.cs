using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersA
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int counter = 0;
            int numOfArray = 0;
            while (numOfArray < word.Length)
            {
                if (word[numOfArray] == 'A' || word[numOfArray] == 'a')
                {
                    counter++;
                    numOfArray++;
                }
                else
                {
                    numOfArray++;
                }
            }
            Console.WriteLine($"Количество букв а = {counter}");

            
            Console.ReadKey();
        }
    }
}
