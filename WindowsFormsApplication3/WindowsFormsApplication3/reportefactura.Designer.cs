namespace WindowsFormsApplication3
{
    partial class reportefactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturas = new WindowsFormsApplication3.facturas();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataclientes = new WindowsFormsApplication3.dataclientes();
            this.Venta_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetcomprobantes = new WindowsFormsApplication3.datasetcomprobantes();
            this.clientesTableAdapter = new WindowsFormsApplication3.dataclientesTableAdapters.clientesTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApplication3.gestionrubricasDataSet10TableAdapters.TableAdapterManager();
            this.estudiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiosTableAdapter = new WindowsFormsApplication3.dataclientesTableAdapters.estudiosTableAdapter();
            this.Venta_ClienteTableAdapter = new WindowsFormsApplication3.datasetcomprobantesTableAdapters.Venta_ClienteTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ventasTableAdapter = new WindowsFormsApplication3.facturasTableAdapters.ventasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Venta_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetcomprobantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "ventas";
            this.ventasBindingSource.DataSource = this.facturas;
            // 
            // facturas
            // 
            this.facturas.DataSetName = "facturas";
            this.facturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.dataclientes;
            // 
            // dataclientes
            // 
            this.dataclientes.DataSetName = "dataclientes";
            this.dataclientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Venta_ClienteBindingSource
            // 
            this.Venta_ClienteBindingSource.DataMember = "Venta_Cliente";
            this.Venta_ClienteBindingSource.DataSource = this.datasetcomprobantes;
            // 
            // datasetcomprobantes
            // 
            this.datasetcomprobantes.DataSetName = "datasetcomprobantes";
            this.datasetcomprobantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplication3.gestionrubricasDataSet10TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usuariosTableAdapter = null;
            // 
            // estudiosBindingSource
            // 
            this.estudiosBindingSource.DataMember = "estudios";
            this.estudiosBindingSource.DataSource = this.dataclientes;
            // 
            // estudiosTableAdapter
            // 
            this.estudiosTableAdapter.ClearBeforeFill = true;
            // 
            // Venta_ClienteTableAdapter
            // 
            this.Venta_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "facturas";
            reportDataSource1.Value = this.ventasBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.clientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(868, 534);
            this.reportViewer1.TabIndex = 0;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // reportefactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 534);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "reportefactura";
            this.Text = "reportefactura";
            this.Load += new System.EventHandler(this.reportefactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Venta_ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetcomprobantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource clientesBindingSource;
        private dataclientes dataclientes;
        private dataclientesTableAdapters.clientesTableAdapter clientesTableAdapter;
        private gestionrubricasDataSet10TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource estudiosBindingSource;
        private dataclientesTableAdapters.estudiosTableAdapter estudiosTableAdapter;
        private System.Windows.Forms.BindingSource Venta_ClienteBindingSource;
        private datasetcomprobantes datasetcomprobantes;
        private datasetcomprobantesTableAdapters.Venta_ClienteTableAdapter Venta_ClienteTableAdapter;
        private facturas facturas;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private facturasTableAdapters.ventasTableAdapter ventasTableAdapter;

    }
}