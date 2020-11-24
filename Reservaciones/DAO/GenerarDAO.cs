using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Reservaciones.DAO
{
    class GenerarDAO
    {
        private DataTable table = null;
        private MySqlConnection cn = null;
        private MySqlDataReader reader = null;
        private MySqlCommand cmd = null;
        public int id_visitante { get; set; }
        public string name = "";
        public string lastname = "";
        // id_profesional,id_visitante,id_dias,fecha,motivo,estado,created_at/
        public bool Insertar(int id_profesional ,int id_dias , string motivo,string estado)
        {
            try
            {
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "INSERT INTO generar (id_profesional,id_visitante,id_dias,fecha,motivo,estado,created_at) values ('" + id_profesional + "','" + id_visitante + "','" + id_dias + "','" + motivo + "','" + estado + "',NOW())";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                Cerrar();
            }
            return false;
        }

        //id_profesional,id_visitante,id_dias,fecha,motivo,estado,created_at
        public DataTable Consultar()
        {
            try
            {
                Columnas();
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "select id_profesional,id_visitante,id_dias,fecha,motivo,estado,created_at from generar";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id_profesional = reader.GetInt32(0);
                    int id_visitante = reader.GetInt32(1);
                    int id_dias = reader.GetInt32(2);
                    string fecha = reader.GetString(3);
                    string motivo = reader.GetString(4);
                    string estado = reader.GetString(5);
                    DateTime created_at = reader.GetDateTime(6);
                    table.Rows.Add(id_profesional, id_visitante, id_dias ,fecha, motivo, estado, created_at);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                Cerrar();
            }
            return table;
        }

        public bool Eliminar( int id)
        {
            try
            {
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "DELETE FROM generar where id_generar = '" + id + "';";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ocurrio un Error en el proceso");
            }
            finally
            {
                Cerrar();
            }
            return false;
        }

        /*id_profesional,id_visitante,id_dias,fecha,motivo,estado,created_at*/
        public bool Actualizar(int id, string nombre, string apellido, string documento, string tipo, List<string> telefonos, List<string> tipos)
        {
            try
            {
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText ="";
                cmd.CommandText +="";
                foreach (var item in telefonos.Zip(tipos, (a, b) => new { A = a, B = b }))
                {
                    cmd.CommandText += "";
                }
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ocurrion un Error en el proceso"); ;
            }
            finally
            {
                Cerrar();
            }
            return false;
        }
        /*id_profesional,id_visitante,id_dias,fecha,motivo,estado,created_at*/
        private void Columnas()
        {
            table = new DataTable();
            table.Columns.Add("Id_profesional");
            table.Columns.Add("Id_visitante");
            table.Columns.Add("Id_dias");
            table.Columns.Add("Fecha");
            table.Columns.Add("Motivo");
            table.Columns.Add("Estado");
            table.Columns.Add("Created_at");
        }
        private void Cerrar()
        {
            if (cn != null && cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public void Filtrar(string documento)
        {
            try
            {
                cn = Conexion.Conectar();
                var cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "select id_visitante,nombre,apellido from visitante where documento_identidad = '" + documento + "';";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    if (nombre != "")
                    {
                        this.id_visitante = id;
                        this.name = nombre;
                        this.lastname = apellido;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }
    }
}
