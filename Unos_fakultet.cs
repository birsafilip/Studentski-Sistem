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
    public partial class Unos_fakulteta : Form
    {
        private void puni_combo()
        {
            string strSQL = "Select distinct Ime_uni From Univerzitet";
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

        public String imef
        {
            get { return textBox1.Text; }
        }

        public String imeu
        {
            get { return comboBox1.Text; }
        }

        public String ul
        {

            get { return textBox2.Text; }
        }

        public String tel
        {
            get { return textBox3.Text; }
        }

        public String em
        {
            get { return textBox4.Text; }
        }

        public String st
        {
            get { return textBox5.Text; }
        }

        public int sp
        {
            get { return Convert.ToInt32(textBox6.Text); }
        }

        public Unos_fakulteta()
        {
            InitializeComponent();
            puni_combo();
        }

        public String IKF
        {
            get { return comboBox1.Text; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "")
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Unesite podatke!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
