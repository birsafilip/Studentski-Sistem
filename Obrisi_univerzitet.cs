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
    public partial class Obrisi_univerzitet : Form
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

        public String Naziv_uni
        {
            get { return comboBox1.Text; }
        }

        public String Mesto
        {
            get { return textBox1.Text; }
        }

        public Obrisi_univerzitet()
        {
            InitializeComponent();
            puni_combo();
        }

        public String IDU;

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string strSQL = "Select * From Univerzitet where Ime_uni = @Ime_uni";
            SqlConnection con = new SqlConnection(Konekcija.cnn);
            con.Open();
            SqlCommand Command = new SqlCommand(strSQL, con);

            Command.Parameters.AddWithValue("@Ime_uni", comboBox1.Text);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader["Mesto"].ToString();
                comboBox1.Text = reader["Ime_uni"].ToString();
                IDU = reader["Ime_uni"].ToString();
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
                MessageBox.Show("Unesite pravu vrednost!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
