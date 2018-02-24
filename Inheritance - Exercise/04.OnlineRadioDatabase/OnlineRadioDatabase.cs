using System;
using System.Collections.Generic;
using System.Linq;

public class OnlineRadioDatabase
{
    static void Main()
    {
        var songsCount = int.Parse(Console.ReadLine());
        var songs = new List<Song>();
        for (int index = 0; index < songsCount; index++)
        {
            try
            {
                var songTokens = Console.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                var artistName = songTokens[0];
                var songName = songTokens[1];
                var time = new int[2];
                try
                {
                    time = songTokens[2]
                        .Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                }
                catch
                {
                    throw new ArgumentException("Invalid song length.");
                }
                var minutes = time[0];
                var seconds = time[1];
                var song = new Song(artistName, songName, minutes, seconds);
                songs.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }


        var countOfSongs = songs.Count;
        Console.WriteLine($"Songs added: {countOfSongs}");
        var playlistSeconds = 0;
        var playlistMinutes = 0;
        var playlistHours = 0;
        if (countOfSongs > 0)
        {
            var totalMinutes = songs.Sum(s => s.Minutes);
            var totalSeconds = songs.Sum(s => s.Seconds);
            playlistSeconds = totalSeconds % 60;
            playlistMinutes = (totalMinutes + totalSeconds / 60) % 60;
            playlistHours = (totalMinutes + totalSeconds / 60) / 60;
        }

        Console.WriteLine($"Playlist length: {playlistHours}h {playlistMinutes}m {playlistSeconds}s");
    }
}