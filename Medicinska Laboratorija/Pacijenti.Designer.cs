
namespace Medicinska_Laboratorija
{
    partial class Pacijenti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacijenti));
            this.btObrisi = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btDodaj = new System.Windows.Forms.Button();
            this.dataGridViewPacijent = new System.Windows.Forms.DataGridView();
            this.tbDatumRodjenja = new System.Windows.Forms.TextBox();
            this.rbZenski = new System.Windows.Forms.RadioButton();
            this.rbMuski = new System.Windows.Forms.RadioButton();
            this.tbKontakt = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.btnRezultati = new System.Windows.Forms.Button();
            this.btnPacijent = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacijent)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btObrisi
            // 
            this.btObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btObrisi.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.btObrisi.Location = new System.Drawing.Point(925, 343);
            this.btObrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btObrisi.Name = "btObrisi";
            this.btObrisi.Size = new System.Drawing.Size(120, 39);
            this.btObrisi.TabIndex = 42;
            this.btObrisi.Text = "OBRIŠI";
            this.btObrisi.UseVisualStyleBackColor = false;
            this.btObrisi.Click += new System.EventHandler(this.btObrisi_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btIzmeni.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btIzmeni.FlatAppearance.BorderSize = 0;
            this.btIzmeni.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.btIzmeni.Location = new System.Drawing.Point(613, 343);
            this.btIzmeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(120, 39);
            this.btIzmeni.TabIndex = 41;
            this.btIzmeni.Text = "IZMENI";
            this.btIzmeni.UseVisualStyleBackColor = false;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btDodaj
            // 
            this.btDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btDodaj.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.btDodaj.Location = new System.Drawing.Point(297, 343);
            this.btDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(120, 39);
            this.btDodaj.TabIndex = 40;
            this.btDodaj.Text = "DODAJ";
            this.btDodaj.UseVisualStyleBackColor = false;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // dataGridViewPacijent
            // 
            this.dataGridViewPacijent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPacijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacijent.Location = new System.Drawing.Point(297, 422);
            this.dataGridViewPacijent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPacijent.Name = "dataGridViewPacijent";
            this.dataGridViewPacijent.RowHeadersWidth = 51;
            this.dataGridViewPacijent.RowTemplate.Height = 24;
            this.dataGridViewPacijent.Size = new System.Drawing.Size(748, 319);
            this.dataGridViewPacijent.TabIndex = 39;
            this.dataGridViewPacijent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacijent_CellContentClick);
            // 
            // tbDatumRodjenja
            // 
            this.tbDatumRodjenja.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.tbDatumRodjenja.Location = new System.Drawing.Point(534, 274);
            this.tbDatumRodjenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDatumRodjenja.Name = "tbDatumRodjenja";
            this.tbDatumRodjenja.Size = new System.Drawing.Size(200, 26);
            this.tbDatumRodjenja.TabIndex = 38;
            // 
            // rbZenski
            // 
            this.rbZenski.AutoSize = true;
            this.rbZenski.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbZenski.Location = new System.Drawing.Point(890, 122);
            this.rbZenski.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbZenski.Name = "rbZenski";
            this.rbZenski.Size = new System.Drawing.Size(84, 28);
            this.rbZenski.TabIndex = 37;
            this.rbZenski.TabStop = true;
            this.rbZenski.Text = "Ženski";
            this.rbZenski.UseVisualStyleBackColor = true;
            // 
            // rbMuski
            // 
            this.rbMuski.AutoSize = true;
            this.rbMuski.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMuski.Location = new System.Drawing.Point(774, 122);
            this.rbMuski.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMuski.Name = "rbMuski";
            this.rbMuski.Size = new System.Drawing.Size(80, 28);
            this.rbMuski.TabIndex = 36;
            this.rbMuski.TabStop = true;
            this.rbMuski.Text = "Muški";
            this.rbMuski.UseVisualStyleBackColor = true;
            // 
            // tbKontakt
            // 
            this.tbKontakt.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.tbKontakt.Location = new System.Drawing.Point(534, 199);
            this.tbKontakt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKontakt.Name = "tbKontakt";
            this.tbKontakt.Size = new System.Drawing.Size(200, 26);
            this.tbKontakt.TabIndex = 35;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.tbEmail.Location = new System.Drawing.Point(534, 124);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 26);
            this.tbEmail.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(530, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Email";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.tbPrezime.Location = new System.Drawing.Point(297, 274);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(200, 26);
            this.tbPrezime.TabIndex = 32;
            // 
            // tbIme
            // 
            this.tbIme.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.tbIme.Location = new System.Drawing.Point(297, 199);
            this.tbIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(200, 26);
            this.tbIme.TabIndex = 31;
            // 
            // btnRezultati
            // 
            this.btnRezultati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
            this.btnRezultati.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btnRezultati.FlatAppearance.BorderSize = 0;
            this.btnRezultati.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Bold);
            this.btnRezultati.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRezultati.Location = new System.Drawing.Point(24, 422);
            this.btnRezultati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRezultati.Name = "btnRezultati";
            this.btnRezultati.Size = new System.Drawing.Size(149, 39);
            this.btnRezultati.TabIndex = 13;
            this.btnRezultati.Text = "REZULTATI";
            this.btnRezultati.UseVisualStyleBackColor = false;
            this.btnRezultati.Click += new System.EventHandler(this.btnRezultati_Click);
            // 
            // btnPacijent
            // 
            this.btnPacijent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
            this.btnPacijent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btnPacijent.FlatAppearance.BorderSize = 0;
            this.btnPacijent.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Bold);
            this.btnPacijent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPacijent.Location = new System.Drawing.Point(24, 330);
            this.btnPacijent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPacijent.Name = "btnPacijent";
            this.btnPacijent.Size = new System.Drawing.Size(149, 39);
            this.btnPacijent.TabIndex = 11;
            this.btnPacijent.Text = "PACIJENTI";
            this.btnPacijent.UseVisualStyleBackColor = false;
            this.btnPacijent.Click += new System.EventHandler(this.btnPacijent_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
            this.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Bold);
            this.btnTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTest.Location = new System.Drawing.Point(24, 242);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(149, 39);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "TESTOVI";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.btnRezultati);
            this.panel1.Controls.Add(this.btnPacijent);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 754);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(530, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Kontakt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(770, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Pol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(530, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Datum rođenja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(293, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(293, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(587, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "PACIJENTI";
            // 
            // tbJMBG
            // 
            this.tbJMBG.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.tbJMBG.Location = new System.Drawing.Point(297, 124);
            this.tbJMBG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.Size = new System.Drawing.Size(200, 26);
            this.tbJMBG.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(293, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "JMBG";
            // 
            // Pacijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 753);
            this.Controls.Add(this.tbJMBG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btObrisi);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.dataGridViewPacijent);
            this.Controls.Add(this.tbDatumRodjenja);
            this.Controls.Add(this.rbZenski);
            this.Controls.Add(this.rbMuski);
            this.Controls.Add(this.tbKontakt);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pacijenti";
            this.Text = "Pacijenti";
            this.Load += new System.EventHandler(this.Pacijent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacijent)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btObrisi;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.DataGridView dataGridViewPacijent;
        private System.Windows.Forms.TextBox tbDatumRodjenja;
        private System.Windows.Forms.RadioButton rbZenski;
        private System.Windows.Forms.RadioButton rbMuski;
        private System.Windows.Forms.TextBox tbKontakt;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btnRezultati;
        private System.Windows.Forms.Button btnPacijent;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.Label label8;
    }
}