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
                sqlCommand.CommandText = "SELECT * FROM PACIJENTI";
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
                sqlCommand.CommandText = "INSERT INTO PACIJENTI VALUES(@JMBG, @Ime, @Prezime, @Email, @Pol, @DatumRodjenja, @Kontakt)";

                sqlCommand.Parameters.AddWithValue("@JMBG", pacijent.JMBG);
                sqlCommand.Parameters.AddWithValue("@Ime", pacijent.Ime);
                sqlCommand.Parameters.AddWithValue("@Prezime", pacijent.Prezime);
                sqlCommand.Parameters.AddWithValue("@Email", pacijent.Email);
                sqlCommand.Parameters.AddWithValue("@Pol", pacijent.Pol);
                sqlCommand.Parameters.AddWithValue("@DatumRodjenja", pacijent.DatumRodjenja);
                sqlCommand.Parameters.AddWithValue("@Kontakt", pacijent.Kontakt);

                return sqlCommand.ExecuteNonQuery();
            }
        }


        //Metoda za ažuriranje podataka o pacijentima u bazi
        public int UpdatePacijent(Pacijent pacijent)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "UPDATE Pacijenti SET Ime = @Ime, Prezime = @Prezime, Email = @Email, Pol = @Pol, DatumRodjenja = @DatumRodjenja, Kontakt = @Kontakt WHERE JMBG = @JMBG";
                sqlCommand.Parameters.AddWithValue("@Ime", pacijent.Ime);
                sqlCommand.Parameters.AddWithValue("@Prezime", pacijent.Prezime);
                sqlCommand.Parameters.AddWithValue("@Email", pacijent.Email);
                sqlCommand.Parameters.AddWithValue("@Pol", pacijent.Pol);
                sqlCommand.Parameters.AddWithValue("@DatumRodjenja", pacijent.DatumRodjenja);
                sqlCommand.Parameters.AddWithValue("@Kontakt", pacijent.Kontakt);
                sqlCommand.Parameters.AddWithValue("@JMBG", pacijent.JMBG);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        //Metoda za brisanje pacijenata iz baze
        public int DeletePacijent(Pacijent pacijent)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlTransaction transaction = sqlConnection.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = sqlConnection;
                        command.Transaction = transaction;
                        command.CommandText = "DELETE FROM Rezultati WHERE PacijentID = @PacijentID";
                        command.Parameters.AddWithValue("@PacijentID", pacijent.JMBG);
                        command.ExecuteNonQuery();
                        command.CommandText = "DELETE FROM Pacijenti WHERE JMBG = @JMBG";
                        command.Parameters.AddWithValue("@JMBG", pacijent.JMBG);
                        int deletedRows = command.ExecuteNonQuery();
                        transaction.Commit();

                        return deletedRows;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Greška prilikom brisanja pacijenta: " + ex.Message);
                }
            }
        }

        //Metoda za dohvatanje pacijenata iz baze prema JMBG
        public Pacijent GetPacijentByJMBG(string jmbg)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM PACIJENTI WHERE JMBG = @JMBG";
                sqlCommand.Parameters.AddWithValue("@JMBG", jmbg);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    Pacijent pacijent = new Pacijent
                    {
                        JMBG = sqlDataReader.GetString(0),
                        Ime = sqlDataReader.GetString(1),
                        Prezime = sqlDataReader.GetString(2),
                        Email = sqlDataReader.GetString(3),
                        Pol = sqlDataReader.GetString(4),
                        DatumRodjenja = sqlDataReader.GetDateTime(5),
                        Kontakt = sqlDataReader.IsDBNull(6) ? null : sqlDataReader.GetString(6)
                    };

                    return pacijent;
                }

                return null; 
            }
        }
    }
}
