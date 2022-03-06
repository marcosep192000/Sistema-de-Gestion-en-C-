using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient; 
namespace EmailComponent
{
    public class GetEmailIdsFromDB
{ 
    public string connectionString
    {
        get; set;
    }
    public string storedProcName {
        get; set;
    }
    public DataSet GetMailIds() 
    { 
        DataSet ds = new DataSet();
      SqlConnection conn = new SqlConnection("Data Source=MARCOS-PC;Initial Catalog=gestionrubricas;Integrated Security=True");
 
        { 
            SqlCommand command = new SqlCommand(storedProcName,conn);
            command.CommandType = CommandType.StoredProcedure; 
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(ds);        } 
        return ds;
    }
    } 
}