using BussinesLayer;
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
using DataLayer.Models;

namespace Medicinska_Laboratorija
{
    public partial class Testovi : Form
    {

        private readonly TestBussines testBussines;

        public Testovi()
        {
            this.testBussines = new TestBussines();
            InitializeComponent();
            
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

        void osveziTestove()
        {
            List<DataLayer.Models.Test> t = this.testBussines.ListaTestova();
            dataGridViewTest.DataSource = t;
        }
        private void Test_Load(object sender, EventArgs e)
        {
            osveziTestove();
        }

        private void btDodajTest_Click(object sender, EventArgs e)
        {
            if(tbNazivTesta.Text!="" && tbCena.Text!="")
            {
                //t je definisano korišćenjem pune putanje
                //zbog konfuzije između Test.cs u DataLayer-u
                //i Test Medicinska_Laboratory
                DataLayer.Models.Test t = new DataLayer.Models.Test();
                t.sifra_testa = tbSifraTesta.Text;
                t.naziv_testa = tbNazivTesta.Text;
                t.cena_testa = Convert.ToDecimal(tbCena.Text);
                this.testBussines.InsertTest(t);
                osveziTestove();

                tbSifraTesta.Text = "";
                tbNazivTesta.Text = "";
                tbCena.Text = "";

                MessageBox.Show("Test je uspešno dodat u bazu!", "Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Popunite obavezna polja!", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btIzmeniTest_Click(object sender, EventArgs e)
        {
            if (tbNazivTesta.Text != "" && tbCena.Text != "")
            {
                DataLayer.Models.Test t = new DataLayer.Models.Test();
                t.naziv_testa = tbNazivTesta.Text;
                t.cena_testa = Convert.ToDecimal(tbCena.Text);
                t.sifra_testa = sifra_testa;
                this.testBussines.UpdateTest(t);

                osveziTestove();
                tbSifraTesta.Text = "";
                tbNazivTesta.Text = "";
                tbCena.Text = "";

                MessageBox.Show("Test je uspešno ažuriran u bazi!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
                MessageBox.Show("Ažuriranje nije uspelo!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        string sifra_testa;
        private void btObrisiTest_Click(object sender, EventArgs e)
        {
            if (dataGridViewTest.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewTest.SelectedRows[0];
                sifra_testa = selectedRow.Cells["sifra_testa"].Value.ToString();

                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete test?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataLayer.Models.Test tempTest = new DataLayer.Models.Test { sifra_testa = sifra_testa };

                    if (this.testBussines.DeleteTest(tempTest))
                    {
                        osveziTestove();

                        tbSifraTesta.Text = "";
                        tbNazivTesta.Text = "";
                        tbCena.Text = "";
                        MessageBox.Show("Test je uspešno obrisan.", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Neuspešno!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da prvo odaberete test koji želite obrisati.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sifra_testa = dataGridViewTest.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbSifraTesta.Text = dataGridViewTest.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNazivTesta.Text = dataGridViewTest.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbCena.Text = dataGridViewTest.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

    }
}

