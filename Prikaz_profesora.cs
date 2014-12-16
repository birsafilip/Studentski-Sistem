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
    public partial class Prikaz_profesora : Form
    {
        public Prikaz_profesora()
        {
            InitializeComponent();
        }

        private void Prikaz_profesora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentski_sistemDataSet.Profesor' table. You can move, or remove it, as needed.
            this.profesorTableAdapter.Fill(this.studentski_sistemDataSet.Profesor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
