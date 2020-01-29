using System;
using System.Collections.Generic;
using System.Text;

namespace Project._14_2
{
    class Song
    {
        public string Name { get; set; }
        public int Duration { get;set; }
        public string Singer { get; set; }
        public int Year { get; set; }
        public object GetSongData(Song song)
        {
            var data = new
            {
                Title = Name,
                Minutes = Duration,
                AlbumYear = Year
            };

            Console.WriteLine($"{data.Title}-{data.Minutes}min\nYear - {data.AlbumYear} ");

            return data;
        }
    }
}
