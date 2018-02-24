using System;

public class Song
{
    private string artistName;
    private string songName;
    private int minutes;
    private int seconds;

    public Song(string artistName, string songName, int minutes, int seconds)
    {
        ArtistName = artistName;
        SongName = songName;
        Minutes = minutes;
        Seconds = seconds;
    }

    private string ArtistName
    {
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            artistName = value;
        }

    }

    private string SongName
    {
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }
            this.songName = value;
        }
    }

    public int Minutes
    {
        get => minutes;
        private set
        {
            if (value < 0 || value > 14)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }
            minutes = value;
        }
    }

    public int Seconds
    {
        get => seconds;
        private set
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }
            seconds = value;
        }
    }
}