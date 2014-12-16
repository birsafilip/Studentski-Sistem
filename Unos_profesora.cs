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
    public partial class Unos_profesora : Form
    {
        public String sifra
        {
            get { return textBox1.Text; }
        }

        public String ime
        {
            get { return textBox2.Text; }
        }

        public String prezime
        {
            get { return textBox3.Text; }
        }

        public String godiste
        {
            get { return textBox4.Text; }
        }

        public Unos_profesora()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                MessageBox.Show("Uspesno ste dodali profesor", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Doslo je do greske!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
