using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Reservaciones
{
    class Conexion
    {
        public static MySqlConnection Conectar()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "agenda";
            MySqlConnection cn = new MySqlConnection(builder.ToString());
            return cn;

        }
    }

}
