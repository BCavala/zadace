using System;


namespace ClassLibrary
{
    public class Episode
    {
        private Description description;
        private int viewers = 0;
        private double maxrate = 0;
        private double sumscore = 0;


        public Episode() { }
        public Episode(int viewers, double sumscore, double maxrate, Description description)
        {
            this.viewers = viewers;
            this.maxrate = maxrate;
            this.sumscore = sumscore;
            this.description = description;
        }

       
        public void AddView(double a)
        {
            if (a > maxrate)
            {
                maxrate = a;
                viewers++;
            }
        }
        public static double GenerateRandomScore(int minimum, int maximum)
        {
            Random random = new Random();
            double randscore = (random.NextDouble() * (maximum - minimum)) + minimum;
            return randscore;
        }
        public double GetAverageScore()
        {
            return sumscore;
        }
        public double GetMaxScore()
        {
            return maxrate;
        }
        public double GetViewerCount()
        {
            return viewers;
        }
        public override string ToString()
        {
            return $"{viewers},{Math.Round(sumscore,2)},{maxrate},{description.EpNumbr},{description.Duration},{description.MovieName}";
        }
    }
}