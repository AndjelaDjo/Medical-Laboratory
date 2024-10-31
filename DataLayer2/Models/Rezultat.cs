using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Rezultat
    {
        public int RezultatID { get; set; }
        public string TestID { get; set; }
        public string PacijentID { get; set; }
        public DateTime datum { get; set; }
        

    }
}
