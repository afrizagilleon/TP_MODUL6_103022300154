using System;
using System.Diagnostics;

public class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Debug.Assert(title != null, "Title tidak boleh null!");
        Debug.Assert(title.Length <= 100, "Title maksimal 100 karakter!");

        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count <= 10_000_000, "Penambahan play count maksimal 10.000.000 per panggilan!");

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"[ERROR] Overflow terjadi: {ex.Message}");
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID     : {id}");
        Console.WriteLine($"Title  : {title}");
        Console.WriteLine($"Plays  : {playCount}");
        Console.WriteLine("-----------------------------");
    }
}
