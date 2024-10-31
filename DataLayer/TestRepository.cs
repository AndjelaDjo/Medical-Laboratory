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
    public class TestRepository
    {
        public List<Test> ListaTestova()
        {
            List<Test> lista = new List<Test>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT* FROM TEST";
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

        //Metoda za dodavanje testova u bazu
        public int InsertTest(Test test)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO TEST VALUES('{0}', '{1}', '{2}')",

                test.sifra_testa, test.naziv_testa, test.cena_testa);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        //Metoda za azuriranje podataka u Test
        public int UpdateTest(Test test)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE TEST SET sifra_testa = '{0}', naziv_testa = '{1}', cena_testa = '{2}'",

                test.sifra_testa, test.naziv_testa, test.cena_testa);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        //Metoda za brisanje testova iz baze
        public int DeleteTest(Test test)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM TEST WHERE id_stampaca = " + test.sifra_testa;
                return command.ExecuteNonQuery();
            }
        }



    }
}
