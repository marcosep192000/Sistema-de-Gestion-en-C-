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
using System.Text.RegularExpressions;
namespace WindowsFormsApplication3
{
    public partial class Form5 : Form
    {
        public Form5(string ver)
        {
            InitializeComponent();
            this.dato = ver;


        }

        SqlDataAdapter adaptador;

        SqlConnection conexion;
        string dato;
        public string parar;
      
        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        { 
            eliminar.Enabled = true;
            grabar.Enabled = true;
            modificarti.Enabled = false; 
            nuevo.Enabled = false;
            consultar.Enabled = false;
            
            

            
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet15.localidad' Puede moverla o quitarla según sea necesario.
            this.localidadTableAdapter.Fill(this.gestionrubricasDataSet15.localidad);
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet20.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.gestionrubricasDataSet20.clientes);
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet7.provincia' Puede moverla o quitarla según sea necesario.
            this.provinciaTableAdapter.Fill(this.gestionrubricasDataSet7.provincia);
            conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            // conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            conexion.Open();

            SqlCommand comando = new SqlCommand("select  max(id_contacto) +1 as contador from contactoporempres", conexion);

            SqlDataReader datos = comando.ExecuteReader();

            while (datos.Read())
            {

                idcontacto.AppendText(datos["contador"].ToString());
            }


            conexion.Close();


            SqlCommand alta = new SqlCommand("insert into contactoporempres        ( Nombre_de_Contacto, Mailcontacto, TelefonoContacto, empresa, provincia, ciudad, documento, direccion, numero, piso,apellido)values(@Nombre_de_Contacto,@Mailcontacto,@TelefonoContacto,@empresa,@provincia,@ciudad,@documento,@direccion,@numero,@piso,@apellido)", conexion);

