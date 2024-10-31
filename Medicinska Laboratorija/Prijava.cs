using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicinska_Laboratorija
{
    public partial class Prijava : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MedLabDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Prijava()
        {
            InitializeComponent();
            tbLozinka.UseSystemPasswordChar = true;
        }

        private bool ProveriPostojanjeAdminaUBazi(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Admini WHERE email = @Email", connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private bool ProveriIspravnostLozinke(string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT password FROM Admini WHERE email = @Email", connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        string sacuvanaLozinka = cmd.ExecuteScalar() as string;
                        return sacuvanaLozinka != null && sacuvanaLozinka.Equals(password);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom izvršavanja SQL upita: " + ex.Message);
                return false;
            }
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {

            string lozinka = tbLozinka.Text;
            string email = tbEmail.Text;

            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(lozinka))
            {

                if (ProveriPostojanjeAdminaUBazi(email))
                {
                    if (ProveriIspravnostLozinke(email, lozinka))
                    {
                        var prijava = new Pacijenti();
                        prijava.Show();
                        this.Hide();
                        MessageBox.Show("Uspešna prijava!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lozinka nije ispravna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ovaj admin ne postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Popunite sva polja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            var prijava = new Registracija();
            prijava.Show();
            this.Hide();
        }

        private void cbPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            tbLozinka.UseSystemPasswordChar = !cbPrikaziLozinku.Checked;
        }
    }
}
