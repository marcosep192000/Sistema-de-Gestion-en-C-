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
using Microsoft.Reporting.WinForms; 
namespace WindowsFormsApplication3
{
    public partial class hisoricoporcliente : Form
    {
        public hisoricoporcliente()
        {
            InitializeComponent();
        }
        SqlDataAdapter adaptador, da;
        SqlConnection conexion; DataTable drt;
        private void hisoricoporcliente_Load(object sender, EventArgs e)
        {
           


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

            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.SteelBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AutoResizeRows();

             //  SqlConnection cnx = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
         SqlConnection cnx = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            string query = "SELECT        dbo.prueba.fecha, dbo.prueba.numerofact, dbo.estudios.nombre, dbo.prueba.retira, dbo.articulos.nombredearticulo, dbo.detallefactura.numerolibro, dbo.detallefactura.cantidadhojas, dbo.detallefactura.comentario, dbo.detallefactura.entrega FROM   dbo.clientes INNER JOIN  dbo.prueba ON dbo.clientes.idcliente = dbo.prueba.clienteid INNER JOIN dbo.detallefactura ON dbo.prueba.numerofact = dbo.detallefactura.numerofact INNER JOIN dbo.estudios ON dbo.clientes.idestudi = dbo.estudios.idestudio INNER JOIN dbo.articulos ON dbo.detallefactura.codigoarticul = dbo.articulos.codigoarticulo where dbo.clientes.nombre like  @param + '%' and   dbo.prueba.fecha  BETWEEN @param1 and @param2" ;

            SqlCommand cmd = new SqlCommand(query, cnx);
            if (textBox1.Text != (""))
            {

                cmd.Parameters.AddWithValue("@param", textBox1.Text);
                cmd.Parameters.AddWithValue("@param1", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@param2", dateTimePicker2.Value);
                adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Aqua;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;

            }

            else {


                MessageBox.Show("Ingrese datos para realizar la busqueda");
            }
            
        }

        public  void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
