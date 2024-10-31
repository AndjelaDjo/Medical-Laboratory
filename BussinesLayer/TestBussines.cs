using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    class TestBussines
    {

        private readonly TestRepository tRepo;
        public TestBussines()
        {
            this.tRepo = new TestRepository();
        }
        public List<Test> ListaTestova()
        {
            return this.tRepo.ListaTestova();
        }
        public bool InsertTest(Test test)
        {
            if (this.tRepo.InsertTest(test) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateTest(Test test)
        {
            if (this.tRepo.UpdateTest(test) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteTest(Test test)
        {
            if (this.tRepo.DeleteTest(test) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
