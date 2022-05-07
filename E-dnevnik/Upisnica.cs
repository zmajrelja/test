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
    public partial class Upisnica : Form
    {
        public DataTable ptabela(string naredba)
        {

            DataTable tabela = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, Konekcija.cs());
            adapter.Fill(tabela);
            return tabela;
        
        }

        public void pcombo(ComboBox a, string naredba)
        {

            a.DisplayMember = "naziv";
            a.ValueMember = "id";
            a.DataSource = ptabela(naredba);

        }


        public Upisnica()
        {
            InitializeComponent();
        }

        private void Upisnica_Load(object sender, EventArgs e)
        {
            
            pcombo(comboBox1, "select * from skolska_godina");
            comboBox1.SelectedIndex = -1;

        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex > -1)
            {
                
                comboBox2.Enabled = true;
                pcombo(comboBox2, $"select id, str(razred) + '/' + indeks  as 'naziv' from odeljenje where godina_id = {comboBox1.SelectedValue}");
            }
            else
            {
                comboBox2.DataSource = null;
                comboBox2.Enabled = false;
            }

            comboBox2.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox2.SelectedIndex > -1)
            {
                comboBox3.SelectedIndex = -1;
                comboBox3.Enabled = true;
                pcombo(comboBox3, $"select osoba_id as id, ime + ' ' + prezime as naziv from Upisnica join Osoba on(Osoba.id = osoba_id)");

                
                dataGridView1.DataSource = ptabela($"select upisnica.id as upis_id, osoba_id as id, ime + ' ' + prezime as naziv from Upisnica join Osoba on(Osoba.id = osoba_id) where odeljenje_id = {comboBox2.SelectedValue}");
                dataGridView1.Columns["upis_id"].Visible = false;

            }
            else
            {
                comboBox3.DataSource = null;
                comboBox3.Enabled = false;
                dataGridView1.DataSource = null;
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            if (dataGridView1.CurrentRow.Index > -1 && dataGridView1.Rows.Count > 0)
                comboBox3.SelectedValue = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id"].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection 命令 = Konekcija.cs();

            SqlCommand naredba = new SqlCommand($"insert into upisnica(odeljenje_id, osoba_id) values ({comboBox2.SelectedValue.ToString()}, {comboBox3.SelectedValue.ToString()})", 命令);

            命令.Open();
            naredba.ExecuteNonQuery();
            命令.Close();

            dataGridView1.DataSource = ptabela($"select upisnica.id as upis_id, osoba_id as id, ime + ' ' + prezime as naziv from Upisnica join Osoba on(Osoba.id = osoba_id) where odeljenje_id = {comboBox2.SelectedValue}");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection 命令 = Konekcija.cs();

            SqlCommand naredba = new SqlCommand($"update Upisnica set odeljenje_id = {comboBox2.SelectedValue}, osoba_id = {comboBox3.SelectedValue} where id = {dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["upis_id"].Value}", 命令);

            命令.Open();
            naredba.ExecuteNonQuery();
            命令.Close();

            dataGridView1.DataSource = ptabela($"select upisnica.id as upis_id, osoba_id as id, ime + ' ' + prezime as naziv from Upisnica join Osoba on(Osoba.id = osoba_id) where odeljenje_id = {comboBox2.SelectedValue}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection 命令 = Konekcija.cs();

            SqlCommand naredba = new SqlCommand($"delete from Upisnica where id = {dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["upis_id"].Value}", 命令);

            命令.Open();
            naredba.ExecuteNonQuery();
            命令.Close();

            dataGridView1.DataSource = ptabela($"select upisnica.id as upis_id, osoba_id as id, ime + ' ' + prezime as naziv from Upisnica join Osoba on(Osoba.id = osoba_id) where odeljenje_id = {comboBox2.SelectedValue}");

        }
    }
}
