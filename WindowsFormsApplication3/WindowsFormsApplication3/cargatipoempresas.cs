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
    public partial class cargatipoempresas : Form
    {
        public cargatipoempresas()
        {
            InitializeComponent();
        }
        SqlConnection conexion;
        SqlDataAdapter adaptador; 
        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        
       

        private void cargatipoempresas_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false; 
            carga.Enabled    = false; 
            label3.Visible   = false;
            textBox3.Visible = false; 
            eliminar.Enabled = false;
            grabar.Enabled = false;
            modific.Enabled = false; 

            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Aqua;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet5.tipoempresas' Puede moverla o quitarla según sea necesario.
            this.tipoempresasTableAdapter.Fill(this.gestionrubricasDataSet5.tipoempresas);
           
       //  conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            SqlCommand alta = new SqlCommand("insert into tipoempresas (tipo_empresa) values (@tipo_empresa)", conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipo_empresa", SqlDbType.VarChar)); 

        

         SqlCommand baja = new SqlCommand("delete from tipoempresas where tipo_empresa=@tipo_empresa", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@tipo_empresa", SqlDbType.VarChar));

            SqlCommand modificacion = new SqlCommand("update tipoempresas set tipo_empresa=@tipo_empresa where tipo_empresa=@nombreanterior", conexion);
            adaptador.UpdateCommand = modificacion;

            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@tipo_empresa", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreanterior", SqlDbType.VarChar));
      




}
        private void button3_Click(object sender, EventArgs e)
        {
           
            
            }
        
        private void button2_Click(object sender, EventArgs e)
        {
            carga.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }
        void  actua ()
        {
            gestionrubricasDataSet5.Clear(); 
         this.tipoempresasTableAdapter.Fill (this.gestionrubricasDataSet5.tipoempresas);
        
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void grabar_Click(object sender, EventArgs e)
        {
            if (nuevo.Enabled==false && textBox3.Visible==false)
            {
                cargardatos();

            carga.Enabled = false;
            carga.Enabled = false;
            label3.Visible = false;
            textBox3.Visible = false;
           
            grabar.Enabled = false;
            modific.Enabled = false;
            nuevo.Enabled = true;
            consultar.Enabled = true; 
}
            if (modific.Enabled == false && nuevo.Enabled==false )
            {
                modif();
                carga.Enabled = false;
             
                label3.Visible = false;
                textBox3.Visible = false;
                eliminar.Enabled = false;
                
                modific.Enabled = false;
                nuevo.Enabled = true;
                consultar.Enabled = true; 
            }

        }

        void cargardatos()
        {
            adaptador.InsertCommand.Parameters["@tipo_empresa"].Value = textBox2.Text;
            try
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("ingrese datos");
                    grabar.Enabled = true;
                    eliminar.Enabled = true; 
                }
                else
                {
                    conexion.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("datos cargados correctamente");
                    textBox2.Enabled = false;
                    textBox2.Text = "";
                    carga.Enabled = false;
                    eliminar.Enabled = false;
                    carga.Text = "";
                    Refresh();

                    
                    actua();

                }
            }

            catch (SqlException exepcion)
            {
                MessageBox.Show(exepcion.ToString());


            }
            finally { conexion.Close(); }
        }




        void eli() {
            adaptador.DeleteCommand.Parameters["@tipo_empresa"].Value = textBox2.Text;

            try
            {
                conexion.Open();

                int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                if (cantidad > 0)
                {
                    MessageBox.Show("Empresa eliminada");
                    actua();
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Empresa inexistente");

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

   public void consultar_Click(object sender, EventArgs e)
        {
            eliminar.Enabled = true; 
            nuevo.Enabled = false;
            modific.Enabled = true; 
            consultarsociedad consultar = new consultarsociedad();
            consultar.pasar += new consultarsociedad.datos(ejecutar);
            consultar.Show(); 


        }

        void ejecutar(string nombreempresa,string idempresa)
        {
            textBox2.Enabled = false; 
            textBox2.Text = idempresa; 
            carga.Text = nombreempresa;
           
        
        }
        void modif()
        {
            carga.Enabled = true; 
            adaptador.UpdateCommand.Parameters["@nombreanterior"].Value = textBox2.Text;
            adaptador.UpdateCommand.Parameters["@tipo_empresa"].Value = textBox3.Text;


            try
            {
                conexion.Open();
                int informacion = adaptador.UpdateCommand.ExecuteNonQuery();
                if (informacion > 0)
                {

                    MessageBox.Show("Cambio de Nombre de Empresa realizado");
                    textBox2.Text = textBox3.Text;
                    textBox3.Visible = false;
                    label3.Visible = false;
                    carga.Text = "";
                    textBox2.Text = ""; 

                }
                else
                { MessageBox.Show("no se encuentran resultados para realzar la modificacion "); }

                actua();
                textBox4.Text = "";
                textBox3.Text = "";
                carga.Text = "";
                textBox2.Text = "";
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
            modific.Enabled = false;
            nuevo.Enabled = false;
            consultar.Enabled = false; 
            label3.Visible = true;
            textBox3.Visible = true;
            
            grabar.Enabled = true; 
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            
            textBox2.Text = "";
            textBox2.Enabled = true; 
            nuevo.Enabled= false;
            modific.Enabled = false;
            consultar.Enabled = false;
            grabar.Enabled = true;
            eliminar.Enabled = true; 
            conexion.Open();
            SqlCommand comando = new SqlCommand("select  max(id_empresa) +1 as contador from tipoempresas", conexion);

            SqlDataReader datos = comando.ExecuteReader();

            while (datos.Read())
            {

                carga.AppendText(datos["contador"].ToString());
            }


            conexion.Close();

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            
            carga.Enabled = false;
            label3.Visible = false;
            textBox3.Visible = false;
            eliminar.Enabled = false;
            grabar.Enabled = false;
            modific.Enabled = false;
            nuevo.Enabled = true;
            consultar.Enabled = true;
            carga.Text = "";
            textBox2.Enabled = false; 
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
       

    }
}
