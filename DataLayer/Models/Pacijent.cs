using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Pacijent
    {
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Pol { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Kontakt { get; set; }
    }
}
