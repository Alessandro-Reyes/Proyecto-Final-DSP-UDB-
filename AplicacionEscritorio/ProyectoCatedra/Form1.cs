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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const string User = "Admin";
        const string Pass = "123456";

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassw.Text)  )
            {
                MessageBox.Show("Por favor rellene los campos debidos para continuar");
            }
            else if (txtPassw.Text == Pass && txtUser.Text == User)
            {
                MessageBox.Show("Bienvenido al Sistema " + User);
                menu frm = new menu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al loguear");
            }
        }
    }
}
