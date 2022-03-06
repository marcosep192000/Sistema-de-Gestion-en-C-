namespace WindowsFormsApplication3
{
    partial class consultarestudio
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
            this.estudiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet23 = new WindowsFormsApplication3.gestionrubricasDataSet23();
            this.estudiosTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet23TableAdapters.estudiosTableAdapter();
            this.gestionrubricasDataSet24 = new WindowsFormsApplication3.gestionrubricasDataSet24();
            this.estudiosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estudiosTableAdapter1 = new WindowsFormsApplication3.gestionrubricasDataSet24TableAdapters.estudiosTableAdapter();
            this.gestionrubricasDataSet25 = new WindowsFormsApplication3.gestionrubricasDataSet25();
            this.estudiosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.estudiosTableAdapter2 = new WindowsFormsApplication3.gestionrubricasDataSet25TableAdapters.estudiosTableAdapter();
            this.gestionrubricasDataSet25BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.idestudioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oficinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecontactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet25BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiosBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idestudioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cuitDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.codigopostalDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.pisoDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.oficinaDataGridViewTextBoxColumn,
            this.altaDataGridViewTextBoxColumn,
            this.nombrecontactoDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.estudiosBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // estudiosBindingSource
            // 
            this.estudiosBindingSource.DataMember = "estudios";
            this.estudiosBindingSource.DataSource = this.gestionrubricasDataSet23;
            // 
            // gestionrubricasDataSet23
            // 
            this.gestionrubricasDataSet23.DataSetName = "gestionrubricasDataSet23";
            this.gestionrubricasDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiosTableAdapter
            // 
            this.estudiosTableAdapter.ClearBeforeFill = true;
            // 
            // gestionrubricasDataSet24
            // 
            this.gestionrubricasDataSet24.DataSetName = "gestionrubricasDataSet24";
            this.gestionrubricasDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiosBindingSource1
            // 
            this.estudiosBindingSource1.DataMember = "estudios";
            this.estudiosBindingSource1.DataSource = this.gestionrubricasDataSet24;
            // 
            // estudiosTableAdapter1
            // 
            this.estudiosTableAdapter1.ClearBeforeFill = true;
            // 
            // gestionrubricasDataSet25
            // 
            this.gestionrubricasDataSet25.DataSetName = "gestionrubricasDataSet25";
            this.gestionrubricasDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiosBindingSource2
            // 
            this.estudiosBindingSource2.DataMember = "estudios";
            this.estudiosBindingSource2.DataSource = this.gestionrubricasDataSet25;
            // 
            // estudiosTableAdapter2
            // 
            this.estudiosTableAdapter2.ClearBeforeFill = true;
            // 
            // gestionrubricasDataSet25BindingSource
            // 
            this.gestionrubricasDataSet25BindingSource.DataSource = this.gestionrubricasDataSet25;
            this.gestionrubricasDataSet25BindingSource.Position = 0;
            // 
            // estudiosBindingSource3
            // 
            this.estudiosBindingSource3.DataMember = "estudios";
            this.estudiosBindingSource3.DataSource = this.gestionrubricasDataSet25BindingSource;
            // 
            // idestudioDataGridViewTextBoxColumn
            // 
            this.idestudioDataGridViewTextBoxColumn.DataPropertyName = "idestudio";
            this.idestudioDataGridViewTextBoxColumn.HeaderText = "idestudio";
            this.idestudioDataGridViewTextBoxColumn.Name = "idestudioDataGridViewTextBoxColumn";
            this.idestudioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            this.cuitDataGridViewTextBoxColumn.DataPropertyName = "cuit";
            this.cuitDataGridViewTextBoxColumn.HeaderText = "cuit";
            this.cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            // 
            // codigopostalDataGridViewTextBoxColumn
            // 
            this.codigopostalDataGridViewTextBoxColumn.DataPropertyName = "codigopostal";
            this.codigopostalDataGridViewTextBoxColumn.HeaderText = "codigopostal";
            this.codigopostalDataGridViewTextBoxColumn.Name = "codigopostalDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // pisoDataGridViewTextBoxColumn
            // 
            this.pisoDataGridViewTextBoxColumn.DataPropertyName = "piso";
            this.pisoDataGridViewTextBoxColumn.HeaderText = "piso";
            this.pisoDataGridViewTextBoxColumn.Name = "pisoDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // oficinaDataGridViewTextBoxColumn
            // 
            this.oficinaDataGridViewTextBoxColumn.DataPropertyName = "oficina";
            this.oficinaDataGridViewTextBoxColumn.HeaderText = "oficina";
            this.oficinaDataGridViewTextBoxColumn.Name = "oficinaDataGridViewTextBoxColumn";
            // 
            // altaDataGridViewTextBoxColumn
            // 
            this.altaDataGridViewTextBoxColumn.DataPropertyName = "alta";
            this.altaDataGridViewTextBoxColumn.HeaderText = "alta";
            this.altaDataGridViewTextBoxColumn.Name = "altaDataGridViewTextBoxColumn";
            // 
            // nombrecontactoDataGridViewTextBoxColumn
            // 
            this.nombrecontactoDataGridViewTextBoxColumn.DataPropertyName = "nombrecontacto";
            this.nombrecontactoDataGridViewTextBoxColumn.HeaderText = "nombrecontacto";
            this.nombrecontactoDataGridViewTextBoxColumn.Name = "nombrecontactoDataGridViewTextBoxColumn";
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            // 
            // consultarestudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 382);
            this.Controls.Add(this.dataGridView1);
            this.Name = "consultarestudio";
            this.Text = "consultarestudio";
            this.Load += new System.EventHandler(this.consultarestudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet25BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiosBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gestionrubricasDataSet23 gestionrubricasDataSet23;
        private System.Windows.Forms.BindingSource estudiosBindingSource;
        private gestionrubricasDataSet23TableAdapters.estudiosTableAdapter estudiosTableAdapter;
        private gestionrubricasDataSet24 gestionrubricasDataSet24;
        private System.Windows.Forms.BindingSource estudiosBindingSource1;
        private gestionrubricasDataSet24TableAdapters.estudiosTableAdapter estudiosTableAdapter1;
        private gestionrubricasDataSet25 gestionrubricasDataSet25;
        private System.Windows.Forms.BindingSource estudiosBindingSource2;
        private gestionrubricasDataSet25TableAdapters.estudiosTableAdapter estudiosTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestudioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oficinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecontactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource estudiosBindingSource3;
        private System.Windows.Forms.BindingSource gestionrubricasDataSet25BindingSource;
    }
}