using DataLayer.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TestRepository
    {
        public List<Test> ListaTestova()
        {
            List<Test> lista = new List<Test>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Testovi";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Test t = new Test();
                    t.sifra_testa = sqlDataReader.GetString(0);
                    t.naziv_testa = sqlDataReader.GetString(1);
                    t.cena_testa = sqlDataReader.GetDecimal(2);

                    lista.Add(t);
                }
            }
            return lista;
        }

        // Metoda za dodavanje testova u bazu
        public int InsertTest(Test test)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO Testovi VALUES(@Sifra, @Naziv, @Cena)";
                sqlCommand.Parameters.AddWithValue("@Sifra", test.sifra_testa);
                sqlCommand.Parameters.AddWithValue("@Naziv", test.naziv_testa);
                sqlCommand.Parameters.AddWithValue("@Cena", test.cena_testa);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        // Metoda za ažuriranje testova u bazi podataka
        public int UpdateTest(Test test)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "UPDATE Testovi SET NazivTesta = @naziv_testa, CenaTesta = @cena_testa WHERE ŠifraTesta = @sifra_testa";
                sqlCommand.Parameters.AddWithValue("@naziv_testa", test.naziv_testa);  
                sqlCommand.Parameters.AddWithValue("@cena_testa", test.cena_testa);    
                sqlCommand.Parameters.AddWithValue("@sifra_testa", test.sifra_testa); 

                return sqlCommand.ExecuteNonQuery();
            }
        }


        // Metoda za brisanje testova iz baze
        public int DeleteTest(Test test)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlTransaction transaction = sqlConnection.BeginTransaction();

                try
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Transaction = transaction;
                        sqlCommand.CommandText = "DELETE FROM Rezultati WHERE TestID = @TestID";
                        sqlCommand.Parameters.AddWithValue("@TestID", test.sifra_testa);
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.CommandText = "DELETE FROM Testovi WHERE ŠifraTesta = @Sifra";
                        sqlCommand.Parameters.AddWithValue("@Sifra", test.sifra_testa);
                        int deletedRows = sqlCommand.ExecuteNonQuery();
                        transaction.Commit();

                        return deletedRows;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Greška prilikom brisanja testa: " + ex.Message);
                }
            }
        }

    }
}
