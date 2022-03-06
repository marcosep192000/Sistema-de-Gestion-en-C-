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
    public partial class consultaclientesporfactura : Form
    {
        public consultaclientesporfactura()
        {
            InitializeComponent();
        }

        SqlDataAdapter adaptador,da ; 
 
        private void consultaclientesporfactura_Load(object sender, EventArgs e)
        {
      //    SqlConnection conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
         SqlConnection  conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            string sql = "select nombre from clientes";


            using (da = new SqlDataAdapter(sql, conexion))
            {
              DataTable  dt = new DataTable();
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
         
            
         //  SqlConnection cnx = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
            SqlConnection cnx = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            string query = "SELECT dbo.clientes.nombre, dbo.estudios.nombre AS Expr1, dbo.prueba.numerofact, dbo.detallefactura.entrega, dbo.detallefactura.codigoarticul, dbo.detallefactura.numerofact AS Expr2 FROM     dbo.clientes INNER JOIN   dbo.prueba ON dbo.clientes.idcliente = dbo.prueba.clienteid INNER JOIN  dbo.estudios ON dbo.clientes.idestudi = dbo.estudios.idestudio INNER JOIN   dbo.articulos INNER JOIN   dbo.detallefactura ON dbo.articulos.codigoarticulo = dbo.detallefactura.codigoarticul ON dbo.prueba.numerofact = dbo.detallefactura.numerofact  WHERE dbo.clientes.nombre LIKE @param + '%' and   dbo.prueba.fecha  BETWEEN @param1 and @param2   GROUP BY dbo.clientes.nombre, dbo.estudios.nombre, dbo.prueba.numerofact, dbo.detallefactura.entrega, dbo.detallefactura.codigoarticul, dbo.detallefactura.numerofact  ";

            SqlCommand cmd = new SqlCommand(query, cnx);

            cmd.Parameters.AddWithValue("@param", textBox1.Text);
            cmd.Parameters.AddWithValue("@param1", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@param2", dateTimePicker2.Text);
            adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
              dataGridView1.DataSource = dt;
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //    SqlConnection cnx = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
           
          SqlConnection cnx = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
          string quer = "SELECT dbo.articulos.nombredearticulo, dbo.detallefactura.numerolibro, dbo.detallefactura.cantidadhojas FROM     dbo.clientes INNER JOIN  dbo.prueba ON dbo.clientes.idcliente = dbo.prueba.clienteid INNER JOIN dbo.detallefactura INNER JOIN  dbo.articulos ON dbo.detallefactura.codigoarticul = dbo.articulos.codigoarticulo ON dbo.prueba.numerofact = dbo.detallefactura.numerofact INNER JOIN dbo.estudios ON dbo.clientes.idestudi = dbo.estudios.idestudio     where     dbo.prueba.numerofact = @param";

            SqlCommand cmd = new SqlCommand(quer, cnx);

            cmd.Parameters.AddWithValue("@param", textBox2.Text);
       
            adaptador = new SqlDataAdapter(cmd);
            DataTable dl = new DataTable();
            adaptador.Fill(dl);
            dataGridView2.DataSource = dl;
            
            
            
            } 


            
            
            
            }



    } 
     
//"SELECT dbo.articulos.nombredearticulo, dbo.detallefactura.numerolibro, dbo.detallefactura.cantidadhojas FROM     dbo.clientes INNER JOIN  dbo.prueba ON dbo.clientes.idcliente = dbo.prueba.clienteid INNER JOIN dbo.detallefactura INNER JOIN  dbo.articulos ON dbo.detallefactura.codigoarticul = dbo.articulos.codigoarticulo ON dbo.prueba.numerofact = dbo.detallefactura.numerofact INNER JOIN dbo.estudios ON dbo.clientes.idestudi = dbo.estudios.idestudio     where     dbo.prueba.numerofact = @param"
//"SELECT dbo.clientes.nombre, dbo.estudios.nombre AS Expr1, dbo.prueba.numerofact, dbo.detallefactura.entrega, dbo.detallefactura.codigoarticul, dbo.detallefactura.numerofact AS Expr2 FROM     dbo.clientes INNER JOIN   dbo.prueba ON dbo.clientes.idcliente = dbo.prueba.clienteid INNER JOIN  dbo.estudios ON dbo.clientes.idestudi = dbo.estudios.idestudio INNER JOIN   dbo.articulos INNER JOIN   dbo.detallefactura ON dbo.articulos.codigoarticulo = dbo.detallefactura.codigoarticul ON dbo.prueba.numerofact = dbo.detallefactura.numerofact  WHERE dbo.clientes.nombre LIKE @param + '%' and   dbo.prueba.fecha  BETWEEN @param1 and @param2   GROUP BY dbo.clientes.nombre, dbo.estudios.nombre, dbo.prueba.numerofact, dbo.detallefactura.entrega, dbo.detallefactura.codigoarticul, dbo.detallefactura.numerofact "