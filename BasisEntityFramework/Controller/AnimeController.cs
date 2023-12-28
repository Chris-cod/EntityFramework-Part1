using BasisEntityFramework.Data;
using BasisEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BasisEntityFramework.Controller
{
    public class AnimeController
    {
        private Anime anime = new Anime();
        private AnimeContext animeContext = new AnimeContext();
        public AnimeController() { }
        public void AddAnime(string name, string productionStudio, string Author, string details, int nbrsstaffels)
        {
            anime.Name = name;
            anime.ProductionStudio = productionStudio;
            anime.Author = Author;
            anime.AnzahlStaffel = nbrsstaffels;
            anime.Synopsis = details;

            animeContext.Add(anime);
            animeContext.SaveChanges();
        }

        public Anime GetAnime(string name)
        {
            var manga = from anime in animeContext.Animes
                        where anime.Name == name
                        select anime;
            foreach (var an in manga)
            {
                anime.Name = name;
                anime.AnzahlStaffel = an.AnzahlStaffel;
                anime.Author = an.Author;
                anime.ProductionStudio = an.ProductionStudio;
            }

            return anime;
        }
    }
}
