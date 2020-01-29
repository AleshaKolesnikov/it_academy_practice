using System;
using System.Collections.Generic;
using System.Text;

namespace Project._14_2
{
    class Song
    {
        public string SongName { get; set; }
        public int SongMinutes { get;set; }
        public string SongAuthor { get; set; }
        public int SongAlbumYear { get; set; }
        public object GetSongData(Song song)
        {
            var songs = new
            {
            SongName = song.SongName,
            SongMinutes = song.SongMinutes,
            SongAuthor = song.SongAuthor,
            SongAlbumYear = song.SongAlbumYear
        };
            return songs;
        }
    }
}
