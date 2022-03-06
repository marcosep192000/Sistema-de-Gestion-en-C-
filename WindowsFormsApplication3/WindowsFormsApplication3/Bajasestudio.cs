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
    public partial class Bajasestudio : Form
    {
        public Bajasestudio()
        {
            InitializeComponent();
        }
        SqlDataAdapter adaptador, da;
        DataTable dt;
        SqlConnection conexion; 
        private void Bajasestudio_Load(object sender, EventArgs e)
        {
        //  conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
          conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            SqlCommand baja = new SqlCommand("delete from estudios where nombre=@nombre", conexion);
            adaptador = new SqlDataAdapter();

            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));

            string sql = "select nombre from estudios";


            using (da = new SqlDataAdapter(sql, conexion))
            {
                dt = new DataTable();
                da.Fill(dt);

                this.textBo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.textBo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                foreach (DataRow dr in dt.Rows)
                {
                    this.textBo.AutoCompleteCustomSource.Add(dr[0].ToString());
                }

            }


        }

        private void buscar_Click(object sender, EventArgs e)
        {
             string cadena = "SELECT *  FROM estudios where  nombre='" + textBo.Text + "'";

            SqlCommand consulta = new SqlCommand(cadena, conexion);

            conexion.Open();
            SqlDataReader leer = consulta.ExecuteReader();
            if (leer.Read() == true)
            {
                this.textBo.AutoCompleteCustomSource.Add(leer[0].ToString());
                numerocliente.Text = leer["idestudio"].ToString();
                nombre.Text = leer["nombre"].ToString();
                direccion.Text = leer["direccion"].ToString();
                cuit.Text = leer["cuit"].ToString();
                telefono.Text = leer["telefono"].ToString(); 
                codigo.Text = leer ["codigopostal"].ToString ();
                nombre1.Text = leer ["nombrecontacto1"].ToString ();
                telefono1.Text = leer ["telefono1"].ToString ();
                mail1.Text = leer ["mail1"].ToString ();
               nombre2.Text = leer ["nombrecontacto2"].ToString();
                telefono2.Text = leer ["telefonocontacto2"].ToString ();
                mail2.Text = leer ["mail2"].ToString ();
                comboBox2.SelectedValue = leer["ciudad"].ToString();
          
         
        
           
          
          
          


            }
            else
            {
                MessageBox.Show(" no se encontro el registro");
                nombre.Text = "";
                direccion.Text = "";


               

            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         adaptador.DeleteCommand.Parameters["@nombre"].Value = textBo.Text;

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
                MessageBox.Show("Actialmente el Estudio que intenta borrar se encuentra relacionado con una Empresa desvincule la empresa de este  estudio e intentelo nuevamente");


            }

            finally
            {
                conexion.Close();

            }
        }
        }
    }

