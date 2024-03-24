// See https://aka.ms/new-console-template for more information
using tpmodule6_1302220064;

class Program
{
    static void Main(string[] args)
    {
        // Create a SayaTubeVideo object with title
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract Farrel Haykal");

        // Increase play count
        video.IncreasePlayCount(1);

        // Print video details
        video.publicVideoDetails();
    }
}
