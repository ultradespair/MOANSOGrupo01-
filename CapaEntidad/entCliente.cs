﻿using System;
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
}
