using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== UJI NORMAL ===");
        SayaMusicTrack track = new SayaMusicTrack("Bohemian Rhapsody");
        track.IncreasePlayCount(500);
        track.PrintTrackDetails();

        //Console.WriteLine("=== UJI OVERFLOW ===");
        //SayaMusicTrack track2 = new SayaMusicTrack("Stairway to Heaven");
        //for (int i = 0; i < 300; i++)
        //{
        //    track2.IncreasePlayCount(10_000_000);
        //}
        //track2.PrintTrackDetails();

        Console.WriteLine("=== UJI PRECONDITION NULL ===");
         SayaMusicTrack trackNull = new SayaMusicTrack(null);
    }
}
