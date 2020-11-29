using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Reflection;
using Pabo.Calendar;
namespace Reservaciones.DAO
{
    class GetDAO
    {
        private MySqlConnection cn = null;
        private DataTable TableDays = null;
        private DataTable TablePro = null;
        private DataTable TableState = null;

        public int id_visitante;
        public string name = "";
        public string lastname = "";


        public List<string> dias = new List<string>();
        public List<string> estado = new List<string>();
        public List<string> profesional = new List<string>();

        public List<int> num = new List<int>();
        public DataTable GetProfesional()
        {
            try
            {
                ColumnasP();
                cn = Conexion.Conectar();
                var cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "select id_profesional,concat(nombre,' ',apellido) from profesional";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombrec = reader.GetString(1);
                    if(nombrec != "")
                    {
                        this.profesional.Add(nombrec);
                    }
                    TablePro.Rows.Add(id, nombrec);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                cn.Close();           
            }
            return TablePro;
        }
        public DataTable GetDias()
        {
            try
            {
                ColumnasD();
                cn = Conexion.Conectar();
                var cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "select * from dias ";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string dias = reader.GetString(1);
                    if(dias != "")
                    {
                        this.dias.Add(dias);
                    }
                    TableDays.Rows.Add(id, dias);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                cn.Close();
            }
            return TableDays;
        }

        public DataTable GetEstado()
        {
            try
            {
                ColumnasE();
                cn = Conexion.Conectar();
                var cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "select * from estado ";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string estado = reader.GetString(1);
                    if (estado != "")
                    {
                        this.estado.Add(estado);
                    }
                    TableState.Rows.Add(id, estado);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                cn.Close();
            }
            return TableState;
        }

        public void GetFiltro(string documento)
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                cn.Close();
            }
        }
	    public void GetDisponibilidadProfesional(int id ) 
        {
            try
            {
                cn = Conexion.Conectar();
                var cmd = cn.CreateCommand();
                cn.Open();
                cmd.CommandText = "SELECT * FROM disponibilidad WHERE id_profesional ='" + id + "' ";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int item = reader.GetInt32(1);
                    if (item != 0)
                    {
                        num.Add(item);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                cn.Close();
            }                       
        }
        public void ColumnasP()
        {
            TablePro = new DataTable();
            TablePro.Columns.Add("Id");
            TablePro.Columns.Add("Nombre");
        }

        public void ColumnasD()
        {
            TableDays = new DataTable();
            TableDays.Columns.Add("Id_dias");
            TableDays.Columns.Add("Dias");
        }
        public void ColumnasE()
        {
            TableState = new DataTable();
            TableState.Columns.Add("Id_estado");
            TableState.Columns.Add("Estado");
        }


    }
}
