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
   public partial class Form2 : Form
    {
       public Form2( string resultado ,string historico,string estudioscontables, string modificacionusuarios, string mantenimientoclientes, string mantenimientoestudios, string clave, string nombre, string pedidos, string modificarpedido, string clientes, string mails  )
        {
            InitializeComponent();
           
            this.modificacionusuarios = modificacionusuarios; this.historico = historico;
            this.mantenimientoclientes = mantenimientoclientes; this.mantenimientoestudios = mantenimientoestudios; this.clave = clave; this.nombre = nombre; this.pedidos = pedidos; this.modificarpedido = modificarpedido; this.clientes = clientes; this.mails = mails; this.estudioscontables = estudioscontables;
            this.resultado = resultado;
           
        }
       
 int cont = 1;
 int minuto = 0;
 int hora = 0;

        SqlDataAdapter adaptador;
        SqlConnection conexion;
        string resultado,modificacionusuarios, mantenimientoclientes, mantenimientoestudios, clave, nombre, pedidos, modificarpedido, clientes, mails,historico,estudioscontables;

      public  void Form2_Load(object sender, EventArgs e)
        {

            string total = segundos.Text + minutos.Text + horas.Text;
            label2.Text = total.ToString ();

            string inicio = DateTime.Now.ToString();
            label1.Text = inicio.ToString(); 
            minutos.Text = ":00";
            horas.Text = "00";

           dateTimePicker1.Value = DateTime.Now;
           Label1t.Text = (resultado.ToString());
         

        
          
          
          
          
          if (modificacionusuarios == "True")
            {
                altasUsuario.Enabled = true;
            }
            else {
                altasUsuario.Enabled = false;
               
            
           
            }

          if (mantenimientoclientes == "True")
            {
                mantenimientoclie.Enabled = true;
            }
            else
            {
                   mantenimientoclie.Enabled = false;


            }

          if (mantenimientoestudios == "True")
            {
                mantenimientoEstudiosContablesToolStripMenuItem.Enabled = true;
            }
            else
            {
                mantenimientoEstudiosContablesToolStripMenuItem.Enabled = false;



            }

            if (pedidos == "True")
            {
                nuevopedido.Enabled = true;
            }
            else
            {
                nuevopedido.Enabled = false;



            }


            if (modificarpedido == "True")
            {
                modificarEstadoToolStripMenuItem.Enabled = true;
            }
            else
            {
                modificarEstadoToolStripMenuItem.Enabled = false;



            }

            if (mails == "True")
            {
                envioDeEmailsToolStripMenuItem.Enabled = true;
            }
            else
            {
                envioDeEmailsToolStripMenuItem.Enabled = false;



            }

            if (historico == "True")
            {
                historicoPorClieteToolStripMenuItem.Enabled = true;
            }
            else
            {
                historicoPorClieteToolStripMenuItem.Enabled = false;
            }

            if (estudioscontables == "True")
            {
                mantenimientoEstudiosContablesToolStripMenuItem.Enabled = true;
            }
            else
            {
                mantenimientoEstudiosContablesToolStripMenuItem.Enabled = false;



            }








         // conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
            conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            adaptador =new  SqlDataAdapter();
          SqlCommand sesion = new SqlCommand("insert into usuarioss (fechahorasalida) values (@fechahorasalida)",conexion);
          adaptador.InsertCommand = sesion;
          adaptador.InsertCommand.Parameters.Add(new SqlParameter ("@fechahorasalida",SqlDbType.DateTime));

}
       


        private void mantenimientoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mantenimientoEstudiosContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }



     private void mantenimientoClientesToolStripMenuItem_Click_1(object sender, EventArgs e)
     {
        
     
       


        }

       private void todosLosClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 Form2 = new Form7();
            Form2.Show();
        }

        public void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


            Form8 Form2 = new Form8();
            Form2.Show();
        }

        private void todosLosEstudiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formestudios form2 = new Formestudios();
            form2.Show();
        }

        private void cerrarCecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string final = DateTime.Now.ToString(); 






            Form1 Form2 = new Form1();
            Form2.Show();
            this.Hide();

        }

        public void envioDeEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnviodeMails Form2 = new EnviodeMails();
            Form2.Show();
        }

        private void altaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaclientes Form2 = new altaclientes();
            Form2.Show();
        }

        private void altaEstudiosContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoestudios Form2 = new nuevoestudios();
            Form2.Show();  
        }

        private void crearTipoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altatipodeusuario Form2 = new altatipodeusuario();
            Form2.Show();
        }

        private void altasUsuario_Click(object sender, EventArgs e)
        {
           modificacion  Form2 = new modificacion();
           Form2.Show();
         }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pedidosespera Form2 = new pedidosespera();
            Form2.Show(); 

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertarusuario(); 



            Application.Exit();
        }

        private void pruebaFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void busquedaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaclientesporfactura Form2 = new consultaclientesporfactura();
            Form2.Show(); 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void modificacionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificaciondeclientes Form2 = new modificaciondeclientes();
            Form2.Show(); 
        }

        private void bajasDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BAJACLIENTES Form2 = new BAJACLIENTES();
            Form2.Show(); 
        }

        private void historicoPorClieteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hisoricoporcliente Form2 = new hisoricoporcliente();
            Form2.Show(); 
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            consultaclientesporfactura Form2 = new consultaclientesporfactura();
            Form2.Show(); 

        }

        private void modificarEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificacionEstudiosContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificacionestudios Form2 = new modificacionestudios();
            Form2.Show();
        }

        private void bajaEstudiosContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bajasestudio Form2 = new Bajasestudio();
            Form2.Show();
        }

        private void listadoDeEstudiosPorClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listadocompletoestudiosclientes Form2 = new listadocompletoestudiosclientes();
            Form2.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientesporestudio Form2 = new clientesporestudio();
            Form2.Show(); 
        
        }

        private void buscarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buscarcliente Form2 = new buscarcliente();
            Form2.Show(); 
        }

       public void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             

      
        }

       private void toolStripStatusLabel1_Click(object sender, EventArgs e)
       {

       }

       private void tool_Click(object sender, EventArgs e)
       {
        // tool.Text= DateTime.Now();
       }

       public  void timer1_Tick(object sender, EventArgs e)
       {
           if (timer1.Enabled == true)
           { 

           cont = cont + 1 ;
           if (cont == 61)
               cont = 0; 
               
           segundos.Text =":"+ cont.ToString();
           if (cont == 0)
           { 
               minuto= minuto +1 ;
               minutos.Text = minuto.ToString()+":";  
           
           
           }
           if (minuto == 60)
           {
               hora = hora + 1;
               horas.Text = hora.ToString();
           
           }
           
           }
       }

       private void Form2_MouseClick(object sender, MouseEventArgs e)
       {
          
           if (minuto == 1)
           {

               Form1 f = new Form1();
               f.Show();
               this.Close(); 

           
           }
       }

       private void cambiarPielesToolStripMenuItem_Click(object sender, EventArgs e)
       {
          

       }
       private void pictureBox1_Click(object sender, EventArgs e)
       {
        
       }

       private void leonToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\marcos\Documents\Visual Studio 2012\Projects\WebApplication2\WindowsFormsApplication3\WindowsFormsApplication3\imag\The_King_lion_hd_wallpapers.jpg");
       }

       private void marToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\marcos\Documents\Visual Studio 2012\Projects\WebApplication2\WindowsFormsApplication3\WindowsFormsApplication3\imag\images.jpg");
       }

       private void autoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\marcos\Documents\Visual Studio 2012\Projects\WebApplication2\WindowsFormsApplication3\WindowsFormsApplication3\imag\Fondos-HD-para-pc-auto.jpg");
       }

       private void button3_Click(object sender, EventArgs e)
       {
           System.Diagnostics.Process.Start("WWW.GOOGLE.COM");
       }

       void insertarusuario()
       {
           string total =horas.Text+minutos.Text+segundos.Text;
           label2.Text = total.ToString();
           label3.Text = DateTime.Now.ToString();
           adaptador = new SqlDataAdapter();
           SqlCommand alta = new SqlCommand("insert into usuarioss (nombre,fechahora,tiempotranscurrido,fechahorasalida)values (@nombre,@fechahora,@tiempotranscurrido,@fechahorasalida)", conexion);

           adaptador.InsertCommand = alta;
           adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
           adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechahora", SqlDbType.VarChar));
           adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tiempotranscurrido", SqlDbType.VarChar));
           adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechahorasalida", SqlDbType.VarChar));
          
          adaptador.InsertCommand.Parameters["@nombre"].Value = Label1t.Text ;
          adaptador.InsertCommand.Parameters["@fechahora"].Value = label1.Text;
          adaptador.InsertCommand.Parameters["@fechahorasalida"].Value = label3.Text ;
         adaptador.InsertCommand.Parameters["@tiempotranscurrido"].Value = label2.Text ;

          try {
              conexion.Open ();

              adaptador.InsertCommand.ExecuteNonQuery();

          
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

       private void cadeteriaToolStripMenuItem_Click(object sender, EventArgs e)
       {
          
       }

       private void modificarOpcionesDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
       {

       }

       private void pictureBox3_Click(object sender, EventArgs e)
       {

       }
        
        }
           
        }
       

      
   

