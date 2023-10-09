using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giangiordano.Datos
{
    public class Base
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["NetGenerica"].ConnectionString;
        public SqlConnection con = new SqlConnection(ConnectionString);
    }
}
