namespace WindowsFormsApplication3
{
    partial class consultarContacto
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
            this.idcontactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredeContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailcontactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoporempresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet22 = new WindowsFormsApplication3.gestionrubricasDataSet22();
            this.contactoporempresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet21 = new WindowsFormsApplication3.gestionrubricasDataSet21();
            this.contactoporempresTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet21TableAdapters.contactoporempresTableAdapter();
            this.contactoporempresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactoporempresTableAdapter1 = new WindowsFormsApplication3.gestionrubricasDataSet22TableAdapters.contactoporempresTableAdapter();
            this.gestionrubricasDataSet22BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoporempresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoporempresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoporempresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet22BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcontactoDataGridViewTextBoxColumn,
            this.nombredeContactoDataGridViewTextBoxColumn,
            this.mailcontactoDataGridViewTextBoxColumn,
            this.telefonoContactoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.idempresaDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.pisoDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactoporempresBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowDoubleClick);
            this.dataGridView1.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGridView1_CellContextMenuStripNeeded);
            // 
            // idcontactoDataGridViewTextBoxColumn
            // 
            this.idcontactoDataGridViewTextBoxColumn.DataPropertyName = "id_contacto";
            this.idcontactoDataGridViewTextBoxColumn.HeaderText = "id_contacto";
            this.idcontactoDataGridViewTextBoxColumn.Name = "idcontactoDataGridViewTextBoxColumn";
            this.idcontactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombredeContactoDataGridViewTextBoxColumn
            // 
            this.nombredeContactoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_de_Contacto";
            this.nombredeContactoDataGridViewTextBoxColumn.HeaderText = "Nombre_de_Contacto";
            this.nombredeContactoDataGridViewTextBoxColumn.Name = "nombredeContactoDataGridViewTextBoxColumn";
            this.nombredeContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailcontactoDataGridViewTextBoxColumn
            // 
            this.mailcontactoDataGridViewTextBoxColumn.DataPropertyName = "Mailcontacto";
            this.mailcontactoDataGridViewTextBoxColumn.HeaderText = "Mailcontacto";
            this.mailcontactoDataGridViewTextBoxColumn.Name = "mailcontactoDataGridViewTextBoxColumn";
            this.mailcontactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoContactoDataGridViewTextBoxColumn
            // 
            this.telefonoContactoDataGridViewTextBoxColumn.DataPropertyName = "TelefonoContacto";
            this.telefonoContactoDataGridViewTextBoxColumn.HeaderText = "TelefonoContacto";
            this.telefonoContactoDataGridViewTextBoxColumn.Name = "telefonoContactoDataGridViewTextBoxColumn";
            this.telefonoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idempresaDataGridViewTextBoxColumn
            // 
            this.idempresaDataGridViewTextBoxColumn.DataPropertyName = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.HeaderText = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.Name = "idempresaDataGridViewTextBoxColumn";
            this.idempresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            this.provinciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            this.ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pisoDataGridViewTextBoxColumn
            // 
            this.pisoDataGridViewTextBoxColumn.DataPropertyName = "piso";
            this.pisoDataGridViewTextBoxColumn.HeaderText = "piso";
            this.pisoDataGridViewTextBoxColumn.Name = "pisoDataGridViewTextBoxColumn";
            this.pisoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactoporempresBindingSource2
            // 
            this.contactoporempresBindingSource2.DataMember = "contactoporempres";
            this.contactoporempresBindingSource2.DataSource = this.gestionrubricasDataSet22;
            // 
            // gestionrubricasDataSet22
            // 
            this.gestionrubricasDataSet22.DataSetName = "gestionrubricasDataSet22";
            this.gestionrubricasDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactoporempresBindingSource
            // 
            this.contactoporempresBindingSource.DataMember = "contactoporempres";
            this.contactoporempresBindingSource.DataSource = this.gestionrubricasDataSet21;
            // 
            // gestionrubricasDataSet21
            // 
            this.gestionrubricasDataSet21.DataSetName = "gestionrubricasDataSet21";
            this.gestionrubricasDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactoporempresTableAdapter
            // 
            this.contactoporempresTableAdapter.ClearBeforeFill = true;
            // 
            // contactoporempresBindingSource1
            // 
            this.contactoporempresBindingSource1.DataMember = "contactoporempres";
            this.contactoporempresBindingSource1.DataSource = this.gestionrubricasDataSet22;
            // 
            // contactoporempresTableAdapter1
            // 
            this.contactoporempresTableAdapter1.ClearBeforeFill = true;
            // 
            // gestionrubricasDataSet22BindingSource
            // 
            this.gestionrubricasDataSet22BindingSource.DataSource = this.gestionrubricasDataSet22;
            this.gestionrubricasDataSet22BindingSource.Position = 0;
            // 
            // consultarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 420);
            this.Controls.Add(this.dataGridView1);
            this.Name = "consultarContacto";
            this.Text = "Consultar Contacto";
            this.Load += new System.EventHandler(this.consultarContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoporempresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoporempresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoporempresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet22BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gestionrubricasDataSet21 gestionrubricasDataSet21;
        private System.Windows.Forms.BindingSource contactoporempresBindingSource;
        private gestionrubricasDataSet21TableAdapters.contactoporempresTableAdapter contactoporempresTableAdapter;
        private gestionrubricasDataSet22 gestionrubricasDataSet22;
        private System.Windows.Forms.BindingSource contactoporempresBindingSource1;
        private gestionrubricasDataSet22TableAdapters.contactoporempresTableAdapter contactoporempresTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredeContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailcontactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contactoporempresBindingSource2;
        private System.Windows.Forms.BindingSource gestionrubricasDataSet22BindingSource;
    }
}