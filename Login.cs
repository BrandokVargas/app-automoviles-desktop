using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_Automóviles
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Brandok" && txtPassword.Text == "brandok10")
            {
                this.Hide();
                Cargando c = new Cargando();
                c.ShowDialog();

                using (Inicio mostrarUser = new Inicio(txtUser.Text))
                    mostrarUser.ShowDialog();
               


            }
            else
            {
                MessageBox.Show("Ha ocurrido un error,\nsolo el grupo 11 tiene acceso \na este sistema.");
            }

            txtUser.Text = txtPassword.Text = "";

            



        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
