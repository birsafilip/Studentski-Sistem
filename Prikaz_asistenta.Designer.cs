namespace Studentski_sistem___Filip
{
    partial class Prikaz_asistenta
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.studentski_sistemDataSet = new Studentski_sistem___Filip.Studentski_sistemDataSet();
            this.asistentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asistentTableAdapter = new Studentski_sistem___Filip.Studentski_sistemDataSetTableAdapters.AsistentTableAdapter();
            this.sifraAsistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraProfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentski_sistemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraAsistDataGridViewTextBoxColumn,
            this.sifraProfDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.godisteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asistentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentski_sistemDataSet
            // 
            this.studentski_sistemDataSet.DataSetName = "Studentski_sistemDataSet";
            this.studentski_sistemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asistentBindingSource
            // 
            this.asistentBindingSource.DataMember = "Asistent";
            this.asistentBindingSource.DataSource = this.studentski_sistemDataSet;
            // 
            // asistentTableAdapter
            // 
            this.asistentTableAdapter.ClearBeforeFill = true;
            // 
            // sifraAsistDataGridViewTextBoxColumn
            // 
            this.sifraAsistDataGridViewTextBoxColumn.DataPropertyName = "Sifra_Asist";
            this.sifraAsistDataGridViewTextBoxColumn.HeaderText = "Sifra_Asist";
            this.sifraAsistDataGridViewTextBoxColumn.Name = "sifraAsistDataGridViewTextBoxColumn";
            // 
            // sifraProfDataGridViewTextBoxColumn
            // 
            this.sifraProfDataGridViewTextBoxColumn.DataPropertyName = "Sifra_Prof";
            this.sifraProfDataGridViewTextBoxColumn.HeaderText = "Sifra_Prof";
            this.sifraProfDataGridViewTextBoxColumn.Name = "sifraProfDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // godisteDataGridViewTextBoxColumn
            // 
            this.godisteDataGridViewTextBoxColumn.DataPropertyName = "Godiste";
            this.godisteDataGridViewTextBoxColumn.HeaderText = "Godiste";
            this.godisteDataGridViewTextBoxColumn.Name = "godisteDataGridViewTextBoxColumn";
            // 
            // Prikaz_asistenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prikaz_asistenta";
            this.Text = "Prikaz_asistenta";
            this.Load += new System.EventHandler(this.Prikaz_asistenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentski_sistemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Studentski_sistemDataSet studentski_sistemDataSet;
        private System.Windows.Forms.BindingSource asistentBindingSource;
        private Studentski_sistemDataSetTableAdapters.AsistentTableAdapter asistentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraAsistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraProfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godisteDataGridViewTextBoxColumn;
    }
}