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
    public partial class Formestudios : Form
    {
        public Formestudios()
        {
            InitializeComponent();
        }

        private void Formestudios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataclientes.estudios' Puede moverla o quitarla según sea necesario.
            this.estudiosTableAdapter.Fill(this.dataclientes.estudios);

            this.reportViewer1.RefreshReport();
        }
    }
}
