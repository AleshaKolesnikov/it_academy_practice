using System;

namespace Project._14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();

            Console.WriteLine("Input Song's title:");
            song.Name = Console.ReadLine();

            Console.WriteLine("Input Duration:");
            song.Duration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Year:");
            song.Year = Convert.ToInt32(Console.ReadLine());

            song.GetSongData(song);
        }
    }
}
