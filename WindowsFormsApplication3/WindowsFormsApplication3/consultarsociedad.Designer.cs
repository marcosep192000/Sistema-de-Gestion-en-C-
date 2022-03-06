namespace WindowsFormsApplication3
{
    partial class consultarsociedad
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
            this.idempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoempresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipodeempresas = new WindowsFormsApplication3.tipodeempresas();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tipoempresasTableAdapter = new WindowsFormsApplication3.tipodeempresasTableAdapters.tipoempresasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoempresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodeempresas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempresaDataGridViewTextBoxColumn,
            this.tipoempresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tipoempresasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idempresaDataGridViewTextBoxColumn
            // 
            this.idempresaDataGridViewTextBoxColumn.DataPropertyName = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.HeaderText = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.Name = "idempresaDataGridViewTextBoxColumn";
            this.idempresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoempresaDataGridViewTextBoxColumn
            // 
            this.tipoempresaDataGridViewTextBoxColumn.DataPropertyName = "tipo_empresa";
            this.tipoempresaDataGridViewTextBoxColumn.HeaderText = "tipo_empresa";
            this.tipoempresaDataGridViewTextBoxColumn.Name = "tipoempresaDataGridViewTextBoxColumn";
            // 
            // tipoempresasBindingSource
            // 
            this.tipoempresasBindingSource.DataMember = "tipoempresas";
            this.tipoempresasBindingSource.DataSource = this.tipodeempresas;
            // 
            // tipodeempresas
            // 
            this.tipodeempresas.DataSetName = "tipodeempresas";
            this.tipodeempresas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Sociedad: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(430, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 2;
            // 
            // tipoempresasTableAdapter
            // 
            this.tipoempresasTableAdapter.ClearBeforeFill = true;
            // 
            // consultarsociedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 416);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "consultarsociedad";
            this.Text = "consultarsociedad";
            this.Load += new System.EventHandler(this.consultarsociedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoempresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodeempresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private tipodeempresas tipodeempresas;
        private System.Windows.Forms.BindingSource tipoempresasBindingSource;
        private tipodeempresasTableAdapters.tipoempresasTableAdapter tipoempresasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoempresaDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}