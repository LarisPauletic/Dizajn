namespace AplikacijaBiblioteka
{
    partial class Pocetna
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
            this.btnUpisKorisnika = new System.Windows.Forms.Button();
            this.btnUpisKnjiga = new System.Windows.Forms.Button();
            this.btnPosudbaKnjige = new System.Windows.Forms.Button();
            this.btnStanjeKnjige = new System.Windows.Forms.Button();
            this.btnStanjeKnjigaSkladiste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpisKorisnika
            // 
            this.btnUpisKorisnika.Location = new System.Drawing.Point(276, 63);
            this.btnUpisKorisnika.Name = "btnUpisKorisnika";
            this.btnUpisKorisnika.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpisKorisnika.Size = new System.Drawing.Size(123, 46);
            this.btnUpisKorisnika.TabIndex = 0;
            this.btnUpisKorisnika.Text = "Upis Korisnika";
            this.btnUpisKorisnika.UseVisualStyleBackColor = true;
            this.btnUpisKorisnika.Click += new System.EventHandler(this.btnUpisKorisnika_Click);
            // 
            // btnUpisKnjiga
            // 
            this.btnUpisKnjiga.Location = new System.Drawing.Point(276, 145);
            this.btnUpisKnjiga.Name = "btnUpisKnjiga";
            this.btnUpisKnjiga.Size = new System.Drawing.Size(123, 43);
            this.btnUpisKnjiga.TabIndex = 1;
            this.btnUpisKnjiga.Text = "Upis knjiga";
            this.btnUpisKnjiga.UseVisualStyleBackColor = true;
            this.btnUpisKnjiga.Click += new System.EventHandler(this.btnUpisKnjiga_Click);
            // 
            // btnPosudbaKnjige
            // 
            this.btnPosudbaKnjige.Location = new System.Drawing.Point(276, 220);
            this.btnPosudbaKnjige.Name = "btnPosudbaKnjige";
            this.btnPosudbaKnjige.Size = new System.Drawing.Size(123, 43);
            this.btnPosudbaKnjige.TabIndex = 2;
            this.btnPosudbaKnjige.Text = "Posudba Knjige";
            this.btnPosudbaKnjige.UseVisualStyleBackColor = true;
            this.btnPosudbaKnjige.Click += new System.EventHandler(this.btnPosudbaKnjige_Click);
            // 
            // btnStanjeKnjige
            // 
            this.btnStanjeKnjige.Location = new System.Drawing.Point(276, 292);
            this.btnStanjeKnjige.Name = "btnStanjeKnjige";
            this.btnStanjeKnjige.Size = new System.Drawing.Size(123, 41);
            this.btnStanjeKnjige.TabIndex = 3;
            this.btnStanjeKnjige.Text = "Stanje Knjiga";
            this.btnStanjeKnjige.UseVisualStyleBackColor = true;
            this.btnStanjeKnjige.Click += new System.EventHandler(this.btnStanjeKnjige_Click);
            // 
            // btnStanjeKnjigaSkladiste
            // 
            this.btnStanjeKnjigaSkladiste.Location = new System.Drawing.Point(276, 357);
            this.btnStanjeKnjigaSkladiste.Name = "btnStanjeKnjigaSkladiste";
            this.btnStanjeKnjigaSkladiste.Size = new System.Drawing.Size(123, 47);
            this.btnStanjeKnjigaSkladiste.TabIndex = 4;
            this.btnStanjeKnjigaSkladiste.Text = "Stanje Knjiga Skladiste";
            this.btnStanjeKnjigaSkladiste.UseVisualStyleBackColor = true;
            this.btnStanjeKnjigaSkladiste.Click += new System.EventHandler(this.btnStanjeKnjigaSkladiste_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStanjeKnjigaSkladiste);
            this.Controls.Add(this.btnStanjeKnjige);
            this.Controls.Add(this.btnPosudbaKnjige);
            this.Controls.Add(this.btnUpisKnjiga);
            this.Controls.Add(this.btnUpisKorisnika);
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpisKorisnika;
        private System.Windows.Forms.Button btnUpisKnjiga;
        private System.Windows.Forms.Button btnPosudbaKnjige;
        private System.Windows.Forms.Button btnStanjeKnjige;
        private System.Windows.Forms.Button btnStanjeKnjigaSkladiste;
    }
}