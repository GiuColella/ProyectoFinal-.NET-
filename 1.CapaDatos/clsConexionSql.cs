using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _1.CapaDatos
{
    public abstract class clsConexionSql
    {
        private readonly string connectionString;

        public clsConexionSql()
        {
            connectionString = "Server=DESKTOP-6APJ911\\colel; DataBase=dbCompany; integrated security = true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
