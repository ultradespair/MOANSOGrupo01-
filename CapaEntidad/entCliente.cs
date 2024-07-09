using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {


            public int ClienteID { get; set; }
            public string NombreCompleto { get; set; }
            public int DNI { get; set; }
            public int NumeroTelefono { get; set; }
            public string CorreoElectronico { get; set; }
            public DateTime FechaNacimiento { get; set; }
        



    }

    public class entUsuario
    {

        public string Usuario { get; set; }
        public string Contraseña { get; set; }

    }

    public class Instructor
    {
        public int InstructorID { get; set; }
        public string NombreCompleto { get; set; }
        public int DNI { get; set; }
        public int NumeroTelefonico { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Horario { get; set; }
    }

    public class entReserva
    {
        public int ReservaID { get; set; }
        public int ClienteID { get; set; }
        public string NombreEvento { get; set; }
        public string TipoEvento { get; set; }
        public string LugarReserva { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
