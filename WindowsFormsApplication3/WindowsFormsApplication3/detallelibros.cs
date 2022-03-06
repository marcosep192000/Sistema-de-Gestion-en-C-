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
    public partial class detallelibros : Form
    {
        public detallelibros()
        {
            InitializeComponent();
        }

        public detallelibros(Form8 form8)
        {
            // TODO: Complete member initialization
            this.form8 = form8;
        }
        SqlDataAdapter adaptador;
        private Form8 form8;
        private void detallelibros_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Aqua;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;



      // SqlConnection  cnx = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
           SqlConnection cnx = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
             string query = "SELECT        dbo.clientes.nombre, dbo.prueba.fecha, dbo.articulos.nombredearticulo, dbo.detallefactura.numerolibro FROM dbo.clientes INNER JOIN dbo.prueba ON dbo.clientes.idcliente = dbo.prueba.clienteid INNER JOIN dbo.detallefactura ON dbo.prueba.numerofact = dbo.detallefactura.numerofact INNER JOIN dbo.articulos ON dbo.detallefactura.codigoarticul = dbo.articulos.codigoarticulo WHERE (dbo.clientes.nombre LIKE '%" + label1.Text + "%') AND (dbo.detallefactura.codigoarticul ='" + label3.Text + "') ";

            SqlCommand cmd = new SqlCommand(query, cnx);
           
                adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;

        }

     public void button1_Click(object sender, EventArgs e)
        {
          
            form8.cargargrid(); 

        }

        
      
    }
}
