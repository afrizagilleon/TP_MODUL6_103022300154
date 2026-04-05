using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL6_103022300154
{
    internal class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Random rnd = new Random();
            this.id = rnd.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID     : {id}");
            Console.WriteLine($"Title  : {title}");
            Console.WriteLine($"Plays  : {playCount}");
            Console.WriteLine("-----------------------------");
        }
    }

}
