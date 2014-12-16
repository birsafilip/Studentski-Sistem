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
    public partial class Unos_asistenta : Form
    {

        public String ime
        {
            get { return textBox1.Text; }
        }

        public String prezime
        {
            get { return textBox2.Text; }
        }

        public String godiste
        {
            get { return textBox3.Text; }
        }

        public int sifAsistenta
        {
            get { return Convert.ToInt32(textBox4.Text); }
        }

        public int sifProfesora
        {
            get { return Convert.ToInt32(textBox5.Text); }
        }

        public Unos_asistenta()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                MessageBox.Show("Uspesno ste uneli asistenta", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Doslo je do greske!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
