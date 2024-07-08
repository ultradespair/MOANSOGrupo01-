using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOANSO_Grupo_01
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            entUsuario nuevoUsuario = new entUsuario
            {
                Usuario = txtNuevoUsuario.Text,
                Contraseña = txtNuevaContraseña.Text
            };

            bool registrado = LOGusuario.Instancia.RegistrarUsuario(nuevoUsuario);

            if (registrado)
            {
                MessageBox.Show("Usuario registrado exitosamente.");
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario.");
            }
        }

        private void CargarUsuarios()
        {
            DataTable dt = LOGusuario.Instancia.ListarUsuarios();
            dgvUsuarios.DataSource = dt;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}