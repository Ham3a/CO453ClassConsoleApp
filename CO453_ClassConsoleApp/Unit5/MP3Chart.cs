using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ClassConsoleApp.Unit5
{
    class MP3Chart
    {
        public const int MAXN_SONGS = 5;
        private string[] chart;
        private int[] votes = new int[MAXN_SONGS];

        public MP3Chart()
        {
            chart = new string[]
            {
                "Don't Start Now",
                "Dance Monkey",
                "Own It",
                "Blinding Lights",
                "The Box",
                "This is Real",
                "Good as Hell",
                "South of the Border",
                "Physical",
                "Post Malone"
            };
        }

        public void GetVotes()
        {

         }


        public void ShowVotes()
        {
 
        }

        public void ShowSongs()
        {
            SimpleIO.WriteTitle("UK Top 10 Chart Singles", "Task 5.2");

            int position = 0;

            foreach (string song in chart)
            {
                position++;
                Console.WriteLine("Song " + position + " is " + song);
            }
        }
    }
}
