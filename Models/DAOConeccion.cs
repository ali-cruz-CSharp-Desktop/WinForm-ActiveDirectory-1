using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginActiveDirectory02.Models
{
    public class DAOConeccion
    {
        private string stringConn = ConfigurationManager.ConnectionStrings["acceso_DBActiveDirectory"].ConnectionString;

        // Retorna un DataTable
        public Response Select(string query)
        {
            Response response = new Response();
            response.dt = new System.Data.DataTable();

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(stringConn))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConn);
                    sqlDataAdapter.Fill(response.dt);
                    return response;
                }
            } catch(Exception ex)
            {
                response.Msg = "Error" + ex.Message;
                return response;
            }
        }



    }
}
