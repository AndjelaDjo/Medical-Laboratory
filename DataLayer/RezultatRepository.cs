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
    public class RezultatRepository
    {
        public List<Rezultat> ListaRezultata()
        {
            List<Rezultat> lista = new List<Rezultat>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT* FROM REZULTAT";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Rezultat r = new Rezultat();
                    r.TestID = sqlDataReader.GetString(0);
                    r.PacijentID = sqlDataReader.GetString(1);
                    r.datum = sqlDataReader.GetDateTime(2);

                    lista.Add(r);
                }
            }
            return lista;
        }

        //Metoda za dodavanje rezultata u bazu
        public int InsertRezultat(Rezultat rezultat)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO REZULTAT VALUES('{0}', '{1}', '{2}')",

                rezultat.TestID, rezultat.PacijentID, rezultat.datum);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        //Metoda za azuriranje podataka u Rezultat
        public int UpdateRezultat(Rezultat rezultat)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE REZULTAT SET TestID = '{0}', PacijentID = '{1}', datum = '{2}'",

                rezultat.TestID, rezultat.PacijentID, rezultat.datum);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        //Metoda za brisanje rezultata iz baze
        public int DeleteRezultat(Rezultat rezultat)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM REZULTAT WHERE TestID = " + rezultat.TestID + " AND PacijentID = " + rezultat.PacijentID; ;
                return command.ExecuteNonQuery();
            }
        }
    }
}
