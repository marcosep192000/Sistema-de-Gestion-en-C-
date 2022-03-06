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
    public partial class altaclientes : Form
    {
       
        public altaclientes()
        {
            InitializeComponent();
        }
        SqlConnection conexion;
        SqlDataAdapter adaptador, da;
        DataTable dt;
        int res;
        int tipores;
        int prov;
        public string ver;
        private void altaclientes_Load(object sender, EventArgs e)
        {
     string fecha  = DateTime.Now.ToString() ;
          maskedTextBox2.Text = fecha; 
            button4.Enabled = false; 
            eliminar.Enabled = false;
            grabar.Enabled = false;
            modificar.Enabled = false;
            nuevo.Enabled = true;
            consultar.Enabled = true;
          
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet9.provincia' Puede moverla o quitarla según sea necesario.
            this.provinciaTableAdapter.Fill(this.gestionrubricasDataSet9.provincia);
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet8.localidad' Puede moverla o quitarla según sea necesario.
            this.localidadTableAdapter.Fill(this.gestionrubricasDataSet8.localidad);


            this.tipoempresasTableAdapter.Fill(this.gestionrubricasDataSet5.tipoempresas);

            this.estudiosTableAdapter.Fill(this.gestionrubricasDataSet2.estudios);
           

            conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
          // conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
            adaptador = new SqlDataAdapter();



            bloquear();






            SqlCommand alta = new SqlCommand("insert into clientes  (nombre,direccion,cuit,contacto2,contacto1,codigopostal,telefono1,codigo_ciudad,telefono2,mail2,mail,idestudi,tipo,piso,oficina,alta,numero) values (@nombre,@direccion,@cuit,@contacto2,@contacto1,@codigopostal,@telefono1,@codigo_ciudad,@telefono2,@mail2,@mail,@idestudi,@tipo,@piso,@oficina,@alta,@numero )", conexion);
            adaptador.InsertCommand = alta;




            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@contacto2", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@contacto1", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigopostal", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@telefono1", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigo_ciudad", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@telefono2", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@mail2", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@idestudi", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipo", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@piso", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@oficina", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@alta", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));



            SqlCommand modificacion  = new SqlCommand("update clientes set  nombre=@nombre,direccion=@direccion,cuit=@cuit,contacto2=@contacto2,contacto1=@contacto1,codigopostal=@codigopostal,telefono1=@telefono1,codigo_ciudad=@codigo_ciudad,telefono2=@telefono2,mail2=@mail2,mail=@mail,idestudi=@idestudi,tipo=@tipo,piso=@piso,oficina=@oficina,alta=@alta,numero=@numero where idcliente=@nombreanterior", conexion);
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
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@piso", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@oficina", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@alta", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));



















        }


        void actualizardatos()
        {


        }

       
         private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
 

 try
 {

     conexion.Open();
     SqlCommand consulta = new SqlCommand("Select  localidad, id ,id_provincia from localidad where id_provincia = '" + comboBox2.SelectedValue + "'", conexion);

     DataTable dt = new DataTable();

     
     SqlDataAdapter adaptador = new SqlDataAdapter(consulta);
     adaptador.Fill(dt);
     comboBox3.DataSource = dt;
     comboBox3.DisplayMember = "localidad";
     comboBox3.ValueMember = "id";

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


       

     

       
    



       


        private void button1_Click_1(object sender, EventArgs e)
        {
            cargatipoempresas altaclientes = new cargatipoempresas();
            altaclientes.Show();
        }

        private void cargar_Click_1(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.provinciaTableAdapter.FillBy(this.gestionrubricasDataSet9.provincia);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.provinciaTableAdapter.FillBy1(this.gestionrubricasDataSet9.provincia);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void codigopostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class1.txtCaracter_KeyPress(e);
        }

        private void telefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class1.txtCaracter_KeyPress(e);
        }

        private void telefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class1.txtCaracter_KeyPress(e);
        }



        private void limpiar_Click_1(object sender, EventArgs e)
        {
          
        }

        private void tipo_Click(object sender, EventArgs e)
        {
            this.tipoempresasTableAdapter.Fill(this.gestionrubricasDataSet5.tipoempresas);
        }

        private void contacto1_Click(object sender, EventArgs e)
        {
            contacto1.Text = ""; 
        }

        private void email1_Click(object sender, EventArgs e)
        {
            email1.Text = "";
        }

        private void telefono1_Click(object sender, EventArgs e)
        {
            telefono1.Text = ""; 
        }

        private void contacto2_Click(object sender, EventArgs e)
        {
            contacto2.Text = "";
        }

        private void email2_Click(object sender, EventArgs e)
        {
            email2.Text = "";
         
        }

        private void telefono2_Click(object sender, EventArgs e)
        {
            telefono2.Text = ""; 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            nuevoestudios nuevoestudio = new nuevoestudios();
            nuevoestudio.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        public void button4_Click(object sender, EventArgs e)
        {
            ver = idver.Text;
          

            Form5 empleados = new Form5 (ver);
            empleados.Show(); 
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString();
            maskedTextBox2.Text = fecha;
            maskedTextBox2.Enabled = false; 
            consultar.Enabled = false; 
            grabar.Enabled = true; 
            nuevo.Enabled = false; 
            idver.Enabled = false;
            eliminar.Enabled = true;
            button4.Enabled = false; 
            conexion.Open();
            SqlCommand comando = new SqlCommand("select  max(idcliente) +1 as contador from clientes", conexion);

            SqlDataReader datos = comando.ExecuteReader();

            while (datos.Read())
            {

                idver.AppendText(datos["contador"].ToString());
            }


            conexion.Close();


            desbloquear();
        
            


        }

        void cargarcliente()

        {
            try
            {
                adaptador.InsertCommand.Parameters["@nombre"].Value = nombre.Text;
                adaptador.InsertCommand.Parameters["@direccion"].Value = direccion.Text;
                adaptador.InsertCommand.Parameters["@cuit"].Value = maskedTextBox1.Text;
                adaptador.InsertCommand.Parameters["@contacto1"].Value = contacto1.Text;
                adaptador.InsertCommand.Parameters["@codigopostal"].Value = codigopostal.Text;
                adaptador.InsertCommand.Parameters["@telefono1"].Value = telefono1.Text;
                adaptador.InsertCommand.Parameters["@contacto2"].Value = contacto2.Text;
                adaptador.InsertCommand.Parameters["@telefono2"].Value = telefono2.Text;
                adaptador.InsertCommand.Parameters["@mail2"].Value = email2.Text;
                adaptador.InsertCommand.Parameters["@mail"].Value = email1.Text;
                adaptador.InsertCommand.Parameters["@codigo_ciudad"].Value = comboBox2.SelectedValue;
                adaptador.InsertCommand.Parameters["@idestudi"].Value = comboBox1.SelectedValue;
                adaptador.InsertCommand.Parameters["@tipo"].Value = tipo.SelectedValue;
                adaptador.InsertCommand.Parameters["@piso"].Value = piso.Text;
                adaptador.InsertCommand.Parameters["@oficina"].Value = oficina.Text;
                adaptador.InsertCommand.Parameters["@alta"].Value = maskedTextBox2.Text;
                adaptador.InsertCommand.Parameters["@numero"].Value = numero.Text; 
                conexion.Open();
                if (maskedTextBox2.Text != ("  /  /") && piso.Text != ("") && oficina.Text != ("") && numero.Text != ("")  && nombre.Text != ("") && direccion.Text != ("") && maskedTextBox1.Text != ("  -        -") && codigopostal.Text != (""))
                {


                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Datos cargados correctamente,a partir de ahora usted prodra agregar un NUEVO contacto");
                    grabar.Enabled = false;
                   
                    bloquear();
                    nuevo.Enabled = true;
                    button4.Enabled = true; 
                }
                else
                {
                    MessageBox.Show("complete los datos a cargar  intentelo nuevamente");
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
            if (nuevo.Enabled == false && button4.Enabled== false)
            {
                if (maskedTextBox1.Text == "  -        -")
                {

                    maskedTextBox1.BackColor = Color.OrangeRed;


                }
                else
                {
                    maskedTextBox1.BackColor = Color.White;



                }
                if (nombre.Text == "")
                {
                    nombre.BackColor = Color.OrangeRed;
                }
                else
                {
                    nombre.BackColor = Color.White;

                }

                if (direccion.Text == "")
                {
                    direccion.BackColor = Color.Red;
                }
                else { direccion.BackColor = Color.White; }




                if (codigopostal.Text == "")
                {
                    codigopostal.BackColor = Color.Red;
                }
                else
                { codigopostal.BackColor = Color.White; }



                if (maskedTextBox2.Text == "  /  /")
                {

                    maskedTextBox2.BackColor = Color.Red;

                }
                else { maskedTextBox2.BackColor = Color.White; }




                if (numero.Text == "")
                {
                    numero.BackColor = Color.Red;

                }
                else
                {

                    numero.BackColor = Color.White;
                }



                if (piso.Text == "")
                {
                    piso.BackColor = Color.Red;

                }
                else { piso.BackColor = Color.White; }





                if (oficina.Text == "")
                { oficina.BackColor = Color.Red; }
                else { oficina.BackColor = Color.White; }



                if (comboBox3.Text == "")
                {
                    label28.Text = "!";
                    label28.BackColor = Color.Red;
                }
                else
                {
                    label28.Text = "";
                    comboBox3.BackColor = Color.White;


                }


                cargarcliente();
               
            }
            if (nuevo.Enabled== false && button4.Enabled== true )
            {
                if (maskedTextBox1.Text == "  -        -")
                {

                    maskedTextBox1.BackColor = Color.OrangeRed;


                }
                else
                {
                    maskedTextBox1.BackColor = Color.White;



                }
                if (nombre.Text == "")
                {
                    nombre.BackColor = Color.OrangeRed;
                }
                else
                {
                    nombre.BackColor = Color.White;

                }

                if (direccion.Text == "")
                {
                    direccion.BackColor = Color.Red;
                }
                else { direccion.BackColor = Color.White; }




                if (codigopostal.Text == "")
                {
                    codigopostal.BackColor = Color.Red;
                }
                else
                { codigopostal.BackColor = Color.White; }



                if (maskedTextBox2.Text == "  /  /")
                {

                    maskedTextBox2.BackColor = Color.Red;

                }
                else { maskedTextBox2.BackColor = Color.White; }




                if (numero.Text == "")
                {
                    numero.BackColor = Color.Red;

                }
                else
                {

                    numero.BackColor = Color.White;
                }



                if (piso.Text == "")
                {
                    piso.BackColor = Color.Red;

                }
                else { piso.BackColor = Color.White; }





                if (oficina.Text == "")
                { oficina.BackColor = Color.Red; }
                else { oficina.BackColor = Color.White; }



                if (comboBox3.Text == "")
                {
                    label28.Text = "!";
                    label28.BackColor = Color.Red;
                }
                else
                {
                    label28.Text = "";
                    comboBox3.BackColor = Color.White;


                }

               modificacionc();
               
            
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
           


        }
        void limpiar() {

            idver.Text = "";
            nombre.Text= "";
            maskedTextBox1.Text = "";
            
            numero.Text = "";
            piso.Text = "";
            oficina.Text = "";
            direccion.Text = "";
          
            contacto1.Text = "";
            codigopostal.Text = "";
            telefono1.Text = "";
            email1.Text = "";
          
            maskedTextBox2.Text = ""; 
        
        
        }
        void bloquear() { 
        
         idver.Enabled = false;
            nombre.Enabled = false;
            maskedTextBox1.Enabled = false;
            tipo.Enabled = false;
            numero.Enabled = false;
            piso.Enabled = false;
            oficina.Enabled = false;
            direccion.Enabled = false;
            comboBox3.Enabled = false;
            comboBox2.Enabled = false;
            contacto1.Enabled = false;
            codigopostal.Enabled = false;
            telefono1.Enabled = false;
            email1.Enabled = false;
            comboBox1.Enabled = false;
            maskedTextBox2.Enabled = false; 
        
        
        
        
        
        }
        void desbloquear() {

            
            nombre.Enabled = true;
            maskedTextBox1.Enabled = true;
            tipo.Enabled = true;
            numero.Enabled = true;
            piso.Enabled = true;
            oficina.Enabled = true;
            direccion.Enabled = true;
            comboBox3.Enabled = true;
            comboBox2.Enabled = true;
            contacto1.Enabled = true;
            codigopostal.Enabled = true;
            telefono1.Enabled = true;
            email1.Enabled = true;
            comboBox1.Enabled = true;
             
        
        
        
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void oficina_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void piso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void consultar_Click(object sender, EventArgs e)
        {
          

        }
        public void ejecutar(string uno, string dos, string cuatro, string siete, string tres, string cinco, string ocho, string trece, string diez, string once, string doce, string diesiocho, string diesinueve)//, string tres, string cuatro, string cinco, string seis, string siete, string ocho, string nueve, string diez, string once, string doce, string trece, string catorce
        {

            
            comboBox1.SelectedValue = uno;
            idver.Text = dos;
            maskedTextBox1.Text = siete;
            tipores = Convert.ToInt32(cuatro);
            tipo.SelectedValue = tipores;
            nombre.Text = tres;
            direccion.Text = cinco;
            codigopostal.Text = ocho;
            maskedTextBox2.Text = trece;
            numero.Text = once;
            piso.Text = doce;
            oficina.Text = doce;
           

            prov = Convert.ToInt32(diesiocho);
            comboBox2.SelectedValue = prov;
            loca();
           int  localidades = Convert.ToInt32(diesinueve); 
            comboBox3.SelectedValue = localidades;
     
        
        
        }
        private void consultar_Click_1(object sender, EventArgs e)
        {
            actualizar();
            nuevo.Enabled = false;
            modificar.Enabled = true;
            eliminar.Enabled = true; 
  Form6 form = new Form6();

            form.pasado+=new Form6.pasar(ejecutar);
           
             form.ShowDialog();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void modificar_Click(object sender, EventArgs e)
        {
         
         
          
            button4.Enabled = true;
            eliminar.Enabled = true;
            nuevo.Enabled = false;
            grabar.Enabled = true;
            desbloquear();
        }

        
        void modificacionc()
        {
            eliminar.Enabled = true; 
           
            adaptador.UpdateCommand.Parameters["@nombreanterior"].Value = idver.Text;
            adaptador.UpdateCommand.Parameters["@nombre"].Value = nombre.Text;
            adaptador.UpdateCommand.Parameters["@direccion"].Value = direccion.Text;
            adaptador.UpdateCommand.Parameters["@cuit"].Value = maskedTextBox1.Text;
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
            adaptador.UpdateCommand.Parameters["@piso"].Value = piso.Text;
            adaptador.UpdateCommand.Parameters["@oficina"].Value = oficina.Text;
            adaptador.UpdateCommand.Parameters["@alta"].Value = maskedTextBox2.Text;
            adaptador.UpdateCommand.Parameters["@numero"].Value = numero.Text;

            if (maskedTextBox2.Text != ("  /  /") && piso.Text != ("") && oficina.Text != ("") && numero.Text != ("") && nombre.Text != ("") && direccion.Text != ("") && maskedTextBox1.Text != ("  -        -") && codigopostal.Text != (""))
                {
                    conexion.Open();
                    adaptador.UpdateCommand.ExecuteNonQuery();

                    MessageBox.Show("datos actualizados con exito");
                    eliminar.Enabled = false; 
                    actualizardatos();
                  
                    grabar.Enabled = false;
                    modificar.Enabled = false;
                    nuevo.Enabled = true;
                    consultar.Enabled = true;
                    limpiar();
                    bloquear();
                  
        }
                else
                {

                    MessageBox.Show("Cargue los datos resaltados  para continuar ");
                    eliminar.Enabled = true;
                    grabar.Enabled = false;
                    modificar.Enabled = false;
                    nuevo.Enabled = true;
                    consultar.Enabled = true;
        }


        conexion.Close();


            
        
}

        private void eliminar_Click(object sender, EventArgs e)
        {
            colores();
            eliminar.Enabled = false;
            grabar.Enabled = false;
            modificar.Enabled = false;
            nuevo.Enabled = true;
            consultar.Enabled = true;
            bloquear();
            limpiar(); 

        }

        void colores()
        { 
        
                    maskedTextBox1.BackColor = Color.OrangeRed;

                    maskedTextBox1.BackColor = Color.White;
                    nombre.BackColor = Color.White;
 direccion.BackColor = Color.White; 
                 codigopostal.BackColor = Color.White; 
                 maskedTextBox2.BackColor = Color.White; 
                    numero.BackColor = Color.White;
                piso.BackColor = Color.White;         
                oficina.BackColor = Color.White;    
                    comboBox3.BackColor = Color.White;

        
        }
        void loca()
        {
            try
            {

                conexion.Open();
                SqlCommand consulta = new SqlCommand("Select  localidad, id ,id_provincia from localidad where id_provincia = '" + comboBox2.SelectedValue + "'", conexion);

                DataTable dt = new DataTable();


                SqlDataAdapter adaptador = new SqlDataAdapter(consulta);
                adaptador.Fill(dt);
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "localidad";
                comboBox3.ValueMember = "id";

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
        }
   

}
        
        
    

