using System;

namespace Project._14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song();
            var song = new
            {
                Title = "Numb",
                Minutes = 4,
                AlbumYear = new DateTime().AddYears(2002)
            };
        }
    }
}
