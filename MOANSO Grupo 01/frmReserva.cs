using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace MOANSO_Grupo_01
{
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar datos desde la interfaz de usuario
                int clienteID = ObtenerClienteID(); // Implementa lógica para obtener el ID del cliente registrado
                string nombreEvento = txtNombreReserva.Text;
                string tipoEvento = cbEventoReserva.SelectedItem.ToString();
                string lugarReserva = cbAreaReserva.SelectedItem.ToString();
                DateTime fechaReserva = dtpFechaReserva.Value;

                // Crear objeto de reserva
                entReserva reserva = new entReserva
                {
                    ClienteID = clienteID,
                    NombreEvento = nombreEvento,
                    TipoEvento = tipoEvento,
                    LugarReserva = lugarReserva,
                    FechaReserva = fechaReserva
                };

                // Insertar reserva
                bool resultado = LOGcliente.InsertarReserva(reserva);

                if (resultado)
                {
                    MessageBox.Show("Reserva insertada correctamente.");
                    // Actualizar DataGridView con las reservas actualizadas
                    CargarReservas();
                }
                else
                {
                    MessageBox.Show("Error al insertar la reserva.");
                }

                // Limpiar campos después de reservar
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al reservar: {ex.Message}");
            }
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            CargarTiposDeEventos();
            CargarDeportes();
            CargarReservas();
        }

        private void CargarTiposDeEventos()
        {
            List<string> tiposDeEventos = LOGcliente.ObtenerTiposDeEventos();
            cbEventoReserva.DataSource = tiposDeEventos;
        }

        private void CargarDeportes()
        {
            List<string> deportes = LOGcliente.ObtenerDeportes();
            cbAreaReserva.DataSource = deportes;
        }

        private void CargarReservas()
        {
            List<entReserva> reservas = LOGcliente.ListarReservas();
            dgvReservasTotales.DataSource = reservas;
        }

        private int ObtenerClienteID()
        {
            // Implementa lógica para obtener el ID del cliente registrado
            return 1; // Ejemplo, debes implementar la lógica adecuada
        }

        private void LimpiarCampos()
        {
            txtNombreReserva.Text = "";
            cbEventoReserva.SelectedIndex = -1;
            cbAreaReserva.SelectedIndex = -1;
            dtpFechaReserva.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear entidad Reserva con los datos modificados
                entReserva reservaModificada = new entReserva
                {
                    ClienteID = int.Parse(txtClienteReserva.Text),
                    NombreEvento = txtNombreReserva.Text,
                    TipoEvento = cbEventoReserva.SelectedItem.ToString(),
                    LugarReserva = cbAreaReserva.SelectedItem.ToString(),
                    FechaReserva = dtpFechaReserva.Value
                };

                // Llamar al método en la capa lógica para modificar la reserva
                if (LOGcliente.Instancia.ModificarReserva(reservaModificada))
                {
                    MessageBox.Show("Reserva modificada correctamente");
                    CargarReservas(); // Volver a cargar las reservas en el DataGridView
                    LimpiarCampos(); 
                }
                else
                {
                    MessageBox.Show("Error al modificar la reserva");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvReservasTotales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se haya seleccionado una fila válida
            {
                DataGridViewRow fila = dgvReservasTotales.Rows[e.RowIndex];

                // Mostrar datos en TextBox u otros controles
                txtClienteReserva.Text = fila.Cells["ClienteID"].Value.ToString();
                txtNombreReserva.Text = fila.Cells["NombreEvento"].Value.ToString();
                cbEventoReserva.SelectedItem = fila.Cells["TipoEvento"].Value.ToString();
                cbAreaReserva.SelectedItem = fila.Cells["LugarReserva"].Value.ToString();
                dtpFechaReserva.Value = Convert.ToDateTime(fila.Cells["FechaReserva"].Value);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaReserva_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
