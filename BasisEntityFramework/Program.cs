using BasisEntityFramework.Controller;
using BasisEntityFramework.Data;
using BasisEntityFramework.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using AnimeContext context = new AnimeContext();

        //Anime onePunch = new Anime() {
        //    Name = "One Punch Man",
        //    ProductionStudio = "Madhouse",
        //    Author = "Yusuke Murata",
        //    AnzahlStaffel = 2,
        //    Synopsis = "Saitama ist ein junger Held mit Glatze und Umhang. Er lebt in der Stadt Z, wo diverse Monster auftauchen und Schaeden verursachen"

        //};

        //context.Add(onePunch);
        //context.SaveChanges();

        //var manga = from anime in context.Animes
        //            where anime.Name == "One Punch man"
        //            select anime;

        AnimeController controller = new AnimeController();

        var manga = controller.GetAnime("One Punch man");

        
            Console.WriteLine($"Name: {manga.Name}");
            Console.WriteLine($"Author: {manga.Author}");
            Console.WriteLine($"Staffel: {manga.AnzahlStaffel}");
    }

}