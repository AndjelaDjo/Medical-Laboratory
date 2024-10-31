using DataLayer.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                sqlCommand.CommandText = "SELECT * FROM Rezultati";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Rezultat r = new Rezultat();
                    r.RezultatID = sqlDataReader.GetInt32(0);
                    r.TestID = sqlDataReader.GetString(1);
                    r.PacijentID = sqlDataReader.GetString(2);
                    r.datum = sqlDataReader.GetDateTime(3);

                    lista.Add(r);
                }
            }
            return lista;
        }

        // Metoda za dodavanje rezultata u bazu
        public int InsertRezultat(Rezultat rezultat)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO Rezultati (TestID, PacijentID, datum) VALUES (@TestID, @PacijentID, @Datum)";
                sqlCommand.Parameters.AddWithValue("@TestID", rezultat.TestID);
                sqlCommand.Parameters.AddWithValue("@PacijentID", rezultat.PacijentID);
                sqlCommand.Parameters.AddWithValue("@Datum", rezultat.datum);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        // Metoda za ažuriranje rezultata u bazi
        public int UpdateRezultat(Rezultat rezultat)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "UPDATE Rezultati SET PacijentID = @PacijentID, Datum = @Datum WHERE TestID = @TestID";
                sqlCommand.Parameters.AddWithValue("@PacijentID", rezultat.PacijentID);
                sqlCommand.Parameters.AddWithValue("@Datum", rezultat.datum);
                sqlCommand.Parameters.AddWithValue("@TestID", rezultat.TestID);

                return sqlCommand.ExecuteNonQuery();
            }
        }


        // Metoda za brisanje rezultata iz baze
        public int DeleteRezultat(Rezultat rezultat)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM Rezultati WHERE RezultatID = @RezultatID";
                command.Parameters.AddWithValue("@RezultatID", rezultat.RezultatID);

                return command.ExecuteNonQuery();
            }
        }
    }
}
