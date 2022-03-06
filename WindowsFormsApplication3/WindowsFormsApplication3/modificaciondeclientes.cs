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
    public partial class modificaciondeclientes : Form
    {
        public modificaciondeclientes()
        {
            InitializeComponent();
        }

        SqlConnection conexion;
        SqlDataAdapter adaptador, da;
        DataTable dt;
        private void modificaciondeclientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet7.provincia' Puede moverla o quitarla según sea necesario.
            this.provinciaTableAdapter1.Fill(this.gestionrubricasDataSet7.provincia);
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet9.provincia' Puede moverla o quitarla según sea necesario.
            this.provinciaTableAdapter.Fill(this.gestionrubricasDataSet9.provincia);
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet8.localidad' Puede moverla o quitarla según sea necesario.
            this.localidadTableAdapter.Fill(this.gestionrubricasDataSet8.localidad);


            this.tipoempresasTableAdapter.Fill(this.gestionrubricasDataSet5.tipoempresas);

            this.estudiosTableAdapter.Fill(this.gestionrubricasDataSet2.estudios);

          //  conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
             conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            adaptador = new SqlDataAdapter();




            actualizardatos();

            string sql = "select nombre from clientes";


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


            SqlCommand modificacion = new SqlCommand("update clientes set nombre=@nombre,direccion=@direccion,cuit=@cuit,contacto2=@contacto2,contacto1=@contacto1,codigopostal=@codigopostal,telefono1=@telefono1,codigo_ciudad=@codigo_ciudad,telefono2=@telefono2, mail2=@mail2,mail=@mail,idestudi=@idestudi,tipo=@tipo  where idcliente=@nombreanterior", conexion);


            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreanterior", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@contacto2", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@contacto1", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigopostal", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@telefono1", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigo_ciudad", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@telefono2", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@mail2", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@idestudi", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@tipo", SqlDbType.Int));












        }




        private void Modificar_Click(object sender, EventArgs e)
        {
            adaptador.UpdateCommand.Parameters["@nombreanterior"].Value = numerocliente.Text;
            adaptador.UpdateCommand.Parameters["@nombre"].Value = nombre.Text;
            adaptador.UpdateCommand.Parameters["@direccion"].Value = direccion.Text;
            adaptador.UpdateCommand.Parameters["@cuit"].Value = cuit.Text;
            adaptador.UpdateCommand.Parameters["@contacto1"].Value = contacto1.Text;
            adaptador.UpdateCommand.Parameters["@codigopostal"].Value = codigopostal.Text;
            adaptador.UpdateCommand.Parameters["@telefono1"].Value = telefono1.Text;
            adaptador.UpdateCommand.Parameters["@contacto2"].Value = contacto2.Text;
            adaptador.UpdateCommand.Parameters["@telefono2"].Value = telefono2.Text;
            adaptador.UpdateCommand.Parameters["@mail2"].Value = email2.Text;
            adaptador.UpdateCommand.Parameters["@mail"].Value = email1.Text;
            adaptador.UpdateCommand.Parameters["@codigo_ciudad"].Value = comboBox2.SelectedValue;
            adaptador.UpdateCommand.Parameters["@idestudi"].Value = comboBox1.SelectedValue;
            adaptador.UpdateCommand.Parameters["@tipo"].Value = tipo.SelectedValue;

            try
            {

                if (numerocliente.Text != (""))
                {
                    conexion.Open();
                    adaptador.UpdateCommand.ExecuteNonQuery();

                    MessageBox.Show("datos actualizados con exito");

                    actualizardatos();
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

        public void buscar_Click(object sender, EventArgs e)
        {

            string cadena = "SELECT * from clientes  WHERE  nombre = '" + textBox.Text +"'";

            SqlCommand consulta = new SqlCommand(cadena, conexion);

            conexion.Open();
            SqlDataReader leer = consulta.ExecuteReader();
            if (leer.Read() == true)
            {
                this.textBox.AutoCompleteCustomSource.Add(leer[0].ToString());
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

        void limp()
        {
            textBox.Text = "";
            nombre.Text = "";
            cuit.Text = "";
            codigopostal.Text = "";
            direccion.Text = "";
            telefono1.Text = "";
            telefono2.Text = "";
            contacto1.Text = "";
            contacto2.Text = "";
            email1.Text = "";
            email2.Text = "";

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            limp();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void actualizar()
        {

            gestionrubricasDataSet9.Clear();
            this.provinciaTableAdapter.Fill(this.gestionrubricasDataSet9.provincia);
            gestionrubricasDataSet8.Clear();
            this.localidadTableAdapter.Fill(this.gestionrubricasDataSet8.localidad);
            gestionrubricasDataSet5.Clear();
            this.tipoempresasTableAdapter.Fill(this.gestionrubricasDataSet5.tipoempresas);
            gestionrubricasDataSet2.Clear();
            this.estudiosTableAdapter.Fill(this.gestionrubricasDataSet2.estudios);


        }
        public void actualizardatos()
        {



            string sql = "select nombre from clientes";


            using (da = new SqlDataAdapter(sql, conexion))
            {


                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);

                this.textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                foreach (DataRow dr in dt.Rows)
                {

                    this.textBox.AutoCompleteCustomSource.Add(dr[0].ToString());
                }

            }

        }

        public void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
    }
   