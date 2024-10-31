using DataLayer.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PacijentRepository
    {
        public List<Pacijent> ListaPacijenata()
        {
            List<Pacijent> lista = new List<Pacijent>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Pacijent";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Pacijent pacijent = new Pacijent();
                    pacijent.JMBG = sqlDataReader.GetString(0);
                    pacijent.Ime = sqlDataReader.GetString(1);
                    pacijent.Prezime = sqlDataReader.GetString(2);
                    pacijent.Email = sqlDataReader.GetString(3);
                    pacijent.Pol = sqlDataReader.GetString(4);
                    pacijent.DatumRodjenja = sqlDataReader.GetDateTime(5);
                    pacijent.Kontakt = sqlDataReader.IsDBNull(6) ? null : sqlDataReader.GetString(6);

                    lista.Add(pacijent);
                }
            }
            return lista;
        }

        //Metoda za dodavanje pacijenata u bazu
        public int InsertPacijent(Pacijent pacijent)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO PACIJENT VALUES('{0}', '{1}', '{2}')",

                pacijent.JMBG, pacijent.Ime, pacijent.Prezime, pacijent.Email, pacijent.Pol,
                pacijent.DatumRodjenja, pacijent.Kontakt);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        //Metoda za azuriranje podataka u Pacijent
        public int UpdatePacijent(Pacijent pacijent)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE PACIJENT SET sifra_testa = '{0}', naziv_testa = '{1}', cena_testa = '{2}'",

                 pacijent.JMBG, pacijent.Ime, pacijent.Prezime, pacijent.Email, pacijent.Pol,
                pacijent.DatumRodjenja, pacijent.Kontakt);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        //Metoda za brisanje testova iz baze
        public int DeletePacijent(Pacijent pacijent)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM PACIJENT WHERE id_stampaca = " + test.sifra_testa;
                return command.ExecuteNonQuery();
            }
        }
    }
}
