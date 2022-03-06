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
    public partial class nuevoestudios : Form
    {
        public nuevoestudios()
        {
            InitializeComponent();
        }
        SqlConnection conexion;
        SqlDataAdapter adaptador; 
        private void nuevoestudios_Load(object sender, EventArgs e)
        {
            modific.Enabled = false;
            grabar.Enabled = false; 
            codigo.Enabled = false;
            telefono2.Enabled = false; 

  this.provinciaTableAdapter.Fill(this.gestionrubricasDataSet9.provincia);

            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet8.localidad' Puede moverla o quitarla según sea necesario.
            this.localidadTableAdapter.Fill(this.gestionrubricasDataSet8.localidad);
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet9.provincia' Puede moverla o quitarla según sea necesario.
            nuevo.Enabled = true;
            consultar.Enabled = true;
            eliminar.Enabled = false;
            cargar.Enabled = false; 
            desabilitar();
          // conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
           conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            adaptador = new SqlDataAdapter();


            SqlCommand alta = new SqlCommand("insert into estudios ( nombre, cuit, telefono, direccion, ciudad, codigopostal, numero, piso, mail, oficina, alta, nombrecontacto,provincia) values (@nombre,@cuit,@telefono,@direccion,@ciudad,@codigopostal,@numero,@piso,@mail,@oficina,@alta,@nombrecontacto,@provincia)", conexion);

            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@provincia", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@ciudad", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigopostal", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@piso", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@oficina", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@alta", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombrecontacto", SqlDbType.VarChar));

            SqlCommand modificacion = new SqlCommand("update estudios set  nombre=@nombre,cuit@=cuit,telefono=@telefono,direccion@direccion,ciudad=@ciudad,codigopostal=@codigopostal,numero=@numero,piso=@piso,mail=@mail,oficina=@oficina,alta=@alta,nombrecontacto=@nombredecontacto,provincia=@provincia where idestudio=@nombreanterior", conexion);

            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreanterior",SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@provincia", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@ciudad", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigopostal", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@piso", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@oficina", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@alta", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombrecontacto", SqlDbType.VarChar));
          


        
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class1.txtCaracter_KeyPress(e);
        }

        private void cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class1.txtCaracter_KeyPress(e);
        }

        private void telefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class1.txtCaracter_KeyPress(e);
        }

        private void telefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class1.txtCaracter_KeyPress(e);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevo.Enabled = false;
            consultar.Enabled = false;
            modific.Enabled = false;
            eliminar.Enabled = true;
            grabar.Enabled = true;   
            habilitar(); 
            conexion.Open();
            string fecha = DateTime.Now.ToString();
            telefono2.Text = fecha;
            SqlCommand comando = new SqlCommand("select  max(idestudio) +1 as contador from estudios", conexion);

            SqlDataReader datos = comando.ExecuteReader();

            while (datos.Read())
            {

                codigo.AppendText(datos["contador"].ToString());
            }


            conexion.Close();

        }



        void cargarestudio()
        {

            adaptador.InsertCommand.Parameters["@nombre"].Value = nombres.Text;
            adaptador.InsertCommand.Parameters["@cuit"].Value = cuits.Text;
            adaptador.InsertCommand.Parameters["@provincia"].Value = comboBox1.SelectedValue;
            adaptador.InsertCommand.Parameters["@telefono"].Value = telefonos.Text;
            adaptador.InsertCommand.Parameters["@direccion"].Value = direccions.Text;
            adaptador.InsertCommand.Parameters["@ciudad"].Value = ciudads.SelectedValue;
            adaptador.InsertCommand.Parameters["@codigopostal"].Value = codigo.Text;
            adaptador.InsertCommand.Parameters["@numero"].Value = nombre1.Text;
            adaptador.InsertCommand.Parameters["@piso"].Value = telefono1.Text;
            adaptador.InsertCommand.Parameters["@mail"].Value = mail1.Text;
            adaptador.InsertCommand.Parameters["@oficina"].Value = nombre2.Text;
            adaptador.InsertCommand.Parameters["@alta"].Value = telefono2.Text;
            adaptador.InsertCommand.Parameters["@nombrecontacto"].Value = mail2.Text;
            //    , numero, piso, mail, oficina, alta, nombrecontacto

            try
            {
                if (nombres.Text != ("") && cuits.Text != ("") && telefonos.Text != ("") && direccions.Text != (""))
                {
                    conexion.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Datos de estudio cargado correctamente");

                }
                else
                {
                    MessageBox.Show("Complete todos los campos a cargar e intentelo de nuevamente. ");
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

        private void grabar_Click(object sender, EventArgs e)
        {
            if (nuevo.Enabled == false && consultar.Enabled == false)
            {
                cargarestudio();
 limpiar();
            desabilitar();
            }
            else
            {
                modificar();
                limpiar();
                desabilitar();
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                conexion.Open();
                SqlCommand consulta = new SqlCommand("Select  localidad, id ,id_provincia from localidad where id_provincia = '" + comboBox1.SelectedValue + "'", conexion);

                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta);
                adaptador.Fill(dt);
                ciudads.DataSource = dt;
                ciudads.DisplayMember = "localidad";
                ciudads.ValueMember = "id";

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
        void limpiar()
        {
            nombres.Text = "";
            cuits.Text = "";
           telefonos.Text = "";
          direccions.Text = "";
         
          codigo.Text = "";
             nombre1.Text = "";
             telefono1.Text = "";
             mail1.Text = "";
            nombre2.Text = "";
            telefono2.Text = "";
            mail2.Text = "";
        
        
        
        }
        void habilitar()
        {

            nombres.Enabled=true;
            cuits.Enabled = true;
            telefonos.Enabled = true;
            direccions.Enabled = true;
            ciudads.Enabled = true;
           
            nombre1.Enabled = true;
            telefono1.Enabled = true;
            mail1.Enabled = true;
            nombre2.Enabled = true;
            codigopostals.Enabled = true; 
            mail2.Enabled = true;
            comboBox1.Enabled = true; 
        
        }
        void desabilitar()
        {
            nombres.Enabled = false;
            cuits.Enabled = false;
            telefonos.Enabled = false;
            direccions.Enabled = false;
            ciudads.Enabled =false;
            codigo.Enabled = false;
            nombre1.Enabled = false;
            telefono1.Enabled = false;
            mail1.Enabled = false;
            nombre2.Enabled = false;
            telefono2.Enabled = false;
            mail2.Enabled = false;
            comboBox1.Enabled = false;
            codigopostals.Enabled = false;
        }
        
        private void consultar_Click(object sender, EventArgs e)
        {
            nuevo.Enabled = false;
            modific.Enabled = true;
            eliminar.Enabled = true;
            grabar.Enabled = false; 
            
            consultarestudio consultar = new consultarestudio();

       consultar.pasa +=new consultarestudio.pasar(ejecutar);
       consultar.Show(); 
        }
        void ejecutar(string idestudio, string nombre, string cuit, string telefono, string direccion, string ciudad, string codigopostal, string numero, string piso, string mail, string oficina, string alta, string nombrecontacto,string provincia)
        {
            codigo.Text = idestudio;
            nombres.Text = nombre;
            cuits.Text = cuit;
            telefonos.Text = telefono;
            direccions.Text = direccion;
            ciudads.SelectedValue = ciudad;
            codigopostals.Text = codigopostal;
            nombre1.Text = numero;
            telefono1.Text = piso;
            mail1.Text = mail;
            nombre2.Text = oficina;
            telefono2.Text = alta;
            mail2.Text = nombrecontacto;

           
            comboBox1.SelectedValue = provincia;
            loca();
            
            int localidades = Convert.ToInt32(ciudad);
            ciudads.SelectedValue = localidades;
        
        }
        void loca()
        {
            try
            {

                conexion.Open();
                SqlCommand consulta = new SqlCommand("Select  localidad, id ,id_provincia from localidad where id_provincia = '" + comboBox1.SelectedValue + "'", conexion);

                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta);
                adaptador.Fill(dt);
                ciudads.DataSource = dt;
                ciudads.DisplayMember = "localidad";
                ciudads.ValueMember = "id";

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

        private void modific_Click(object sender, EventArgs e)
        {
            habilitar(); 
            grabar.Enabled = true;
            eliminar.Enabled = true ;
            nuevo.Enabled = false;
            consultar.Enabled = true; 


        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            grabar.Enabled = false;
            nuevo.Enabled = true;
            consultar.Enabled = true;
            eliminar.Enabled = false;
            modific.Enabled = false;
            limpiar();
        }
        void modificar()
        {
            adaptador.UpdateCommand.Parameters["@nombreanterior"].Value = codigo.Text; 
            adaptador.UpdateCommand.Parameters["@nombre"].Value = nombres.Text;
            adaptador.UpdateCommand.Parameters["@cuit"].Value = cuits.Text;
            adaptador.UpdateCommand.Parameters["@provincia"].Value = comboBox1.SelectedValue;
            adaptador.UpdateCommand.Parameters["@telefono"].Value = telefonos.Text;
            adaptador.UpdateCommand.Parameters["@direccion"].Value = direccions.Text;
            adaptador.UpdateCommand.Parameters["@ciudad"].Value = ciudads.SelectedValue;
            adaptador.UpdateCommand.Parameters["@codigopostal"].Value = codigo.Text;
            adaptador.UpdateCommand.Parameters["@numero"].Value = nombre1.Text;
            adaptador.UpdateCommand.Parameters["@piso"].Value = telefono1.Text;
            adaptador.UpdateCommand.Parameters["@mail"].Value = mail1.Text;
            adaptador.UpdateCommand.Parameters["@oficina"].Value = nombre2.Text;
            adaptador.UpdateCommand.Parameters["@alta"].Value = telefono2.Text;
            adaptador.UpdateCommand.Parameters["@nombrecontacto"].Value = mail2.Text;
            //    , numero, piso, mail, oficina, alta, nombrecontacto

            try
            {
                if (nombres.Text != ("") && cuits.Text != ("") && telefonos.Text != ("") && direccions.Text != (""))
                {
                    conexion.Open();
                    adaptador.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Datos de estudio modificados correctamente");

                }
                else
                {
                    MessageBox.Show("Complete todos los campos a cargar e intentelo de nuevamente. ");
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


            }

        }

       

       
    

