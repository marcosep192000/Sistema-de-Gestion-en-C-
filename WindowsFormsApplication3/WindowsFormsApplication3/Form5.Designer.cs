namespace WindowsFormsApplication3
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.direcciones = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idcontacto = new System.Windows.Forms.TextBox();
            this.grabar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.modificarti = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telefonos = new System.Windows.Forms.MaskedTextBox();
            this.pisos = new System.Windows.Forms.MaskedTextBox();
            this.numeros = new System.Windows.Forms.MaskedTextBox();
            this.combociudad = new System.Windows.Forms.ComboBox();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet15 = new WindowsFormsApplication3.gestionrubricasDataSet15();
            this.comboprovincia = new System.Windows.Forms.ComboBox();
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet7 = new WindowsFormsApplication3.gestionrubricasDataSet7();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboempresa = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet20 = new WindowsFormsApplication3.gestionrubricasDataSet20();
            this.label13 = new System.Windows.Forms.Label();
            this.emailS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.documentos = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.provinciaTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet7TableAdapters.provinciaTableAdapter();
            this.clientesTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet20TableAdapters.clientesTableAdapter();
            this.localidadTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet15TableAdapters.localidadTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mostrardatos = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet20)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Piso ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero ";
            // 
            // direcciones
            // 
            this.direcciones.Location = new System.Drawing.Point(10, 162);
            this.direcciones.Name = "direcciones";
            this.direcciones.Size = new System.Drawing.Size(202, 20);
            this.direcciones.TabIndex = 5;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(10, 109);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(202, 20);
            this.nom.TabIndex = 6;
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Id Contacto ";
            // 
            // idcontacto
            // 
            this.idcontacto.Location = new System.Drawing.Point(10, 41);
            this.idcontacto.Name = "idcontacto";
            this.idcontacto.Size = new System.Drawing.Size(85, 20);
            this.idcontacto.TabIndex = 11;
            this.idcontacto.AcceptsTabChanged += new System.EventHandler(this.idcontacto_AcceptsTabChanged);
            // 
            // grabar
            // 
            this.grabar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grabar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grabar.FlatAppearance.BorderSize = 0;
            this.grabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grabar.Image = ((System.Drawing.Image)(resources.GetObject("grabar.Image")));
            this.grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.grabar.Location = new System.Drawing.Point(337, -2);
            this.grabar.Name = "grabar";
            this.grabar.Size = new System.Drawing.Size(75, 77);
            this.grabar.TabIndex = 72;
            this.grabar.Text = "grabar ";
            this.grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grabar.UseVisualStyleBackColor = false;
            this.grabar.Click += new System.EventHandler(this.button8_Click);
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
            this.eliminar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eliminar.Location = new System.Drawing.Point(268, -1);
            this.eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(77, 79);
            this.eliminar.TabIndex = 68;
            this.eliminar.Text = "Cancelar ";
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
            this.consultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consultar.Image = ((System.Drawing.Image)(resources.GetObject("consultar.Image")));
            this.consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.consultar.Location = new System.Drawing.Point(91, -2);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(85, 77);
            this.consultar.TabIndex = 71;
            this.consultar.Text = "Consultar ";
            this.consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
                       // 
            // modificarti
            // 
            this.modificarti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modificarti.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modificarti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarti.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.modificarti.FlatAppearance.BorderSize = 0;
            this.modificarti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.modificarti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.modificarti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarti.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modificarti.Image = ((System.Drawing.Image)(resources.GetObject("modificarti.Image")));
            this.modificarti.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.modificarti.Location = new System.Drawing.Point(183, -1);
            this.modificarti.Margin = new System.Windows.Forms.Padding(4);
            this.modificarti.Name = "modificarti";
            this.modificarti.Size = new System.Drawing.Size(85, 78);
            this.modificarti.TabIndex = 69;
            this.modificarti.Text = "Modificar";
            this.modificarti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.modificarti.UseVisualStyleBackColor = false;
            this.modificarti.Click += new System.EventHandler(this.modificar_Click);
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
            this.nuevo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nuevo.Image = ((System.Drawing.Image)(resources.GetObject("nuevo.Image")));
            this.nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nuevo.Location = new System.Drawing.Point(-1, 0);
            this.nuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(85, 78);
            this.nuevo.TabIndex = 70;
            this.nuevo.Text = "Nuevo ";
            this.nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevo.UseVisualStyleBackColor = false;
            this.nuevo.Click += new System.EventHandler(this.button12_Click);
            this.nuevo.MouseCaptureChanged += new System.EventHandler(this.nuevo_MouseCaptureChanged);
          
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button13.Location = new System.Drawing.Point(433, -1);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(72, 77);
            this.button13.TabIndex = 73;
            this.button13.Text = "Cerrar";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.telefonos);
            this.groupBox1.Controls.Add(this.pisos);
            this.groupBox1.Controls.Add(this.numeros);
            this.groupBox1.Controls.Add(this.combociudad);
            this.groupBox1.Controls.Add(this.comboprovincia);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.comboempresa);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.emailS);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.apellidos);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.documentos);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.idcontacto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.direcciones);
            this.groupBox1.Controls.Add(this.nom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 346);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "label7";
            // 
            // telefonos
            // 
            this.telefonos.Location = new System.Drawing.Point(6, 209);
            this.telefonos.Mask = "000-000-0000";
            this.telefonos.Name = "telefonos";
            this.telefonos.Size = new System.Drawing.Size(204, 20);
            this.telefonos.TabIndex = 74;
            // 
            // pisos
            // 
            this.pisos.Location = new System.Drawing.Point(350, 162);
            this.pisos.Mask = "####";
            this.pisos.Name = "pisos";
            this.pisos.Size = new System.Drawing.Size(100, 20);
            this.pisos.TabIndex = 73;
            // 
            // numeros
            // 
            this.numeros.Location = new System.Drawing.Point(231, 162);
            this.numeros.Mask = "####";
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(100, 20);
            this.numeros.TabIndex = 72;
            // 
            // combociudad
            // 
            this.combociudad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.localidadBindingSource, "id", true));
            this.combociudad.DataSource = this.localidadBindingSource;
            this.combociudad.DisplayMember = "localidad";
            this.combociudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combociudad.FormattingEnabled = true;
            this.combociudad.Location = new System.Drawing.Point(228, 256);
            this.combociudad.Name = "combociudad";
            this.combociudad.Size = new System.Drawing.Size(222, 21);
            this.combociudad.TabIndex = 71;
            this.combociudad.ValueMember = "id_provincia";
            // 
            // localidadBindingSource
            // 
            this.localidadBindingSource.DataMember = "localidad";
            this.localidadBindingSource.DataSource = this.gestionrubricasDataSet15;
            // 
            // gestionrubricasDataSet15
            // 
            this.gestionrubricasDataSet15.DataSetName = "gestionrubricasDataSet15";
            this.gestionrubricasDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboprovincia
            // 
            this.comboprovincia.DataSource = this.provinciaBindingSource;
            this.comboprovincia.DisplayMember = "provincia";
            this.comboprovincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboprovincia.FormattingEnabled = true;
            this.comboprovincia.Location = new System.Drawing.Point(10, 256);
            this.comboprovincia.Name = "comboprovincia";
            this.comboprovincia.Size = new System.Drawing.Size(203, 21);
            this.comboprovincia.TabIndex = 70;
            this.comboprovincia.ValueMember = "id";
            this.comboprovincia.SelectedIndexChanged += new System.EventHandler(this.comboprovincia_SelectedIndexChanged);
            // 
            // provinciaBindingSource
            // 
            this.provinciaBindingSource.DataMember = "provincia";
            this.provinciaBindingSource.DataSource = this.gestionrubricasDataSet7;
            // 
            // gestionrubricasDataSet7
            // 
            this.gestionrubricasDataSet7.DataSetName = "gestionrubricasDataSet7";
            this.gestionrubricasDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(7, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 69;
            this.label15.Text = "Provincia :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(243, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 15);
            this.label16.TabIndex = 68;
            this.label16.Text = "Ciudad :";
            this.label16.UseWaitCursor = true;
            // 
            // comboempresa
            // 
            this.comboempresa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientesBindingSource, "idcliente", true));
            this.comboempresa.DataSource = this.clientesBindingSource;
            this.comboempresa.DisplayMember = "nombre";
            this.comboempresa.FormattingEnabled = true;
            this.comboempresa.Location = new System.Drawing.Point(228, 41);
            this.comboempresa.Name = "comboempresa";
            this.comboempresa.Size = new System.Drawing.Size(225, 21);
            this.comboempresa.TabIndex = 24;
            this.comboempresa.ValueMember = "idcliente";
            this.comboempresa.SelectedIndexChanged += new System.EventHandler(this.comboempresa_SelectedIndexChanged);
            this.comboempresa.SelectedValueChanged += new System.EventHandler(this.comboempresa_SelectedValueChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.gestionrubricasDataSet20;
            // 
            // gestionrubricasDataSet20
            // 
            this.gestionrubricasDataSet20.DataSetName = "gestionrubricasDataSet20";
            this.gestionrubricasDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Empresa ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // emailS
            // 
            this.emailS.Location = new System.Drawing.Point(10, 304);
            this.emailS.Name = "emailS";
            this.emailS.Size = new System.Drawing.Size(200, 20);
            this.emailS.TabIndex = 22;
            this.emailS.Text = "nombre@dominio.com";
            this.emailS.TextChanged += new System.EventHandler(this.emailS_TextChanged);
            this.emailS.Validated += new System.EventHandler(this.emailS_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "E-Mail:  ";
            // 
            // apellidos
            // 
            this.apellidos.Location = new System.Drawing.Point(231, 109);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(219, 20);
            this.apellidos.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Apellido";
            // 
            // documentos
            // 
            this.documentos.Location = new System.Drawing.Point(231, 209);
            this.documentos.Mask = "##.###.###";
            this.documentos.Name = "documentos";
            this.documentos.Size = new System.Drawing.Size(219, 20);
            this.documentos.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Documento Nº:";
            // 
            // provinciaTableAdapter
            // 
            this.provinciaTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // localidadTableAdapter
            // 
            this.localidadTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrardatos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.TabIndex = 75;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mostrardatos
            // 
            this.mostrardatos.Name = "mostrardatos";
            this.mostrardatos.Size = new System.Drawing.Size(31, 17);
            this.mostrardatos.Text = "Info!";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 489);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.grabar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.modificarti);
            this.Controls.Add(this.nuevo);
            this.Name = "Form5";
            this.Text = "Nuevo Contacto ";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet20)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox direcciones;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idcontacto;
        private System.Windows.Forms.Button grabar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button modificarti;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox documentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboempresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox emailS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboprovincia;
        private System.Windows.Forms.ComboBox combociudad;
        private gestionrubricasDataSet7 gestionrubricasDataSet7;
        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private gestionrubricasDataSet7TableAdapters.provinciaTableAdapter provinciaTableAdapter;
        private gestionrubricasDataSet20 gestionrubricasDataSet20;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private gestionrubricasDataSet20TableAdapters.clientesTableAdapter clientesTableAdapter;
        private gestionrubricasDataSet15 gestionrubricasDataSet15;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private gestionrubricasDataSet15TableAdapters.localidadTableAdapter localidadTableAdapter;
        private System.Windows.Forms.MaskedTextBox telefonos;
        private System.Windows.Forms.MaskedTextBox pisos;
        private System.Windows.Forms.MaskedTextBox numeros;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button consultar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mostrardatos;
    }
}