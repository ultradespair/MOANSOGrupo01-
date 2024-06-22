using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;



namespace MOANSO_Grupo_01
{
    public partial class Inicio : Form
    {
        public static ToolStripMenuItem MenuActivo = null;
        public static Form FormularioActivo = null;

        public Inicio()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.DarkSeaGreen; // Color predeterminado del sistema para ToolStripMenuItem
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill; // Hace que el formulario ocupe todo el espacio del contenedor
            formulario.BackColor = Color.White;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            AbrirFormulario(menuItem, new frmClientes());
        }

        private void instructoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            AbrirFormulario(menuItem, new frmInstructores());
        }

        private void finanzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            AbrirFormulario(menuItem, new frmFinanzas());

        }

        private void deportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            AbrirFormulario(menuItem, new frmUsuarios());
        }

        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            AbrirFormulario(menuItem, new frmDeportes());
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            AbrirFormulario(menuItem, new frmReserva());
        }
    }
}
