namespace Studentski_sistem___Filip
{
    partial class Prikazi_profesorovog_asistenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sifra_profesora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra_asistenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime_asistenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime_asistenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sifra_profesora,
            this.Sifra_asistenta,
            this.Ime_asistenta,
            this.Prezime_asistenta,
            this.Godiste});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // Sifra_profesora
            // 
            this.Sifra_profesora.HeaderText = "Sifra profesora";
            this.Sifra_profesora.Name = "Sifra_profesora";
            this.Sifra_profesora.ReadOnly = true;
            // 
            // Sifra_asistenta
            // 
            this.Sifra_asistenta.HeaderText = "Sifra asistenta";
            this.Sifra_asistenta.Name = "Sifra_asistenta";
            this.Sifra_asistenta.ReadOnly = true;
            // 
            // Ime_asistenta
            // 
            this.Ime_asistenta.HeaderText = "Ime asistenta";
            this.Ime_asistenta.Name = "Ime_asistenta";
            this.Ime_asistenta.ReadOnly = true;
            // 
            // Prezime_asistenta
            // 
            this.Prezime_asistenta.HeaderText = "Prezime asistenta";
            this.Prezime_asistenta.Name = "Prezime_asistenta";
            this.Prezime_asistenta.ReadOnly = true;
            // 
            // Godiste
            // 
            this.Godiste.HeaderText = "Godiste";
            this.Godiste.Name = "Godiste";
            this.Godiste.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prezime profesora ciji se asistent prikazuje:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Prikazi_profesorovog_asistenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prikazi_profesorovog_asistenta";
            this.Text = "Prikaz_profesorovog_asistenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra_profesora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra_asistenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime_asistenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime_asistenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godiste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}