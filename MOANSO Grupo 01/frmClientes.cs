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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public void listarCliente()
        {
            dgvCliente.DataSource = LOGcliente.Instancia.ListarCliente();
        }

        private void btnRegistroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                
                c.NombreCompleto = txtNombreCompleto.Text.Trim();
                c.DNI = int.Parse(txtDNI.Text.Trim());
                c.NumeroTelefono = int.Parse(txtNumero.Text.Trim());
                c.CorreoElectronico = txtCorreoCli .Text.Trim();
                c.FechaNacimiento = dtpfechacliente.Value;
                LOGcliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }

            listarCliente();

        }
    }
}
