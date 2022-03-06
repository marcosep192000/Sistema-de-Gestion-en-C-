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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            facturaModelo = WindowsFormsApplication3.Properties.Resources.FACTURA; 

        }
      


        SqlConnection conexion;
        DataTable dt; SqlDataAdapter da,adaptador2,adaptador,adaptador1; DataSet datos1;
        private Image facturaModelo;
        public void Form8_Load(object sender, EventArgs e)
        {
            this.data1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            data1.Columns[5].Visible = false;
            cantidad.Enabled = false;
            cantidad.BackColor = Color.WhiteSmoke;
            entrega.Enabled = false;
            entrega.BackColor = Color.WhiteSmoke;
            numerolibro.Enabled = false;
            numerolibro.BackColor = Color.WhiteSmoke;
            textBox2.Enabled = false;
            textBox2.BackColor = Color.WhiteSmoke;
            comboBox1.Enabled = false;
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox2.Enabled = false;
            comboBox2.BackColor = Color.WhiteSmoke;

            date.Value = DateTime.Now;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet14.articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter2.Fill(this.gestionrubricasDataSet14.articulos);
            // TODO: esta línea de código carga datos en la tabla 'gestionrubricasDataSet4.articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter1.Fill(this.gestionrubricasDataSet4.articulos);
             label2.Parent = groupBox1; label4.Parent = groupBox1; label3.Parent = groupBox1; label5.Parent = groupBox1;
            label9.Parent = groupBox2;
            label10.Parent = groupBox2;
            label11.Parent = groupBox2;
            label13.Parent = groupBox2;
            conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
          // conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
            conexion.Open();

            SqlCommand comando = new SqlCommand("select  max(numerofact) +1 as contador from prueba", conexion);

            SqlDataReader datos = comando.ExecuteReader();

            while (datos.Read())
            {

                boton.AppendText(datos["contador"].ToString());
            }


            conexion.Close();


            acru();
            
        
 
 }
        public void button1_Click(object sender, EventArgs e)
        {
            cantidad.Enabled = true;
            cantidad.BackColor = Color.White;
            entrega.Enabled = true;
            entrega.BackColor = Color.White;
            

            textBox2.Enabled = true;
            textBox2.BackColor = Color.White;
            comboBox1.Enabled = true;
            comboBox1.BackColor = Color.White;
            comboBox2.Enabled = true;
            comboBox2.BackColor = Color.White;
            try
            {
                string cadena = "SELECT *  FROM clientes where  nombre='" + textBox1.Text + "'";

                SqlCommand consulta = new SqlCommand(cadena, conexion);
                conexion.Open();
                SqlDataReader leer = consulta.ExecuteReader();
                if (leer.Read() == true)
                {
                    this.textBox1.AutoCompleteCustomSource.Add(leer[0].ToString());
                    cliente.Text = leer["idcliente"].ToString();
                    direccion.Text = leer["direccion"].ToString();


                    telefono.Text = leer["telefono1"].ToString();

                    

                }
                else
                {
                    MessageBox.Show(" no se encontro el registro");
                    cliente.Text = "";
                    direccion.Text = "";



                    telefono.Text = "";




                }
                
            }
        
     catch (Exception)
            {
                conexion.Close();
            }
                finally { conexion.Close();
            }
}
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            cliente.Text = "";
            direccion.Text = "";
        
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            altaclientes Form8 = new altaclientes();
            Form8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        public void leer ()
        { string cadena = "SELECT nombre  FROM clientes " ;

            SqlCommand consulta = new SqlCommand(cadena, conexion);
            conexion.Open();
            SqlDataReader leer = consulta.ExecuteReader();
            if (leer.Read() )
            {
                this.textBox1.AutoCompleteCustomSource.Add(leer[0].ToString());
              
            }
           
            conexion.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            articulos Form8 = new articulos();
            Form8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
                

                    if (cantidad.Text != "" && numerolibro.Text != "")
                    {
                        buscar();
                        try
                        {



                            string cadena = " SELECT  dbo.clientes.nombre, dbo.detallefactura.codigoarticul, dbo.detallefactura.numerolibro FROM dbo.clientes INNER JOIN dbo.prueba ON dbo.clientes.idcliente = dbo.prueba.clienteid INNER JOIN  dbo.detallefactura ON dbo.prueba.numerofact = dbo.detallefactura.numerofact WHERE (dbo.clientes.nombre LIKE '%" + textBox1.Text + "%') AND (dbo.detallefactura.codigoarticul ='" + comboBox1.SelectedValue + "') AND (dbo.detallefactura.numerolibro ='" + numerolibro.Text + "')";
                            SqlCommand consulta = new SqlCommand(cadena, conexion);
                            conexion.Open();
                            SqlDataReader leer = consulta.ExecuteReader();

                            if (leer.Read() == true)
                            {
                                string cont = leer["numerolibro"].ToString();
                                int r = Convert.ToInt32(cont);
                                int numero = Convert.ToInt32(numerolibro.Text);

                                if (cont.ToString() == numerolibro.Text)
                                {
                                    detallelibros f = new detallelibros();

                                    f.datoslibro.Text = numerolibro.Text;
                                    f.label1.Text = textBox1.Text;
                                    f.label2.Text = comboBox1.Text;
                                    f.label3.Text = comboBox1.SelectedValue.ToString();
                                    f.ShowDialog();

                                }
                            }

                            else
                            {

                                cargargrid();



                            }
                        }
                        catch (Exception)
                        {

                        }
                        finally
                        {
                            conexion.Close();
                        }

                    }




                    else
                    {
                        MessageBox.Show("Complete los datos solicitados \n 1-Cantidad de hojas: Numero de hojas que posee el Libro a rubricar. \n 2- Libros: selecione el nombre de Libro a Rubricar ");
                    }
                }
            
    
     
        public  void Aceptar_Click(object sender, EventArgs e)
        {

            SqlCommand altafactura = new SqlCommand("insert into prueba (fecha,clienteid,retira)values(@fecha,@clienteid,@retira)", conexion);
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.InsertCommand = altafactura;
            adaptador1.InsertCommand.Parameters.Add(new SqlParameter("@fecha", SqlDbType.VarChar));
            adaptador1.InsertCommand.Parameters.Add(new SqlParameter("@clienteid", SqlDbType.Int));
            adaptador1.InsertCommand.Parameters.Add(new SqlParameter("@retira", SqlDbType.Int));

            adaptador1.InsertCommand.Parameters["@fecha"].Value = date.Text;
            adaptador1.InsertCommand.Parameters["@clienteid"].Value = cliente.Text;
            adaptador1.InsertCommand.Parameters["@retira"].Value = entrega.Text;
            try
            {

                if (cliente.Text == "" && entrega.Text== "")
                {
                    MessageBox.Show("complete datos para proseguir con la operacion ");

                }
                else
                {
                    conexion.Open();

                    adaptador1.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("cliente cargado");
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

        public void actualizardatos()
        {
            datos1.Clear();
            adaptador2.Fill(datos1, "detallefactura");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliente.Text = "";
            direccion.Text = "";
            telefono.Text = "";
            textBox1.Text = "";
            cantidad.Enabled = false;
            cantidad.BackColor = Color.WhiteSmoke;
            entrega.Enabled = false;
            entrega.BackColor = Color.WhiteSmoke;
            numerolibro.Enabled = false;
            numerolibro.BackColor = Color.WhiteSmoke;
            textBox2.Enabled = false;
            textBox2.BackColor = Color.WhiteSmoke;
            comboBox1.Enabled = false;
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox2.Enabled = false;
            comboBox2.BackColor = Color.WhiteSmoke;
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && cliente.Text == "")
            {
                MessageBox.Show("Ingrese datos de Cliente para Continuar.");

            }
            else
            {


                if (data1.Rows.Count == 0)
                {
                    MessageBox.Show("Usted debe ingresar un item");
                }
                else
                {
                    int cont = 0;
                    SqlCommand altafactura = new SqlCommand("insert into prueba (fecha,clienteid)values(@fecha,@clienteid)", conexion);
                    SqlDataAdapter adaptador1 = new SqlDataAdapter();
                    adaptador1.InsertCommand = altafactura;
                    adaptador1.InsertCommand.Parameters.Add(new SqlParameter("@fecha", SqlDbType.VarChar));
                    adaptador1.InsertCommand.Parameters.Add(new SqlParameter("@clienteid", SqlDbType.Int));
                    adaptador1.InsertCommand.Parameters["@fecha"].Value = date.Text;
                    adaptador1.InsertCommand.Parameters["@clienteid"].Value = cliente.Text;

                    try
                    {

                        if (cliente.Text == "")
                        {
                            MessageBox.Show("complete datos");

                        }
                        else
                        {
                            conexion.Open();

                            adaptador1.InsertCommand.ExecuteNonQuery();

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

                    if (comboBox2.SelectedValue != (""))
                    {
                        SqlCommand altaproductos = new SqlCommand("insert into detallefactura (numerofact,entrega,cantidadhojas,numerolibro,codigoarticul,comentario)values (@numerofact, @entrega, @cantidadhojas, @numerolibro, @codigoarticul,@comentario)", conexion);
                        conexion.Open();
                        foreach (DataGridViewRow row in data1.Rows)
                        {
                            altaproductos.Parameters.Clear();



                            altaproductos.Parameters.AddWithValue("@numerofact", Convert.ToString(row.Cells["factura"].Value));
                            altaproductos.Parameters.AddWithValue("@codigoarticul", Convert.ToString(row.Cells["codigo"].Value));
                            altaproductos.Parameters.AddWithValue("@cantidadhojas", Convert.ToString(row.Cells["canthojas"].Value));
                            altaproductos.Parameters.AddWithValue("@numerolibro", Convert.ToString(row.Cells["numlibro"].Value));
                            altaproductos.Parameters.AddWithValue("@entrega", Convert.ToString(row.Cells["estado"].Value));
                            altaproductos.Parameters.AddWithValue("@comentario", Convert.ToString(row.Cells["comentario"].Value));
                            altaproductos.ExecuteNonQuery();
                            this.imprimir.Enabled = true;

                            cargar.Enabled = false;


                        }
                        MessageBox.Show("los datos de la factura numero :" + boton.Text + " fueron cargados exitosamente, pulse emitir comprobante impreso ");
                    }
                    else
                    {

                        MessageBox.Show("Debe completar todos los campos para poder continuar");

                    }

                    conexion.Close();




                }
            }

        }

        

        private void cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = this.data1.Rows.GetFirstRow(
               DataGridViewElementStates.Selected);
            if (rowToDelete > -1)
            {
                this.data1.Rows.RemoveAt(data1.CurrentRow.Index);
            }
            else {
                MessageBox.Show("No hay Items para eliminar!(Si desea elimar un Item posicionese sobre la flecha)");
            }

        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            int X = this.Width;
            int Y = this.Height;
            string texto = this.Text; 

            int[] x = { 120, 600, 500,400};
            int firstY = 350;
            int y = 365;
            Image facturaActual = facturaModelo;
            Graphics g = Graphics.FromImage(facturaActual);
            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Center;
            formatter.Alignment = StringAlignment.Center;
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            SolidBrush brush = new SolidBrush(Color.Black);
g.DrawString(textBox1.Text, font, brush, new Point(145,215),formatter);
g.DrawString(cliente.Text, font, brush, new Point(196, 184), formatter);
g.DrawString(direccion.Text, font, brush, new Point(77, 244), formatter);
g.DrawString(date.Text, font, brush, new Point(545,40), formatter);
g.DrawString(boton.Text, font, brush, new Point(599, 57), formatter);
g.DrawString(telefono.Text, font, brush, new Point(89, 275), formatter);


            for (int i = 0; i < data1.Rows.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0)
                        g.DrawString(data1.Rows[i].Cells[j].Value.ToString(), font, brush, new Point(x[j], firstY), formatter);
                    else
                        g.DrawString(data1.Rows[i].Cells[j].Value.ToString(), font, brush, new Point(x[j], y), formatter);
               
                
                }
              


                y += 26;

            }
 

            Form f2 = new Form();
            f2.Show();
            f2.Validate();
            PictureBox pbox = new PictureBox();
            pbox.Image = facturaActual;
            pbox.SizeMode = PictureBoxSizeMode.AutoSize;
            f2.Width = pbox.Width + 17;
            f2.Height = pbox.Height + 37;
            f2.Controls.Add(pbox); 






        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            imprimir.Enabled = false;
            
            boton.Text = "";
            cliente.Text = "";
            direccion.Text = "";
            telefono.Text = "";
            textBox1.Text = "";
            numerolibro.Text = "";
            cantidad.Text = "";
            comboBox2.Text = "";
          
           data1.Rows.Clear();    
          
            
            
           
            
            cargar.Enabled = true; 
conexion.Open();
            SqlCommand comando = new SqlCommand("select  max(numerofact) +1 as contador from prueba", conexion);

            SqlDataReader datos = comando.ExecuteReader();

            while (datos.Read())
            {

                boton.AppendText(datos["contador"].ToString());
            }


            conexion.Close();
        }

        private void numerolibro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (data1.Rows.Count < 7)
            {
                cantidad.Enabled = true;
                cantidad.BackColor = Color.White;
                entrega.Enabled = true;
                entrega.BackColor = Color.White;

                numerolibro.BackColor = Color.WhiteSmoke;
                textBox2.Enabled = true;
                textBox2.BackColor = Color.White;
                comboBox1.Enabled = true;
                comboBox1.BackColor = Color.White;
                comboBox2.Enabled = true;
                comboBox2.BackColor = Color.White;
                numerolibro.Text = "";
                cantidad.Text = "";
                textBox2.Text = "";
                entrega.Text = "";
                textBox2.Text = "Sin Comentarios";
            }
            else
            {
                MessageBox.Show("No se permite agregar mas items para este comprobante ");
            
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            try
            {
                string cadena = " SELECT        dbo.clientes.nombre, dbo.articulos.nombredearticulo, dbo.detallefactura.numerolibro FROM  dbo.estudios INNER JOIN  dbo.clientes ON dbo.estudios.idestudio = dbo.clientes.idestudi INNER JOIN  dbo.prueba ON dbo.clientes.idcliente = dbo.prueba.clienteid INNER JOIN  dbo.detallefactura ON dbo.prueba.numerofact = dbo.detallefactura.numerofact INNER JOIN  dbo.articulos ON dbo.detallefactura.codigoarticul = dbo.articulos.codigoarticulo  WHERE (dbo.clientes.nombre LIKE '%" + textBox1.Text + "%')";
              
                
                
                
                
                SqlCommand consulta = new SqlCommand(cadena, conexion);                                                                                                                                                                                                                                                                                                                                                                                 
                conexion.Open();
                SqlDataReader leer = consulta.ExecuteReader();
                if (leer.Read() == true)
                {

                    string cont = leer["numerolibro"].ToString();

                   
                        detallelibros f = new detallelibros();

                        
                        f.label1.Text = textBox1.Text;
                        f.label2.Text = comboBox1.Text;
                        f.label3.Text = comboBox1.SelectedValue.ToString();
                       
                        f.ShowDialog();
                 
}

                   
                }

            

            catch (Exception) { MessageBox.Show(""); }
            finally { conexion.Close(); }
        }


        public  void  cargargrid()
        {
            entrega.Text = boton.Text;
            DataGridView datas;

            data1.ColumnCount = 7;


            data1.Columns[0].Name = "Nombre Libro";
            data1.Rows.Add(comboBox1.Text, comboBox1.SelectedValue, cantidad.Text, numerolibro.Text, comboBox2.Text, boton.Text, textBox2.Text);//, );
            cantidad.Text = "";
            numerolibro.Text = "";
            entrega.Text = "";
            cantidad.Enabled = false;
            cantidad.BackColor = Color.WhiteSmoke;
            entrega.Enabled = false;
            entrega.BackColor = Color.WhiteSmoke;
            numerolibro.Enabled = false;
            numerolibro.BackColor = Color.WhiteSmoke;
            textBox2.Enabled = false;
            textBox2.BackColor = Color.WhiteSmoke; ;
            comboBox1.Enabled = false;
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox2.Enabled = false;
            comboBox2.BackColor = Color.WhiteSmoke;
        }


        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                if(comboBox1.Enabled == true ) {
                    numerolibro.Text = ""; 
                string cada = " SELECT  max  (dbo.detallefactura.numerolibro) +1 AS res  FROM dbo.clientes INNER JOIN dbo.prueba ON dbo.clientes.idcliente = dbo.prueba.clienteid INNER JOIN  dbo.detallefactura ON dbo.prueba.numerofact = dbo.detallefactura.numerofact WHERE(dbo.clientes.nombre LIKE '%" + textBox1.Text + "%') AND (dbo.detallefactura.codigoarticul ='" + comboBox1.SelectedValue + "')";
                SqlCommand con = new SqlCommand(cada, conexion);
                conexion.Open();
                SqlDataReader leera = con.ExecuteReader();

                if (leera.Read() == true)
                {
                   // string contA = leera["res"].ToString();

                    //contA = numerolibro.Text;
                    
                    

                    numerolibro.AppendText(leera["res"].ToString());

                    
 
                    if (numerolibro.Text == "")
                    {

                        numerolibro.Text = "1";

                    
                    }

                }
                    
            }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());



            }
            finally { conexion.Close(); }
        }

       public void button11_Click(object sender, EventArgs e)
        {
          
           DialogResult result = MessageBox.Show("Usted va a modificar la  correlatividad de  este libro desea continuar?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                numerolibro.Enabled = true;
                numerolibro.BackColor = Color.WhiteSmoke;
                
            }
            else if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Cancel)
            {
            }
           
                 
        }
       public void actualizar()
       {
         
          
       }

       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
       {
  comboBox1.Refresh();

       }

       private void comboBox1_Click(object sender, EventArgs e)
       {
           this.articulosTableAdapter2.Fill(this.gestionrubricasDataSet14.articulos);
           
       }

       public void acru()
       {
           string sql = "select nombre from clientes";


           using (da = new SqlDataAdapter(sql, conexion))
           {
               dt = new DataTable();
               da.Fill(dt);

               this.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
               this.textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
               foreach (DataRow dr in dt.Rows)
               {
                   this.textBox1.AutoCompleteCustomSource.Add(dr[0].ToString());
               }

           }
       
       
       
       }

       private void textBox2_Click(object sender, EventArgs e)
       {
           textBox2.Text = ""; 
       }

       private void data1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       }

       void buscar()
       {
         foreach (DataGridViewRow Row in data1.Rows)
           {
              
               string Valor = Convert.ToString(Row.Cells[1].Value);

               if (Valor == this.comboBox1.SelectedValue.ToString())
               {
                   MessageBox.Show("el item que intenta ingresar ya fue cargado");
                   this.data1.Rows.RemoveAt(data1.CurrentRow.Index);
               }
           }
       }




        }
    }
