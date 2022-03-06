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
    public partial class clientesporestudio : Form
    {
        public clientesporestudio()
        {
            InitializeComponent();
        }
        SqlDataAdapter da; SqlConnection conexion; DataTable drt; 
        private void clientesporestudio_Load(object sender, EventArgs e)
        {
            //    SqlConnection conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
            conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            string sql = "select nombre from estudios";

            using (da = new SqlDataAdapter(sql, conexion))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                this.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                foreach (DataRow dr in dt.Rows)
                {
                    this.textBox1.AutoCompleteCustomSource.Add(dr[0].ToString());
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Violet;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            SqlCommand consultaestudios = new SqlCommand("SELECT dbo.clientes.nombre, dbo.clientes.direccion, dbo.clientes.cuit, dbo.clientes.telefono1, dbo.clientes.telefono2, dbo.clientes.mail2, dbo.clientes.codigopostal, dbo.clientes.contacto1, dbo.clientes.contacto2,dbo.clientes.codigo_ciudad, dbo.clientes.mail, dbo.estudios.nombre AS Expr1 FROM            dbo.estudios INNER JOIN dbo.clientes ON dbo.estudios.idestudio = dbo.clientes.idestudi WHERE        (dbo.estudios.nombre ='" + textBox1.Text + "')", conexion);
            SqlDataAdapter adap = new SqlDataAdapter(consultaestudios);
            drt = new DataTable();

            adap.Fill(drt);
            dataGridView1.DataSource = drt;
           
        }
    }
}
