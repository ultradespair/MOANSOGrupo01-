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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmclientes = new frmClientes();
            frmclientes.Show();
        }

        private void instructoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInstructores frminstructores = new frmInstructores ();
            frminstructores.Show();
        }

        private void finanzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinanzas frmfinanzas = new frmFinanzas();
            frmfinanzas.Show();

        }
    }
}
