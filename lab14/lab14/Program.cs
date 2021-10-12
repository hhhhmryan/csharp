using System;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {

            ArtistMusician[] ourartists = new ArtistMusician[4];

            ourartists[0] = new Band("Waterparks", DateTime.Today, 3);
            ourartists[1] = new Band("Calm", DateTime.Today, 5);
            ourartists[2] = new SoloArtist("Alice", DateTime.Today, "no");
            ourartists[3] = new SoloArtist("Awsten", DateTime.Today, "yes");

            for (int i = 0; i < ourartists.Length; i++)
            {
                ourartists[i].Info();
                Console.WriteLine();
            }

            ourartists[0] = new Band("Waterparks", DateTime.Today, 3, 5, 0);
            ourartists[1] = new Band("Calm", DateTime.Today, 5, 1, 4);
            ourartists[2] = new SoloArtist("Alice", DateTime.Today, "no", 3, 2, 5);
            ourartists[3] = new SoloArtist("Awsten", DateTime.Today, "yes", 0, 3, 3);

            Console.WriteLine("Дискография артистов: ");
            Console.WriteLine();
            for (int i = 0; i < ourartists.Length; i++)
            {
                Console.WriteLine(ourartists[i].name + ":");
                ourartists[i].Discography();
                Console.WriteLine();
            }

            Band waterparks = new Band("Waterparks", DateTime.Today, 3, 5, 0);
            SoloArtist awsten = new SoloArtist("Awsten", DateTime.Today, "yes", 0, 3, 3);
            Console.WriteLine();

            waterparks.SetNames();
            awsten.SideActivity();
            Console.WriteLine();

            waterparks.Info();
            awsten.Info();

        }
    }
}
