using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Deportes.Models
{
    public class conexion
    {
        //Declaramos loss objetos que utilizaremos en toda nuestra clase
        string coneccionString;
        SqlConnection conexionSQL;
        public DataSet DataSetPrincipal;
        SqlDataAdapter DataAdapterEspecífico;
        public conexion()
        {
            //Configuramos la conexion y obtenemos la cadena de conexion desde el Web.config
            coneccionString =
           ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conexionSQL = new SqlConnection(coneccionString);
            DataSetPrincipal = new DataSet();
            conexionSQL.Open();
            /*Inicializamos el adaptador específico que se utilizará en la gestión de
            registros de producto*/
            DataAdapterEspecífico = new SqlDataAdapter();
            DataAdapterEspecífico.SelectCommand = new SqlCommand("SELECT * FROM Productos",
           conexionSQL);
        }
        public void conectar()
        {
            conexionSQL.Open();
        }
        public void desconectar()
        {
            conexionSQL.Close();
        }
        public void copiarBaseDatos()
        {
            //Cargamos las tablas al dataset a través del método cargarTabla
            cargarTabla("Productos", "id_Productos");
            cargarTabla("Transacciones", "id_Trans");
            cargarTabla("TipoTransaccion", "id_TipoTrans");
            cargarTabla("Ventas", "id_Ventas");
            cargarTabla("DevolucionProv", "id_DevolucionProv");
            cargarTabla("CompraProv", "id_Comprov");
            /*Establecemos la relacion de llaves foraneas entre las tablas,
            verifique la sintaxis de cada una de ellas*/
            ForeignKeyConstraint fk1_cat_pro;
            fk1_cat_pro = new
           ForeignKeyConstraint(DataSetPrincipal.Tables["CompraProv"].Columns["id_Comprov"],
           DataSetPrincipal.Tables["Productos"].Columns["id_Comprov"]);
            DataSetPrincipal.Tables["Productos"].Constraints.Add(fk1_cat_pro);
            /*ForeignKeyConstraint fk1_sup_pro;
           fk1_sup_pro = new
           ForeignKeyConstraint(DataSetPrincipal.Tables["Suppliers"].Columns["SupplierID"],
           DataSetPrincipal.Tables["Products"].Columns["SupplierID"]);
            DataSetPrincipal.Tables["Products"].Constraints.Add(fk1_sup_pro);*/
        }
        public void cargarTabla(String nombreTabla, String primaryKey)
        {
            nombreTabla = nombreTabla.Trim();
            //Si la tabla no existe en el contexto actual, procederemos a adicionarla
            if (DataSetPrincipal.Tables.IndexOf(nombreTabla) == -1)
            {
                /*Configuramos un control dataAdapter para que funcione como puente entre
                dataset y base de datos */
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand();
                dataAdapter.SelectCommand.CommandText = "SELECT * FROM " + nombreTabla;
                dataAdapter.SelectCommand.Connection = conexionSQL;
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                //Populamos el dataset con la tabla que acabamos de obtener
                dataAdapter.FillSchema(DataSetPrincipal, SchemaType.Source, nombreTabla);
                dataAdapter.Fill(DataSetPrincipal, nombreTabla);
                dataAdapter.SelectCommand.Dispose();
                dataAdapter.Dispose();
                //Obtenemos la tabla actual y establecemos el campo que se utilizará como llave primaria
                DataTable tablaActual;
                tablaActual = DataSetPrincipal.Tables[nombreTabla];
                DataColumn[] columnasPrincipales = new DataColumn[1];
                columnasPrincipales[0] = tablaActual.Columns[primaryKey];
                tablaActual.PrimaryKey = columnasPrincipales;
            }
        }
        public int insertarProducto(DataSet ds, string TipoProducto, string Precio,
       string Proveedor, string Existencias)
        {
            DataTable table = ds.Tables["Productos"];
            DataRow row = table.NewRow();
            row["TipoProducto"] = TipoProducto;
            row["Precio"] = Precio;
            row["Proveedor"] = Proveedor;
            row["Existencias"] = Existencias;
            table.Rows.Add(row);
            if (ds.HasChanges())
            {
                SqlCommandBuilder comando = new SqlCommandBuilder(DataAdapterEspecífico);
                int filasAfectadas = DataAdapterEspecífico.Update(ds, "Productos");
                ds.AcceptChanges();
                return filasAfectadas;
            }
            return 0;
        }
        public Product mostrardatos(int productID, DataSet ds)
        {
            DataView vistaFiltro = new DataView(ds.Tables["Productos"]);
            vistaFiltro.RowFilter = "id_Productos = " + id_Productos;
            Product itemproduct = new Product();
            foreach (DataRowView dr in vistaFiltro)
            {
                itemproduct.ProductID = dr["ProductID"].ToString();
                itemproduct.ProductName = dr["ProductName"].ToString();
                itemproduct.SupplierID = dr["SupplierID"].ToString();
                itemproduct.CategoryID = dr["CategoryID"].ToString();
                itemproduct.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                itemproduct.UnitPrice = dr["UnitPrice"].ToString();
                itemproduct.UnitsInStock = dr["UnitsInStock"].ToString();
                itemproduct.UnitsOnOrder = dr["UnitsOnOrder"].ToString();
            }
            return itemproduct;
        }



    }
}