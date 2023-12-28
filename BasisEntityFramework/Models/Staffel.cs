using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasisEntityFramework.Models
{
    public class Staffel
    {
        public int Id { get; set; }
        public int StafellNummer { get; set; }
        public string StafellName { get; set; } = null!;
        public int AnzahlFolge { get; set; }
        public ICollection<Folge> Folges { get; set; } = null!;

    }
}
