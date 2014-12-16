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
    public partial class Prikazi_profesorovog_asistenta : Form
    {
        int sifra_prof;

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

        public Prikazi_profesorovog_asistenta()
        {
            InitializeComponent();
            puni_combo();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string strSQL = "Select Sifra_prof From Profesor where Prezime = @prez";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            Command.Parameters.AddWithValue("@prez", comboBox1.Text);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                sifra_prof = Convert.ToInt32(reader["Sifra_Prof"].ToString());
            }
            con.Close();
            strSQL = "Select * From Asistent where Sifra_Prof = @sp";
            con.Open();
            Command = new SqlCommand(strSQL, con);

            Command.Parameters.AddWithValue("@sp", sifra_prof);
            reader = Command.ExecuteReader();

            while (reader.Read())
            {
                int b = Convert.ToInt32(reader["Sifra_Asist"].ToString());
                int a = Convert.ToInt32(reader["Sifra_Prof"].ToString());
                String c = reader["Ime"].ToString();
                String d = reader["Prezime"].ToString();
                String f = reader["Godiste"].ToString();
                dataGridView1.Rows.Insert(0, a, b, c, d, f);
            }
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }     

    }
}
