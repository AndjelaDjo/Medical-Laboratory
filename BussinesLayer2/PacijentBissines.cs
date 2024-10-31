using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class PacijentBissines
    {
        private readonly PacijentRepository pRepo;
        public PacijentBissines()
        {
            this.pRepo = new PacijentRepository();
        }
        public List<Pacijent> ListaPacijenata()
        {
            return this.pRepo.ListaPacijenata();
        }
        public bool InsertPacijent(Pacijent pacijent)
        {
            if (this.pRepo.InsertPacijent(pacijent) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdatePacijent(Pacijent pacijent)
        {
            if (this.pRepo.UpdatePacijent(pacijent) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeletePacijent(Pacijent pacijent)
        {
            if (this.pRepo.DeletePacijent(pacijent) > 0)
            {
                return true;
            }
            return false;
        }

        public Pacijent GetPacijentByJMBG(string jmbg)
        {
            return this.pRepo.GetPacijentByJMBG(jmbg);
        }
    }
}
