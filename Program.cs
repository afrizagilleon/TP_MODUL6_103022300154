using System;
using TP_MODUL6_103022300154;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack track = new SayaMusicTrack("Bohemian Rhapsody");
        track.IncreasePlayCount(500);
        track.PrintTrackDetails();
    }
}
