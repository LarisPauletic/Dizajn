namespace AplikacijaBiblioteka
{
    partial class StanjeKnjigaSkladište
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxIdKnj = new System.Windows.Forms.TextBox();
            this.txtBxAutorKnj = new System.Windows.Forms.TextBox();
            this.txtBxNazivKnj = new System.Windows.Forms.TextBox();
            this.btnPretraziStanje = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPosudenihKnjiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID knjige";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naziv";
            // 
            // txtBxIdKnj
            // 
            this.txtBxIdKnj.Location = new System.Drawing.Point(281, 295);
            this.txtBxIdKnj.Name = "txtBxIdKnj";
            this.txtBxIdKnj.Size = new System.Drawing.Size(100, 20);
            this.txtBxIdKnj.TabIndex = 4;
            // 
            // txtBxAutorKnj
            // 
            this.txtBxAutorKnj.Location = new System.Drawing.Point(281, 348);
            this.txtBxAutorKnj.Name = "txtBxAutorKnj";
            this.txtBxAutorKnj.Size = new System.Drawing.Size(100, 20);
            this.txtBxAutorKnj.TabIndex = 5;
            // 
            // txtBxNazivKnj
            // 
            this.txtBxNazivKnj.Location = new System.Drawing.Point(281, 397);
            this.txtBxNazivKnj.Name = "txtBxNazivKnj";
            this.txtBxNazivKnj.Size = new System.Drawing.Size(100, 20);
            this.txtBxNazivKnj.TabIndex = 6;
            // 
            // btnPretraziStanje
            // 
            this.btnPretraziStanje.Location = new System.Drawing.Point(453, 328);
            this.btnPretraziStanje.Name = "btnPretraziStanje";
            this.btnPretraziStanje.Size = new System.Drawing.Size(143, 59);
            this.btnPretraziStanje.TabIndex = 7;
            this.btnPretraziStanje.Text = "Pretrazi";
            this.btnPretraziStanje.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stanje,
            this.BrojPosudenihKnjiga});
            this.dataGridView1.Location = new System.Drawing.Point(191, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 177);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Stanje
            // 
            this.Stanje.HeaderText = "Stanje";
            this.Stanje.Name = "Stanje";
            // 
            // BrojPosudenihKnjiga
            // 
            this.BrojPosudenihKnjiga.HeaderText = "Broj posuđenih knjiga";
            this.BrojPosudenihKnjiga.Name = "BrojPosudenihKnjiga";
            this.BrojPosudenihKnjiga.Width = 200;
            // 
            // StanjeKnjigaSkladište
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPretraziStanje);
            this.Controls.Add(this.txtBxNazivKnj);
            this.Controls.Add(this.txtBxAutorKnj);
            this.Controls.Add(this.txtBxIdKnj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StanjeKnjigaSkladište";
            this.Text = "StanjeKnjigaSkladište";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxIdKnj;
        private System.Windows.Forms.TextBox txtBxAutorKnj;
        private System.Windows.Forms.TextBox txtBxNazivKnj;
        private System.Windows.Forms.Button btnPretraziStanje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPosudenihKnjiga;
    }
}