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
    public partial class Izmeni_asistenta : Form
    {
        private void puni_combo()
        {
            string strSQL = "Select Sifra_Asist From Asistent";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Sifra_Asist"].ToString());
            }
            con.Close();
        }

        public String Naziv
        {
            get { return textBox1.Text; }
        }

        public String Prezime
        {
            get { return textBox2.Text; }
        }

        public String Godiste
        {
            get { return textBox3.Text; }
        }

        public int Sifra_profesora
        {
            get { return Convert.ToInt32(textBox4.Text); }
        }

        public int Sifra_asistenta
        {
            get { return Convert.ToInt32(comboBox1.Text); }
        }

        public Izmeni_asistenta()
        {
            InitializeComponent();
            puni_combo();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string strSQL = "Select * From Asistent where Sifra_Asist = @sa";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            Command.Parameters.AddWithValue("@sa", comboBox1.Text);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader["Ime"].ToString();
                textBox2.Text = reader["Prezime"].ToString();
                textBox3.Text = reader["Godiste"].ToString();
                textBox4.Text = reader["Sifra_prof"].ToString();
                comboBox1.Text = reader["Sifra_Asist"].ToString();
            }
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Unesite prave vrednosti !", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
