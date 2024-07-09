using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaLogica
{
    public class LOGinstructor
    {
        private DATinstructor _instructorData = new DATinstructor();

        public void RegistrarInstructor(string nombre, int dni, int telefono, string email, DateTime fechaNacimiento)
        {
            _instructorData.InsertarInstructor(nombre, dni, telefono, email, fechaNacimiento);
        }

        public DataTable ObtenerInstructores()
        {
            return _instructorData.ObtenerInstructores();
        }

        public void AsignarHorario(int instructorID, int horarioID, string especialidad)
        {
            _instructorData.ActualizarInstructor(instructorID, horarioID, especialidad);
        }

        public DataTable ObtenerHorarios()
        {
            return _instructorData.ObtenerHorarios();
        }
    }
}

