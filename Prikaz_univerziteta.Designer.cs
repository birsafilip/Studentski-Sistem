﻿namespace Studentski_sistem___Filip
{
    partial class Prikaz_univerziteta
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
            this.univerzitetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.univerzitetTableAdapter = new Studentski_sistem___Filip.Studentski_sistemDataSetTableAdapters.UniverzitetTableAdapter();
            this.imeuniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentski_sistemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.univerzitetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeuniDataGridViewTextBoxColumn,
            this.mestoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.univerzitetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 180);
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
            // univerzitetBindingSource
            // 
            this.univerzitetBindingSource.DataMember = "Univerzitet";
            this.univerzitetBindingSource.DataSource = this.studentski_sistemDataSet;
            // 
            // univerzitetTableAdapter
            // 
            this.univerzitetTableAdapter.ClearBeforeFill = true;
            // 
            // imeuniDataGridViewTextBoxColumn
            // 
            this.imeuniDataGridViewTextBoxColumn.DataPropertyName = "Ime_uni";
            this.imeuniDataGridViewTextBoxColumn.HeaderText = "Ime_uni";
            this.imeuniDataGridViewTextBoxColumn.Name = "imeuniDataGridViewTextBoxColumn";
            // 
            // mestoDataGridViewTextBoxColumn
            // 
            this.mestoDataGridViewTextBoxColumn.DataPropertyName = "Mesto";
            this.mestoDataGridViewTextBoxColumn.HeaderText = "Mesto";
            this.mestoDataGridViewTextBoxColumn.Name = "mestoDataGridViewTextBoxColumn";
            // 
            // Prikaz_univerziteta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 215);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prikaz_univerziteta";
            this.Text = "Prikaz_univerziteta";
            this.Load += new System.EventHandler(this.Prikaz_univerziteta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentski_sistemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.univerzitetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Studentski_sistemDataSet studentski_sistemDataSet;
        private System.Windows.Forms.BindingSource univerzitetBindingSource;
        private Studentski_sistemDataSetTableAdapters.UniverzitetTableAdapter univerzitetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeuniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestoDataGridViewTextBoxColumn;
    }
}