            adaptador.InsertCommand = alta;

            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@Nombre_de_Contacto", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@Mailcontacto", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@TelefonoContacto", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@empresa", SqlDbType.VarChar));
           
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@provincia", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@ciudad", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@documento", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@piso", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
            comboempresa.SelectedValue = dato;
            dato = nom.Text;
            idcontacto.Enabled = false;
            

            SqlCommand modificar = new SqlCommand("update  contactoporempres set Nombre_de_Contacto=@Nombre_de_Contacto,Mailcontacto=@Mailcontacto,TelefonoContacto=@TelefonoContacto,provincia=@provincia,ciudad=@ciudad,documento=@documento,direccion=@direccion,numero=@numero,piso=@piso,apellido=@apellido where id_contacto=@nombreanterior", conexion);

            adaptador.UpdateCommand = modificar;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreanterior", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@Nombre_de_Contacto", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@Mailcontacto", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@TelefonoContacto", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@provincia", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@ciudad", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@documento", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@piso", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));


        }

        private void button12_Click(object sender, EventArgs e)
        {
            hablitartodo();
            limpiar();
            consultar.Enabled = false;
            grabar.Enabled = true;
            nuevo.Enabled = false;

            eliminar.Enabled = true;

        }


        void altacontacto()
        {
            try
            {

                adaptador.InsertCommand.Parameters["@Nombre_de_Contacto"].Value = nom.Text;
                adaptador.InsertCommand.Parameters["@Mailcontacto"].Value = emailS.Text;
                adaptador.InsertCommand.Parameters["@TelefonoContacto"].Value = telefonos.Text;
                adaptador.InsertCommand.Parameters["@empresa"].Value = comboempresa.SelectedValue;
                adaptador.InsertCommand.Parameters["@provincia"].Value = comboprovincia.SelectedValue;
                adaptador.InsertCommand.Parameters["@ciudad"].Value = combociudad.SelectedValue;
                adaptador.InsertCommand.Parameters["@documento"].Value = documentos.Text;
                adaptador.InsertCommand.Parameters["@direccion"].Value = direcciones.Text;
                adaptador.InsertCommand.Parameters["@numero"].Value = numeros.Text;
                adaptador.InsertCommand.Parameters["@piso"].Value = pisos.Text;
                adaptador.InsertCommand.Parameters["@apellido"].Value = apellidos.Text;
                conexion.Open();

                if (nom.Text != "" && pisos.Text != "" && direcciones.Text != "" && apellidos.Text != "" && documentos.Text != "" && telefonos.Text != "")
                {

                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Datos Cargados Correctamente");
                }

                else
                {
                    MessageBox.Show("los datos no fueron cargados , intente nuevamente");

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

        private void button8_Click(object sender, EventArgs e)
        {
            if (nuevo.Enabled == false && consultar.Enabled == false )
            
                {
                    if (documentos.Text == "  ,   ,")
                    {

                        documentos.BackColor = Color.OrangeRed;


                    }
                    else
                    {
                        documentos.BackColor = Color.White;



                    }
                    if (nom.Text == "")
                    {
                        nom.BackColor = Color.OrangeRed;
                    }
                    else
                    {
                        nom.BackColor = Color.White;

                    }

                    if (direcciones.Text == "")
                    {
                        direcciones.BackColor = Color.Red;
                    }
                    else { direcciones.BackColor = Color.White; }










                    if (numeros.Text == "")
                    {
                        numeros.BackColor = Color.Red;

                    }
                    else
                    {

                        numeros.BackColor = Color.White;
                    }



                    if (pisos.Text == "")
                    {
                        pisos.BackColor = Color.Red;

                    }
                    else { pisos.BackColor = Color.White; }








                    if (combociudad.Text == "")
                    {
                        label7.Text = "!";
                        label7.BackColor = Color.Red;
                    }
                    else
                    {
                        label7.Text = "";
                        combociudad.BackColor = Color.White;


                    }
                    if (apellidos.Text == "")
                    {
                        apellidos.BackColor = Color.Red;

                    }
                    else { apellidos.BackColor = Color.White; }

                    if (telefonos.Text == "   -   -")
                    {
                        telefonos.BackColor = Color.Red;

                    }
                    else { telefonos.BackColor = Color.White; }

                    altacontacto();

                }
                else {
                    modifica(); 
                
                
                
                }



        }


        private void comboprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                conexion.Open();
                SqlCommand consulta = new SqlCommand("Select  localidad, id ,id_provincia from localidad where id_provincia = '" + comboprovincia.SelectedValue + "'", conexion);

                DataTable dt = new DataTable();


                SqlDataAdapter adaptador = new SqlDataAdapter(consulta);
                adaptador.Fill(dt);
                combociudad.DataSource = dt;
                combociudad.DisplayMember = "localidad";
                combociudad.ValueMember = "id";

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

        private void comboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboempresa_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void modificar_Click(object sender, EventArgs e)
        {
         
            eliminar.Enabled = true;
            nuevo.Enabled = false;
            grabar.Enabled = true;
            hablitartodo();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            parar = Convert.ToString(comboempresa.SelectedValue);

            nuevo.Enabled = false;
            modificarti.Enabled = true;
            consultarContacto consulta = new consultarContacto();

            consulta.pasa += new consultarContacto.dato(ejecutar);

            consulta.Show();



        }
        public void ejecutar(string id_contacto, string Nombre_de_Contacto, string Mailcontacto, string TelefonoContacto, string Celular, string empresa, string id_empresa, string provincia, string ciudad, string email, string documento, string direccion, string numero, string piso, string apellido)
        {
            nom.Text = Nombre_de_Contacto;
            idcontacto.Text = id_contacto;
            emailS.Text = email;
            pisos.Text = piso;
            apellidos.Text = apellido;
            documentos.Text = documento;
            numeros.Text = numero;
            direcciones.Text = direccion;
            telefonos.Text = TelefonoContacto;
            comboempresa.SelectedValue = empresa;


            int prov = Convert.ToInt32(provincia);
            comboprovincia.SelectedValue = prov;
            loca();
            int localidades = Convert.ToInt32(ciudad);
            combociudad.SelectedValue = localidades;


        }
        private void eliminar_Click(object sender, EventArgs e)
        {
            eliminar.Enabled = false;
            grabar.Enabled = false;
            modificarti.Enabled = false;
            nuevo.Enabled = true;
            consultar.Enabled = true;
        }
        void hablitartodo()
        {


            nom.Enabled = true;
            apellidos.Enabled = true;
            direcciones.Enabled = true;
            pisos.Enabled = true;
            combociudad.Enabled = true;
            comboprovincia.Enabled = true;
            emailS.Enabled = true;
            documentos.Enabled = true;
            telefonos.Enabled = true;
            numeros.Enabled = true;
        }
        void desabilitartodo()
        {
            idcontacto.Enabled = false;
            comboempresa.Enabled = false;
            nom.Enabled = false;
            apellidos.Enabled = false;
            direcciones.Enabled = false;
            pisos.Enabled = false;
            combociudad.Enabled = false;
            comboprovincia.Enabled = false;
            emailS.Enabled = false;
            documentos.Enabled = false;
            telefonos.Enabled = false;
            numeros.Enabled = false;
        }
        void limpiar()
        {
            idcontacto.Text = "";
            nom.Text = "";
            apellidos.Text = "";
            direcciones.Text = "";
            pisos.Text = "";
            emailS.Text = "";

        }
        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = emailS.Text;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }


        }

        private void emailS_Validated(object sender, EventArgs e)
        {
            if (email_bien_escrito(emailS.Text) == false)
            {
                MessageBox.Show("Debe insertar un formato valido de Email ");
            }
        }

        private void emailS_TextChanged(object sender, EventArgs e)
        {

        }
        void loca()
        {
            try
            {

                conexion.Open();
                SqlCommand consulta = new SqlCommand("Select  localidad, id ,id_provincia from localidad where id_provincia = '" + comboprovincia.SelectedValue + "'", conexion);

                DataTable dt = new DataTable();


                SqlDataAdapter adaptador = new SqlDataAdapter(consulta);
                adaptador.Fill(dt);
                combociudad.DataSource = dt;
                combociudad.DisplayMember = "localidad";
                combociudad.ValueMember = "id";

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


        void modifica()
        {
            try
            {
                adaptador.UpdateCommand.Parameters["@nombreanterior"].Value = idcontacto.Text;
                adaptador.UpdateCommand.Parameters["@Nombre_de_Contacto"].Value = nom.Text;
                adaptador.UpdateCommand.Parameters["@Mailcontacto"].Value = emailS.Text;
                adaptador.UpdateCommand.Parameters["@TelefonoContacto"].Value = telefonos.Text;
                adaptador.UpdateCommand.Parameters["@provincia"].Value = comboprovincia.SelectedValue;
                adaptador.UpdateCommand.Parameters["@ciudad"].Value = combociudad.SelectedValue;
                adaptador.UpdateCommand.Parameters["@documento"].Value = documentos.Text;
                adaptador.UpdateCommand.Parameters["@direccion"].Value = direcciones.Text;
                adaptador.UpdateCommand.Parameters["@numero"].Value = numeros.Text;
                adaptador.UpdateCommand.Parameters["@piso"].Value = pisos.Text;
                adaptador.UpdateCommand.Parameters["@apellido"].Value = apellidos.Text;
             

                if (nom.Text != "" && pisos.Text != "" && direcciones.Text != "" && apellidos.Text != "" && documentos.Text != "" && telefonos.Text != "")
                {
   conexion.Open();
                    adaptador.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados Correctamente");
                }

                else
                {
                    MessageBox.Show("los datos no fueron cargados , intente nuevamente");

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

        private void idcontacto_AcceptsTabChanged(object sender, EventArgs e)
        {
           
        }

        

        private void nuevo_MouseCaptureChanged(object sender, EventArgs e)
        {
            mostrardatos.Text = "Usted podra Registrar una NUEVA Empresa"; 
        }

        
    }

}