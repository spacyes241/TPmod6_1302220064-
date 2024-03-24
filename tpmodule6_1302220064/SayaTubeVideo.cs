using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodule6_1302220064
{
    public class SayaTubeVideo
    {
       private int id;
       private String title;
       private  int playCount;

        public SayaTubeVideo(String title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            Debug.Assert(title.Length <= 100 && title != null);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Contract.Requires(count > 0 && count <= 10000000, "Input penambahan play count maximal 10.000.000 playcount");
            Contract.Ensures(playCount <= int.MaxValue - count, "Penambahan play count melebihi maximal.");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Penambahan play count melebihi batas maksimal, yakni melebihi 10.000.000.");
            }
        }

    public void publicVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
  
}
        
