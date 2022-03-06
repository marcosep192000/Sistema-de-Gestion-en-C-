namespace WindowsFormsApplication3
{
    partial class buscarlibro
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
            this.gestionrubricasDataSet26 = new WindowsFormsApplication3.gestionrubricasDataSet26();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet26TableAdapters.articulosTableAdapter();
            this.codigoarticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredearticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoarticuloDataGridViewTextBoxColumn,
            this.nombredearticuloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.articulosBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // gestionrubricasDataSet26
            // 
            this.gestionrubricasDataSet26.DataSetName = "gestionrubricasDataSet26";
            this.gestionrubricasDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataMember = "articulos";
            this.articulosBindingSource.DataSource = this.gestionrubricasDataSet26;
            // 
            // articulosTableAdapter
            // 
            this.articulosTableAdapter.ClearBeforeFill = true;
            // 
            // codigoarticuloDataGridViewTextBoxColumn
            // 
            this.codigoarticuloDataGridViewTextBoxColumn.DataPropertyName = "codigoarticulo";
            this.codigoarticuloDataGridViewTextBoxColumn.HeaderText = "codigoarticulo";
            this.codigoarticuloDataGridViewTextBoxColumn.Name = "codigoarticuloDataGridViewTextBoxColumn";
            this.codigoarticuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombredearticuloDataGridViewTextBoxColumn
            // 
            this.nombredearticuloDataGridViewTextBoxColumn.DataPropertyName = "nombredearticulo";
            this.nombredearticuloDataGridViewTextBoxColumn.HeaderText = "nombredearticulo";
            this.nombredearticuloDataGridViewTextBoxColumn.Name = "nombredearticuloDataGridViewTextBoxColumn";
            // 
            // buscarlibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 373);
            this.Controls.Add(this.dataGridView1);
            this.Name = "buscarlibro";
            this.Text = "buscarlibro";
            this.Load += new System.EventHandler(this.buscarlibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gestionrubricasDataSet26 gestionrubricasDataSet26;
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private gestionrubricasDataSet26TableAdapters.articulosTableAdapter articulosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoarticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredearticuloDataGridViewTextBoxColumn;
    }
}