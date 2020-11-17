using System;
using System.Text;
using ClassLibrary1;

namespace ClassLibrary
{
    public class TvUtilities
    {
        Random rand = new Random();
        double GenerateRandomScore()
        {
            double number;
            number = rand.NextDouble() * 10.00;
            return number;
        }

        public static Episode Parse(string field)
        {
            Episode epizoda = new Episode();
            Description opis = new Description();

            string[] parts = field.Split(',');

            epizoda.ViewerNum = Convert.ToInt32(parts[0]);

            // stack overflow rjesenje start
            // change the current culture to a culture that uses the dot as the decimal separator
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            //stack overflow rjesenje end

            epizoda.Sum=double.Parse(parts[1]);
            epizoda.Max = double.Parse(parts[2]);

            opis.EpisodeNum = Convert.ToInt32(parts[3]);
            opis.EpisodeLength = TimeSpan.Parse(parts[4]);
            opis.EpisodeName = parts[5];
            epizoda.Description = opis;

            return epizoda;
        }
        public static void Sort(Episode[] episodes)
        {
            int i, j;
            for(i=0;i<episodes.Length-1;i++)
            {
                for(j=0;j<episodes.Length-1-i;j++)
                {
                    if(episodes[j]<episodes[j+1])
                    {
                        Episode temp = new Episode();
                        temp = episodes[j];
                        episodes[j] = episodes[j + 1];
                        episodes[j + 1] = temp;

                    }
                }
            }
        }
    }
    public class Description
    {
        private int episodeNum;
        private TimeSpan episodeLength;
        private string episodeName;

        public TimeSpan EpisodeLength { get => episodeLength; set => episodeLength = value; }
        public int EpisodeNum { get => episodeNum; set => episodeNum = value; }
        public string EpisodeName { get => episodeName; set => episodeName = value; }

        public Description(int episodeNum, TimeSpan episodeLength, string episodeName)
        {
            this.episodeNum = episodeNum;
            this.episodeLength = episodeLength;
            this.episodeName = episodeName;
        }
        public Description()
        {

        }
        //s
        public override string ToString()
        {
            return $"{episodeNum},{episodeLength},{episodeName}";
        }
    }
 }

