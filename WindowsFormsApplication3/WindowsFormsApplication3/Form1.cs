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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        SqlConnection conexion;
      public string resultado ;

        string modificacionusuarios, mantenimientoclientes, mantenimientoestudios, clave, nombre, pedidos, modificarpedido, clientes, mails, estudioscontables, historico;
        int cont =3;


        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Visible = false; 
            conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
            //  conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            string cadena = "SELECT *  FROM usuarios where  nombre='" + textBox1.Text + "'and clave='" +textBox2.Text + "'";


            SqlCommand consulta = new SqlCommand(cadena, conexion);
            conexion.Open();
            SqlDataReader leer = consulta.ExecuteReader();
            if (leer.Read() == true)
            {



                string nombre = leer["nombre"].ToString();
                string contraseña = leer["clave"].ToString();
                modificacionusuarios = leer["modificacionusuarios"].ToString();
                mantenimientoclientes = leer["mantenimientoclientes"].ToString();
                mantenimientoestudios = leer["mantenimientoestudios"].ToString();
                pedidos = leer["pedidos"].ToString();
                modificarpedido = leer["modificarpedido"].ToString();
                clientes = leer["clientes"].ToString();
                mails = leer["mails"].ToString();
                historico = leer["historico"].ToString();
                estudioscontables = leer["estudioscontables"].ToString();





                if (textBox1.Text == nombre.ToString() && textBox2.Text == contraseña.ToString())
                {


                    MessageBox.Show ("Bienvenido Usuario :" + textBox1.Text);
                    resultado = textBox1.Text;
                    Form2 Form1 = new Form2(resultado, historico, estudioscontables, mantenimientoclientes, modificacionusuarios, mantenimientoestudios, clave, nombre, pedidos, modificarpedido, clientes, mails);
                    Form1.Show();
                    this.Hide();

                }

            }
            else
            {



                cont = cont - 1;
                label5.Visible = true; 
               
                label4.Text = " " + cont;



                if (cont == 0)
                {
                    MessageBox.Show("El sistema se cerrara agoto su numero de intentos"  );
                    Application.Exit();
                   // splashinicio s = new splashinicio();
                    
                }



            }
                conexion.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        
    }
}












