namespace Studentski_sistem___Filip
{
    partial class Prikaz_predmeta
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
            this.predmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predmetTableAdapter = new Studentski_sistem___Filip.Studentski_sistemDataSetTableAdapters.PredmetTableAdapter();
            this.sifrapredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraprofDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fondcasovaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brECTSbodovaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacinpolaganjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brsemestraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentski_sistemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifrapredDataGridViewTextBoxColumn,
            this.sifraprofDataGridViewTextBoxColumn,
            this.fondcasovaDataGridViewTextBoxColumn,
            this.brECTSbodovaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.nacinpolaganjaDataGridViewTextBoxColumn,
            this.brsemestraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.predmetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 191);
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
            // predmetBindingSource
            // 
            this.predmetBindingSource.DataMember = "Predmet";
            this.predmetBindingSource.DataSource = this.studentski_sistemDataSet;
            // 
            // predmetTableAdapter
            // 
            this.predmetTableAdapter.ClearBeforeFill = true;
            // 
            // sifrapredDataGridViewTextBoxColumn
            // 
            this.sifrapredDataGridViewTextBoxColumn.DataPropertyName = "Sifra_pred";
            this.sifrapredDataGridViewTextBoxColumn.HeaderText = "Sifra_pred";
            this.sifrapredDataGridViewTextBoxColumn.Name = "sifrapredDataGridViewTextBoxColumn";
            // 
            // sifraprofDataGridViewTextBoxColumn
            // 
            this.sifraprofDataGridViewTextBoxColumn.DataPropertyName = "Sifra_prof";
            this.sifraprofDataGridViewTextBoxColumn.HeaderText = "Sifra_prof";
            this.sifraprofDataGridViewTextBoxColumn.Name = "sifraprofDataGridViewTextBoxColumn";
            // 
            // fondcasovaDataGridViewTextBoxColumn
            // 
            this.fondcasovaDataGridViewTextBoxColumn.DataPropertyName = "Fond_casova";
            this.fondcasovaDataGridViewTextBoxColumn.HeaderText = "Fond_casova";
            this.fondcasovaDataGridViewTextBoxColumn.Name = "fondcasovaDataGridViewTextBoxColumn";
            // 
            // brECTSbodovaDataGridViewTextBoxColumn
            // 
            this.brECTSbodovaDataGridViewTextBoxColumn.DataPropertyName = "Br_ECTS_bodova";
            this.brECTSbodovaDataGridViewTextBoxColumn.HeaderText = "Br_ECTS_bodova";
            this.brECTSbodovaDataGridViewTextBoxColumn.Name = "brECTSbodovaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // nacinpolaganjaDataGridViewTextBoxColumn
            // 
            this.nacinpolaganjaDataGridViewTextBoxColumn.DataPropertyName = "Nacin_polaganja";
            this.nacinpolaganjaDataGridViewTextBoxColumn.HeaderText = "Nacin_polaganja";
            this.nacinpolaganjaDataGridViewTextBoxColumn.Name = "nacinpolaganjaDataGridViewTextBoxColumn";
            // 
            // brsemestraDataGridViewTextBoxColumn
            // 
            this.brsemestraDataGridViewTextBoxColumn.DataPropertyName = "Br_semestra";
            this.brsemestraDataGridViewTextBoxColumn.HeaderText = "Br_semestra";
            this.brsemestraDataGridViewTextBoxColumn.Name = "brsemestraDataGridViewTextBoxColumn";
            // 
            // Prikaz_predmeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prikaz_predmeta";
            this.Text = "Prikaz_predmeta";
            this.Load += new System.EventHandler(this.Prikaz_predmeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentski_sistemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Studentski_sistemDataSet studentski_sistemDataSet;
        private System.Windows.Forms.BindingSource predmetBindingSource;
        private Studentski_sistemDataSetTableAdapters.PredmetTableAdapter predmetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifrapredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraprofDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fondcasovaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brECTSbodovaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacinpolaganjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brsemestraDataGridViewTextBoxColumn;
    }
}