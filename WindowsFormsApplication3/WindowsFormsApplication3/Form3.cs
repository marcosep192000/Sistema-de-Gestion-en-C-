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
    public partial class modificacion : Form
    {
        public modificacion()
        {
            InitializeComponent();
        }

        SqlConnection conexion;
        SqlDataAdapter adaptador;
        DataSet datos1;

        public void modificacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet27.usuarios' Puede moverla o quitarla según sea necesario.
         
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet17.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter3.Fill(this.gestionrubricasDataSet17.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet10.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter2.Fill(this.gestionrubricasDataSet10.usuarios);

       
            
            label1.Parent = groupBox1;
            label2.Parent = groupBox1; 
            
            label4.Parent = groupBox2;
            label5.Parent = groupBox2;
            label6.Parent = groupBox2;
         
            label7.Parent = groupBox2; 
           
         
        
 label8.Parent = groupBox1;
 label9.Parent = groupBox5;
 label10.Parent = groupBox5;
 label11.Parent = groupBox5; 

            label13.Parent = groupBox5;
            label12.Parent = groupBox5;

        
            label14.Parent = groupBox5;
           

           
            label16.Parent = groupBox5; 
       
  bloqueo();
  button2.Enabled = false; 
  button3.Enabled = false; 
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet1.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter1.Fill(this.gestionrubricasDataSet1.usuarios);
        //   conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
         conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            SqlCommand alta = new SqlCommand("insert into usuarios (modificacionusuarios,mantenimientoclientes,mantenimientoestudios,clave,nombre,pedidos,modificarpedido,clientes, mails,estudioscontables,historico,name,direccion,telefono,apellido,cargo)values (@modificacionusuarios,@mantenimientoclientes,@mantenimientoestudios,@clave,@nombre,@pedidos,@modificarpedido,@clientes,@mails,@estudioscontables,@historico,@name,@direccion,@telefono,@apellido,@cargo)", conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@clave", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@modificacionusuarios", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@mantenimientoclientes", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@pedidos", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@modificarpedido", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@clientes", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@mails", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@mantenimientoestudios", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@historico", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@estudioscontables", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
          adaptador.InsertCommand.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cargo", SqlDbType.VarChar));

            SqlCommand consulta = new SqlCommand("SELECT ID_usuario, nombre, clave, modificacionusuarios, mantenimientoclientes, mantenimientoestudios, pedidos, modificarpedido, clientes, mails,name,direccion,telefono,apellido,cargo FROM     usuarios", conexion);
            adaptador.SelectCommand = consulta;
            datos1 = new DataSet();
            conexion.Open();
            adaptador.Fill(datos1,"usuarios");
            conexion.Close();
         
           
            SqlCommand baja = new SqlCommand("delete from usuarios where nombre=@nombre", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));

            SqlCommand modificacion = new SqlCommand("update usuarios set nombre=@nombre, clave=@clave, modificacionusuarios=@modificacionusuarios,mantenimientoclientes=@mantenimientoclientes,mantenimientoestudios=@mantenimientoestudios,pedidos=@pedidos,modificarpedido=@modificarpedido,clientes=@clientes,mails=@mails,name=@name,direccion=@direccion,telefono=@telefono,apellido=@apellido,cargo=@cargo where nombre=@nombreanterior", conexion);
            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@clave", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreanterior", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@modificacionusuarios", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@mantenimientoclientes", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@pedidos", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@modificarpedido", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@clientes", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@mails", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@mantenimientoestudios", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cargo", SqlDbType.VarChar));


        }


       





        public void button1_Click_1(object sender, EventArgs e)
        {
            adaptador.InsertCommand.Parameters["@nombre"].Value = nombre.Text;
            adaptador.InsertCommand.Parameters["@clave"].Value = clave.Text;
            adaptador.InsertCommand.Parameters["@modificacionusuarios"].Value = this.checkBox8.Checked;
            adaptador.InsertCommand.Parameters["@mantenimientoclientes"].Value = this.checkBox7.Checked;
            adaptador.InsertCommand.Parameters["@pedidos"].Value = this.checkBox1.Checked;
            adaptador.InsertCommand.Parameters["@modificarpedido"].Value = this.checkBox2.Checked;
            adaptador.InsertCommand.Parameters["@clientes"].Value = this.checkBox9.Checked;
            adaptador.InsertCommand.Parameters["@mails"].Value = this.checkBox6.Checked;
            adaptador.InsertCommand.Parameters["@mantenimientoestudios"].Value = this.checkBox7.Checked;
            adaptador.InsertCommand.Parameters["@estudioscontables"].Value = checkBox4.Checked;
            adaptador.InsertCommand.Parameters["@historico"].Value = this.checkBox5.Checked;


            adaptador.InsertCommand.Parameters["@name"].Value = name.Text;
            adaptador.InsertCommand.Parameters["@apellido"].Value = apellido.Text;
            adaptador.InsertCommand.Parameters["@direccion"].Value = direccion.Text;
            adaptador.InsertCommand.Parameters["@telefono"].Value = telefono.Text;
            adaptador.InsertCommand.Parameters["@cargo"].Value = cargo.SelectedItem;
             comparar();
            
            try
            {

                if (nombre.Text != "" && clave.Text != ""&& nombre.Text != "" && clave.Text != "" &&name.Text != "" &&direccion.Text != "" && telefono.Text != ""&& apellido.Text != ""       )
                {
                   
                    
                    
                   
                  
                   

                    conexion.Open();

                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("datos cargados correctamente");

                    nombre.Enabled = false;
                    clave.Enabled = false;
                    bloqueo();

                    limpiar();

                    actualizardatos();


                }
                else {
                 

                    MessageBox.Show("Corrobore que los campos a ingresar ");
                
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

        private void button2_Click(object sender, EventArgs e)
        {
            adaptador.DeleteCommand.Parameters["@nombre"].Value = nombre.Text;

            try
            {
                conexion.Open();

                int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                if (cantidad > 0)
                {
                    MessageBox.Show("Usuario eliminado");
                    actualizardatos();
                    button2.Enabled = false; 
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Enabled = false; 
            desbloqueo();
        }


       public void actualizardatos()
        {
            datos1.Clear();
            adaptador.Fill(datos1,"usuarios");

        }

       private void fillToolStripButton_Click(object sender, EventArgs e)
       {
           try
           {
               this.usuariosTableAdapter1.Fill(this.gestionrubricasDataSet1.usuarios);
           }
           catch (System.Exception ex)
           {
               System.Windows.Forms.MessageBox.Show(ex.Message);
           }
          

       }

       private void button4_Click(object sender, EventArgs e)
       {
           Close();
       }

       private void button7_Click(object sender, EventArgs e)
       {
           button3.Enabled = false;
           button8.Enabled = false;
           button2.Enabled = false; 
           button7.Enabled = true;


           desbloqueo();
           limpiar();
          
       
       }

       private void button8_Click(object sender, EventArgs e)
       {
           buscarUSUARIO bs = new buscarUSUARIO();
           bs.Show();
           button2.Enabled = true; 
           button3.Enabled=true ;
           button7.Enabled = false;
           bloqueo(); 
               string cadena = "SELECT *  FROM usuarios where  nombre='" + nombre.Text + "'";
              SqlCommand  con = new SqlCommand (cadena , conexion);
              conexion.Open(); 
              SqlDataReader leer = con.ExecuteReader();

              if (leer.Read() == true)
              {
                 clave.Text = leer["clave"].ToString();
                 name.Text = leer["name"].ToString();
                 direccion.Text = leer["direccion"].ToString();
                 cargo.SelectedItem = leer["cargo"].ToString();
                 telefono.Text = leer["telefono"].ToString();
                 apellido.Text = leer["apellido"].ToString();
                  checkBox8.Checked = Convert.ToBoolean(leer["modificacionusuarios"]);
                  checkBox7.Checked = Convert.ToBoolean(leer["mantenimientoclientes"]);
                  checkBox1.Checked = Convert.ToBoolean(leer["pedidos"]);
                  checkBox2.Checked = Convert.ToBoolean(leer["modificarpedido"]);
                  checkBox9.Checked = Convert.ToBoolean(leer["clientes"]);
                  checkBox6.Checked = Convert.ToBoolean(leer["mails"]);
                  checkBox3.Checked = Convert.ToBoolean(leer["mantenimientoestudios"]);
              }

              conexion.Close();
           }

       private void checkBox1_CheckedChanged(object sender, EventArgs e)
       {

       }

       private void groupBox1_Enter(object sender, EventArgs e)
       {

       }

     


       void comparar()
       { 
       string cadena = "SELECT *  FROM usuarios where  nombre='" + nombre.Text + "'";


            SqlCommand consulta = new SqlCommand(cadena, conexion);
            conexion.Open();
            SqlDataReader leer = consulta.ExecuteReader();
            if (leer.Read() == true)
            {



                string nombres = leer["nombre"].ToString();

                if (nombre.Text == nombres.ToString())
                {

                    nombre.Text = "";
                    clave.Text = "";
                   MessageBox.Show("usuario ya registrado");
                }
                
            }
       
conexion.Close();
            }

       private void groupBox4_Enter(object sender, EventArgs e)
       {

       }
       void limpiar()
       {
           nombre.Text = "";
           clave.Text = "";
           name.Text = "";
           direccion.Text = "";
           telefono.Text = "";
           apellido.Text = "";
          
       

       }
       void bloqueo()
       {
           nombre.Enabled = false;
           apellido.Enabled = false;
           name.Enabled = false;
           direccion.Enabled = false;
           telefono.Enabled = false;
           apellido.Enabled = false;
           clave.Enabled = false;
           cargo.Enabled = false;
           checkBox1.Enabled = false;
           checkBox2.Enabled = false; checkBox3.Enabled = false; checkBox4.Enabled = false; checkBox5.Enabled = false;
           checkBox6.Enabled = false;
           checkBox7.Enabled = false;
           checkBox8.Enabled = false;
           checkBox9.Enabled = false;
       
       
       }
       void desbloqueo()
       {
           nombre.Enabled = true;
           apellido.Enabled = true;
           name.Enabled = true;
           direccion.Enabled = true;
           telefono.Enabled = true;
           apellido.Enabled = true;
           clave.Enabled = true;
           cargo.Enabled = true;
           checkBox1.Enabled = true;
           checkBox2.Enabled = true; checkBox3.Enabled = true; checkBox4.Enabled = true; checkBox5.Enabled = true;
           checkBox6.Enabled = true;
           checkBox7.Enabled = true;
           checkBox8.Enabled = true;
           checkBox9.Enabled = true;
       
       }
       void alta()
       {

           adaptador.InsertCommand.Parameters["@nombre"].Value = nombre.Text;
           adaptador.InsertCommand.Parameters["@clave"].Value = clave.Text;
           adaptador.InsertCommand.Parameters["@modificacionusuarios"].Value = this.checkBox8.Checked;
           adaptador.InsertCommand.Parameters["@mantenimientoclientes"].Value = this.checkBox7.Checked;
           adaptador.InsertCommand.Parameters["@pedidos"].Value = this.checkBox1.Checked;
           adaptador.InsertCommand.Parameters["@modificarpedido"].Value = this.checkBox2.Checked;
           adaptador.InsertCommand.Parameters["@clientes"].Value = this.checkBox9.Checked;
           adaptador.InsertCommand.Parameters["@mails"].Value = this.checkBox6.Checked;
           adaptador.InsertCommand.Parameters["@mantenimientoestudios"].Value = this.checkBox7.Checked;
           adaptador.InsertCommand.Parameters["@estudioscontables"].Value = checkBox4.Checked;
           adaptador.InsertCommand.Parameters["@historico"].Value = this.checkBox5.Checked;


           adaptador.InsertCommand.Parameters["@name"].Value = name.Text;
           adaptador.InsertCommand.Parameters["@apellido"].Value = apellido.Text;
           adaptador.InsertCommand.Parameters["@direccion"].Value = direccion.Text;
           adaptador.InsertCommand.Parameters["@telefono"].Value = telefono.Text;
           adaptador.InsertCommand.Parameters["@cargo"].Value = cargo.SelectedItem;
           comparar();

           try
           {

               if (nombre.Text != "" && clave.Text != "" && nombre.Text != "" && clave.Text != "" && name.Text != "" && direccion.Text != "" && telefono.Text != "" && apellido.Text != "")
               {







                   conexion.Open();

                   adaptador.InsertCommand.ExecuteNonQuery();
                   MessageBox.Show("datos cargados correctamente");

                   nombre.Enabled = false;
                   clave.Enabled = false;
                   checkBox1.Enabled = false;
                   checkBox2.Enabled = false; checkBox3.Enabled = false; checkBox4.Enabled = false; checkBox5.Enabled = false;
                   checkBox6.Enabled = false;
                   checkBox7.Enabled = false;
                   checkBox8.Enabled = false;
                   checkBox9.Enabled = false;

                   limpiar();

                   actualizardatos();


               }
               else
               {


                   MessageBox.Show("Corrobore que los campos a ingresar ");
                  


               }

 button3.Enabled = false; 

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

       private void button5_Click(object sender, EventArgs e)
       {
           if (button7.Enabled == true )
           {

               alta();
             
               button8.Enabled = true;
               button2.Enabled = true; 
               button7.Enabled = true;
          
           
           }

           else    
           {
              
               if (button3.Enabled==false  ) 

               desbloqueo(); 
               atualizar();
               limpiar();
               bloqueo();
               button3.Enabled = false; 
           
           }

       }

       void atualizar()
       { 

       adaptador.UpdateCommand.Parameters["@nombreanterior"].Value = nombre.Text;
            adaptador.UpdateCommand.Parameters["@nombre"].Value = nombre.Text;
            adaptador.UpdateCommand.Parameters["@clave"].Value = clave.Text;
            adaptador.UpdateCommand.Parameters["@modificacionusuarios"].Value = checkBox8.Checked;
            adaptador.UpdateCommand.Parameters["@mantenimientoclientes"].Value = checkBox7.Checked;
            adaptador.UpdateCommand.Parameters["@pedidos"].Value = checkBox1.Checked;
            adaptador.UpdateCommand.Parameters["@modificarpedido"].Value = checkBox2.Checked;
            adaptador.UpdateCommand.Parameters["@clientes"].Value = checkBox9.Checked;
            adaptador.UpdateCommand.Parameters["@mails"].Value = checkBox4.Checked;
            adaptador.UpdateCommand.Parameters["@mantenimientoestudios"].Value = checkBox3.Checked;
            adaptador.UpdateCommand.Parameters["@name"].Value = name.Text;
            adaptador.UpdateCommand.Parameters["@apellido"].Value = apellido.Text;
            adaptador.UpdateCommand.Parameters["@direccion"].Value = direccion.Text;
            adaptador.UpdateCommand.Parameters["@telefono"].Value = telefono.Text;
            adaptador.UpdateCommand.Parameters["@cargo"].Value = cargo.SelectedText;
            try
            {
                conexion.Open();
                int informacion = adaptador.UpdateCommand.ExecuteNonQuery();
                if (informacion > 0)
                {

                    MessageBox.Show("cambio de Usuario realizado exitosamente ");
                    limpiar();
                }
                else
                { MessageBox.Show("no se encuentran resultados para realzar la modificacion "); }


                actualizardatos();

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

       private void telefono_TextChanged(object sender, EventArgs e)
       {
         

        
       }

       private void telefono_KeyPress(object sender, KeyPressEventArgs e)
       {
           Class1.txtCaracter_KeyPress(e);
       }

       private void button5_MouseLeave(object sender, EventArgs e)
       {
           bara.Text = "Graba los cambios realizados ";
       }
       } 
    }









