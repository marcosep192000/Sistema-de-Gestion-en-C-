namespace WindowsFormsApplication3
{
    partial class cargatipoempresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cargatipoempresas));
            this.button3 = new System.Windows.Forms.Button();
            this.carga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoempresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet5 = new WindowsFormsApplication3.gestionrubricasDataSet5();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tipoempresasTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet5TableAdapters.tipoempresasTableAdapter();
            this.grabar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.modific = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoempresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet5)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(53, 67);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cargar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // carga
            // 
            this.carga.Location = new System.Drawing.Point(603, 132);
            this.carga.Margin = new System.Windows.Forms.Padding(2);
            this.carga.Name = "carga";
            this.carga.Size = new System.Drawing.Size(94, 20);
            this.carga.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de sociedad: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(980, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 105);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese una nueva sociedad :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempresaDataGridViewTextBoxColumn,
            this.tipoempresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tipoempresasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(690, 249);
            this.dataGridView1.TabIndex = 6;
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
            this.tipoempresasBindingSource.DataSource = this.gestionrubricasDataSet5;
            // 
            // gestionrubricasDataSet5
            // 
            this.gestionrubricasDataSet5.DataSetName = "gestionrubricasDataSet5";
            this.gestionrubricasDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(835, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 142);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mmodificacion Libros ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre desociedad anterior : ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 32);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 20);
            this.textBox4.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(52, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 33);
            this.button4.TabIndex = 1;
            this.button4.Text = "&Modificar ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nuevo nombre de sociedad : ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(243, 132);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 20);
            this.textBox3.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(875, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 115);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baja Libros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre Sociedad : ";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(52, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 33);
            this.button5.TabIndex = 0;
            this.button5.Text = "&Eliminar ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 132);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // tipoempresasTableAdapter
            // 
            this.tipoempresasTableAdapter.ClearBeforeFill = true;
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
            this.grabar.Location = new System.Drawing.Point(310, 3);
            this.grabar.Name = "grabar";
            this.grabar.Size = new System.Drawing.Size(75, 89);
            this.grabar.TabIndex = 85;
            this.grabar.Text = "&Grabar Datos";
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
            this.eliminar.Location = new System.Drawing.Point(406, 2);
            this.eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(77, 90);
            this.eliminar.TabIndex = 80;
            this.eliminar.Text = "&Cancelar Operacion";
            this.eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
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
            this.consultar.Location = new System.Drawing.Point(99, 4);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(85, 89);
            this.consultar.TabIndex = 84;
            this.consultar.Text = "&Consultar Sociedad";
            this.consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // modific
            // 
            this.modific.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modific.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modific.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modific.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.modific.FlatAppearance.BorderSize = 0;
            this.modific.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.modific.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.modific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modific.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modific.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modific.Image = ((System.Drawing.Image)(resources.GetObject("modific.Image")));
            this.modific.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.modific.Location = new System.Drawing.Point(205, 3);
            this.modific.Margin = new System.Windows.Forms.Padding(4);
            this.modific.Name = "modific";
            this.modific.Size = new System.Drawing.Size(85, 89);
            this.modific.TabIndex = 81;
            this.modific.Text = "&Modificar Sociedad";
            this.modific.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.modific.UseVisualStyleBackColor = false;
            this.modific.Click += new System.EventHandler(this.modific_Click);
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
            this.nuevo.Location = new System.Drawing.Point(7, 4);
            this.nuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(85, 89);
            this.nuevo.TabIndex = 83;
            this.nuevo.Text = "&Nueva Sociedad";
            this.nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevo.UseVisualStyleBackColor = false;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
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
            this.cerrar.Location = new System.Drawing.Point(625, 2);
            this.cerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(72, 87);
            this.cerrar.TabIndex = 82;
            this.cerrar.Text = "&Cerrar";
            this.cerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Id Sociedad : ";
            // 
            // cargatipoempresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(710, 427);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.grabar);
            this.Controls.Add(this.carga);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.modific);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cargatipoempresas";
            this.Text = "Nuevo tipo de Sociedad ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.cargatipoempresas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoempresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet5)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox carga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private gestionrubricasDataSet5 gestionrubricasDataSet5;
        private System.Windows.Forms.BindingSource tipoempresasBindingSource;
        private gestionrubricasDataSet5TableAdapters.tipoempresasTableAdapter tipoempresasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button grabar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button modific;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label label5;
    }
}