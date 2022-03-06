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
    public partial class buscarUSUARIO : Form
    {
        public buscarUSUARIO()
        {
            InitializeComponent();
        }

        private void buscarUSUARIO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet1.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter1.Fill(this.gestionrubricasDataSet1.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet17.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.gestionrubricasDataSet17.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'tipousuarios.tipohusuarios' Puede moverla o quitarla según sea necesario.
     
        }
    }
}
