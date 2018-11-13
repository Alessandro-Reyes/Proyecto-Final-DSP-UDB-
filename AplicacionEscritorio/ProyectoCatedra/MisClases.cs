using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//Integrantes:
//Cristian Alexander Bernabel Avelar    BA171971
//Daniel Alejandro Campos Mejía         CM171972
//Javier Ulises Coreas Alas             CA171975
//Jose Alejandro Cruz Ponce             CP171985
//Alessandro Adalberto De la o Reyes    DR171986
namespace ProyectoCatedra
{
    class Conexion
    {
        //Sentencia de Conexion con SQL Server
       SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-KAQFAUM1\\SQLEXPRESS;Initial Catalog=Deportes;Integrated Security=True");
        //Declaracion de los comandos a utilizar
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand cmd;
        private DataTable dt;
        //Validamos la conexion con SQL Server
       public void conectar()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión Exitosa");
            }
            catch
            {
                MessageBox.Show("Error al conectar.");
            }
            finally
            {
                conexion.Close();
            }
        }
        //Creamos este metodo para hacer la consulta para el metodo MostrarDatos
        public void consulta(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, conexion);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        //Metodo para agregar Datos a la BDD
        public bool Agregar(string sql)
        {
            conexion.Open();
            cmd = new SqlCommand(sql, conexion);
            int i = cmd.ExecuteNonQuery();
            conexion.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Metodo para Eliminar datos de la BDD
        public bool Eliminar(string tabla, string condicion)
        {
            conexion.Open();
            string eliminar = "DELETE FROM " + tabla + " WHERE " + condicion;
            cmd = new SqlCommand(eliminar, conexion);
            int i = cmd.ExecuteNonQuery();
            conexion.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Metodo para Modificar datos de la BDD
        public bool Modificar(string tabla, string campo, string condicion)
        {
            conexion.Open();
            string modificar = "UPDATE " + tabla + " SET " + campo + " WHERE " + condicion;
            cmd = new SqlCommand(modificar, conexion);
            int i = cmd.ExecuteNonQuery();
            conexion.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Metodo para Buscar datos de la BDD
        public DataTable BuscarData(string consulta)
        {
            conexion.Open();
            cmd = new SqlCommand(consulta, conexion);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            return dt;
        }
    }
    }

