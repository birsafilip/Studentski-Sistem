using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentski_sistem___Filip
{
    public partial class Prikaz_univerziteta : Form
    {
        public Prikaz_univerziteta()
        {
            InitializeComponent();
        }

        private void Prikaz_univerziteta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentski_sistemDataSet.Univerzitet' table. You can move, or remove it, as needed.
            this.univerzitetTableAdapter.Fill(this.studentski_sistemDataSet.Univerzitet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
