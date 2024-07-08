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
        public Boolean InsertarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreCompleto", Cli.NombreCompleto);
                cmd.Parameters.AddWithValue("@DNI", Cli.DNI); 
                cmd.Parameters.AddWithValue("@NumeroTelefono", Cli.NumeroTelefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", Cli.CorreoElectronico);
                cmd.Parameters.AddWithValue("@FechaNacimiento", Cli.FechaNacimiento);
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


    }
}
