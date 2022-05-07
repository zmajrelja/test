using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_dnevnik
{
    public partial class Sifarnik : Form
    {
        string tabela;
        SqlDataAdapter adapter;
        DataTable podaci;

        public Sifarnik(string tabela)
        {
            InitializeComponent();

            this.tabela = tabela;

        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter($"select * from {tabela}", Konekcija.cs());
            podaci = new DataTable();
            adapter.Fill(podaci);
            dataGridView1.DataSource = podaci;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable menjano = podaci.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (menjano != null)
            {

                adapter.Update(menjano);
                this.Close();
            
            }
        }
    }
}
