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
    public partial class Izmeni_profesora : Form
    {
        private void puni_combo()
        {
            string strSQL = "Select Prezime From Profesor";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Prezime"].ToString());
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

        public Izmeni_profesora()
        {
            InitializeComponent();
            puni_combo();
        }
        public String PR;

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
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
            string strSQL = "Select * From Profesor where Prezime = @pr";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            Command.Parameters.AddWithValue("@pr", comboBox1.Text);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader["Ime"].ToString();
                textBox2.Text = reader["Prezime"].ToString();
                textBox3.Text = reader["Godiste"].ToString();
                comboBox1.Text = reader["Prezime"].ToString();
                
            }
            con.Close();
        }

    }
}

