using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Studentski_sistem___Filip
{
    public partial class Unos_predmeta : Form
    {

        public String naziv
        {
            get { return textBox1.Text; }
        }

        public int brPoena
        {
            get { return Convert.ToInt32(textBox2.Text); }
        }

        public int brSemestara
        {
            get { return Convert.ToInt32(textBox3.Text); }
        }

        public String nacinPolaganja
        {
            get { return textBox4.Text; }
        }

        public int fond
        {
            get { return Convert.ToInt32(textBox5.Text); }
        }

        public int sifProfesora
        {
            get { return Convert.ToInt32(textBox6.Text); }
        }

        public int sifPredmeta
        {
            get { return Convert.ToInt32(textBox7.Text); }
        }

        public Unos_predmeta()
        {
            InitializeComponent();
        }

        private void textBox1_Validating_1(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Polje mora biti popunjeno");
                textBox1.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Validating_1(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider2.SetError(textBox1, "Polje mora biti popunjeno");
                textBox2.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox3_Validating_1(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                errorProvider3.SetError(textBox1, "Polje mora biti popunjeno");
                textBox3.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox4_Validating_1(object sender, CancelEventArgs e)
        {
            if (textBox4.Text == "")
            {
                errorProvider4.SetError(textBox1, "Polje mora biti popunjeno");
                textBox4.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox5_Validating_1(object sender, CancelEventArgs e)
        {
            if (textBox5.Text == "")
            {
                errorProvider5.SetError(textBox1, "Polje mora biti popunjeno");
                textBox5.Focus();
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void textBox6_Validating_1(object sender, CancelEventArgs e)
        {
            if (textBox6.Text == "")
            {
                errorProvider6.SetError(textBox1, "Polje mora biti popunjeno");
                textBox6.Focus();
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void textBox7_Validating_1(object sender, CancelEventArgs e)
        {
            if (textBox7.Text == "")
            {
                errorProvider7.SetError(textBox1, "Polje mora biti popunjeno");
                textBox7.Focus();
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                MessageBox.Show("Uspesno ste dodali predmet", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Doslo je do greske!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
    }
}
