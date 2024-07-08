using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LOGcliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LOGcliente _instancia = new LOGcliente();
        //privado para evitar la instanciación directa
        public static LOGcliente Instancia
        {
            get
            {
                return LOGcliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///inserta
        public void InsertaCliente(entCliente Cli)
        {
            DATcliente.Instancia.InsertarCliente(Cli);
        }
        #endregion singleton
    }
}
