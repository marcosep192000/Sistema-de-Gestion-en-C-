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
    public partial class articulos : Form
    {
        public articulos()
        {
            InitializeComponent();
        }
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        

        private void articulos_Load(object sender, EventArgs e)
        {
            label3.Visible = false; 
            textBox3.Visible = false;
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet15.tipoempresas' Puede moverla o quitarla según sea necesario.
            this.tipoempresasTableAdapter.Fill(this.gestionrubricasDataSet15.tipoempresas);
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Aqua;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet11.articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.gestionrubricasDataSet11.articulos);
           conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
    
            
       //  conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
            
            adaptador = new SqlDataAdapter();
            SqlCommand alta = new SqlCommand ("insert into articulos (nombredearticulo)values (@nombredearticulo)",conexion);
            
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombredearticulo", SqlDbType.VarChar));


            SqlCommand baja = new SqlCommand("delete from articulos where nombredearticulo=@nombredearticulo", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@nombredearticulo", SqlDbType.VarChar));

            SqlCommand modificacion = new SqlCommand("update articulos set nombredearticulo=@nombredearticulo where nombredearticulo=@nombreanterior", conexion);
            adaptador.UpdateCommand = modificacion;
         
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombredearticulo", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreanterior", SqlDbType.VarChar));
      
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form8 F = new Form8();

            F.actualizar();

            


            this.Close();  
        }
        public void actualizardatos()
        {
            gestionrubricasDataSet11.Clear();
            this.articulosTableAdapter.Fill(this.gestionrubricasDataSet11.articulos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adaptador.DeleteCommand.Parameters["@nombredearticulo"].Value = textBox2.Text;

            try
            {
                conexion.Open();

                int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                if (cantidad > 0)
                {
                    MessageBox.Show("Articulo  eliminado");
                    actua();
                    textBox2.Text = ""; 
                }
                else
                {
                    MessageBox.Show("Articulo inexistente");

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

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
   void actua() 
    {
        gestionrubricasDataSet11.Clear();
        this.articulosTableAdapter.Fill(this.gestionrubricasDataSet11.articulos);

    }


   public void cargar()
   {
       adaptador.InsertCommand.Parameters["@nombredearticulo"].Value = textBox1.Text;

       try
       {
           if (textBox1.Text == "")
           {

               MessageBox.Show("Usted no a ingresado ningun dato ");

           }
           else
           {
               conexion.Open();

               adaptador.InsertCommand.ExecuteNonQuery();
               MessageBox.Show("Datos ingresados correctamente");
               actua();
               textBox1.Text = "";
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
       cargar(); 
   }
   void actualizar()
   {
       adaptador.UpdateCommand.Parameters["@nombreanterior"].Value = id.Text;
       adaptador.UpdateCommand.Parameters["@nombredearticulo"].Value = textBox3.Text;


       try
       {
           conexion.Open();
           int informacion = adaptador.UpdateCommand.ExecuteNonQuery();
           if (informacion > 0)
           {

               MessageBox.Show("Cambio de Nombre de articulo realizado");

           }
           else
           { MessageBox.Show("no se encuentran resultados para realzar la modificacion "); }

           actua();
           id.Text = "";
           textBox3.Text = "";


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

   private void modificar_Click(object sender, EventArgs e)
   {
       textBox3.Visible = true;
       label3.Visible = true;

   }

  
   public void consultar_Click(object sender, EventArgs e)
   {
       eliminar.Enabled = true;
       nuevo.Enabled = false;
       modificar.Enabled = true;
       
       buscarlibro buscar = new buscarlibro();
       buscar.pasar += new buscarlibro.datos(ejecutar);
       buscar.Show();



       
   }

   void ejecutar(string nombrelibro, string idlibro)
   {
       id.Enabled = false;
       id.Text = idlibro;
       textBox1.Text = nombrelibro;


   }


    }
}


