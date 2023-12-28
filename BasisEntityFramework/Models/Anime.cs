using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasisEntityFramework.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ProductionStudio { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int AnzahlStaffel { get; set; }
        public string Synopsis { get; set; } = null!;
        public ICollection<Staffel> Staffels { get; set; } = null!;

    }
}
