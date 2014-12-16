﻿using System;
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
    public partial class Obrisi_asistenta : Form
    {
        private void puni_combo()
        {
            string strSQL = "Select Prezime From Asistent";
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

        public String Ime_asist
        {
            get { return textBox1.Text; }
        }

        public String Godiste
        {
            get { return textBox2.Text; }
        }

        public String Prezime
        {
            get { return comboBox1.Text; }
        }

        public Obrisi_asistenta()
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
            if (comboBox1.Text != "")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Izaberite ime asistenta", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string strSQL = "Select * From Asistent where Prezime = @pr";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            Command.Parameters.AddWithValue("@pr", comboBox1.Text);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader["Ime"].ToString();
                textBox2.Text = reader["Godiste"].ToString();
                comboBox1.Text = reader["Prezime"].ToString();
            }
            con.Close();
        }
     
    }
}
