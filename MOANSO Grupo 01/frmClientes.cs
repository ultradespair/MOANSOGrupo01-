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

        private void LimpiarForm()
        {
            txtNombreCompleto.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtCorreoCli.Text = string.Empty;
            dtpfechacliente.Value = DateTime.Now;
           
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
            LimpiarForm();
            listarCliente();

        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.NombreCompleto = txtNombreCompleto.Text.Trim();
                c.DNI = int.Parse(txtDNI.Text.Trim());
                c.NumeroTelefono = int.Parse(txtNumero.Text.Trim());
                c.CorreoElectronico = txtCorreoCli.Text.Trim();
                c.FechaNacimiento = dtpfechacliente.Value;
                LOGcliente.Instancia.ModificarCliente(c);
                MessageBox.Show("Cliente modificado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            listarCliente();
            listarCliente();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
                txtNombreCompleto.Text = row.Cells["NombreCompleto"].Value.ToString();
                txtDNI.Text = row.Cells["DNI"].Value.ToString();
                txtNumero.Text = row.Cells["NumeroTelefono"].Value.ToString();
                txtCorreoCli.Text = row.Cells["CorreoElectronico"].Value.ToString();
                dtpfechacliente.Value = DateTime.Parse(row.Cells["FechaNacimiento"].Value.ToString());
            }
        }


    }
}
