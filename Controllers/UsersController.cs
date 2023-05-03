using LoginActiveDirectory02.Models;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginActiveDirectory02.Controllers
{
    public class UsersController
    {
        

        // Obtengo usuario(s)
        bool status = false;
        public bool GetNTuser(string NTuser)
        {
            DAOConeccion data = new DAOConeccion();
            Response response = new Response();

            string query = "exec SP_ConsultaAll @LastName = " + NTuser + "";
            response = data.Select(query);

            if (response.dt.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string GetCurrentDomainPath()
        {
            DirectoryEntry directoryEntry = new DirectoryEntry("LDAP://RootDSE");
            return "LDAP://" + directoryEntry.Properties["defaultNamingContext"][0].ToString();
        }






    }
}
