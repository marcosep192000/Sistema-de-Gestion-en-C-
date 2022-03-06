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
    public partial class modificacionestudios : Form
    {
        public modificacionestudios()
        {
            InitializeComponent();
        }
        SqlConnection conexion;
        SqlDataAdapter adaptador,da;
        DataTable dt;
        private void modificacionestudios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet8.localidad' Puede moverla o quitarla según sea necesario.
            this.localidadTableAdapter.Fill(this.gestionrubricasDataSet8.localidad);
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet9.provincia' Puede moverla o quitarla según sea necesario.
            this.provinciaTableAdapter.Fill(this.gestionrubricasDataSet9.provincia);


        //   conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
            conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            adaptador = new SqlDataAdapter();

            SqlCommand modificacion = new SqlCommand("update estudios set nombre=@nombre,cuit=@cuit,telefono=@telefono,direccion=@direccion,ciudad=@ciudad,codigopostal=@codigopostal,nombrecontacto1=@nombrecontacto1,telefono1=@telefono1,mail1=@mail1,nombrecontacto2=@nombrecontacto2,       telefonocontacto2=@telefonocontacto2,mail2=@mail2 where idestudio=@nombreanterior", conexion);

            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreanterior", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@ciudad", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigopostal", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombrecontacto1", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@telefono1", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@mail1", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombrecontacto2", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@telefonocontacto2", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@mail2", SqlDbType.VarChar));


         
            string sql = "select nombre from estudios";


            using (da = new SqlDataAdapter(sql, conexion))
            {

                dt = new DataTable();

                da.Fill(dt);

                this.textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                foreach (DataRow dr in dt.Rows)
                {
                    this.textBox.AutoCompleteCustomSource.Add(dr[0].ToString());
                }

            }

          


          

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            adaptador.UpdateCommand.Parameters["@nombreanterior"].Value = numerocliente.Text;
            adaptador.UpdateCommand.Parameters["@nombre"].Value = nombre.Text;
            adaptador.UpdateCommand.Parameters["@cuit"].Value = cuit.Text;
            adaptador.UpdateCommand.Parameters["@telefono"].Value = telefono.Text;
            adaptador.UpdateCommand.Parameters["@direccion"].Value = direccion.Text;
            adaptador.UpdateCommand.Parameters["@ciudad"].Value = ciudad.SelectedValue;
            adaptador.UpdateCommand.Parameters["@codigopostal"].Value = codigo.Text;
            adaptador.UpdateCommand.Parameters["@nombrecontacto1"].Value = nombre1.Text;
            adaptador.UpdateCommand.Parameters["@telefono1"].Value = telefono1.Text;
            adaptador.UpdateCommand.Parameters["@mail1"].Value = mail1.Text;
            adaptador.UpdateCommand.Parameters["@nombrecontacto2"].Value = nombre2.Text;
            adaptador.UpdateCommand.Parameters["@telefonocontacto2"].Value = telefono2.Text;
            adaptador.UpdateCommand.Parameters["@mail2"].Value = mail2.Text;
            try
            {

                if (numerocliente.Text != (""))
                {
                    conexion.Open();
                    adaptador.UpdateCommand.ExecuteNonQuery();

                    MessageBox.Show("datos actualizados con exito");

                    
                }
                else
                {

                    MessageBox.Show("realice la busqueda antes de modificar datos de cliente ");
                }




            }
            catch (SqlException exepcion)
            {
                MessageBox.Show(exepcion.ToString());

            }
            finally { conexion.Close(); }
        
        }

        private void buscar_Click(object sender, EventArgs e)
        {
             string cadena = "SELECT *  FROM estudios where  nombre='" + textBox.Text + "'";

            SqlCommand consulta = new SqlCommand(cadena, conexion);

            conexion.Open();
            SqlDataReader leer = consulta.ExecuteReader();
            if (leer.Read() == true)
            {
                this.textBox.AutoCompleteCustomSource.Add(leer[0].ToString());
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
               ciudad.SelectedValue = leer["ciudad"].ToString();
          
         
        
           
          
          
          


            }
            else
            {
                MessageBox.Show(" no se encontro el registro");
                nombre.Text = "";
                direccion.Text = "";


               

            }
            conexion.Close();
        }
        }
    }

