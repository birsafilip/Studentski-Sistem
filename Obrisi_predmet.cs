using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Studentski_sistem___Filip
{
    public partial class Obrisi_predmet : Form
    {
        private void puni_combo()
        {
            string strSQL = "Select Naziv From Predmet";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Naziv"].ToString());
            }
            con.Close();
        }

        public String Nacin_pol
        {
            get { return textBox1.Text; }
        }

        public String Broj_sem
        {
            get { return textBox2.Text; }
        }

        public String Naziv_pred
        {
            get { return comboBox1.Text; }
        }

        public Obrisi_predmet()
        {
            InitializeComponent();
            puni_combo();
        }

        public String OBP;

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string strSQL = "Select * From Predmet where Naziv = @naz";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            Command.Parameters.AddWithValue("@naz", comboBox1.Text);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader["Nacin_polaganja"].ToString();
                textBox2.Text = reader["Br_semestra"].ToString();
                comboBox1.Text = reader["Naziv"].ToString();
                OBP = reader["Sifra_pred"].ToString();
            }

            con.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Izaberite naziv predmeta!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
    }
}
