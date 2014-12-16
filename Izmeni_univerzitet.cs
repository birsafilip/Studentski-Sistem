using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Studentski_sistem___Filip
{
    public partial class Izmeni_univerzitet : Form
    {
        private void puni_combo()
        {
            string strSQL = "Select Ime_uni From Univerzitet";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Ime_uni"].ToString());
            }
            con.Close();
        }

        public String Naziv
        {
            get { return textBox1.Text; }
        }

        public String Mesto
        {

            get { return textBox2.Text; }
        }

        public String staro
        {

            get { return comboBox1.Text; }
        }

        public Izmeni_univerzitet()
        {
            InitializeComponent();
            puni_combo();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string strSQL = "Select * From Univerzitet where Ime_uni = @iu";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            Command.Parameters.AddWithValue("@iu", comboBox1.Text);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader["Ime_uni"].ToString();
                textBox2.Text = reader["Mesto"].ToString();
                comboBox1.Text = reader["Ime_uni"].ToString();
            }

            con.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Unesite trazene vrednosti !", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

