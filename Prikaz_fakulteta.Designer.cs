namespace Studentski_sistem___Filip
{
    partial class Prikaz_fakulteta
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
            this.fakultetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakultetTableAdapter = new Studentski_sistem___Filip.Studentski_sistemDataSetTableAdapters.FakultetTableAdapter();
            this.imefakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifrapredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeuniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentski_sistemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imefakDataGridViewTextBoxColumn,
            this.sifrapredDataGridViewTextBoxColumn,
            this.imeuniDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fakultetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 172);
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
            // fakultetBindingSource
            // 
            this.fakultetBindingSource.DataMember = "Fakultet";
            this.fakultetBindingSource.DataSource = this.studentski_sistemDataSet;
            // 
            // fakultetTableAdapter
            // 
            this.fakultetTableAdapter.ClearBeforeFill = true;
            // 
            // imefakDataGridViewTextBoxColumn
            // 
            this.imefakDataGridViewTextBoxColumn.DataPropertyName = "Ime_fak";
            this.imefakDataGridViewTextBoxColumn.HeaderText = "Ime_fak";
            this.imefakDataGridViewTextBoxColumn.Name = "imefakDataGridViewTextBoxColumn";
            // 
            // sifrapredDataGridViewTextBoxColumn
            // 
            this.sifrapredDataGridViewTextBoxColumn.DataPropertyName = "Sifra_pred";
            this.sifrapredDataGridViewTextBoxColumn.HeaderText = "Sifra_pred";
            this.sifrapredDataGridViewTextBoxColumn.Name = "sifrapredDataGridViewTextBoxColumn";
            // 
            // imeuniDataGridViewTextBoxColumn
            // 
            this.imeuniDataGridViewTextBoxColumn.DataPropertyName = "Ime_uni";
            this.imeuniDataGridViewTextBoxColumn.HeaderText = "Ime_uni";
            this.imeuniDataGridViewTextBoxColumn.Name = "imeuniDataGridViewTextBoxColumn";
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E_mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E_mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // Prikaz_fakulteta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prikaz_fakulteta";
            this.Text = "Prikaz_fakulteta";
            this.Load += new System.EventHandler(this.Prikaz_fakulteta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentski_sistemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Studentski_sistemDataSet studentski_sistemDataSet;
        private System.Windows.Forms.BindingSource fakultetBindingSource;
        private Studentski_sistemDataSetTableAdapters.FakultetTableAdapter fakultetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imefakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifrapredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeuniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}