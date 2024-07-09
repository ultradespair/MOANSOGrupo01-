using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DATinstructor
    {
        public void InsertarInstructor(string nombre, int dni, int telefono, string email, DateTime fechaNacimiento)
        {
            using (SqlConnection conn = Conexion.Instancia.Conectar())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertarInstructor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                cmd.Parameters.AddWithValue("@DNI", dni);
                cmd.Parameters.AddWithValue("@NumeroTelefonico", telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", email);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerInstructores()
        {
            DataTable dtInstructores = new DataTable();
            using (SqlConnection conn = Conexion.Instancia.Conectar())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ObtenerInstructores", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtInstructores);
            }
            return dtInstructores;
        }

        public void ActualizarInstructor(int instructorID, int horarioID, string especialidad)
        {
            using (SqlConnection conn = Conexion.Instancia.Conectar())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ActualizarInstructor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InstructorID", instructorID);
                cmd.Parameters.AddWithValue("@HorarioID", horarioID);
                cmd.Parameters.AddWithValue("@Especialidad", especialidad);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerHorarios()
        {
            DataTable dtHorarios = new DataTable();
            using (SqlConnection conn = Conexion.Instancia.Conectar())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ObtenerHorarios", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtHorarios);
            }
            return dtHorarios;
        }
    }
}

