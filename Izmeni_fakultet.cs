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
    public partial class Izmeni_fakultet : Form
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

        public String Ime_fak
        {
            get { return textBox1.Text; }

        }

        public String Ime_uni
        {
            get { return textBox2.Text; }
        }

        public String Ulica
        {
            get { return textBox3.Text; }
        }

        public String Telefon
        {
            get { return textBox4.Text; }
        }

        public String mejl
        {
            get { return textBox5.Text; }
        }

        public String Status
        {
            get { return textBox6.Text; }
        }

        public String staro
        {
            get { return comboBox1.Text; }
        }

        public Izmeni_fakultet()
        {
            InitializeComponent();
            puni_combo();
        }

        public String IFK;

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string strSQL = "Select * From Fakultet where Ime_fak = @if";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            Command.Parameters.AddWithValue("@if", comboBox1.Text);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader["Ime_fak"].ToString();
                textBox2.Text = reader["Ime_uni"].ToString();
                textBox3.Text = reader["Ulica"].ToString();
                textBox4.Text = reader["Telefon"].ToString();
                textBox5.Text = reader["E_mail"].ToString();
                textBox6.Text = reader["Status"].ToString();
                comboBox1.Text = reader["Ime_uni"].ToString();
                IFK = reader["Ime_fak"].ToString();
            }

            con.Close();
        }

    }
}
