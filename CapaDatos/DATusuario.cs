using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DATusuario
    {
        private static readonly DATusuario _instancia = new DATusuario();
        public static DATusuario Instancia
        {
            get
            {
                return DATusuario._instancia;
            }
        }

        public bool VerificarUsuario(entUsuario usuario)
        {
            SqlCommand cmd = null;
            bool resultado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spVerificarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return resultado;
        }

        public bool InsertarUsuario(entUsuario usuario)
        {
            SqlCommand cmd = null;
            bool resultado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return resultado;
        }

        public DataTable ListarUsuarios()
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarUsuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }
}
