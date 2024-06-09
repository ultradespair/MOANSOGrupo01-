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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncuota_Click(object sender, EventArgs e)
        {
            frmCuotas frmcuotas = new frmCuotas();
            frmcuotas.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmHistorial frmhistorial = new frmHistorial();
            frmhistorial.Show();
        }
    }
}
