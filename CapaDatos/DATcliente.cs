using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DATcliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly DATcliente _instancia = new DATcliente();
        //privado para evitar la instanciación directa
        public static DATcliente Instancia
        {
            get
            {
                return DATcliente._instancia;
            }
        }
        #endregion singleton


        #region sigleton
        /////////////////////////InsertaCliente
        public bool InsertarCliente(entCliente cli)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreCompleto", cli.NombreCompleto);
                cmd.Parameters.AddWithValue("@DNI", cli.DNI);
                cmd.Parameters.AddWithValue("@NumeroTelefono", cli.NumeroTelefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", cli.CorreoElectronico);
                cmd.Parameters.AddWithValue("@FechaNacimiento", cli.FechaNacimiento);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }






        ////////////////////listado de Clientes
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();

                    Cli.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Cli.NombreCompleto = dr["NombreCompleto"].ToString();
                    Cli.DNI = Convert.ToInt32(dr["DNI"]);
                    Cli.NumeroTelefono = Convert.ToInt32(dr["NumeroTelefono"]);
                    Cli.CorreoElectronico = dr["CorreoElectronico"].ToString();
                    Cli.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }


        #endregion singleton


        ///////////////////////// InsertaReserva
        public Boolean InsertarReserva(entReserva res)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del procedimiento almacenado
                cmd.Parameters.AddWithValue("@ClienteID", res.ClienteID);
                cmd.Parameters.AddWithValue("@NombreEvento", res.NombreEvento);
                cmd.Parameters.AddWithValue("@TipoEvento", res.TipoEvento);
                cmd.Parameters.AddWithValue("@LugarReserva", res.LugarReserva);
                cmd.Parameters.AddWithValue("@FechaReserva", res.FechaReserva);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }

        //////////////////// Listado de Reservas
        public List<entReserva> ListarReservas()
        {
            SqlCommand cmd = null;
            List<entReserva> lista = new List<entReserva>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spObtenerReservas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entReserva res = new entReserva();

                    res.ReservaID = Convert.ToInt32(dr["ReservaID"]);
                    res.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    res.NombreEvento = dr["NombreEvento"].ToString();
                    res.TipoEvento = dr["TipoEvento"].ToString();
                    res.LugarReserva = dr["LugarReserva"].ToString();
                    res.FechaReserva = Convert.ToDateTime(dr["FechaReserva"]);
                    lista.Add(res);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }

        public List<string> ObtenerTiposDeEventos()
        {
            List<string> tiposDeEventos = new List<string> { "Ocasional", "Festivo", "Torneo" };
            return tiposDeEventos;
        }

        public List<string> ObtenerDeportes()
        {
            SqlCommand cmd = null;
            List<string> deportes = new List<string>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SELECT TipoDeporte FROM Deporte", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    deportes.Add(dr["TipoDeporte"].ToString());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return deportes;
        }

        public Boolean ModificarReserva(entReserva res)
        {
            SqlCommand cmd = null;
            Boolean modificado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReservaID", res.ReservaID);
                cmd.Parameters.AddWithValue("@ClienteID", res.ClienteID);
                cmd.Parameters.AddWithValue("@NombreEvento", res.NombreEvento);
                cmd.Parameters.AddWithValue("@TipoEvento", res.TipoEvento);
                cmd.Parameters.AddWithValue("@LugarReserva", res.LugarReserva);
                cmd.Parameters.AddWithValue("@FechaReserva", res.FechaReserva);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modificado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return modificado;
        }

        public Boolean ModificarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean modifica = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ModificarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
                cmd.Parameters.AddWithValue("@NombreCompleto", Cli.NombreCompleto);
                cmd.Parameters.AddWithValue("@DNI", Cli.DNI);
                cmd.Parameters.AddWithValue("@NumeroTelefono", Cli.NumeroTelefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", Cli.CorreoElectronico);
                cmd.Parameters.AddWithValue("@FechaNacimiento", Cli.FechaNacimiento);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modifica = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return modifica;
        }

    }

}

