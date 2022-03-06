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
    public partial class buscarcliente : Form
    {
        public buscarcliente()
        {
            InitializeComponent();
        }
        SqlDataAdapter adaptador, da;
        SqlConnection conexion; DataTable drt;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }


        private void buscarcliente_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.SteelBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.YellowGreen;
          
            //    SqlConnection conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
            conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            string sql = "select nombre from clientes";



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
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("SELECT dbo.clientes.nombre, dbo.tipoempresas.tipo_empresa, dbo.clientes.direccion, dbo.clientes.cuit, dbo.clientes.telefono1, dbo.clientes.telefono2, dbo.clientes.mail2, dbo.clientes.contacto1, dbo.clientes.contacto2,dbo.clientes.mail, dbo.estudios.nombre AS Estudio FROM  dbo.clientes INNER JOIN dbo.tipoempresas ON dbo.clientes.tipo = dbo.tipoempresas.id_empresa INNER JOIN dbo.estudios ON dbo.clientes.idestudi = dbo.estudios.idestudio WHERE        (dbo.clientes.nombre = '"+textBox1.Text+ "') ", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta);
            DataTable datos = new DataTable();
            adaptador.Fill(datos);
            dataGridView1.DataSource = datos; 

        }
    }
}
