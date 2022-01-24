namespace AplikacijaBiblioteka
{
    partial class PosudbaKnjige
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
            this.dateTimePickerPosudba = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVracanje = new System.Windows.Forms.DateTimePicker();
            this.txtBxIdKnjige = new System.Windows.Forms.TextBox();
            this.txtBxIdKorisnika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpisPosudba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerPosudba
            // 
            this.dateTimePickerPosudba.Location = new System.Drawing.Point(286, 86);
            this.dateTimePickerPosudba.Name = "dateTimePickerPosudba";
            this.dateTimePickerPosudba.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPosudba.TabIndex = 0;
            // 
            // dateTimePickerVracanje
            // 
            this.dateTimePickerVracanje.Location = new System.Drawing.Point(286, 160);
            this.dateTimePickerVracanje.Name = "dateTimePickerVracanje";
            this.dateTimePickerVracanje.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVracanje.TabIndex = 1;
            // 
            // txtBxIdKnjige
            // 
            this.txtBxIdKnjige.Location = new System.Drawing.Point(286, 219);
            this.txtBxIdKnjige.Name = "txtBxIdKnjige";
            this.txtBxIdKnjige.Size = new System.Drawing.Size(100, 20);
            this.txtBxIdKnjige.TabIndex = 2;
            // 
            // txtBxIdKorisnika
            // 
            this.txtBxIdKorisnika.Location = new System.Drawing.Point(286, 277);
            this.txtBxIdKorisnika.Name = "txtBxIdKorisnika";
            this.txtBxIdKorisnika.Size = new System.Drawing.Size(100, 20);
            this.txtBxIdKorisnika.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posudba knjige";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vraćanje knjige";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID knjige";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID korisinika";
            // 
            // btnUpisPosudba
            // 
            this.btnUpisPosudba.Location = new System.Drawing.Point(563, 160);
            this.btnUpisPosudba.Name = "btnUpisPosudba";
            this.btnUpisPosudba.Size = new System.Drawing.Size(115, 51);
            this.btnUpisPosudba.TabIndex = 8;
            this.btnUpisPosudba.Text = "Upis";
            this.btnUpisPosudba.UseVisualStyleBackColor = true;
            // 
            // PosudbaKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpisPosudba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxIdKorisnika);
            this.Controls.Add(this.txtBxIdKnjige);
            this.Controls.Add(this.dateTimePickerVracanje);
            this.Controls.Add(this.dateTimePickerPosudba);
            this.Name = "PosudbaKnjige";
            this.Text = "PosudbaKnjige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerPosudba;
        private System.Windows.Forms.DateTimePicker dateTimePickerVracanje;
        private System.Windows.Forms.TextBox txtBxIdKnjige;
        private System.Windows.Forms.TextBox txtBxIdKorisnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpisPosudba;
    }
}