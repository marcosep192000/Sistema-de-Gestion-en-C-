namespace WindowsFormsApplication3
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.boton = new System.Windows.Forms.TextBox();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet3 = new WindowsFormsApplication3.gestionrubricasDataSet3();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numerolibro = new System.Windows.Forms.TextBox();
            this.entrega = new System.Windows.Forms.TextBox();
            this.articulosTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet3TableAdapters.articulosTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.articulosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet4 = new WindowsFormsApplication3.gestionrubricasDataSet4();
            this.articulosTableAdapter1 = new WindowsFormsApplication3.gestionrubricasDataSet4TableAdapters.articulosTableAdapter();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.articulosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet14 = new WindowsFormsApplication3.gestionrubricasDataSet14();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canthojas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numlibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cargar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.articulosTableAdapter2 = new WindowsFormsApplication3.gestionrubricasDataSet14TableAdapters.articulosTableAdapter();
            this.imprimir = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.date.Location = new System.Drawing.Point(688, 17);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(188, 20);
            this.date.TabIndex = 0;
            this.date.Value = new System.DateTime(2014, 7, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comprobante Nº 000-";
            // 
            // boton
            // 
            this.boton.BackColor = System.Drawing.Color.White;
            this.boton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boton.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.boton.Location = new System.Drawing.Point(144, 15);
            this.boton.Multiline = true;
            this.boton.Name = "boton";
            this.boton.ReadOnly = true;
            this.boton.Size = new System.Drawing.Size(131, 24);
            this.boton.TabIndex = 3;
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataMember = "articulos";
            this.articulosBindingSource.DataSource = this.gestionrubricasDataSet3;
            // 
            // gestionrubricasDataSet3
            // 
            this.gestionrubricasDataSet3.DataSetName = "gestionrubricasDataSet3";
            this.gestionrubricasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(5, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Libros :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(520, 310);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 14);
            this.label10.TabIndex = 27;
            this.label10.Text = "Estado :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(5, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Libro numero : ";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(269, 128);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cargar  Libro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numerolibro
            // 
            this.numerolibro.BackColor = System.Drawing.Color.White;
            this.numerolibro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerolibro.Location = new System.Drawing.Point(4, 86);
            this.numerolibro.Margin = new System.Windows.Forms.Padding(2);
            this.numerolibro.Multiline = true;
            this.numerolibro.Name = "numerolibro";
            this.numerolibro.Size = new System.Drawing.Size(251, 27);
            this.numerolibro.TabIndex = 2;
            this.numerolibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerolibro_KeyPress);
            // 
            // entrega
            // 
            this.entrega.BackColor = System.Drawing.Color.White;
            this.entrega.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.entrega.Location = new System.Drawing.Point(671, 267);
            this.entrega.Margin = new System.Windows.Forms.Padding(2);
            this.entrega.Multiline = true;
            this.entrega.Name = "entrega";
            this.entrega.Size = new System.Drawing.Size(42, 23);
            this.entrega.TabIndex = 35;
            this.entrega.Visible = false;
            // 
            // articulosTableAdapter
            // 
            this.articulosTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(4, 115);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 15);
            this.label13.TabIndex = 37;
            this.label13.Text = "Cantidad de hojas :";
            // 
            // cantidad
            // 
            this.cantidad.BackColor = System.Drawing.Color.White;
            this.cantidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(4, 132);
            this.cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.cantidad.Multiline = true;
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(251, 27);
            this.cantidad.TabIndex = 1;
            this.cantidad.TextChanged += new System.EventHandler(this.cantidad_TextChanged);
            this.cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_KeyPress);
            // 
            // articulosBindingSource1
            // 
            this.articulosBindingSource1.DataMember = "articulos";
            this.articulosBindingSource1.DataSource = this.gestionrubricasDataSet4;
            // 
            // gestionrubricasDataSet4
            // 
            this.gestionrubricasDataSet4.DataSetName = "gestionrubricasDataSet4";
            this.gestionrubricasDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulosTableAdapter1
            // 
            this.articulosTableAdapter1.ClearBeforeFill = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(22, 82);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(123, 36);
            this.button10.TabIndex = 0;
            this.button10.Text = "Cargar nuevo libro";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(459, 44);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Limpiar Datos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // telefono
            // 
            this.telefono.BackColor = System.Drawing.Color.White;
            this.telefono.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(371, 100);
            this.telefono.Multiline = true;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Size = new System.Drawing.Size(189, 21);
            this.telefono.TabIndex = 14;
            this.telefono.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(368, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono : ";
            // 
            // direccion
            // 
            this.direccion.BackColor = System.Drawing.Color.White;
            this.direccion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.Location = new System.Drawing.Point(115, 100);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Size = new System.Drawing.Size(145, 21);
            this.direccion.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(113, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Direccion :";
            // 
            // cliente
            // 
            this.cliente.BackColor = System.Drawing.Color.White;
            this.cliente.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(8, 100);
            this.cliente.Multiline = true;
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(100, 21);
            this.cliente.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(22, 31);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 36);
            this.button8.TabIndex = 1;
            this.button8.Text = "Alta Clientes ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(357, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(116, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(5, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente Numero : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.direccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(671, 131);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(263, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Numero:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(266, 100);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 21);
            this.textBox3.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.data1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.entrega);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.cantidad);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numerolibro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(20, 189);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(862, 371);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cargar Items de Pedido";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(734, 254);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 36);
            this.button7.TabIndex = 8;
            this.button7.Text = "Eliminar Item";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(734, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 37);
            this.button5.TabIndex = 7;
            this.button5.Text = "Agregar Item";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(271, 82);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(177, 31);
            this.button11.TabIndex = 66;
            this.button11.Text = "Modificar Num. Libro ";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(271, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 31);
            this.button6.TabIndex = 4;
            this.button6.Text = "Consultar Libro Anterior";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(451, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 65;
            this.label7.Text = "Comentario por Libro: ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(454, 39);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(402, 120);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Sin Comentario";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.articulosBindingSource2;
            this.comboBox1.DisplayMember = "nombredearticulo";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 45);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 22);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "codigoarticulo";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.ValueMemberChanged += new System.EventHandler(this.comboBox1_ValueMemberChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // articulosBindingSource2
            // 
            this.articulosBindingSource2.DataMember = "articulos";
            this.articulosBindingSource2.DataSource = this.gestionrubricasDataSet14;
            // 
            // gestionrubricasDataSet14
            // 
            this.gestionrubricasDataSet14.DataSetName = "gestionrubricasDataSet14";
            this.gestionrubricasDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.data1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Codigo,
            this.canthojas,
            this.numlibro,
            this.estado,
            this.factura,
            this.comentario});
            this.data1.GridColor = System.Drawing.Color.CadetBlue;
            this.data1.Location = new System.Drawing.Point(4, 180);
            this.data1.Margin = new System.Windows.Forms.Padding(2);
            this.data1.Name = "data1";
            this.data1.RowTemplate.Height = 24;
            this.data1.Size = new System.Drawing.Size(725, 182);
            this.data1.TabIndex = 63;
            this.data1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data1_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Descripcion";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 117;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 84;
            // 
            // canthojas
            // 
            this.canthojas.HeaderText = "Cantidad de hojas";
            this.canthojas.Name = "canthojas";
            this.canthojas.ReadOnly = true;
            this.canthojas.Width = 114;
            // 
            // numlibro
            // 
            this.numlibro.HeaderText = "Libro Numero";
            this.numlibro.Name = "numlibro";
            this.numlibro.ReadOnly = true;
            this.numlibro.Width = 118;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 85;
            // 
            // factura
            // 
            this.factura.HeaderText = "Nf";
            this.factura.Name = "factura";
            this.factura.ReadOnly = true;
            this.factura.Width = 50;
            // 
            // comentario
            // 
            this.comentario.HeaderText = "comentario";
            this.comentario.Name = "comentario";
            this.comentario.Width = 113;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "RECEPCION"});
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "RECEPCION"});
            this.comboBox2.Location = new System.Drawing.Point(521, 324);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 23);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "RECEPCION";
            // 
            // cargar
            // 
            this.cargar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar.Image = ((System.Drawing.Image)(resources.GetObject("cargar.Image")));
            this.cargar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cargar.Location = new System.Drawing.Point(657, 565);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(102, 48);
            this.cargar.TabIndex = 3;
            this.cargar.Text = "cargar";
            this.cargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(782, 565);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cerrar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // articulosTableAdapter2
            // 
            this.articulosTableAdapter2.ClearBeforeFill = true;
            // 
            // imprimir
            // 
            this.imprimir.Enabled = false;
            this.imprimir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimir.Image = ((System.Drawing.Image)(resources.GetObject("imprimir.Image")));
            this.imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imprimir.Location = new System.Drawing.Point(504, 565);
            this.imprimir.Margin = new System.Windows.Forms.Padding(2);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(131, 48);
            this.imprimir.TabIndex = 4;
            this.imprimir.Text = "Imprimir Comp";
            this.imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imprimir.UseVisualStyleBackColor = true;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(20, 565);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 48);
            this.button9.TabIndex = 2;
            this.button9.Text = "Nuevo Comprobante";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(706, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 130);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones  Generales";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(908, 618);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Name = "Form8";
            this.Text = "Carga de Comprobantes ";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox entrega;
        private gestionrubricasDataSet3 gestionrubricasDataSet3;
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private gestionrubricasDataSet3TableAdapters.articulosTableAdapter articulosTableAdapter;
        private System.Windows.Forms.Label label13;
        private gestionrubricasDataSet4 gestionrubricasDataSet4;
        private System.Windows.Forms.BindingSource articulosBindingSource1;
        private gestionrubricasDataSet4TableAdapters.articulosTableAdapter articulosTableAdapter1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView data1;
        private gestionrubricasDataSet14 gestionrubricasDataSet14;
        private System.Windows.Forms.BindingSource articulosBindingSource2;
        private gestionrubricasDataSet14TableAdapters.articulosTableAdapter articulosTableAdapter2;
        private System.Windows.Forms.Button imprimir;
        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.TextBox boton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn canthojas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numlibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentario;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox numerolibro;
        public System.Windows.Forms.TextBox cantidad;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
    }
}