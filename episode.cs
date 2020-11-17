using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Episode
    {
        private int viewerNum=0;
        private double sum = 0;
        private double max = 0.00;

        private Description description = new Description();

        public Episode(int v, double s, double m)
        {
            this.viewerNum = v;
            this.sum = s;
            this.max = m;
        }
        public Episode(int v, double s, double m,Description description)
        {
            this.viewerNum = v;
            this.sum = s;
            this.max = m;

            this.description.EpisodeNum = description.EpisodeNum;
            this.description.EpisodeLength = description.EpisodeLength;
            this.description.EpisodeName = description.EpisodeName;
        }
//s
        public Episode()
        {
        }



        //override ToString()
        public override string ToString()
        {
            return $"{viewerNum},{sum},{max},{description.EpisodeNum},{description.EpisodeLength},{description.EpisodeName}";
        }
        //SETTERI
        public int ViewerNum { get => viewerNum; set => viewerNum = value; }
        public double Sum { get => sum; set => sum = value; }
        public double Max { get => max; set => max = value; }
        public Description Description { get => description; set => description=value; }

        //END SETTERI
        Random generate = new Random();

        public void AddView(double randomScore)
        {
            sum += randomScore;
            viewerNum++;
            if(randomScore >max)
            {
                max = randomScore;
            }
        }
        public double GetMaxScore()
        {
            return max;
        }
        public double GetAverageScore()
        {
            double average;
            average = sum / viewerNum;
            return average;
        }
        public int GetViewerCount()
        {
            return viewerNum;
        }
        //overload operatoraaa
        public static bool operator >(Episode ep1,Episode ep2)
        {
            if(ep1.GetAverageScore()>ep2.GetAverageScore())
            return true;
            else
            {
                return false;
            }
        }
        public static bool operator <(Episode ep1,Episode ep2)
        {
            if (ep1.GetAverageScore() < ep2.GetAverageScore())
                return true;
            else
            {
                return false;
            }
        }
    }
}
