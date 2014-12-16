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
    public partial class Prikaz_asistenta : Form
    {
        public Prikaz_asistenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prikaz_asistenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentski_sistemDataSet.Asistent' table. You can move, or remove it, as needed.
            this.asistentTableAdapter.Fill(this.studentski_sistemDataSet.Asistent);

        }
    }
}
