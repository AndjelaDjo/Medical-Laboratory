using BussinesLayer;
using DataLayer.Models;
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
    public partial class Rezultati : Form
    {
        private readonly RezultatBussines rezultatBussines;
        private readonly PacijentBissines pacijentBissines;
        private BindingSource bindingSource = new BindingSource();
        public Rezultati()
        {
            this.rezultatBussines = new RezultatBussines();
            this.pacijentBissines = new PacijentBissines();
            InitializeComponent();  
            tbJMBG.TextChanged += tbJMBG_TextChanged;
            PopuniSifraTestaComboBox();
            cbSifraTesta.SelectedIndexChanged += cbSifraTesta_SelectedIndexChanged;

        }
        private void btnPacijent_Click(object sender, EventArgs e)
        {
            var log = new Pacijenti();
            log.Show();
            this.Hide();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            var log = new Testovi();
            log.Show();
            this.Hide();
        }
        void osveziRezultate()
        {
            List<DataLayer.Models.Rezultat> r = this.rezultatBussines.ListaRezultat();
            dataGridViewRezultati.DataSource = r;
        }
        private void Rezultati_Load(object sender, EventArgs e)
        {
            osveziRezultate();
            
        }
        private void btDodajRezultat_Click(object sender, EventArgs e)
        {
            if (tbJMBG.Text != "" && tbIme.Text != "" && tbPrezime.Text != "" && cbSifraTesta.SelectedItem != null && dateTimePickerDatum.Value != DateTimePicker.MinimumDateTime)
            {
                DataLayer.Models.Rezultat r = new DataLayer.Models.Rezultat();
                DataLayer.Models.Pacijent p = new DataLayer.Models.Pacijent();
                r.TestID = cbSifraTesta.Text;
                r.PacijentID = tbJMBG.Text;
                r.datum = dateTimePickerDatum.Value;


                this.rezultatBussines.InsertRezultat(r);

                osveziRezultate();

                tbIme.Text = "";
                tbPrezime.Text = "";
                tbJMBG.Text = "";
                tbCena.Text = "";
                tbNazivTesta.Text = "";
                cbSifraTesta.Text = "";
                tbCena.Text = "";
                

                MessageBox.Show("Rezultat je uspešno dodat u bazu!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Popunite obavezna polja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbJMBG_TextChanged(object sender, EventArgs e)
        {
            string enteredJMBG = tbJMBG.Text;

            if (!string.IsNullOrEmpty(enteredJMBG))
            {
                DataLayer.Models.Pacijent pacijent = this.pacijentBissines.GetPacijentByJMBG(enteredJMBG);

                if (pacijent != null)
                {
                    tbIme.Text = pacijent.Ime;
                    tbPrezime.Text = pacijent.Prezime;
                }
                else
                {
                    tbIme.Text = "";
                    tbPrezime.Text = "";
                }
            }
            else
            {
                tbIme.Text = "";
                tbPrezime.Text = "";
            }
        }

        void PopuniSifraTestaComboBox()
        {
            List<string> listaSifraTesta = this.rezultatBussines.DobaviSifraTestaListu();
            cbSifraTesta.DataSource = listaSifraTesta;
        }

        private void cbSifraTesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTestCode = cbSifraTesta.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedTestCode))
            {
                var result = this.rezultatBussines.DobaviNazivICenuTesta(selectedTestCode);

                tbNazivTesta.Text = result.Key;
                tbCena.Text = result.Value.ToString();
            }
            else
            {
                tbNazivTesta.Text = "";
                tbCena.Text = "";
            }
        }

        int rezultatID;
        private void btObrisiRezultat_Click(object sender, EventArgs e)
        {
            if (dataGridViewRezultati.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewRezultati.SelectedRows[0];
                rezultatID = (int)selectedRow.Cells["RezultatID"].Value;

                DialogResult result = MessageBox.Show("Da li ste sigurni da želite obrisati rezultat?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Rezultat tempRezultat = new Rezultat { RezultatID = rezultatID };

                    if (this.rezultatBussines.DeleteRezultat(tempRezultat))
                    {
                        osveziRezultate();
                        tbIme.Text = "";
                        tbPrezime.Text = "";
                        tbJMBG.Text = "";
                        tbCena.Text = "";
                        tbNazivTesta.Text = "";
                        cbSifraTesta.Text = "";
                        tbCena.Text = "";
                       
                        MessageBox.Show("Rezultat je uspešno obrisan.", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Neuspešno!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da prvo odaberete rezultat koji želite obrisati.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btIzmeniRezultat_Click(object sender, EventArgs e)
        {
            if (tbJMBG.Text != "" && tbIme.Text != "" && tbPrezime.Text != "" && tbCena.Text!="" && cbSifraTesta.SelectedItem != null && dateTimePickerDatum.Value != DateTimePicker.MinimumDateTime)
            {
                DataLayer.Models.Rezultat r = new DataLayer.Models.Rezultat();
                DataLayer.Models.Test t = new DataLayer.Models.Test();
                r.TestID = cbSifraTesta.Text;
                r.PacijentID = tbJMBG.Text;
                r.datum = dateTimePickerDatum.Value;
                r.RezultatID = rezultatID;
                t.naziv_testa = tbNazivTesta.Text;
                t.cena_testa = Convert.ToDecimal(tbCena.Text);
                this.rezultatBussines.UpdateRezultat(r);

                osveziRezultate();
                tbIme.Text = "";
                tbPrezime.Text = "";
                tbJMBG.Text = "";
                tbCena.Text = "";
                tbNazivTesta.Text = "";
                cbSifraTesta.Text = "";
                tbCena.Text = "";
                

                MessageBox.Show("Rezultat je uspešno ažuriran u bazi!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ažuriranje rezultat nije uspelo!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewRezultati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbJMBG.Text = dataGridViewRezultati.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbSifraTesta.Text = dataGridViewRezultati.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePickerDatum.Value= Convert.ToDateTime(dataGridViewRezultati.Rows[e.RowIndex].Cells[3].Value.ToString());
        }
    }
}
