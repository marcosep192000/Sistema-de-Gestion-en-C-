using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class consultarContacto : Form
    {
        public delegate void dato(string id_contacto, string Nombre_de_Contacto, string Mailcontacto, string TelefonoContacto, string Celular, string empresa, string id_empresa, string provincia, string ciudad, string email, string documento, string direccion, string numero, string piso,string apellido);
        public event dato pasa;
        public consultarContacto()
        {

            InitializeComponent();
        }
        string parar; 
        private void consultarContacto_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.YellowGreen;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            parar = parar; 
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet22.contactoporempres' Puede moverla o quitarla según sea necesario.
            this.contactoporempresTableAdapter1.Fill(this.gestionrubricasDataSet22.contactoporempres);

            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;


            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;

        }

        private void dataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {

        }

        private void dataGridView1_RowDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_contacto = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            string Nombre_de_Contacto = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            string Mailcontacto = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);


            string TelefonoContacto = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            string Celular = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            string empresa = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            string id_empresa = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            string provincia = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            string ciudad = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
            string email = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
            string documento = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
            string direccion = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
            string numero = Convert.ToString(dataGridView1.CurrentRow.Cells[12].Value);
            string piso = Convert.ToString(dataGridView1.CurrentRow.Cells[13].Value);
            string apellido = Convert.ToString(dataGridView1.CurrentRow.Cells[14].Value);


            pasa(id_contacto, Nombre_de_Contacto, Mailcontacto, TelefonoContacto, Celular, empresa, id_empresa, provincia, ciudad, email, documento, direccion, numero, piso,apellido);
            this.Close();
        }

 
    }
}
