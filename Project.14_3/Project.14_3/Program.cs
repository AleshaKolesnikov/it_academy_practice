using System;
using System.Collections.Generic;
using System.Collections;

namespace Project._14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] _names = new string[] { "John", "Bob", "Stan", "Bill", "Ashley", "Cathrine", "Margot" };

            int[] _phoneNumbers = new int[_names.Length];
            int _number = 220_00_01;
            for (int i = 0; i < _phoneNumbers.Length; i++)
            {
                _phoneNumbers[i] = _number;
                _number = _number + 1;
            }

            int[] _flatNumbers = new int[_names.Length];
            for (int i = 0; i < _flatNumbers.Length; i++)
            {
                _flatNumbers[i] = i + 1;
            }

            List<Neighbor> floorNeighbors = new List<Neighbor>();
            for (int i = 0; i < _names.Length; i++)
            {
                floorNeighbors.Add(new Neighbor() { FlatNumber = _flatNumbers[i], FullName = _names[i], PhoneNumber = _phoneNumbers[i] });
            }               //Fills the List

            Console.WriteLine("Insert the number of flat");
            int inputFlatNumber = Convert.ToInt32(Console.ReadLine());

            foreach (Neighbor neighbor1 in floorNeighbors)
            {
                if (neighbor1.FlatNumber.Equals(inputFlatNumber))
                {
                    Console.WriteLine($"The neighbor is in {floorNeighbors.IndexOf(neighbor1)+1}'s place in the List.");
                }
            }       // Finds the Neighbor

            foreach (Neighbor neighbor in floorNeighbors)
            {
                if (neighbor.FlatNumber.Equals(inputFlatNumber))
                {
                    Console.WriteLine(neighbor.FullName + "-" + neighbor.PhoneNumber);
                }
            }        // Shows name & phone number
        }
    }
}
