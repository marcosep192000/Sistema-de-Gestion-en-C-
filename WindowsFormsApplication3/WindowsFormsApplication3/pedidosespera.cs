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
using System.Net.Mail;
using System.Net; 
namespace WindowsFormsApplication3
{
    public partial class pedidosespera : Form
    {
        public pedidosespera()
        {
            InitializeComponent();
        }
        SqlDataAdapter adaptador;
        SqlConnection conexion;
        DataSet datos;
        String facturanumero;
        string abono;
        public void pedidosespera_Load(object sender, EventArgs e)
        {
         
      //     conexion = new SqlConnection("Data Source=VENTAS-3;Initial Catalog=gestionrubricas;Integrated Security=True");
          conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");

           string select = "SELECT   dbo.clientes.nombre,dbo.clientes.mail, dbo.estudios.nombre AS estudios, dbo.prueba.numerofact AS comprobante, dbo.prueba.fecha, dbo.articulos.nombredearticulo AS Nombre_articulo, dbo.detallefactura.numerolibro, dbo.detallefactura.entrega, dbo.detallefactura.comentario, dbo.detallefactura.detallefactura FROM dbo.estudios INNER JOIN dbo.clientes ON dbo.estudios.idestudio = dbo.clientes.idestudi INNER JOIN dbo.prueba ON dbo.clientes.idcliente = dbo.prueba.clienteid INNER JOIN dbo.detallefactura ON dbo.prueba.numerofact = dbo.detallefactura.numerofact INNER JOIN dbo.articulos ON dbo.detallefactura.codigoarticul = dbo.articulos.codigoarticulo where entrega != 'TERMINADO' ";

            SqlCommand consulta = new SqlCommand(select, conexion);
            adaptador = new SqlDataAdapter(consulta);
            datos = new DataSet();

            DataTable dt = new DataTable();


            adaptador.Fill(dt);
            dataGridView2.DataSource = dt;

            conexion.Close();
ChangeStyle();
//dataGridView2.Columns[1].Visible = false;
//dataGridView2.Columns[8].Visible = false;
//dataGridView2.Columns[9].Visible = false;
        
        }
        public void borrar()
        {

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        public void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        public void ChangeStyle()
        {
            foreach (DataGridViewRow row in this.dataGridView2.Rows)
            {

               abono = Convert.ToString(row.Cells["entrega"].Value);

                if (abono == ("RECEPCION"))
                {
                    row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }

                else if (abono == "EN TRAMITE")
                {
                    row.DefaultCellStyle.BackColor = Color.DimGray;
                }
                else if (abono == "PARA RETIRAR")
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen;
                }
               else  if (abono == "TERMINADO")
                {
      
                 
                }
           
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeStyle();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            comboBox2.SelectedItem = Convert.ToString(this.dataGridView2.CurrentRow.Cells[7].Value);
            
        }
        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        public void Pasarcampo(DataGridView DataGridView2, TextBox textBox2, string entrega)
        {
            // especifico que campo de la fila que este seleccionada vamos a pasar al textbox
           textBox1.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells[0].Value);
            textBox2.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells[1].Value);
          textBox3.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells[9].Value);
        
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.detallefacturaTableAdapter.Fill(this.gestionrubricasDataSet12.detallefactura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
 if (comboBox2.Text != "" )
                    {

            SqlCommand modificacion = new SqlCommand("update detallefactura set entrega=@entrega , comentario=@comentario  where detallefactura=@nombreanterior  "  , conexion);

            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreanterior", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@entrega", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@comentario", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters["@entrega"].Value = comboBox2.SelectedItem;
                adaptador.UpdateCommand.Parameters["@nombreanterior"].Value = textBox3.Text;
                    adaptador.UpdateCommand.Parameters["@comentario"].Value = textBox4.Text;

            conexion.Open();
          
                adaptador.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Datos actualizados con exito");
                ChangeStyle(); 

                    actualizardatos();
                    conexion.Close();
                   


                        if (comboBox2.Text == "PARA RETIRAR" && textBox5.Text != "")
                        {
                            MailMessage correo = new MailMessage();
                            correo.From = new MailAddress(textBox5.Text);
                            correo.To.Add(textBox5.Text);
                            correo.Subject = "Info libros Rubricados";
                            correo.Body = "Sres:" + textBox1.Text + "                  \n      El pedido de libro ya se encuentra a su disposicion en nuestra sucursal hubicada en la calle Alvear 139 de Lunes a Viernes  de 9:00 hs a 19:00hs.\n  Saludos.\n El Auditor S.A.";
                            correo.IsBodyHtml = false;
                            correo.Priority = MailPriority.Normal;



                            SmtpClient smpt = new SmtpClient();
                            smpt.Credentials = new NetworkCredential("marcos.elgrecomayorista@gmail.com", "MARIANANANO");

                            smpt.Host = "smtp.gmail.com";
                            smpt.Port = 587;
                            smpt.EnableSsl = true;

                            try
                            {
                                smpt.Send(correo);
                                MessageBox.Show("correo enviado");
                                actualizardatos();
                            }
                            catch
                            {
                                MessageBox.Show("no se pudo enviar el correo, verifique destinatario");
                            }
                            correo.Dispose();

                        }

                    }
                    else {

                        MessageBox.Show("Cargue el estado del pedido");
                    }
                }
        

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells[0].Value);
            textBox5.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells[1].Value);
            textBox3.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells[9].Value);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void actualizardatos()
        {

            string select = "SELECT   dbo.clientes.nombre,dbo.clientes.mail, dbo.estudios.nombre AS estudios, dbo.prueba.numerofact AS comprobante, dbo.prueba.fecha, dbo.articulos.nombredearticulo AS Nombre_articulo, dbo.detallefactura.numerolibro, dbo.detallefactura.entrega, dbo.detallefactura.comentario, dbo.detallefactura.detallefactura FROM dbo.estudios INNER JOIN dbo.clientes ON dbo.estudios.idestudio = dbo.clientes.idestudi INNER JOIN dbo.prueba ON dbo.clientes.idcliente = dbo.prueba.clienteid INNER JOIN dbo.detallefactura ON dbo.prueba.numerofact = dbo.detallefactura.numerofact INNER JOIN dbo.articulos ON dbo.detallefactura.codigoarticul = dbo.articulos.codigoarticulo where entrega != 'TERMINADO' ";

            SqlCommand consulta = new SqlCommand(select, conexion);
            adaptador = new SqlDataAdapter(consulta);
            datos = new DataSet();

            DataTable dt = new DataTable();


            adaptador.Fill(dt);
            dataGridView2.DataSource = dt;

            


                conexion.Close();

                ChangeStyle();

            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


}
    }

        
    

