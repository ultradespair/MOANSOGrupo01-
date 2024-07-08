using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LOGusuario
    {
        private static readonly LOGusuario _instancia = new LOGusuario();
        public static LOGusuario Instancia
        {
            get
            {
                return LOGusuario._instancia;
            }
        }

        public bool AutenticarUsuario(entUsuario usuario)
        {
            return DATusuario.Instancia.VerificarUsuario(usuario);
        }

        public bool RegistrarUsuario(entUsuario usuario)
        {
            return DATusuario.Instancia.InsertarUsuario(usuario);
        }

        public DataTable ListarUsuarios()
        {
            return DATusuario.Instancia.ListarUsuarios();
        }
    }
}
