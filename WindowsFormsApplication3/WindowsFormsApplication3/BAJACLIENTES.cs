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
    public partial class BAJACLIENTES : Form
    {
        public BAJACLIENTES()
        {
            InitializeComponent();
        }
        SqlDataAdapter adaptador, da;
        DataTable dt;
        SqlConnection conexion; 


        private void BAJACLIENTES_Load(object sender, EventArgs e)
        {

         // conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
          conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
             SqlCommand baja = new SqlCommand("delete from clientes where nombre=@nombre", conexion);
            adaptador = new SqlDataAdapter(); 
            
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));

            string sql = "select nombre from clientes";


            using (da = new SqlDataAdapter(sql, conexion))
            {
                dt = new DataTable();
                da.Fill(dt);

                this.textB.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.textB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                foreach (DataRow dr in dt.Rows)
                {
                    this.textB.AutoCompleteCustomSource.Add(dr[0].ToString());
                }

            }


        
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            
            string cadena = "SELECT *  FROM clientes where  nombre='" + textB.Text + "'";

            SqlCommand consulta = new SqlCommand(cadena, conexion);

            conexion.Open();
            SqlDataReader leer = consulta.ExecuteReader();
            if (leer.Read() == true)
            {
                this.textB.AutoCompleteCustomSource.Add(leer[0].ToString());
                nombre.Text = leer["nombre"].ToString();
                direccion.Text = leer["direccion"].ToString();
                cuit.Text = leer["cuit"].ToString();
                numerocliente.Text = leer["idcliente"].ToString();
                contacto1.Text = leer["contacto1"].ToString();

                codigopostal.Text = leer["codigopostal"].ToString();
                telefono1.Text = leer["telefono1"].ToString();
                contacto2.Text = leer["contacto2"].ToString();
                telefono2.Text = leer["telefono2"].ToString();
                email1.Text = leer["mail2"].ToString();
                email2.Text = leer["mail"].ToString();
                comboBox2.SelectedValue = leer["codigo_ciudad"].ToString();
                comboBox1.SelectedValue = leer["idestudi"].ToString();
                tipo.SelectedValue = leer["tipo"].ToString();



            }
            else
            {
                MessageBox.Show(" no se encontro el registro");
                nombre.Text = "";
                direccion.Text = "";


                codigopostal.Text = "";
                telefono1.Text = "";

            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adaptador.DeleteCommand.Parameters["@nombre"].Value = textB.Text;

            try
            {
                conexion.Open();

                int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                if (cantidad > 0)
                {
                    MessageBox.Show("Usuario eliminado");
                 
                }
                else
                {
                    MessageBox.Show("usuario inexistente");

                }
            }
            catch (SqlException exepcion)
            {
                MessageBox.Show(exepcion.ToString());


            }

            finally
            {
                conexion.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            cuit.Text = "";
            codigopostal.Text = "";

            telefono1.Text = "";
            telefono2.Text = "";
            contacto1.Text = "";
            contacto2.Text = "";
            email1.Text = "";
            email2.Text = "";
        }
        }



    }


