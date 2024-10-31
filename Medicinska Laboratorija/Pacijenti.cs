using BussinesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicinska_Laboratorija
{
    public partial class Pacijenti : Form
    {
        private readonly PacijentBissines pacijentBussines;

        public Pacijenti()
        {
            this.pacijentBussines = new PacijentBissines();
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var log = new Testovi();
            log.Show();
            this.Hide();
        }
        private void btnPacijent_Click(object sender, EventArgs e)
        {
            var log = new Pacijenti();
            log.Show();
            this.Hide();
        }

        private void btnRezultati_Click(object sender, EventArgs e)
        {
            var log = new Rezultati();
            log.Show();
            this.Hide();
        }
        void osveziPacijente()
        {
            List<DataLayer.Models.Pacijent> p = this.pacijentBussines.ListaPacijenata();
            dataGridViewPacijent.DataSource = p;
        }

        private void Pacijent_Load(object sender, EventArgs e)
        {
            osveziPacijente();
        }
        private void btDodaj_Click(object sender, EventArgs e)
        {
            if (tbJMBG.Text != "" && tbIme.Text != "" && tbPrezime.Text != "" && tbEmail.Text != "" && tbDatumRodjenja.Text != "" && tbKontakt.Text != "")
            {
                //p je definisano korišćenjem pune putanje
                //zbog konfuzije između Pacijent.cs u DataLayer-u
                //i Test Medicinska_Laboratory
                DataLayer.Models.Pacijent p = new DataLayer.Models.Pacijent();
                p.JMBG = tbJMBG.Text;
                p.Ime = tbIme.Text;
                p.Prezime = tbPrezime.Text;
                p.Email = tbEmail.Text;
                p.Kontakt = tbKontakt.Text;
                p.DatumRodjenja = Convert.ToDateTime(tbDatumRodjenja.Text);
                if (rbMuski.Checked)
                {
                    p.Pol = "Muški";
                }
                else
                {
                    p.Pol = "Ženski";
                }

                this.pacijentBussines.InsertPacijent(p);
                osveziPacijente();

                tbJMBG.Text = "";
                tbIme.Text = "";
                tbPrezime.Text = "";
                tbEmail.Text = "";
                tbDatumRodjenja.Text = "";
                tbKontakt.Text = "";
                rbMuski.Checked = false;
                rbZenski.Checked = false;

                MessageBox.Show("Pacijent je uspešno dodat u bazu!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Popunite obavezna polja!", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            if (tbIme.Text != "" && tbPrezime.Text != "" && tbKontakt.Text != "" && tbDatumRodjenja.Text!="" && tbEmail.Text != "")
            {
                DataLayer.Models.Pacijent p = new DataLayer.Models.Pacijent();
                p.Ime = tbIme.Text;
                p.Prezime = tbPrezime.Text;
                p.Email = tbEmail.Text;
                p.Kontakt = tbKontakt.Text;
                p.DatumRodjenja = Convert.ToDateTime(tbDatumRodjenja.Text);
                p.Pol = rbMuski.Checked ? "Muški" : "Ženski";
                p.JMBG = JMBG;
                this.pacijentBussines.UpdatePacijent(p);

                osveziPacijente();

                tbJMBG.Text = "";
                tbIme.Text = "";
                tbPrezime.Text = "";
                tbEmail.Text = "";
                tbKontakt.Text = "";
                tbDatumRodjenja.Text = ""; 
                rbMuski.Checked = false;
                rbZenski.Checked = false;

                MessageBox.Show("Podaci o pacijentu su uspešno ažurirani!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ažuriranje nije uspelo! Molim vas, popunite sva obavezna polja.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        string JMBG;
        private void btObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewPacijent.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPacijent.SelectedRows[0];
                JMBG = selectedRow.Cells["JMBG"].Value.ToString();

                DialogResult result = MessageBox.Show("Da li ste sigurni da želite obrisati pacijenta?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataLayer.Models.Pacijent tempPacijent = new DataLayer.Models.Pacijent { JMBG = JMBG };

                    if (this.pacijentBussines.DeletePacijent(tempPacijent))
                    {
                        osveziPacijente();
                        tbIme.Text = "";
                        tbPrezime.Text = "";
                        tbJMBG.Text = "";
                        tbEmail.Text = "";
                        tbDatumRodjenja.Text = "";
                        tbKontakt.Text = "";
                        rbMuski.Checked = false;
                        rbZenski.Checked = false;
                        MessageBox.Show("Pacijent je uspešno obrisan.", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Neuspešno!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da prvo odaberete pacijenta koji želite obrisati.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridViewPacijent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           JMBG = dataGridViewPacijent.Rows[e.RowIndex].Cells[0].Value.ToString();
           tbJMBG.Text= dataGridViewPacijent.Rows[e.RowIndex].Cells[0].Value.ToString();
           tbIme.Text = dataGridViewPacijent.Rows[e.RowIndex].Cells[1].Value.ToString();
           tbPrezime.Text = dataGridViewPacijent.Rows[e.RowIndex].Cells[2].Value.ToString();
           tbEmail.Text = dataGridViewPacijent.Rows[e.RowIndex].Cells[3].Value.ToString();
           tbDatumRodjenja.Text = dataGridViewPacijent.Rows[e.RowIndex].Cells[5].Value.ToString();
           tbKontakt.Text = dataGridViewPacijent.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

       
    }
}
