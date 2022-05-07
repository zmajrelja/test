using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_dnevnik
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form osoba = new Osoba();
            this.Hide();
            osoba.ShowDialog();
            this.Show();
        }

        private void smeroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new Sifarnik("Smer");
            forma.ShowDialog();
        }

        private void skolskeGodineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new Sifarnik("Skolska_godina");
            forma.ShowDialog();
        }

        private void predmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new Sifarnik("Premet");
            forma.ShowDialog();
        }

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new Sifarnik("Osoba");
            forma.ShowDialog();
        }

        private void raspodelaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form forma = new Raspodela();
            forma.ShowDialog();
        }

        private void upisnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new Upisnica();
            forma.ShowDialog();
        }

        private void ocenaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form forma = new Ocena();
            forma.ShowDialog();
        }
    }
}
