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
    public partial class listadocompletoestudiosclientes : Form
    {
        public listadocompletoestudiosclientes()
        {
            InitializeComponent();
        }
        SqlDataAdapter adaptador; SqlConnection conexion;
private void listadocompletoestudiosclientes_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button5.Enabled = false; 


            //  SqlConnection cnx = conexion SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
             conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.YellowGreen;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            if (radioButton1.Checked)
            {
                SqlCommand consu = new SqlCommand("SELECT        dbo.clientes.nombre, dbo.tipoempresas.tipo_empresa ,dbo.clientes.direccion, dbo.clientes.cuit, dbo.clientes.telefono1, dbo.clientes.mail2, dbo.clientes.codigopostal, dbo.clientes.contacto1, dbo.clientes.mail,dbo.provincia.provincia, dbo.localidad.localidad Expr1  FROM            dbo.clientes INNER JOIN dbo.estudios ON dbo.clientes.idestudi = dbo.estudios.idestudio INNER JOIN dbo.localidad ON dbo.clientes.codigo_ciudad = dbo.localidad.id INNER JOIN dbo.provincia ON dbo.localidad.id_provincia = dbo.provincia.id INNER JOIN dbo.tipoempresas ON dbo.clientes.tipo = dbo.tipoempresas.id_empresa", conexion);

                adaptador = new SqlDataAdapter(consu);
                DataTable ds = new DataTable();
                adaptador.Fill(ds);
                dataGridView1.DataSource = ds;
 button1.Enabled = true;
 button5.Enabled = false; 
            }
            if (radioButton2.Checked)
            {


                SqlCommand cons = new SqlCommand("SELECT        dbo.estudios.nombre AS Nombre, dbo.estudios.cuit AS Nº_Cuit, dbo.estudios.direccion AS Direccion, dbo.estudios.telefono AS Telefono, dbo.localidad.localidad AS Localidad, dbo.provincia.provincia AS Provincia,dbo.estudios.codigopostal AS Cod_Postal, dbo.estudios.nombrecontacto1 AS Contacto_1, dbo.estudios.telefono1 as Telefono, dbo.estudios.mail1 AS Mail, dbo.estudios.nombrecontacto2 as Contacto_2, dbo.estudios.telefonocontacto2 as Telefono_2, dbo.estudios.mail2 as Mail_2 FROM dbo.estudios INNER JOIN dbo.localidad ON dbo.estudios.ciudad = dbo.localidad.id INNER JOIN dbo.provincia ON dbo.localidad.id_provincia = dbo.provincia.id", conexion);

                adaptador = new SqlDataAdapter(cons);
                DataTable dr = new DataTable();
                adaptador.Fill(dr);
                dataGridView1.DataSource = dr;
                button1.Enabled = false; 
                button5.Enabled = true; 


            }

        }

        
    }
}
