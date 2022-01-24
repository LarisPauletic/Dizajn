namespace AplikacijaBiblioteka
{
    partial class UpisKnjiga
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
            this.btnUpisKnj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxIdKnj = new System.Windows.Forms.TextBox();
            this.txtBxNazivKnj = new System.Windows.Forms.TextBox();
            this.txtBxAutorKnj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpisKnj
            // 
            this.btnUpisKnj.Location = new System.Drawing.Point(436, 150);
            this.btnUpisKnj.Name = "btnUpisKnj";
            this.btnUpisKnj.Size = new System.Drawing.Size(97, 41);
            this.btnUpisKnj.TabIndex = 0;
            this.btnUpisKnj.Text = "Upis";
            this.btnUpisKnj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv knjige";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autor knjige";
            // 
            // txtBxIdKnj
            // 
            this.txtBxIdKnj.Location = new System.Drawing.Point(261, 101);
            this.txtBxIdKnj.Name = "txtBxIdKnj";
            this.txtBxIdKnj.Size = new System.Drawing.Size(100, 20);
            this.txtBxIdKnj.TabIndex = 4;
            // 
            // txtBxNazivKnj
            // 
            this.txtBxNazivKnj.Location = new System.Drawing.Point(261, 161);
            this.txtBxNazivKnj.Name = "txtBxNazivKnj";
            this.txtBxNazivKnj.Size = new System.Drawing.Size(100, 20);
            this.txtBxNazivKnj.TabIndex = 5;
            // 
            // txtBxAutorKnj
            // 
            this.txtBxAutorKnj.Location = new System.Drawing.Point(261, 230);
            this.txtBxAutorKnj.Name = "txtBxAutorKnj";
            this.txtBxAutorKnj.Size = new System.Drawing.Size(100, 20);
            this.txtBxAutorKnj.TabIndex = 6;
            // 
            // UpisKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxAutorKnj);
            this.Controls.Add(this.txtBxNazivKnj);
            this.Controls.Add(this.txtBxIdKnj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpisKnj);
            this.Name = "UpisKnjiga";
            this.Text = "UpisKnjiga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpisKnj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxIdKnj;
        private System.Windows.Forms.TextBox txtBxNazivKnj;
        private System.Windows.Forms.TextBox txtBxAutorKnj;
    }
}