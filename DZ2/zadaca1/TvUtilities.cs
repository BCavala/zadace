using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class TvUtilities
    {
        public static void Sort(Episode[] episodes)
        {
            for (int i = 0; i < episodes.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (episodes[j - 1].GetAverageScore() < episodes[j].GetAverageScore())
                    {
                        Episode temp = new Episode();
                        temp = episodes[j - 1];
                        episodes[j - 1] = episodes[j];
                        episodes[j] = temp;
                    }
                }
            }
        }
            public static Episode Parse(string epInput)
        {
            string[] epParse = epInput.Split(',');
            int viewers = int.Parse(epParse[0]);
            double sumscore = double.Parse(epParse[1]);
            double maxrate = double.Parse(epParse[2]);
            int epnumbr = int.Parse(epParse[3]);
            TimeSpan duration = TimeSpan.Parse(epParse[4]);
            string movieName = epParse[5];
            Description tmpDescription = new Description(epnumbr,  duration,  movieName);
            return new Episode(viewers, sumscore, maxrate,tmpDescription);
        }
        public static double GenerateRandomScore(int minimum, int maximum)
        {
            Random random = new Random();
            double randscore = (random.NextDouble() * (maximum - minimum) + minimum);
            return randscore;
        }
        
    }
}