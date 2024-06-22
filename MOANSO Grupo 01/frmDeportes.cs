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
    public partial class frmDeportes : Form
    {
        public static ToolStripMenuItem MenuActivo = null;
        public static Form FormularioActivo = null;
        public frmDeportes()
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

            panelcontenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void fútbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            AbrirFormulario(menuItem, new frmDeportesFutbol());
        }

     
        private void tenisToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            AbrirFormulario(menuItem, new frmDeportesTenis());
        }

        private void golfToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            AbrirFormulario(menuItem, new frmDeportesGolf());
        }

        private void voleyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            AbrirFormulario(menuItem, new frmDeportesVolley());
        }

        private void basketToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            AbrirFormulario(menuItem, new frmDeportesBasket());
        }

        private void nataciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            AbrirFormulario(menuItem, new frmDeportesNatacion());
        }
    }
}
