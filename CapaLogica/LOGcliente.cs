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

        ///listado

        public List<entCliente> ListarCliente()
        {
            return DATcliente.Instancia.ListarCliente();
        }

        #endregion singleton

        public static bool InsertarReserva(entReserva reserva)
        {
            try
            {
               
                return DATcliente.Instancia.InsertarReserva(reserva);
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public static List<entReserva> ListarReservas()
        {
            return DATcliente.Instancia.ListarReservas();
        }

        public static List<string> ObtenerTiposDeEventos()
        {
            return DATcliente.Instancia.ObtenerTiposDeEventos();
        }

        public static List<string> ObtenerDeportes()
        {
            return DATcliente.Instancia.ObtenerDeportes();
        }

        public Boolean ModificarReserva(entReserva reserva)
        {
            return DATcliente.Instancia.ModificarReserva(reserva);
        }

        public void ModificarCliente(entCliente Cli)
        {
            DATcliente.Instancia.ModificarCliente(Cli);
        }

    }
}
