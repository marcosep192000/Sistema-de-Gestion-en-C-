using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
   
        public class Miconexion
        {
            public static SqlConnection ObtnerConexion()
            {

                SqlConnection conexion = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
                conexion.Open();
                return conexion;

            }

        }


    }

