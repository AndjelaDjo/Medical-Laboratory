
namespace Medicinska_Laboratorija
{
    partial class Testovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testovi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRezultati = new System.Windows.Forms.Button();
            this.btnPacijent = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.dataGridViewTest = new System.Windows.Forms.DataGridView();
            this.btObrisiTest = new System.Windows.Forms.Button();
            this.btIzmeniTest = new System.Windows.Forms.Button();
            this.btDodajTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbNazivTesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSifraTesta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.btnRezultati);
            this.panel1.Controls.Add(this.btnPacijent);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 653);
            this.panel1.TabIndex = 28;
            // 
            // btnRezultati
            // 
            this.btnRezultati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
            this.btnRezultati.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btnRezultati.FlatAppearance.BorderSize = 0;
            this.btnRezultati.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Bold);
            this.btnRezultati.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRezultati.Location = new System.Drawing.Point(24, 422);
            this.btnRezultati.Name = "btnRezultati";
            this.btnRezultati.Size = new System.Drawing.Size(150, 40);
            this.btnRezultati.TabIndex = 12;
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
            this.btnPacijent.Name = "btnPacijent";
            this.btnPacijent.Size = new System.Drawing.Size(150, 40);
            this.btnPacijent.TabIndex = 10;
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
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(150, 40);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "TESTOVI";
            this.btnTest.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTest
            // 
            this.dataGridViewTest.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTest.Location = new System.Drawing.Point(284, 336);
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.RowHeadersWidth = 51;
            this.dataGridViewTest.RowTemplate.Height = 24;
            this.dataGridViewTest.Size = new System.Drawing.Size(599, 284);
            this.dataGridViewTest.TabIndex = 37;
            this.dataGridViewTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTest_CellClick);
            // 
            // btObrisiTest
            // 
            this.btObrisiTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btObrisiTest.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.btObrisiTest.Location = new System.Drawing.Point(589, 254);
            this.btObrisiTest.Name = "btObrisiTest";
            this.btObrisiTest.Size = new System.Drawing.Size(120, 40);
            this.btObrisiTest.TabIndex = 36;
            this.btObrisiTest.Text = "OBRIŠI";
            this.btObrisiTest.UseVisualStyleBackColor = false;
            this.btObrisiTest.Click += new System.EventHandler(this.btObrisiTest_Click);
            // 
            // btIzmeniTest
            // 
            this.btIzmeniTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btIzmeniTest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btIzmeniTest.FlatAppearance.BorderSize = 0;
            this.btIzmeniTest.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.btIzmeniTest.Location = new System.Drawing.Point(589, 180);
            this.btIzmeniTest.Name = "btIzmeniTest";
            this.btIzmeniTest.Size = new System.Drawing.Size(120, 40);
            this.btIzmeniTest.TabIndex = 35;
            this.btIzmeniTest.Text = "IZMENI";
            this.btIzmeniTest.UseVisualStyleBackColor = false;
            this.btIzmeniTest.Click += new System.EventHandler(this.btIzmeniTest_Click);
            // 
            // btDodajTest
            // 
            this.btDodajTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btDodajTest.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.btDodajTest.Location = new System.Drawing.Point(589, 107);
            this.btDodajTest.Name = "btDodajTest";
            this.btDodajTest.Size = new System.Drawing.Size(120, 40);
            this.btDodajTest.TabIndex = 34;
            this.btDodajTest.Text = "DODAJ";
            this.btDodajTest.UseVisualStyleBackColor = false;
            this.btDodajTest.Click += new System.EventHandler(this.btDodajTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(544, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "TESTOVI";
            // 
            // tbCena
            // 
            this.tbCena.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.tbCena.Location = new System.Drawing.Point(284, 268);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(200, 26);
            this.tbCena.TabIndex = 32;
            // 
            // tbNazivTesta
            // 
            this.tbNazivTesta.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.tbNazivTesta.Location = new System.Drawing.Point(284, 187);
            this.tbNazivTesta.Name = "tbNazivTesta";
            this.tbNazivTesta.Size = new System.Drawing.Size(200, 26);
            this.tbNazivTesta.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(280, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(280, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Naziv testa";
            // 
            // tbSifraTesta
            // 
            this.tbSifraTesta.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.tbSifraTesta.Location = new System.Drawing.Point(284, 107);
            this.tbSifraTesta.Name = "tbSifraTesta";
            this.tbSifraTesta.Size = new System.Drawing.Size(200, 26);
            this.tbSifraTesta.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(280, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Šifra testa";
            // 
            // Testovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.tbSifraTesta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTest);
            this.Controls.Add(this.btObrisiTest);
            this.Controls.Add(this.btIzmeniTest);
            this.Controls.Add(this.btDodajTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbNazivTesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Testovi";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRezultati;
        private System.Windows.Forms.Button btnPacijent;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataGridView dataGridViewTest;
        private System.Windows.Forms.Button btObrisiTest;
        private System.Windows.Forms.Button btIzmeniTest;
        private System.Windows.Forms.Button btDodajTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbNazivTesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSifraTesta;
        private System.Windows.Forms.Label label4;
    }
}