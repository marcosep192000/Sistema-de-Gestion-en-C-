namespace WindowsFormsApplication3
{
    partial class Formestudios
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataclientes = new WindowsFormsApplication3.dataclientes();
            this.estudiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiosTableAdapter = new WindowsFormsApplication3.dataclientesTableAdapters.estudiosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.estudiosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(850, 384);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataclientes
            // 
            this.dataclientes.DataSetName = "dataclientes";
            this.dataclientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Formestudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 384);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Formestudios";
            this.Text = "Formestudios";
            this.Load += new System.EventHandler(this.Formestudios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource estudiosBindingSource;
        private dataclientes dataclientes;
        private dataclientesTableAdapters.estudiosTableAdapter estudiosTableAdapter;
    }
}