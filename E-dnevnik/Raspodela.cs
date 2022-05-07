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
    public partial class Raspodela : Form
    {
        public Raspodela()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter;
        DataTable podaci;
        int red;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Raspodela_Load(object sender, EventArgs e)
        {
            red = 0;
            adapter = new SqlDataAdapter("select * from raspodela", Konekcija.cs());
            podaci = new DataTable();
            adapter.Fill(podaci);

            刷新();
        }

        public void 刷新()
        {

            btt_begin.Enabled = (red > 1);
            btt_last.Enabled = (red > 0);
            btt_next.Enabled = (red < podaci.Rows.Count - 1);
            btt_end.Enabled = (red < podaci.Rows.Count - 2);
            btt_delete.Enabled = podaci.Rows.Count > 0;
            btt_update.Enabled = podaci.Rows.Count > 0;

            if (red > -1 && red < podaci.Rows.Count)
            {

                adapter = new SqlDataAdapter("select id, naziv from skolska_godina", Konekcija.cs());
                DataTable godina = new DataTable();
                adapter.Fill(godina);

                adapter = new SqlDataAdapter("select id, ime + prezime 'naziv' from osoba where uloga = 2", Konekcija.cs());
                DataTable nastavnik = new DataTable();
                adapter.Fill(nastavnik);

                adapter = new SqlDataAdapter("select id, naziv from predmet", Konekcija.cs());
                DataTable predmet = new DataTable();
                adapter.Fill(predmet);

                adapter = new SqlDataAdapter("select id, STR(razred) + '-' + indeks naziv from odeljenje", Konekcija.cs());
                DataTable odeljenje = new DataTable();
                adapter.Fill(odeljenje);

                comboBox2.DataSource = godina;
                comboBox2.ValueMember = "id";
                comboBox2.DisplayMember = "naziv";
                comboBox2.SelectedValue = podaci.Rows[red]["godina_id"];

                comboBox3.DataSource = nastavnik;
                comboBox3.ValueMember = "id";
                comboBox3.DisplayMember = "naziv";
                comboBox3.SelectedValue = podaci.Rows[red]["nastavnik_id"];

                comboBox4.DataSource = predmet;
                comboBox4.ValueMember = "id";
                comboBox4.DisplayMember = "naziv";
                comboBox4.SelectedValue = podaci.Rows[red]["predmet_id"];

                comboBox5.DataSource = odeljenje;
                comboBox5.ValueMember = "id";
                comboBox5.DisplayMember = "naziv";
                comboBox5.SelectedValue = podaci.Rows[red]["odeljenje_id"];

                textBox1.Text = podaci.Rows[red]["id"].ToString();

            }


            
        
        }

        private void btt_begin_Click(object sender, EventArgs e)
        {
            red = 0;
            刷新();
        }

        private void btt_last_Click(object sender, EventArgs e)
        {
            red--;
            刷新();
        }

        private void btt_nest_Click(object sender, EventArgs e)
        {
            red++;
            刷新();
        }

        private void btt_end_Click(object sender, EventArgs e)
        {
            red = podaci.Rows.Count - 1;
            刷新();
        }

        private void btt_delete_Click(object sender, EventArgs e)
        {
            SqlConnection 命令 = Konekcija.cs();

            SqlCommand naredba = new SqlCommand($"delete from raspodela where id = {textBox1.Text}", 命令);

            命令.Open();
            naredba.ExecuteNonQuery();
            命令.Close();

            podaci.Clear();
            adapter.Fill(podaci);

            red = 0;

            刷新();
        }

        private void btt_insert_Click(object sender, EventArgs e)
        {
            
            SqlConnection 命令 = Konekcija.cs();

            SqlCommand naredba = new SqlCommand($"insert into raspodela(godina_id, nastavnik_id, predmet_id, odeljenje_id) values ({comboBox2.SelectedValue.ToString()}, {comboBox3.SelectedValue.ToString()}, {comboBox4.SelectedValue.ToString()}, {comboBox5.SelectedValue.ToString()})", 命令);

            命令.Open();
            naredba.ExecuteNonQuery();
            命令.Close();

            podaci.Clear();
            adapter.Fill(podaci);

            red = 0;

            刷新();
            
        }

        private void btt_update_Click(object sender, EventArgs e)
        {
            SqlConnection 命令 = Konekcija.cs();

            SqlCommand naredba = new SqlCommand($"update raspodela set godina_id = {comboBox2.SelectedValue.ToString()}, " +
                $"nastavnik_id ={comboBox3.SelectedValue.ToString()}, " +
                $"predmet_id = {comboBox4.SelectedValue.ToString()}, " +
                $"odeljenje_id = {comboBox5.SelectedValue.ToString()}" +
                $"where id = {textBox1.Text}", 命令);

            命令.Open();
            naredba.ExecuteNonQuery();
            命令.Close();

            podaci.Clear();
            adapter.Fill(podaci);

            red = 0;

            刷新();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
