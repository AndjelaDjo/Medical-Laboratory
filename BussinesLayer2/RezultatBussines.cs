using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class RezultatBussines
    {
        private readonly RezultatRepository rRepo;
        public RezultatBussines()
        {
            this.rRepo = new RezultatRepository();
        }
        public List<Rezultat> ListaRezultat()
        {
            return this.rRepo.ListaRezultata();
        }
        public bool InsertRezultat(Rezultat rezultat)
        {
            if (this.rRepo.InsertRezultat(rezultat) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateRezultat(Rezultat rezultat)
        {
            if (this.rRepo.UpdateRezultat(rezultat) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteRezultat(Rezultat rezultat)
        {
            if (this.rRepo.DeleteRezultat(rezultat) > 0)
            {
                return true;
            }
            return false;
        }

        // Prikaz šifri testa u okviru ComboBox-a
        public List<string> DobaviSifraTestaListu()
        {
            List<string> listaSifraTesta = new List<string>();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MedLabDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL upit za izvlačenje ŠifreTesta iz tabele Test
                string query = "SELECT ŠifraTesta FROM Testovi";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Dodaj ŠifraTesta u listu
                            listaSifraTesta.Add(reader["ŠifraTesta"].ToString());
                        }
                    }
                }
            }

            return listaSifraTesta;
        }


        // Prikaz naziva testa na osnovu šifre klikom na jedan od ponudejnih iz padajuće liste
        public KeyValuePair<string, decimal> DobaviNazivICenuTesta(string sifraTesta)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MedLabDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL upit za izvlačenje NazivTesta i Cena iz tabele Test na osnovu ŠifreTesta
                string query = "SELECT NazivTesta, CenaTesta FROM Testovi WHERE ŠifraTesta = @SifraTesta";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SifraTesta", sifraTesta);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nazivTesta = reader["NazivTesta"].ToString();
                            decimal cena = Convert.ToDecimal(reader["CenaTesta"]);

                            return new KeyValuePair<string, decimal>(nazivTesta, cena);
                        }
                    }
                }
            }
            return new KeyValuePair<string, decimal>(string.Empty, 0m);
        }

    }
}
