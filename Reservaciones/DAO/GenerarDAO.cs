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
        public List<string> namepro = new List<string>();
        public bool Insertar(int id_profesional ,int id_visitante ,int id_dias ,string fecha, string motivo,int estado)
        {
            try
            {
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "INSERT INTO generar (id_profesional,id_visitante,id_dias,fecha,motivo,id_estado,created_at) values('" + id_profesional + "','" + id_visitante + "','" + id_dias + "','" + fecha + "','" + motivo + "','" + estado + "',NOW())";
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

        public DataTable Consultar()
        {
            try
            {
                Columnas();
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "generar_cita";
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id_generar = reader.GetInt32(0);
                    string profesional = reader.GetString(1);
                    string visitante = reader.GetString(2);
                    string dia = reader.GetString(3);
                    string fecha = reader.GetString(4);
                    string motivo = reader.GetString(5);
                    string estado = reader.GetString(6);
                    DateTime created_at = reader.GetDateTime(7);
                    table.Rows.Add(id_generar,profesional, visitante,dia,fecha, motivo,estado, created_at);
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

        public bool Eliminar(int id)
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

        /*id_profesional ,id_visitante ,id_dias ,fecha,motivo,estado,created_at*/
        public bool Actualizar(int id,int id_dias,string fecha,string motivo)
        {
            try
            {
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "UPDATE generar set  id_dias = '" + id_dias + "', fecha = '" + fecha + "', motivo = '" + motivo + "' where id_generar = '" + id + "';";
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
        
        private void Columnas()
        {
            table = new DataTable();
            table.Columns.Add("Id_generar");
            table.Columns.Add("Profesional");
            table.Columns.Add("Visitante");
            table.Columns.Add("Dia");
            table.Columns.Add("Fecha");
            table.Columns.Add("Motivo");
            table.Columns.Add("Estado");
            table.Columns.Add("Creado En");
        }
        private void Cerrar()
        {
            if (cn != null && cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }


        public bool SetGenerar(int estado,int id)
        {
            try
            {
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "UPDATE generar set id_estado = '"+estado+"' where id_visitante='"+ id+"'";
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
    }
}
