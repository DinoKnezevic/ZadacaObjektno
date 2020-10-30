using ClassLibrary1;
using System;

namespace Zadaca1
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Random rand = new Random();
             double GenerateRandomScore()
            {
                double number;
                number = rand.NextDouble() * 10.00;
                return number;
            }
            Episode ep1, ep2;
            ep1 = new Episode();
            ep2 = new Episode(10, 64.39, 8.7);
            int viewers = 10;
            for (int i = 0; i < viewers; i++)
            {
                ep1.AddView(GenerateRandomScore());
                Console.WriteLine(ep1.GetMaxScore());
            }
            if (ep1.GetAverageScore() > ep2.GetAverageScore())
            {
                Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
            }
            else
            {
                Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
                //najčešći scenarij, na kraj ispisa dodati bezveze neka slova pa to najcesce ispadne
            }
        }

        
    }
}

// ep2 = new Episode(10, 64.39, 8.7); ovo sam riješio koristeći visual-ovu preporuku koristeći generate constructor