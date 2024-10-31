using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Medicinska_Laboratorija
{
    public partial class Registracija : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MedLabDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Registracija()
        {
            InitializeComponent();
            tbLozinka.UseSystemPasswordChar = true;
            tbPotvrdiLozinku.UseSystemPasswordChar = true;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        private bool ProveriPostojanjeAdminaUBazi(string email)
        {
            try
            {
                bool adminPostoji = false;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Admini WHERE email = @Email", connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Admin sa unetim email-om već postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            adminPostoji = true;
                        }
                    }
                }

                return adminPostoji;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom izvršavanja SQL upita: " + ex.Message);
                return false;
            }
        }

            private bool UnesiPodatkeUBazu(string email, string password)
            {
                try
                {
                    // Provera da li admin sa istim email-om već postoji
                    if (ProveriPostojanjeAdminaUBazi(email))
                    {
                        return false;
                    }

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Admini (email, password) VALUES (@Email, @Password)", connection))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Password", password);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Uspešno ste se registrovali!", "Registracija uspela", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Registracija nije uspela.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greška prilikom izvršavanja SQL upita: " + ex.Message);
                    MessageBox.Show("Došlo je do greške prilikom registracije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            private void btnPrijava_Click(object sender, EventArgs e)
            {
                string lozinka = tbLozinka.Text;
                string potvrdiLozinku = tbPotvrdiLozinku.Text;
                string email = tbEmail.Text;

                if (tbEmail.Text != "" && tbLozinka.Text != "" && tbPotvrdiLozinku.Text != "")
                {
                    if (lozinka.Length >= 8)
                    {
                        if (lozinka == potvrdiLozinku)
                        {
                            if (IsValidEmail(email))
                            {
                                if (!ProveriPostojanjeAdminaUBazi(email))
                                {
                                    UnesiPodatkeUBazu(email, lozinka);
                                    var prijava = new Prijava();
                                    prijava.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Admin sa unetim email-om već postoji.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Unesite ispravan email.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lozinka mora se poklapati sa potvrdom.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lozinka mora imati najmanje 8 karaktera.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Popunite sva polja!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
