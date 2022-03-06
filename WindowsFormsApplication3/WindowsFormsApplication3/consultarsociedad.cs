using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 
namespace WindowsFormsApplication3
{
    public partial class consultarsociedad : Form
    {
        public delegate void datos(string idempresa, string nombreempresa);
        public event datos pasar; 
        public consultarsociedad()
        {
        
         

            InitializeComponent();
        }
                   
 

        private void consultarsociedad_Load(object sender, EventArgs e)
        {
              
            
            // TODO: esta línea de código carga datos en la tabla 'tipodeempresas.tipoempresas' Puede moverla o quitarla según sea necesario.
            this.tipoempresasTableAdapter.Fill(this.tipodeempresas.tipoempresas);

        }

       public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idempresa = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            string nombreempresa = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);

            pasar(idempresa,nombreempresa);
            this.Close();
        
        }
    }
}
