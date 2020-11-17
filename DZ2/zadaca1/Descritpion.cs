using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Description
    {
        private int epNumbr;
        private string movieName;
        private TimeSpan duration;
        public Description(int epNumbr, TimeSpan duration, string movieName)
        {
            this.epNumbr = epNumbr;
            this.duration = duration;
            this.movieName = movieName;
        }

        public int EpNumbr
        {
            get { return epNumbr; }
            set { epNumbr = value; }
        }
        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }
        public TimeSpan Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
