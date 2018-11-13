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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            //Formamos una instancia para poder saltarse de un formulario a otro
            AdminProducto admin = new AdminProducto();
            admin.Show();
            this.Hide();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            //Formamos una instancia para poder saltarse de un formulario a otro
            empresa emp = new empresa();
            emp.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Formamos una instancia para poder saltarse de un formulario a otro
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
