using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using System.Collections;

namespace Reservaciones
{
    class DualDAO
    { 
    
        private DataTable table = null;
        private MySqlConnection cn = null;
        private MySqlDataReader reader = null;
        private MySqlCommand cmd = null;
        public string name ="";
        public string lastname="";
        public bool Insertar(string dual,string nombre, string apellido, string documento, string tipo, List<string> telefonos, List<string> tipos)
        {
            try
            {
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "INSERT INTO "+ dual +" (nombre, apellido, documento_identidad, documento_tipo) values ('" + nombre + "','" + apellido + "','" + documento + "','" + tipo + "');";
                foreach (var item in telefonos.Zip(tipos, (a, b) => new { A = a, B = b }))
                {
                    cmd.CommandText += "INSERT INTO telefono_"+ dual +" (id_"+ dual +", telefono, tipo) values(last_insert_id(),'" + item.A + "','" + item.B + "');";
                }
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

        //metodo para consultar
        public DataTable Consultar(string dual)
        {
            try
            {
                Columnas();
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "select t1.id_"+dual+", t1.nombre, t1.apellido, t1.documento_identidad, t1.documento_tipo, t2.telefono, t2.tipo from "+dual+" as t1 inner join telefono_"+ dual +" as t2 on t1.id_"+dual+" = t2.id_"+dual+" ;";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    String nombre = reader.GetString(1);
                    String apellido = reader.GetString(2);
                    String documento_identidad = reader.GetString(3);
                    String documento_tipo = reader.GetString(4);
                    String telefono = reader.GetString(5);
                    String telefono_tipo = reader.GetString(6);
                    table.Rows.Add(id, nombre, apellido, documento_identidad, documento_tipo, telefono, telefono_tipo);
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

        public bool Eliminar(string dual,int id)
        {
            try
            {
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "DELETE FROM " + dual + " where id_"+ dual +"='"+ id +"';";
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
 
        public bool Actualizar(string dual,int id, string nombre, string apellido, string documento, string tipo, string telefono, string telefono_tipo)
        {
            try
            {
                cn = Conexion.Conectar();
                cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "update "+dual+" set nombre='" +nombre + "',apellido='" + apellido + "',documento_identidad='" + documento + "',documento_tipo='" + tipo + "' where id_"+dual+"='" + id + "';";
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
            table.Columns.Add("Id");
            table.Columns.Add("Nombre");
            table.Columns.Add("Apellido");
            table.Columns.Add("Documento");
            table.Columns.Add("Tipo");
            table.Columns.Add("telefono");
            table.Columns.Add("telefono_tipo");
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
            cn = Conexion.Conectar();
            var cmd = cn.CreateCommand();
            cn.Open();
            cmd.CommandText = "select nombre,apellido from visitante where documento_identidad = '" + documento + "';";
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string nombre = reader.GetString(0);
                string apellido = reader.GetString(1);
                if (nombre != "")
                {
                    this.name = nombre;
                    this.lastname = apellido;
                }
            }
            cn.Close();
        }
    }
}
