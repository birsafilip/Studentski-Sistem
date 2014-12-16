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
    public partial class Izmeni_predmet : Form
    {
        private void puni_combo()
        {
            string strSQL = "Select Sifra_pred From Predmet";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Sifra_pred"].ToString());
            }
            con.Close();
        }

        public String Naziv
        {
            get { return textBox1.Text; }
        }

        public String Nacin_polaganja
        {
            get { return textBox2.Text; }
        }

        public String Broj_semestra
        {
            get { return textBox3.Text; }
        }

        public int Broj_poena
        {
            get { return Convert.ToInt32(textBox4.Text); }
        }

        public String Fond
        {
            get { return textBox5.Text; }
        }

        public int Sifra_predmeta
        {
            get { return Convert.ToInt32(comboBox1.Text); }
        }

        public int Sifra_profesora
        {
            get { return Convert.ToInt32(textBox6.Text); }
        }


        public Izmeni_predmet()
        {
            InitializeComponent();
            puni_combo();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Unesite prave vrednosti !", "Obavestenje");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string strSQL = "Select * From Predmet where Sifra_pred = @sp";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            Command.Parameters.AddWithValue("@sp", comboBox1.Text);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader["Naziv"].ToString();
                textBox2.Text = reader["Nacin_polaganja"].ToString();
                textBox3.Text = reader["Br_semestra"].ToString();
                textBox4.Text = reader["Br_ECTS_bodova"].ToString();
                textBox5.Text = reader["Fond_casova"].ToString();
                textBox6.Text = reader["Sifra_prof"].ToString();
                comboBox1.Text = reader["Sifra_pred"].ToString();
            }

            con.Close();

        }

    }
}