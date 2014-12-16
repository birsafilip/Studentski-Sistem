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
    public partial class Obrisi_fakultet : Form
    {
        private void puni_combo()
        {
            string strSQL = "Select Ime_fak From Fakultet";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Ime_fak"].ToString());
            }
            con.Close();
        }

        public String Ime_fakulteta
        {
            get { return textBox1.Text; }
        }

        public String Naziv_fak
        {
            get { return comboBox1.Text; }
        }

        public Obrisi_fakultet()
        {
            InitializeComponent();
            puni_combo();
        }

        public String IK;

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string strSQL = "Select * From Fakultet where Ime_fak = @id";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            Command.Parameters.AddWithValue("@id", comboBox1.Text);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader["Ime_fak"].ToString();
                comboBox1.Text = reader["Ime_fak"].ToString();
                IK = reader["Ime_fak"].ToString();
            }

            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Izaberite naziv fakulteta!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
    }
}