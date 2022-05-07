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
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }
    }
}
