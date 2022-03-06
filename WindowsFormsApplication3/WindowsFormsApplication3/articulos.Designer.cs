namespace WindowsFormsApplication3
{
    partial class articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(articulos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombredearticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoarticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet11 = new WindowsFormsApplication3.gestionrubricasDataSet11();
            this.dataSet1 = new WindowsFormsApplication3.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet11TableAdapters.articulosTableAdapter();
            this.gestionrubricasDataSet15 = new WindowsFormsApplication3.gestionrubricasDataSet15();
            this.tipoempresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoempresasTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet15TableAdapters.tipoempresasTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grabar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoempresasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombredearticuloDataGridViewTextBoxColumn,
            this.codigoarticuloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.articulosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(586, 143);
            this.dataGridView1.TabIndex = 2;
            // 
            // nombredearticuloDataGridViewTextBoxColumn
            // 
            this.nombredearticuloDataGridViewTextBoxColumn.DataPropertyName = "nombredearticulo";
            this.nombredearticuloDataGridViewTextBoxColumn.HeaderText = "nombredearticulo";
            this.nombredearticuloDataGridViewTextBoxColumn.Name = "nombredearticuloDataGridViewTextBoxColumn";
            this.nombredearticuloDataGridViewTextBoxColumn.Width = 200;
            // 
            // codigoarticuloDataGridViewTextBoxColumn
            // 
            this.codigoarticuloDataGridViewTextBoxColumn.DataPropertyName = "codigoarticulo";
            this.codigoarticuloDataGridViewTextBoxColumn.HeaderText = "codigoarticulo";
            this.codigoarticuloDataGridViewTextBoxColumn.Name = "codigoarticuloDataGridViewTextBoxColumn";
            this.codigoarticuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataMember = "articulos";
            this.articulosBindingSource.DataSource = this.gestionrubricasDataSet11;
            // 
            // gestionrubricasDataSet11
            // 
            this.gestionrubricasDataSet11.DataSetName = "gestionrubricasDataSet11";
            this.gestionrubricasDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // articulosTableAdapter
            // 
            this.articulosTableAdapter.ClearBeforeFill = true;
            // 
            // gestionrubricasDataSet15
            // 
            this.gestionrubricasDataSet15.DataSetName = "gestionrubricasDataSet15";
            this.gestionrubricasDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoempresasBindingSource
            // 
            this.tipoempresasBindingSource.DataMember = "tipoempresas";
            this.tipoempresasBindingSource.DataSource = this.gestionrubricasDataSet15;
            // 
            // tipoempresasTableAdapter
            // 
            this.tipoempresasTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(255, 144);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nuevo nombre de libro : ";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(521, 144);
            this.id.Margin = new System.Windows.Forms.Padding(2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(77, 20);
            this.id.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre de libro  : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(799, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 142);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mmodificacion Libros ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 78;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(728, 328);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 79;
            // 
            // grabar
            // 
            this.grabar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grabar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grabar.FlatAppearance.BorderSize = 0;
            this.grabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grabar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grabar.Image = ((System.Drawing.Image)(resources.GetObject("grabar.Image")));
            this.grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.grabar.Location = new System.Drawing.Point(322, 2);
            this.grabar.Name = "grabar";
            this.grabar.Size = new System.Drawing.Size(75, 89);
            this.grabar.TabIndex = 85;
            this.grabar.Text = "grabar Datos";
            this.grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grabar.UseVisualStyleBackColor = false;
            this.grabar.Click += new System.EventHandler(this.grabar_Click);
            // 
            // eliminar
            // 
            this.eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.eliminar.FlatAppearance.BorderSize = 0;
            this.eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eliminar.Location = new System.Drawing.Point(409, 1);
            this.eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(77, 90);
            this.eliminar.TabIndex = 80;
            this.eliminar.Text = "cancelar Operacion";
            this.eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eliminar.UseVisualStyleBackColor = false;
            // 
            // consultar
            // 
            this.consultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consultar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.consultar.FlatAppearance.BorderSize = 0;
            this.consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consultar.Image = ((System.Drawing.Image)(resources.GetObject("consultar.Image")));
            this.consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.consultar.Location = new System.Drawing.Point(116, 3);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(85, 89);
            this.consultar.TabIndex = 84;
            this.consultar.Text = "Consultar Empresa";
            this.consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(777, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 37);
            this.button4.TabIndex = 1;
            this.button4.Text = "&Modificar ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // modificar
            // 
            this.modificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.modificar.FlatAppearance.BorderSize = 0;
            this.modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modificar.Image = ((System.Drawing.Image)(resources.GetObject("modificar.Image")));
            this.modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.modificar.Location = new System.Drawing.Point(227, 3);
            this.modificar.Margin = new System.Windows.Forms.Padding(4);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(85, 89);
            this.modificar.TabIndex = 81;
            this.modificar.Text = "Modificar empresa";
            this.modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.modificar.UseVisualStyleBackColor = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // nuevo
            // 
            this.nuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nuevo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.nuevo.FlatAppearance.BorderSize = 0;
            this.nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nuevo.Image = ((System.Drawing.Image)(resources.GetObject("nuevo.Image")));
            this.nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nuevo.Location = new System.Drawing.Point(10, 3);
            this.nuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(85, 89);
            this.nuevo.TabIndex = 83;
            this.nuevo.Text = "Nueva Empresa";
            this.nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevo.UseVisualStyleBackColor = false;
            // 
            // cerrar
            // 
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.ForeColor = System.Drawing.Color.Black;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cerrar.Location = new System.Drawing.Point(524, 4);
            this.cerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(72, 87);
            this.cerrar.TabIndex = 82;
            this.cerrar.Text = "Cerrar";
            this.cerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cerrar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(728, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 36);
            this.button3.TabIndex = 74;
            this.button3.Text = "&Cerrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1131, 378);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grabar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "articulos";
            this.Text = "Alta Libros Rubrica ";
            this.Load += new System.EventHandler(this.articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoempresasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private gestionrubricasDataSet11 gestionrubricasDataSet11;
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private gestionrubricasDataSet11TableAdapters.articulosTableAdapter articulosTableAdapter;
        private System.Windows.Forms.Button button3;
        private gestionrubricasDataSet15 gestionrubricasDataSet15;
        private System.Windows.Forms.BindingSource tipoempresasBindingSource;
        private gestionrubricasDataSet15TableAdapters.tipoempresasTableAdapter tipoempresasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredearticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoarticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button grabar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button cerrar;
    }
}