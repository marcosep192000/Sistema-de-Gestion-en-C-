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
    public partial class buscarlibro : Form
    {
        public delegate void datos(string idlibro, string nombrelibro);
        public event datos pasar; 
        public buscarlibro()
        {
            InitializeComponent();
        }

        private void buscarlibro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet26.articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.gestionrubricasDataSet26.articulos);

        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idlibro = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            string nombrelibro = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);

            pasar(idlibro, nombrelibro);
            this.Close();

        }
    }
}
