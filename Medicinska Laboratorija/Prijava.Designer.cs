
namespace Medicinska_Laboratorija
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbPrikaziLozinku = new System.Windows.Forms.CheckBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.btnRegistracija);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 503);
            this.panel1.TabIndex = 9;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
            this.btnRegistracija.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btnRegistracija.FlatAppearance.BorderSize = 0;
            this.btnRegistracija.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegistracija.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistracija.Location = new System.Drawing.Point(36, 427);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(280, 40);
            this.btnRegistracija.TabIndex = 8;
            this.btnRegistracija.Text = "REGISTRACIJA";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 9F);
            this.label4.Location = new System.Drawing.Point(120, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nemate nalog?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbPrikaziLozinku
            // 
            this.cbPrikaziLozinku.AutoSize = true;
            this.cbPrikaziLozinku.Font = new System.Drawing.Font("Sitka Text", 8F);
            this.cbPrikaziLozinku.Location = new System.Drawing.Point(568, 320);
            this.cbPrikaziLozinku.Name = "cbPrikaziLozinku";
            this.cbPrikaziLozinku.Size = new System.Drawing.Size(134, 24);
            this.cbPrikaziLozinku.TabIndex = 16;
            this.cbPrikaziLozinku.Text = "Prikazi Lozinku";
            this.cbPrikaziLozinku.UseVisualStyleBackColor = true;
            this.cbPrikaziLozinku.CheckedChanged += new System.EventHandler(this.cbPrikaziLozinku_CheckedChanged);
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btnPrijava.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(138)))));
            this.btnPrijava.FlatAppearance.BorderSize = 0;
            this.btnPrijava.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrijava.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrijava.Location = new System.Drawing.Point(423, 427);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(280, 40);
            this.btnPrijava.TabIndex = 15;
            this.btnPrijava.Text = "PRIJAVI SE";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // tbLozinka
            // 
            this.tbLozinka.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLozinka.Location = new System.Drawing.Point(422, 288);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(280, 26);
            this.tbLozinka.TabIndex = 14;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(422, 186);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(280, 26);
            this.tbEmail.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(417, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lozinka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(417, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(416, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "PRIJAVA";
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbPrikaziLozinku);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbPrikaziLozinku;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

