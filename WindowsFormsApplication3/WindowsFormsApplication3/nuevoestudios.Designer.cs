namespace WindowsFormsApplication3
{
    partial class nuevoestudios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoestudios));
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet9 = new WindowsFormsApplication3.gestionrubricasDataSet9();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionrubricasDataSet8 = new WindowsFormsApplication3.gestionrubricasDataSet8();
            this.provinciaTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet9TableAdapters.provinciaTableAdapter();
            this.localidadTableAdapter = new WindowsFormsApplication3.gestionrubricasDataSet8TableAdapters.localidadTableAdapter();
            this.grabar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.modific = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ciudads = new System.Windows.Forms.ComboBox();
            this.codigopostals = new System.Windows.Forms.MaskedTextBox();
            this.nombre2 = new System.Windows.Forms.MaskedTextBox();
            this.telefono1 = new System.Windows.Forms.MaskedTextBox();
            this.nombre1 = new System.Windows.Forms.MaskedTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.telefono2 = new System.Windows.Forms.MaskedTextBox();
            this.nombres = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cuits = new System.Windows.Forms.MaskedTextBox();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cargar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.direccions = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.telefonos = new System.Windows.Forms.TextBox();
            this.mail1 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.mail2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet8)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // provinciaTableAdapter
            // 
            this.provinciaTableAdapter.ClearBeforeFill = true;
            // 
            // localidadTableAdapter
            // 
            this.localidadTableAdapter.ClearBeforeFill = true;
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
            this.grabar.Location = new System.Drawing.Point(318, 11);
            this.grabar.Name = "grabar";
            this.grabar.Size = new System.Drawing.Size(75, 89);
            this.grabar.TabIndex = 91;
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
            this.eliminar.Location = new System.Drawing.Point(414, 10);
            this.eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(77, 90);
            this.eliminar.TabIndex = 86;
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
            this.consultar.Location = new System.Drawing.Point(107, 12);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(85, 89);
            this.consultar.TabIndex = 90;
            this.consultar.Text = "&Consultar Estudio";
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
            this.modific.Location = new System.Drawing.Point(213, 11);
            this.modific.Margin = new System.Windows.Forms.Padding(4);
            this.modific.Name = "modific";
            this.modific.Size = new System.Drawing.Size(85, 89);
            this.modific.TabIndex = 87;
            this.modific.Text = "&Modificar Estudio";
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
            this.nuevo.Location = new System.Drawing.Point(15, 12);
            this.nuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(85, 89);
            this.nuevo.TabIndex = 89;
            this.nuevo.Text = "&Nuevo Estudio";
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
            this.cerrar.Location = new System.Drawing.Point(537, 10);
            this.cerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(72, 87);
            this.cerrar.TabIndex = 88;
            this.cerrar.Text = "&Cerrar";
            this.cerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cerrar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ciudads);
            this.groupBox2.Controls.Add(this.codigopostals);
            this.groupBox2.Controls.Add(this.nombre2);
            this.groupBox2.Controls.Add(this.telefono1);
            this.groupBox2.Controls.Add(this.nombre1);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.telefono2);
            this.groupBox2.Controls.Add(this.nombres);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cuits);
            this.groupBox2.Controls.Add(this.codigo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cargar);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.direccions);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.telefonos);
            this.groupBox2.Controls.Add(this.mail1);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.mail2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(15, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 346);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estudio Contable";
            // 
            // ciudads
            // 
            this.ciudads.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.localidadBindingSource, "id", true));
            this.ciudads.DataSource = this.localidadBindingSource;
            this.ciudads.DisplayMember = "localidad";
            this.ciudads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudads.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudads.FormattingEnabled = true;
            this.ciudads.Location = new System.Drawing.Point(292, 201);
            this.ciudads.Name = "ciudads";
            this.ciudads.Size = new System.Drawing.Size(227, 23);
            this.ciudads.TabIndex = 97;
            this.ciudads.ValueMember = "id_provincia";
            // 
            // codigopostals
            // 
            this.codigopostals.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.codigopostals.Location = new System.Drawing.Point(46, 249);
            this.codigopostals.Mask = "#####";
            this.codigopostals.Name = "codigopostals";
            this.codigopostals.Size = new System.Drawing.Size(197, 19);
            this.codigopostals.TabIndex = 96;
            // 
            // nombre2
            // 
            this.nombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.nombre2.Location = new System.Drawing.Point(450, 153);
            this.nombre2.Mask = "aaaa";
            this.nombre2.Name = "nombre2";
            this.nombre2.Size = new System.Drawing.Size(69, 19);
            this.nombre2.TabIndex = 95;
            // 
            // telefono1
            // 
            this.telefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.telefono1.Location = new System.Drawing.Point(363, 153);
            this.telefono1.Mask = "###";
            this.telefono1.Name = "telefono1";
            this.telefono1.Size = new System.Drawing.Size(73, 19);
            this.telefono1.TabIndex = 94;
            // 
            // nombre1
            // 
            this.nombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.nombre1.Location = new System.Drawing.Point(293, 153);
            this.nombre1.Mask = "#####";
            this.nombre1.Name = "nombre1";
            this.nombre1.Size = new System.Drawing.Size(56, 19);
            this.nombre1.TabIndex = 93;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(523, 264);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 12);
            this.label28.TabIndex = 86;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(443, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 16);
            this.label19.TabIndex = 78;
            this.label19.Text = "Alta :";
            // 
            // telefono2
            // 
            this.telefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.telefono2.Location = new System.Drawing.Point(446, 49);
            this.telefono2.Mask = "00/00/0000";
            this.telefono2.Name = "telefono2";
            this.telefono2.Size = new System.Drawing.Size(77, 19);
            this.telefono2.TabIndex = 1;
            this.telefono2.ValidatingType = typeof(System.DateTime);
            // 
            // nombres
            // 
            this.nombres.BackColor = System.Drawing.Color.White;
            this.nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombres.Location = new System.Drawing.Point(48, 100);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(196, 19);
            this.nombres.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(447, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 16);
            this.label18.TabIndex = 75;
            this.label18.Text = "Oficina";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(360, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 71;
            this.label9.Text = "Piso ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(294, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 16);
            this.label17.TabIndex = 72;
            this.label17.Text = "Numero ";
            // 
            // cuits
            // 
            this.cuits.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.cuits.Location = new System.Drawing.Point(292, 100);
            this.cuits.Mask = "##-########-#";
            this.cuits.Name = "cuits";
            this.cuits.Size = new System.Drawing.Size(231, 19);
            this.cuits.TabIndex = 3;
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.codigo.Location = new System.Drawing.Point(49, 49);
            this.codigo.Multiline = true;
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(111, 19);
            this.codigo.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(47, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 16);
            this.label15.TabIndex = 68;
            this.label15.Text = "Id Empresa:";
            // 
            // cargar
            // 
            this.cargar.BackColor = System.Drawing.SystemColors.Menu;
            this.cargar.FlatAppearance.BorderSize = 4;
            this.cargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar.Image = ((System.Drawing.Image)(resources.GetObject("cargar.Image")));
            this.cargar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cargar.Location = new System.Drawing.Point(681, 382);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(213, 37);
            this.cargar.TabIndex = 2;
            this.cargar.Text = "  &Nueva Empresa";
            this.cargar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.provinciaBindingSource;
            this.comboBox1.DisplayMember = "provincia";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 23);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(44, 281);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 16);
            this.label16.TabIndex = 35;
            this.label16.Text = "Direccion de e-mail  : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(47, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 16);
            this.label20.TabIndex = 65;
            this.label20.Text = "Provincia :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(47, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Razon social :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(291, 182);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 16);
            this.label23.TabIndex = 64;
            this.label23.Text = "Ciudad :";
            this.label23.UseWaitCursor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(291, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 16);
            this.label24.TabIndex = 2;
            this.label24.Text = "Cuit : ";
            // 
            // direccions
            // 
            this.direccions.BackColor = System.Drawing.Color.White;
            this.direccions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccions.Location = new System.Drawing.Point(47, 153);
            this.direccions.Name = "direccions";
            this.direccions.Size = new System.Drawing.Size(194, 19);
            this.direccions.TabIndex = 6;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(42, 135);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 16);
            this.label25.TabIndex = 53;
            this.label25.Text = "Direccion:";
            // 
            // telefonos
            // 
            this.telefonos.BackColor = System.Drawing.Color.White;
            this.telefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonos.Location = new System.Drawing.Point(292, 300);
            this.telefonos.Name = "telefonos";
            this.telefonos.Size = new System.Drawing.Size(232, 19);
            this.telefonos.TabIndex = 15;
            this.telefonos.Text = "Sin Datos .";
            // 
            // mail1
            // 
            this.mail1.BackColor = System.Drawing.Color.White;
            this.mail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail1.Location = new System.Drawing.Point(47, 300);
            this.mail1.Name = "mail1";
            this.mail1.Size = new System.Drawing.Size(196, 19);
            this.mail1.TabIndex = 14;
            this.mail1.Text = "ejemplo@dominio.com.ar";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(43, 228);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(95, 16);
            this.label27.TabIndex = 41;
            this.label27.Text = "Codigo postal :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label29.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label29.Location = new System.Drawing.Point(292, 281);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(119, 16);
            this.label29.TabIndex = 22;
            this.label29.Text = "Telefono Empresa :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label30.Location = new System.Drawing.Point(292, 228);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(137, 16);
            this.label30.TabIndex = 39;
            this.label30.Text = "Nombre de contacto : ";
            // 
            // mail2
            // 
            this.mail2.BackColor = System.Drawing.Color.White;
            this.mail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail2.Location = new System.Drawing.Point(293, 249);
            this.mail2.Name = "mail2";
            this.mail2.Size = new System.Drawing.Size(231, 19);
            this.mail2.TabIndex = 13;
            this.mail2.Text = "Sin Datos.";
            // 
            // nuevoestudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(626, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grabar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.modific);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.cerrar);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "nuevoestudios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Estudios contables                                             ";
            this.Load += new System.EventHandler(this.nuevoestudios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionrubricasDataSet8)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private gestionrubricasDataSet9 gestionrubricasDataSet9;
        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private gestionrubricasDataSet9TableAdapters.provinciaTableAdapter provinciaTableAdapter;
        private gestionrubricasDataSet8 gestionrubricasDataSet8;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private gestionrubricasDataSet8TableAdapters.localidadTableAdapter localidadTableAdapter;
        private System.Windows.Forms.Button grabar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button modific;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox codigopostals;
        private System.Windows.Forms.MaskedTextBox nombre2;
        private System.Windows.Forms.MaskedTextBox telefono1;
        private System.Windows.Forms.MaskedTextBox nombre1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox telefono2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox cuits;
        public System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox direccions;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox telefonos;
        private System.Windows.Forms.TextBox mail1;
        private System.Windows.Forms.TextBox nombres;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox mail2;
        private System.Windows.Forms.ComboBox ciudads;

    }
}