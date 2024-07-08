using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_Grupo_01
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Crear una instancia de entUsuario y establecer los valores de usuario y contraseña
            entUsuario usuario = new entUsuario
            {
                Usuario = txtUsuario.Text,
                Contraseña = txtContraseña.Text
            };

            // Llamar al método de autenticación en la capa lógica
            bool autenticado = LOGusuario.Instancia.AutenticarUsuario(usuario);

            // Verificar si las credenciales son correctas
            if (autenticado)
            {
                // Si las credenciales son correctas, mostrar el formulario de inicio
                Inicio form = new Inicio();
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                // Si las credenciales no son correctas, mostrar un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
