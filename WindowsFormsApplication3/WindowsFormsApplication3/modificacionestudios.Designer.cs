﻿namespace WindowsFormsApplication3
{
    partial class modificacionestudios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificacionestudios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet8 = new WindowsFormsApplication3.gestionrubricasDataSet8();
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet9 = new WindowsFormsApplication3.gestionrubricasDataSet9();
            this.label16 = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.ComboBox();
            this.buscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numerocliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cuit = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.nombre2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.mail2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.telefono2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.telefono1 = new System.Windows.Forms.TextBox();
            this.mail1 = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre1 = new System.Windows.Forms.TextBox();
            this.Modificar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.provinciaTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet9TableAdapters.provinciaTableAdapter();
            this.localidadTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet8TableAdapters.localidadTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.ciudad);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.numerocliente);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cuit);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.nombre2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.mail2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.telefono2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.telefono1);
            this.groupBox1.Controls.Add(this.mail1);
            this.groupBox1.Controls.Add(this.direccion);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nombre1);
            this.groupBox1.Location = new System.Drawing.Point(48, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(507, 412);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estudios Contables ";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.localidadBindingSource, "id_provincia", true));
            this.comboBox2.DataSource = this.provinciaBindingSource;
            this.comboBox2.DisplayMember = "provincia";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(28, 342);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(190, 21);
            this.comboBox2.TabIndex = 82;
            this.comboBox2.ValueMember = "id";
            // 
            // localidadBindingSource
            // 
            this.localidadBindingSource.DataMember = "localidad";
            this.localidadBindingSource.DataSource = this.gestionrubricasDataSet8;
            // 
            // gestionrubricasDataSet8
            // 
            this.gestionrubricasDataSet8.DataSetName = "gestionrubricasDataSet8";
            this.gestionrubricasDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciaBindingSource
            // 
            this.provinciaBindingSource.DataMember = "provincia";
            this.provinciaBindingSource.DataSource = this.gestionrubricasDataSet9;
            // 
            // gestionrubricasDataSet9
            // 
            this.gestionrubricasDataSet9.DataSetName = "gestionrubricasDataSet9";
            this.gestionrubricasDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label16.Location = new System.Drawing.Point(27, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 15);
            this.label16.TabIndex = 82;
            this.label16.Text = "Codigo :";
            // 
            // ciudad
            // 
            this.ciudad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.provinciaBindingSource, "id", true));
            this.ciudad.DataSource = this.localidadBindingSource;
            this.ciudad.DisplayMember = "localidad";
            this.ciudad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudad.FormattingEnabled = true;
            this.ciudad.Location = new System.Drawing.Point(28, 386);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(192, 22);
            this.ciudad.TabIndex = 83;
            this.ciudad.ValueMember = "id";
            // 
            // buscar
            // 
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Image = ((System.Drawing.Image)(resources.GetObject("buscar.Image")));
            this.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscar.Location = new System.Drawing.Point(313, 15);
            this.buscar.Margin = new System.Windows.Forms.Padding(2);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(91, 30);
            this.buscar.TabIndex = 79;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(25, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 85;
            this.label9.Text = "Provincia :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(25, 368);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 15);
            this.label17.TabIndex = 84;
            this.label17.Text = "Ciudad :";
            this.label17.UseWaitCursor = true;
            // 
            // numerocliente
            // 
            this.numerocliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numerocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerocliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numerocliente.Location = new System.Drawing.Point(27, 82);
            this.numerocliente.Margin = new System.Windows.Forms.Padding(2);
            this.numerocliente.Multiline = true;
            this.numerocliente.Name = "numerocliente";
            this.numerocliente.Size = new System.Drawing.Size(193, 19);
            this.numerocliente.TabIndex = 81;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(25, 23);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 15);
            this.label15.TabIndex = 78;
            this.label15.Text = "Buscar estudio:";
            // 
            // textBox
            // 
            this.textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox.Location = new System.Drawing.Point(148, 19);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(160, 20);
            this.textBox.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(27, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudio contable :";
            // 
            // cuit
            // 
            this.cuit.Location = new System.Drawing.Point(27, 221);
            this.cuit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(191, 20);
            this.cuit.TabIndex = 2;
            this.cuit.UseWaitCursor = true;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(28, 131);
            this.nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(189, 20);
            this.nombre.TabIndex = 0;
            // 
            // nombre2
            // 
            this.nombre2.Location = new System.Drawing.Point(256, 215);
            this.nombre2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nombre2.Name = "nombre2";
            this.nombre2.Size = new System.Drawing.Size(210, 20);
            this.nombre2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Cuit Nº : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(253, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 15);
            this.label10.TabIndex = 77;
            this.label10.Text = "Telefono de contacto Nº2:";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(27, 301);
            this.codigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(191, 20);
            this.codigo.TabIndex = 4;
            this.codigo.UseWaitCursor = true;
            // 
            // mail2
            // 
            this.mail2.Location = new System.Drawing.Point(255, 294);
            this.mail2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mail2.Name = "mail2";
            this.mail2.Size = new System.Drawing.Size(210, 20);
            this.mail2.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(25, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 15);
            this.label12.TabIndex = 64;
            this.label12.Text = "Codigo postal :";
            this.label12.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(253, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 15);
            this.label11.TabIndex = 74;
            this.label11.Text = "Direccion de e-mail Nº2:";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(27, 174);
            this.telefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(191, 20);
            this.telefono.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(253, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 15);
            this.label14.TabIndex = 75;
            this.label14.Text = "Nombre de contacto Nº 2 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(25, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 58;
            this.label8.Text = "Direccion :";
            // 
            // telefono2
            // 
            this.telefono2.Location = new System.Drawing.Point(256, 254);
            this.telefono2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.telefono2.Name = "telefono2";
            this.telefono2.Size = new System.Drawing.Size(210, 20);
            this.telefono2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(253, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 15);
            this.label4.TabIndex = 71;
            this.label4.Text = "Telefono de contacto Nº1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(25, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "Telefono :";
            this.label6.UseWaitCursor = true;
            // 
            // telefono1
            // 
            this.telefono1.Location = new System.Drawing.Point(255, 127);
            this.telefono1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.telefono1.Name = "telefono1";
            this.telefono1.Size = new System.Drawing.Size(210, 20);
            this.telefono1.TabIndex = 8;
            // 
            // mail1
            // 
            this.mail1.Location = new System.Drawing.Point(254, 174);
            this.mail1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mail1.Name = "mail1";
            this.mail1.Size = new System.Drawing.Size(209, 20);
            this.mail1.TabIndex = 9;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(27, 262);
            this.direccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(191, 20);
            this.direccion.TabIndex = 3;
            this.direccion.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(253, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 15);
            this.label13.TabIndex = 68;
            this.label13.Text = "Nombre de contacto Nº1 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(253, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 67;
            this.label3.Text = "Direccion de e-mail 1 : ";
            // 
            // nombre1
            // 
            this.nombre1.Location = new System.Drawing.Point(254, 84);
            this.nombre1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nombre1.Name = "nombre1";
            this.nombre1.Size = new System.Drawing.Size(210, 20);
            this.nombre1.TabIndex = 7;
            // 
            // Modificar
            // 
            this.Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Modificar.Image")));
            this.Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modificar.Location = new System.Drawing.Point(263, 429);
            this.Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(93, 39);
            this.Modificar.TabIndex = 79;
            this.Modificar.Text = "Modificar";
            this.Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(461, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 37);
            this.button3.TabIndex = 80;
            this.button3.Text = "Cerrar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Image = ((System.Drawing.Image)(resources.GetObject("limpiar.Image")));
            this.limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.limpiar.Location = new System.Drawing.Point(361, 430);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(94, 39);
            this.limpiar.TabIndex = 78;
            this.limpiar.Text = "&Limpiar";
            this.limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limpiar.UseVisualStyleBackColor = false;
            // 
            // provinciaTableAdapter
            // 
            this.provinciaTableAdapter.ClearBeforeFill = true;
            // 
            // localidadTableAdapter
            // 
            this.localidadTableAdapter.ClearBeforeFill = true;
            // 
            // modificacionestudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(574, 487);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.limpiar);
            this.Name = "modificacionestudios";
            this.Text = "modificacionestudios";
            this.Load += new System.EventHandler(this.modificacionestudios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox nombre2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox mail2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox telefono2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefono1;
        private System.Windows.Forms.TextBox mail1;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre1;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox numerocliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox;
        private gestionrubricasDataSet9 gestionrubricasDataSet9;
        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private gestionrubricasDataSet9TableAdapters.provinciaTableAdapter provinciaTableAdapter;
        private gestionrubricasDataSet8 gestionrubricasDataSet8;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private gestionrubricasDataSet8TableAdapters.localidadTableAdapter localidadTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox ciudad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
    }
}