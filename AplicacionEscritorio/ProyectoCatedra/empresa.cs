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
    public partial class empresa : Form
    {
        public empresa()
        {
            InitializeComponent();
        }
        //Instancia para entrar a la conexion de base de datos.
        Conexion c = new Conexion();
        //Metodo para mostrar los campos de una tabla en el datagridview
        public void MostrarDatos()
        {
            c.consulta("SELECT * FROM CompraProv", "CompraProv");
            dtgCompras.DataSource = c.ds.Tables["CompraProv"];
            c.consulta("SELECT * FROM DevolucionProv", "DevolucionProv");
            dtgDevo.DataSource = c.ds.Tables["DevolucionProv"];
          
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {//Llamamos al metodo de Mostrar
            MostrarDatos();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            //Invocamos al metodo BuscarData para que reduzca los campos del datagridview por la busqueda

            dtgCompras.DataSource = c.BuscarData("SELECT * FROM CompraProv WHERE Id_CompraProv = " + txtCompra.Text);
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {//Llamamos al metodo de Mostrar
            MostrarDatos();
        }

        private void btnBuscarD_Click(object sender, EventArgs e)
        {
            //Invocamos al metodo BuscarData para que reduzca los campos del datagridview por la busqueda
            dtgDevo.DataSource = c.BuscarData("SELECT * FROM DevolucionProv WHERE Id_Productos = " + txtDevo.Text);
        }

        private void btnV_Click(object sender, EventArgs e)
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
    }
}
