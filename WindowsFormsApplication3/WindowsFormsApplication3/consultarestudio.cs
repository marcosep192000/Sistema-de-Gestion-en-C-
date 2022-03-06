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
    public partial class consultarestudio : Form
    {
        public delegate void  pasar ( string idestudio ,string nombre,string cuit,string telefono,string direccion,string ciudad, string codigopostal,string numero,string piso,string mail,string oficina,string alta, string nombrecontacto,string provincia);
        public event pasar pasa;

        public consultarestudio()
        {
            InitializeComponent();
        }

        private void consultarestudio_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.YellowGreen;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet25.estudios' Puede moverla o quitarla según sea necesario.
            this.estudiosTableAdapter2.Fill(this.gestionrubricasDataSet25.estudios);
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet24.estudios' Puede moverla o quitarla según sea necesario.
            this.estudiosTableAdapter1.Fill(this.gestionrubricasDataSet24.estudios);
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet23.estudios' Puede moverla o quitarla según sea necesario.
            this.estudiosTableAdapter.Fill(this.gestionrubricasDataSet23.estudios);

        }

      

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idestudio = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            string nombre= Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            string cuit= Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            string telefono = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            string direccion = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            string ciudad = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            string codigopostal = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            string numero = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            string piso= Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
            string mail= Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
            string oficina= Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
            string alta= Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
            string nombrecontacto= Convert.ToString(dataGridView1.CurrentRow.Cells[12].Value);
            string provincia = Convert.ToString(dataGridView1.CurrentRow.Cells[13].Value);
            pasa(idestudio,nombre, cuit, telefono, direccion, ciudad, codigopostal, numero, piso, mail, oficina, alta, nombrecontacto,provincia);
            this.Hide();
}
    }
}
