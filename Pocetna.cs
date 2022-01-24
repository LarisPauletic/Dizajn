using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaBiblioteka
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnUpisKorisnika_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void btnUpisKnjiga_Click(object sender, EventArgs e)
        {
            UpisKnjiga f2 = new UpisKnjiga();
            f2.ShowDialog();
        }

        private void btnPosudbaKnjige_Click(object sender, EventArgs e)
        {
            PosudbaKnjige f2 = new PosudbaKnjige();
            f2.ShowDialog();
        }

        private void btnStanjeKnjige_Click(object sender, EventArgs e)
        {
            StanjeKnjiga f2 = new StanjeKnjiga();
            f2.ShowDialog();
        }

        private void btnStanjeKnjigaSkladiste_Click(object sender, EventArgs e)
        {
            StanjeKnjigaSkladište f2 = new StanjeKnjigaSkladište();
            f2.ShowDialog();
        }
    }
}
