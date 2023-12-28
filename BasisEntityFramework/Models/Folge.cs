using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasisEntityFramework.Models
{
    public class Folge
    {
        public int id { get; set; }
        public int FolgeNummer { get; set; }
        public string FolgeTitle { get; set; } = null!;
        public DateTime Daeur { get; set; }
    }
}
