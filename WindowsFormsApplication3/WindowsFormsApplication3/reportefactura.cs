using Microsoft.Reporting.WinForms;
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
    public partial class reportefactura : Form
    {
        public reportefactura()
        {
            InitializeComponent();
        }

       public void reportefactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataclientes.clientes' Puede moverla o quitarla según sea necesario.
                    // TODO: esta línea de código carga datos en la tabla 'dataclientes.estudios' Puede moverla o quitarla según sea necesario.
            this.estudiosTableAdapter.Fill(this.dataclientes.estudios);
            // TODO: esta línea de código carga datos en la tabla 'facturas.ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.facturas.ventas);
            // TODO: esta línea de código carga datos en la tabla 'facturas.Venta_Cliente' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'facturas.clientes' Puede moverla o quitarla según sea necesario.


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
