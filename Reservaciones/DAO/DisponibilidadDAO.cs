using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reservaciones.DAO
{
    class DisponibilidadDAO
    {
        private DataTable table = null;
        private MySqlCommand cmd = null;
        private MySqlConnection cn = null;
        private MySqlDataReader reader = null;
        private void Cerrar()
        {
            if (cn != null && cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        private void Columnas()
        {
            table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Profesional");
            table.Columns.Add("Id_");
            table.Columns.Add("Dia");
        }
        public DataTable Consultar()
        {
            try
            {
                Columnas();
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "disponibilidad";
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id_profesional = reader.GetInt32(0);
                    string profesional = reader.GetString(1);
                    int id_dias = reader.GetInt32(2);
                    string dia = reader.GetString(3);
                    table.Rows.Add(id_profesional,profesional,id_dias,dia);
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
        public bool Eliminar(int id_profesional,int id)
        {
            try
            {
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "DELETE FROM disponibilidad where id_profesional= '" + id_profesional + "' and id_dias= '" + id + "'";
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
        public bool Insertar(int id_profesional,int id_dias)
        {
            try
            {
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "Insert disponibilidad (id_profesional,id_dias) values('"+id_profesional+"','"+id_dias+"')";
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
        public bool Actualizar(int id_profesional, int id_dias,int id1,int id2)
        {
            try
            {
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "UPDATE disponibilidad set id_profesional = '"+id_profesional +"', id_dias = '"+id_dias+ "' where id_profesional= '" + id1 + "' and id_dias= '" + id2 + "'";
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
    }
}
