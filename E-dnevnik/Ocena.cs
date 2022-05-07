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
    public partial class Ocena : Form
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

        public Ocena()
        {
            InitializeComponent();
        }

        private void Ocena_Load(object sender, EventArgs e)
        {
            
            pcombo(comboBox1, "select * from skolska_godina");
            comboBox1.SelectedIndex = -1;

            for (int i = 1; i < 6; i++)
                comboBox6.Items.Add(i);

            comboBox6.SelectedIndex = 4;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex > -1)
            {
                pcombo(comboBox2, $"select distinct nastavnik_id as id, osoba.ime + osoba.prezime as naziv from raspodela join osoba on osoba.id = nastavnik_id where godina_id = {comboBox1.SelectedValue} and uloga = 2");
                comboBox2.SelectedIndex = -1;
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.DataSource = null;
                comboBox2.Enabled = false;
            }

            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
            {
                
                pcombo(comboBox3, $"select distinct predmet.id as id, predmet.naziv as naziv from raspodela join predmet on predmet.id = predmet_id  where nastavnik_id = {comboBox2.SelectedValue} and godina_id = {comboBox1.SelectedValue}");
                comboBox3.SelectedIndex = -1;
                comboBox3.Enabled = true;
            }
            else
            {
                comboBox3.DataSource = null;
                comboBox3.Enabled = false;
            }

            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox4.SelectedIndex > -1)
            {
                dataGridView1.DataSource = ptabela($"select ocena.id as id ,ime + ' ' + prezime as naziv, ocena, datum from Ocena join Osoba on Osoba.id = ucenik_id join raspodela on raspodela.id = raspodela_id where godina_id = {comboBox1.SelectedValue}and nastavnik_id = {comboBox2.SelectedValue} and predmet_id = {comboBox3.SelectedValue} and odeljenje_id = {comboBox4.SelectedValue}");
                
                pcombo(comboBox5,$"select osoba.id as id, ime + ' ' + prezime as naziv from upisnica join osoba on osoba.id = osoba_id where odeljenje_id = {comboBox4.SelectedValue}");
                comboBox5.Enabled = true;
                comboBox6.Enabled = true;
            }
            else
            {
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;

                dataGridView1.DataSource = null;
            
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex > -1)
            {
                
                pcombo(comboBox4, $"select odeljenje_id as id, STR(razred) + '/' + indeks as naziv from raspodela join Odeljenje on odeljenje_id = odeljenje.id where nastavnik_id = {comboBox2.SelectedValue} and raspodela.godina_id = {comboBox1.SelectedValue} and predmet_id = {comboBox3.SelectedValue}");
                comboBox4.SelectedIndex = -1;
                comboBox4.Enabled = true;

            }
            else
            {
                comboBox4.DataSource = null;
                comboBox4.Enabled = false;
                dataGridView1.DataSource = null;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection 命令 = Konekcija.cs();
            
            string raspodela_id = ptabela($"select id from raspodela where godina_id = {comboBox1.SelectedValue}and nastavnik_id = {comboBox2.SelectedValue} and predmet_id = {comboBox3.SelectedValue} and odeljenje_id = {comboBox4.SelectedValue}").Rows[0]["id"].ToString();
            
            SqlCommand naredba = new SqlCommand($"insert into ocena values('{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', {raspodela_id}, {comboBox6.SelectedItem.ToString()}, { comboBox5.SelectedValue})", 命令);

            命令.Open();
            naredba.ExecuteNonQuery();
            命令.Close();

            dataGridView1.DataSource = ptabela($"select ocena.id as id ,ime + ' ' + prezime as naziv, ocena, datum from Ocena join Osoba on Osoba.id = ucenik_id join raspodela on raspodela.id = raspodela_id where godina_id = {comboBox1.SelectedValue}and nastavnik_id = {comboBox2.SelectedValue} and predmet_id = {comboBox3.SelectedValue} and odeljenje_id = {comboBox4.SelectedValue}");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string raspodela_id = ptabela($"select id from raspodela where godina_id = {comboBox1.SelectedValue}and nastavnik_id = {comboBox2.SelectedValue} and predmet_id = {comboBox3.SelectedValue} and odeljenje_id = {comboBox4.SelectedValue}").Rows[0]["id"].ToString();
            
            SqlConnection 命令 = Konekcija.cs();

            SqlCommand naredba = new SqlCommand($"update ocena " +
                $"set datum = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', " +
                $"ocena = {comboBox6.SelectedIndex + 1}, " +
                $"ucenik_id = {comboBox5.SelectedValue.ToString()}, " +
                $"raspodela_id = {raspodela_id} " +
                $"where id = {dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id"].Value.ToString()}", 命令);

            命令.Open();
            naredba.ExecuteNonQuery();
            命令.Close();

            dataGridView1.DataSource = ptabela($"select ocena.id as id ,ime + ' ' + prezime as naziv, ocena, datum from Ocena join Osoba on Osoba.id = ucenik_id join raspodela on raspodela.id = raspodela_id where godina_id = {comboBox1.SelectedValue}and nastavnik_id = {comboBox2.SelectedValue} and predmet_id = {comboBox3.SelectedValue} and odeljenje_id = {comboBox4.SelectedValue}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string raspodela_id = ptabela($"select id from raspodela where godina_id = {comboBox1.SelectedValue}and nastavnik_id = {comboBox2.SelectedValue} and predmet_id = {comboBox3.SelectedValue} and odeljenje_id = {comboBox4.SelectedValue}").Rows[0]["id"].ToString();

            SqlConnection 命令 = Konekcija.cs();

            SqlCommand naredba = new SqlCommand($"delete from Ocena where id = {dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id"].Value.ToString()}", 命令);

            命令.Open();
            naredba.ExecuteNonQuery();
            命令.Close();
            dataGridView1.DataSource = ptabela($"select ocena.id as id ,ime + ' ' + prezime as naziv, ocena, datum from Ocena join Osoba on Osoba.id = ucenik_id join raspodela on raspodela.id = raspodela_id where godina_id = {comboBox1.SelectedValue}and nastavnik_id = {comboBox2.SelectedValue} and predmet_id = {comboBox3.SelectedValue} and odeljenje_id = {comboBox4.SelectedValue}");
        }
    }
}
