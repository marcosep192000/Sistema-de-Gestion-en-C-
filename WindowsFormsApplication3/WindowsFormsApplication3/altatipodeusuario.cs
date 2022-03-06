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
    public partial class altatipodeusuario : Form
    {
        public altatipodeusuario()
        {
            InitializeComponent();
        }
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        DataSet datos;
        private void altatipodeusuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tipousuarios.tipohusuarios' Puede moverla o quitarla según sea necesario.
            this.tipohusuariosTableAdapter.Fill(this.tipousuarios.tipohusuarios);
            conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            SqlCommand alta = new SqlCommand("insert into tipohusuarios (nombre)values (@nombre)", conexion);
            adaptador.InsertCommand = alta;
           
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaptador.InsertCommand.Parameters["@nombre"].Value = nombre.Text;
            
            try
            {

                conexion.Open();
                if (nombre.Text != ("") )
                {

                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("datos cargados correctamente");
                    
                }
                else
                {
                    MessageBox.Show("Complete datos a cargar");

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        }

       
    }

