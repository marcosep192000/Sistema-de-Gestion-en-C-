namespace WindowsFormsApplication3
{
  public  partial class Form2
  {

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moduloUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.gggToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarCecionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hfghfgToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.modificarOpcionesDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevopedido = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIÈNTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoclie = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lklklklToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mantenimientoEstudiosContablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEstudiosContablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjhjhjToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoPorClieteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEstudiosPorClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fondosDeEscritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadeteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbn = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label1t = new System.Windows.Forms.ToolStripStatusLabel();
            this.segundos = new System.Windows.Forms.ToolStripStatusLabel();
            this.minutos = new System.Windows.Forms.ToolStripStatusLabel();
            this.horas = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduloUsuariosToolStripMenuItem,
            this.cLIÈNTESToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.envioDeEmailsToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.cadeteriaToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // moduloUsuariosToolStripMenuItem
            // 
            this.moduloUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasUsuario,
            this.gggToolStripMenuItem,
            this.cerrarCecionToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.hfghfgToolStripMenuItem,
            this.modificarOpcionesDeUsuarioToolStripMenuItem});
            resources.ApplyResources(this.moduloUsuariosToolStripMenuItem, "moduloUsuariosToolStripMenuItem");
            this.moduloUsuariosToolStripMenuItem.Name = "moduloUsuariosToolStripMenuItem";
            // 
            // altasUsuario
            // 
            resources.ApplyResources(this.altasUsuario, "altasUsuario");
            this.altasUsuario.Name = "altasUsuario";
            this.altasUsuario.Click += new System.EventHandler(this.altasUsuario_Click);
            // 
            // gggToolStripMenuItem
            // 
            this.gggToolStripMenuItem.Name = "gggToolStripMenuItem";
            resources.ApplyResources(this.gggToolStripMenuItem, "gggToolStripMenuItem");
            // 
            // cerrarCecionToolStripMenuItem
            // 
            resources.ApplyResources(this.cerrarCecionToolStripMenuItem, "cerrarCecionToolStripMenuItem");
            this.cerrarCecionToolStripMenuItem.Name = "cerrarCecionToolStripMenuItem";
            this.cerrarCecionToolStripMenuItem.Click += new System.EventHandler(this.cerrarCecionToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            resources.ApplyResources(this.cerrarToolStripMenuItem, "cerrarToolStripMenuItem");
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // hfghfgToolStripMenuItem
            // 
            this.hfghfgToolStripMenuItem.Name = "hfghfgToolStripMenuItem";
            resources.ApplyResources(this.hfghfgToolStripMenuItem, "hfghfgToolStripMenuItem");
            // 
            // modificarOpcionesDeUsuarioToolStripMenuItem
            // 
            this.modificarOpcionesDeUsuarioToolStripMenuItem.Name = "modificarOpcionesDeUsuarioToolStripMenuItem";
            resources.ApplyResources(this.modificarOpcionesDeUsuarioToolStripMenuItem, "modificarOpcionesDeUsuarioToolStripMenuItem");
            this.modificarOpcionesDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarOpcionesDeUsuarioToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevopedido,
            this.toolStripMenuItem2,
            this.modificarEstadoToolStripMenuItem,
            this.toolStripMenuItem3});
            resources.ApplyResources(this.facturacionToolStripMenuItem, "facturacionToolStripMenuItem");
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            // 
            // nuevopedido
            // 
            this.nuevopedido.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            resources.ApplyResources(this.nuevopedido, "nuevopedido");
            this.nuevopedido.Name = "nuevopedido";
            this.nuevopedido.Click += new System.EventHandler(this.nuevoPedidoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // modificarEstadoToolStripMenuItem
            // 
            this.modificarEstadoToolStripMenuItem.Name = "modificarEstadoToolStripMenuItem";
            resources.ApplyResources(this.modificarEstadoToolStripMenuItem, "modificarEstadoToolStripMenuItem");
            this.modificarEstadoToolStripMenuItem.Click += new System.EventHandler(this.modificarEstadoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // cLIÈNTESToolStripMenuItem
            // 
            this.cLIÈNTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoclie,
            this.lklklklToolStripMenuItem,
            this.mantenimientoEstudiosContablesToolStripMenuItem,
            this.hjhjhjToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem1,
            this.historicoPorClieteToolStripMenuItem,
            this.listadoDeEstudiosPorClientesToolStripMenuItem});
            resources.ApplyResources(this.cLIÈNTESToolStripMenuItem, "cLIÈNTESToolStripMenuItem");
            this.cLIÈNTESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cLIÈNTESToolStripMenuItem.Name = "cLIÈNTESToolStripMenuItem";
            // 
            // mantenimientoclie
            // 
            this.mantenimientoclie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClientesToolStripMenuItem});
            resources.ApplyResources(this.mantenimientoclie, "mantenimientoclie");
            this.mantenimientoclie.Name = "mantenimientoclie";
            this.mantenimientoclie.Click += new System.EventHandler(this.mantenimientoClientesToolStripMenuItem_Click_1);
            // 
            // altaClientesToolStripMenuItem
            // 
            this.altaClientesToolStripMenuItem.Name = "altaClientesToolStripMenuItem";
            resources.ApplyResources(this.altaClientesToolStripMenuItem, "altaClientesToolStripMenuItem");
            this.altaClientesToolStripMenuItem.Click += new System.EventHandler(this.altaClientesToolStripMenuItem_Click);
            // 
            // lklklklToolStripMenuItem
            // 
            this.lklklklToolStripMenuItem.Name = "lklklklToolStripMenuItem";
            resources.ApplyResources(this.lklklklToolStripMenuItem, "lklklklToolStripMenuItem");
            // 
            // mantenimientoEstudiosContablesToolStripMenuItem
            // 
            this.mantenimientoEstudiosContablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEstudiosContablesToolStripMenuItem});
            resources.ApplyResources(this.mantenimientoEstudiosContablesToolStripMenuItem, "mantenimientoEstudiosContablesToolStripMenuItem");
            this.mantenimientoEstudiosContablesToolStripMenuItem.Name = "mantenimientoEstudiosContablesToolStripMenuItem";
            this.mantenimientoEstudiosContablesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoEstudiosContablesToolStripMenuItem_Click);
            // 
            // altaEstudiosContablesToolStripMenuItem
            // 
            this.altaEstudiosContablesToolStripMenuItem.Name = "altaEstudiosContablesToolStripMenuItem";
            resources.ApplyResources(this.altaEstudiosContablesToolStripMenuItem, "altaEstudiosContablesToolStripMenuItem");
            this.altaEstudiosContablesToolStripMenuItem.Click += new System.EventHandler(this.altaEstudiosContablesToolStripMenuItem_Click);
            // 
            // hjhjhjToolStripMenuItem
            // 
            this.hjhjhjToolStripMenuItem.Name = "hjhjhjToolStripMenuItem";
            resources.ApplyResources(this.hjhjhjToolStripMenuItem, "hjhjhjToolStripMenuItem");
            // 
            // buscarClienteToolStripMenuItem
            // 
            resources.ApplyResources(this.buscarClienteToolStripMenuItem, "buscarClienteToolStripMenuItem");
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem1
            // 
            resources.ApplyResources(this.buscarClienteToolStripMenuItem1, "buscarClienteToolStripMenuItem1");
            this.buscarClienteToolStripMenuItem1.Name = "buscarClienteToolStripMenuItem1";
            this.buscarClienteToolStripMenuItem1.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem1_Click);
            // 
            // historicoPorClieteToolStripMenuItem
            // 
            resources.ApplyResources(this.historicoPorClieteToolStripMenuItem, "historicoPorClieteToolStripMenuItem");
            this.historicoPorClieteToolStripMenuItem.Name = "historicoPorClieteToolStripMenuItem";
            this.historicoPorClieteToolStripMenuItem.Click += new System.EventHandler(this.historicoPorClieteToolStripMenuItem_Click);
            // 
            // listadoDeEstudiosPorClientesToolStripMenuItem
            // 
            resources.ApplyResources(this.listadoDeEstudiosPorClientesToolStripMenuItem, "listadoDeEstudiosPorClientesToolStripMenuItem");
            this.listadoDeEstudiosPorClientesToolStripMenuItem.Name = "listadoDeEstudiosPorClientesToolStripMenuItem";
            this.listadoDeEstudiosPorClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEstudiosPorClientesToolStripMenuItem_Click);
            // 
            // envioDeEmailsToolStripMenuItem
            // 
            resources.ApplyResources(this.envioDeEmailsToolStripMenuItem, "envioDeEmailsToolStripMenuItem");
            this.envioDeEmailsToolStripMenuItem.Name = "envioDeEmailsToolStripMenuItem";
            this.envioDeEmailsToolStripMenuItem.Click += new System.EventHandler(this.envioDeEmailsToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fondosDeEscritosToolStripMenuItem});
            resources.ApplyResources(this.opcionesToolStripMenuItem, "opcionesToolStripMenuItem");
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            // 
            // fondosDeEscritosToolStripMenuItem
            // 
            this.fondosDeEscritosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leonToolStripMenuItem,
            this.marToolStripMenuItem,
            this.autoToolStripMenuItem});
            resources.ApplyResources(this.fondosDeEscritosToolStripMenuItem, "fondosDeEscritosToolStripMenuItem");
            this.fondosDeEscritosToolStripMenuItem.Name = "fondosDeEscritosToolStripMenuItem";
            // 
            // leonToolStripMenuItem
            // 
            resources.ApplyResources(this.leonToolStripMenuItem, "leonToolStripMenuItem");
            this.leonToolStripMenuItem.Name = "leonToolStripMenuItem";
            this.leonToolStripMenuItem.Click += new System.EventHandler(this.leonToolStripMenuItem_Click);
            // 
            // marToolStripMenuItem
            // 
            resources.ApplyResources(this.marToolStripMenuItem, "marToolStripMenuItem");
            this.marToolStripMenuItem.Name = "marToolStripMenuItem";
            this.marToolStripMenuItem.Click += new System.EventHandler(this.marToolStripMenuItem_Click);
            // 
            // autoToolStripMenuItem
            // 
            resources.ApplyResources(this.autoToolStripMenuItem, "autoToolStripMenuItem");
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Click += new System.EventHandler(this.autoToolStripMenuItem_Click);
            // 
            // cadeteriaToolStripMenuItem
            // 
            resources.ApplyResources(this.cadeteriaToolStripMenuItem, "cadeteriaToolStripMenuItem");
            this.cadeteriaToolStripMenuItem.Name = "cadeteriaToolStripMenuItem";
            this.cadeteriaToolStripMenuItem.Click += new System.EventHandler(this.cadeteriaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbn,
            this.Label1t,
            this.segundos,
            this.minutos,
            this.horas});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // lbn
            // 
            this.lbn.Name = "lbn";
            resources.ApplyResources(this.lbn, "lbn");
            this.lbn.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Label1t
            // 
            resources.ApplyResources(this.Label1t, "Label1t");
            this.Label1t.ForeColor = System.Drawing.Color.Red;
            this.Label1t.Name = "Label1t";
            // 
            // segundos
            // 
            resources.ApplyResources(this.segundos, "segundos");
            this.segundos.Name = "segundos";
            // 
            // minutos
            // 
            this.minutos.Name = "minutos";
            resources.ApplyResources(this.minutos, "minutos");
            // 
            // horas
            // 
            this.horas.Name = "horas";
            resources.ApplyResources(this.horas, "horas");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moduloUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIÈNTESToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem altaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEstudiosContablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarCecionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem altasUsuario;
        public System.Windows.Forms.ToolStripMenuItem mantenimientoclie;
        public System.Windows.Forms.ToolStripMenuItem mantenimientoEstudiosContablesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem envioDeEmailsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nuevopedido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoPorClieteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        public System.Windows.Forms.ToolStripSeparator modificarEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator gggToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator hfghfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator lklklklToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator hjhjhjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEstudiosPorClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbn;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripStatusLabel Label1t;
        private System.Windows.Forms.ToolStripStatusLabel segundos;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel minutos;
        private System.Windows.Forms.ToolStripStatusLabel horas;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fondosDeEscritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem cadeteriaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem modificarOpcionesDeUsuarioToolStripMenuItem;
    }
}