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
    public partial class Form6 : Form
    {
        public delegate void pasar(string uno, string dos, string cuatro, string siete, string tres, string cinco, string ocho, string trece, string diez, string once, string doce, string diesiocho, string diesinueve);//,string tres,string cuatro,string cinco,string seis,string siete,string ocho,string nueve,string diez,string once,string doce,string trece,string catorce
        public event pasar pasado;

        public Form6()
        {
            InitializeComponent();

        }

        SqlDataAdapter adaptador;

        SqlConnection conexion;
        DataTable dt;
        private void Form6_Load(object sender, EventArgs e)
        {
         
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.YellowGreen;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            //  SqlConnection cnx = conexion SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
            conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");

            SqlCommand consu = new SqlCommand("SELECT        dbo.estudios.nombre AS Expr1, dbo.clientes.idcliente, dbo.clientes.nombre, dbo.tipoempresas.tipo_empresa, dbo.clientes.direccion, dbo.clientes.cuit, dbo.clientes.telefono1, dbo.clientes.codigopostal,dbo.clientes.mail, dbo.clientes.numero, dbo.clientes.piso, dbo.clientes.oficina, dbo.clientes.alta, dbo.localidad.localidad, dbo.provincia.provincia,dbo.tipoempresas.id_empresa,dbo.estudios.idestudio,   dbo.provincia.id , dbo.localidad.id AS Expr2 FROM            dbo.clientes INNER JOIN dbo.localidad ON dbo.clientes.codigo_ciudad = dbo.localidad.id INNER JOIN  dbo.provincia ON dbo.localidad.id_provincia = dbo.provincia.id INNER JOIN dbo.estudios ON dbo.clientes.idestudi = dbo.estudios.idestudio INNER JOIN  dbo.tipoempresas ON dbo.clientes.tipo = dbo.tipoempresas.id_empresa ", conexion);

            adaptador = new SqlDataAdapter(consu);
            DataTable ds = new DataTable();
            adaptador.Fill(ds);
          




            dataGridView1.DataSource = ds;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;



            string sql = "'" + textBox1.Text + "'";








        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string uno = Convert.ToString(this.dataGridView1.CurrentRow.Cells[16].Value);
            string dos = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            string tres = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);//nombre 
            string cuatro = Convert.ToString(this.dataGridView1.CurrentRow.Cells[15].Value);//sociedad
            string cinco = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value);//direccion
            string seis = Convert.ToString(this.dataGridView1.CurrentRow.Cells[6].Value);
            string siete = Convert.ToString(this.dataGridView1.CurrentRow.Cells[5].Value);//cuit 
            string ocho = Convert.ToString(this.dataGridView1.CurrentRow.Cells[7].Value);//codigo postal
            string nueve = Convert.ToString(this.dataGridView1.CurrentRow.Cells[8].Value);
            string diez = Convert.ToString(this.dataGridView1.CurrentRow.Cells[9].Value);//numero
            string once = Convert.ToString(this.dataGridView1.CurrentRow.Cells[10].Value);
            string doce = Convert.ToString(this.dataGridView1.CurrentRow.Cells[11].Value);
            string trece = Convert.ToString(this.dataGridView1.CurrentRow.Cells[12].Value);//alta
            string catorce = Convert.ToString(this.dataGridView1.CurrentRow.Cells[13].Value);
            string quince = Convert.ToString(this.dataGridView1.CurrentRow.Cells[14].Value);

            string diecices = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            string diesiocho = Convert.ToString(this.dataGridView1.CurrentRow.Cells[17].Value);
            string diesinueve = Convert.ToString(this.dataGridView1.CurrentRow.Cells[18].Value);
            pasado(uno, dos, cuatro, siete, tres, cinco, ocho, trece, diez, once, doce, diesiocho, diesinueve);//, tres, cuatro,cinco,seis, siete, ocho, nueve,diez, once, doce, trece,catorce
            this.Close();
        }

        public void textBox1_TextChanged(System.Object sender, System.EventArgs e)
        {





        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT        dbo.estudios.nombre AS Expr1, dbo.clientes.idcliente, dbo.clientes.nombre, dbo.tipoempresas.tipo_empresa, dbo.clientes.direccion, dbo.clientes.cuit, dbo.clientes.telefono1, dbo.clientes.codigopostal,dbo.clientes.mail, dbo.clientes.numero, dbo.clientes.piso, dbo.clientes.oficina, dbo.clientes.alta, dbo.localidad.localidad, dbo.provincia.provincia,dbo.tipoempresas.id_empresa,dbo.estudios.idestudio,   dbo.provincia.id , dbo.localidad.id AS Expr2 FROM            dbo.clientes INNER JOIN dbo.localidad ON dbo.clientes.codigo_ciudad = dbo.localidad.id INNER JOIN  dbo.provincia ON dbo.localidad.id_provincia = dbo.provincia.id INNER JOIN dbo.estudios ON dbo.clientes.idestudi = dbo.estudios.idestudio INNER JOIN  dbo.tipoempresas ON dbo.clientes.tipo = dbo.tipoempresas.id_empresa where dbo.clientes.nombre  like('%"+ textBox1.Text+"%') ";
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            adaptador = new SqlDataAdapter(cmd);

            adaptador.Fill(ds);
            dataGridView1.DataSource = ds;
            conexion.Close();

        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
          

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

