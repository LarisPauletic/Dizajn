namespace AplikacijaBiblioteka
{
    partial class Form1
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
            this.txtBxIme = new System.Windows.Forms.TextBox();
            this.txtBxPrezime = new System.Windows.Forms.TextBox();
            this.txtBxId = new System.Windows.Forms.TextBox();
            this.btnUpis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // txtBxIme
            // 
            this.txtBxIme.Location = new System.Drawing.Point(239, 104);
            this.txtBxIme.Name = "txtBxIme";
            this.txtBxIme.Size = new System.Drawing.Size(100, 20);
            this.txtBxIme.TabIndex = 3;
            this.txtBxIme.TextChanged += new System.EventHandler(this.txtBxIme_TextChanged);
            // 
            // txtBxPrezime
            // 
            this.txtBxPrezime.Location = new System.Drawing.Point(239, 167);
            this.txtBxPrezime.Name = "txtBxPrezime";
            this.txtBxPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtBxPrezime.TabIndex = 4;
            // 
            // txtBxId
            // 
            this.txtBxId.Location = new System.Drawing.Point(239, 238);
            this.txtBxId.Name = "txtBxId";
            this.txtBxId.Size = new System.Drawing.Size(100, 20);
            this.txtBxId.TabIndex = 5;
            // 
            // btnUpis
            // 
            this.btnUpis.Location = new System.Drawing.Point(426, 155);
            this.btnUpis.Name = "btnUpis";
            this.btnUpis.Size = new System.Drawing.Size(86, 43);
            this.btnUpis.TabIndex = 6;
            this.btnUpis.Text = "Upis";
            this.btnUpis.UseVisualStyleBackColor = true;
            this.btnUpis.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpis);
            this.Controls.Add(this.txtBxId);
            this.Controls.Add(this.txtBxPrezime);
            this.Controls.Add(this.txtBxIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxIme;
        private System.Windows.Forms.TextBox txtBxPrezime;
        private System.Windows.Forms.TextBox txtBxId;
        private System.Windows.Forms.Button btnUpis;
    }
}

