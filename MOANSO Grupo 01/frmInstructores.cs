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
    public partial class frmInstructores : Form
    {
        private LOGinstructor _instructorLogic = new LOGinstructor();
        public frmInstructores()
        {
            InitializeComponent();
            CargarHorarios();
            CargarInstructores();
        }

        private void CargarHorarios()
        {
            DataTable dtHorarios = _instructorLogic.ObtenerHorarios();
            cmbHorarios.DataSource = dtHorarios;
            cmbHorarios.DisplayMember = "Duracion";
            cmbHorarios.ValueMember = "HorarioID";
        }

        private void CargarInstructores()
        {
            DataTable dtInstructores = _instructorLogic.ObtenerInstructores();
            dgvInstructores.DataSource = dtInstructores;
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInstructores_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarInstructor_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreInstructor.Text;
            int dni = int.Parse(txtDniInstructor.Text);
            int telefono = int.Parse(txtTelefonoInstructor.Text);
            string email = txtEmailInstructor.Text;
            DateTime fechaNacimiento = dtpfechainstructor.Value;

            _instructorLogic.RegistrarInstructor(nombre, dni, telefono, email, fechaNacimiento);
            CargarInstructores(); // Refresca la lista de instructores
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvInstructores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un instructor.");
                return;
            }

            int instructorID = (int)dgvInstructores.SelectedRows[0].Cells["InstructorID"].Value;
            int horarioID = (int)cmbHorarios.SelectedValue;
            string especialidad = GetEspecialidadFromCheckBoxes();

            _instructorLogic.AsignarHorario(instructorID, horarioID, especialidad);
            CargarInstructores(); // Refresca la lista de instructores
        }

        private string GetEspecialidadFromCheckBoxes()
        {
            var especialidades = new System.Text.StringBuilder();
            if (chkFutbol.Checked) especialidades.Append("Fútbol ");
            if (chkBasketball.Checked) especialidades.Append("Basketball ");
            if (chkVolley.Checked) especialidades.Append("Volley ");
            if (chkGolf.Checked) especialidades.Append("Golf ");
            if (chkTenis.Checked) especialidades.Append("Tenis ");
            if (chkNatacion.Checked) especialidades.Append("Natación ");
            return especialidades.ToString().Trim();
        }
    }
}
