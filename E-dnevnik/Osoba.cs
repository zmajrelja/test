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
    public partial class Osoba : Form
    {
        public Osoba()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter;
        DataTable podaci;
        int red;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Osoba_Load(object sender, EventArgs e)
        {

            adapter = new SqlDataAdapter("select * from osoba", Konekcija.cs());
            podaci = new DataTable();
            adapter.Fill(podaci);
            red = 0;

            refresh();

        }

        void refresh()
        {

            btt_begin.Enabled = (red > 1);
            btt_last.Enabled = (red > 0);
            btt_next.Enabled = (red < podaci.Rows.Count - 1);
            btt_end.Enabled = (red < podaci.Rows.Count - 2);
            btt_delete.Enabled = podaci.Rows.Count > 0;
            btt_update.Enabled = podaci.Rows.Count > 0;

            if (red > -1 && red < podaci.Rows.Count)
            {
                tb_ID.Text = podaci.Rows[red]["id"].ToString();
                tb_ime.Text = podaci.Rows[red]["ime"].ToString();
                tb_prezime.Text = podaci.Rows[red]["prezime"].ToString();
                tb_adresa.Text = podaci.Rows[red]["adresa"].ToString();
                tb_email.Text = podaci.Rows[red]["email"].ToString();
                tb_jmbg.Text = podaci.Rows[red]["jmbg"].ToString();
                tb_password.Text = podaci.Rows[red]["pass"].ToString();
                tb_uloga.Text = podaci.Rows[red]["uloga"].ToString();
            }

        }

        private void btt_begin_Click(object sender, EventArgs e)
        {
            red = 0;
            refresh();
        }

        private void btt_end_Click(object sender, EventArgs e)
        {
            red = podaci.Rows.Count - 1;
            refresh();
        }

        private void btt_next_Click(object sender, EventArgs e)
        {
            red++;

            refresh();
        }

        private void btt_last_Click(object sender, EventArgs e)
        {
            red--;
            refresh();
        }

        private void btt_insert_Click(object sender, EventArgs e)
        {

            SqlConnection 命令 = Konekcija.cs();

            SqlCommand naredba = new SqlCommand($"insert into osoba values ('{tb_ime.Text}', '{tb_prezime.Text}', '{tb_adresa.Text}', '{tb_jmbg.Text}', '{tb_email.Text}', '{tb_password.Text}', {tb_uloga.Text})", 命令);

            命令.Open();
            naredba.ExecuteNonQuery();
            命令.Close();

            podaci.Clear();
            adapter.Fill(podaci);

            red = 0;

            refresh();

        }

        private void btt_update_Click(object sender, EventArgs e)
        {
            SqlConnection 命令 = Konekcija.cs();

            SqlCommand naredba = new SqlCommand($"update osoba set ime = '{tb_ime.Text}', prezime = '{tb_prezime.Text}', " +
                $"email = '{tb_email.Text}', adresa = '{tb_adresa.Text}', jmbg = '{tb_jmbg.Text}', " +
                $"pass = '{tb_password.Text}', uloga = {tb_uloga.Text} where id = {tb_ID.Text}", 命令);

            命令.Open();
            naredba.ExecuteNonQuery();
            命令.Close();

            podaci.Clear();
            adapter.Fill(podaci);

            red = 0;

            refresh();

        }

        private void btt_delete_Click(object sender, EventArgs e)
        {
            SqlConnection 命令 = Konekcija.cs();

            SqlCommand naredba = new SqlCommand($"delete from osoba where id = {tb_ID.Text}", 命令);

            命令.Open();
            naredba.ExecuteNonQuery();
            命令.Close();

            podaci.Clear();
            adapter.Fill(podaci);

            red = 0;

            refresh();

        }
    }
}
