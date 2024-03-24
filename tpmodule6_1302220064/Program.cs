// See https://aka.ms/new-console-template for more information
using tpmodule6_1302220064;

class Program
{
    static void Main(string[] args)
    {
        // state awal untuk video berisikan null
        SayaTubeVideo video = null;

        // Design Contract
        try
        {
            // Prekondisi
            video = new SayaTubeVideo("Tutorial Design By Contract - Farrel Haykal G");
            for (int i = 0; i < 10000000; i++)
            {
                video.IncreasePlayCount(2);
            }
        }
        // tes Exception
        catch (Exception tes)
        {
            Console.WriteLine("Error: " + tes.Message);
        }
        finally
        {
            // printoutput jika tidak terdeteksi error
            if (video != null)
            {
                video.publicVideoDetails();
            }
        }
    }
}
    