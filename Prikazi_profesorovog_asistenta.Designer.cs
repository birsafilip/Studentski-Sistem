namespace Studentski_sistem___Gadzovic
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sifra_profesora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra_asistenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime_asistenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime_asistenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(47, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 193);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(269, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prezime profesora cij se asistent prikazuje:";
            // 
            // Prikazi_profesorovog_asistenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Prikazi_profesorovog_asistenta";
            this.Text = "Prikazi_profesorovog_asistenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra_profesora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra_asistenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime_asistenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime_asistenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godiste;
        private System.Windows.Forms.Label label1;
    }
}