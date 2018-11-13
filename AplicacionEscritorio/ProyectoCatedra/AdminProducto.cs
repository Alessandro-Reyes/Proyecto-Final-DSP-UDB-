using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra
{
    public partial class AdminProducto : Form
    {
        
        public AdminProducto()
        {
            InitializeComponent();
        }
        //Instancia para entrar a la conexion de base de datos.
        Conexion C = new Conexion();
        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void AdminProducto_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Sentencia SQL
            string agregar = "INSERT INTO Productos VALUES ('" + txtTipo.Text + "'," + mtbPrecio.Text + ", '" + txtProveedor.Text + "', "+ numExitencia.Value + ")";
            //Verificamos el valor de la funcion booleana sea true
            if (C.Agregar(agregar))
            {
                MessageBox.Show("Datos Agregados");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al Ingresar");
            }
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //Metodo para mostrar los campos de una tabla en el datagridview
        public void MostrarDatos()
        {
            C.consulta("SELECT * FROM Productos", "Productos");
            dtgProductosR.DataSource = C.ds.Tables["Productos"];
            dtgRegistroE.DataSource = C.ds.Tables["Productos"];
            dtgProductosRM.DataSource = C.ds.Tables["Productos"];
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Sentencia SQL
            string modificar = "TipoProducto = '"+txtTipoM.Text+"', Precio = "+mtbPreM.Text+", Proveedor = '"+txtProM.Text+"', Existencias = "+numExiM.Value+"";
            //Validamos que la funcion booleana devuelva true
            if (C.Modificar("Productos", modificar, "Id_Productos = "+txtIDM.Text))
            {
                MessageBox.Show("Producto Actualizado");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }
        //Metodo para mostrar en los campos de texto los datos en los campos seleccionados
        private void dtgRegistroE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dtgRegistroE.Rows[e.RowIndex];
            txtIDE.Text = dgv.Cells[0].Value.ToString();
            txtTipoE.Text = dgv.Cells[1].Value.ToString();
            mtbPreE.Text = dgv.Cells[2].Value.ToString();
            txtProE.Text = dgv.Cells[3].Value.ToString();
            numExiE.Text = dgv.Cells[4].Value.ToString();
            txtIDM.Text = dgv.Cells[0].Value.ToString();
            txtTipoM.Text = dgv.Cells[1].Value.ToString();
            mtbPreM.Text = dgv.Cells[2].Value.ToString();
            txtProM.Text = dgv.Cells[3].Value.ToString();
            numExiM.Text = dgv.Cells[4].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Validamos que la funcion booleana devuelva true
            if (C.Eliminar("Productos","Id_Productos = " + txtIDE.Text))
            {
                MessageBox.Show("Registro Eliminado");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Buscamos los datos del campo TipoProducto y mostrarlos por el metodo
            dtgProductosR.DataSource = C.BuscarData("SELECT * FROM Productos WHERE TipoProducto = '" + txtTipo.Text+"'");
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            //Llamamos al metodo de Mostrar
            MostrarDatos();
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            //Buscamos los datos del campo TipoProducto y mostrarlos por el metodo
            dtgProductosRM.DataSource = C.BuscarData("SELECT * FROM Productos WHERE TipoProducto = '" + txtTipo.Text + "'");
        }

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            //Buscamos los datos del campo TipoProducto y mostrarlos por el metodo
            dtgRegistroE.DataSource = C.BuscarData("SELECT * FROM Productos WHERE TipoProducto = '" + txtTipo.Text + "'");
        }

        private void btnReestablecerE_Click(object sender, EventArgs e)
        {
            //Llamamos al metodo de Mostrar
            MostrarDatos();
        }

        private void btnResM_Click(object sender, EventArgs e)
        {
            //Llamamos al metodo de Mostrar
            MostrarDatos();
        }

        private void btnMe_Click(object sender, EventArgs e)
        {
            //Formamos una instancia para poder saltarse de un formulario a otro
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            //Formamos una instancia para poder saltarse de un formulario a otro
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Formamos una instancia para poder saltarse de un formulario a otro
            menu m = new menu();
            m.Show();
            this.Hide();
        }
    }
}
