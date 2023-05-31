using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Net;

namespace proyecto01_Prueba
{
    public class ConexionBD
    {
        private string coneccionString = "Data Source= JOHAN_D1RECTO; Initial Catalog=ColegioPrueba; User=sa; Password=12345";

        public List<AlumnoBD> ObtenerListadoAlumnos()
        {
            List<AlumnoBD> listadoAlumnos = new List<AlumnoBD>();

            String query = "select * from Alumno";
            using(SqlConnection coneccion = new SqlConnection(coneccionString))
            {
                SqlCommand comando = new SqlCommand(query, coneccion);
                try
                {
                     coneccion.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        AlumnoBD alumno = new AlumnoBD();
                        alumno.Id = reader.GetInt32(0);
                        alumno.NombreAlumno = reader.GetString(1);
                        alumno.DNI = reader.GetString(2);
                        listadoAlumnos.Add(alumno);
                    }
                    reader.Close();
                    coneccion.Close();
                        

                }
                catch(Exception ex)
                {
                    throw new Exception("hay un error: " + ex.Message);
                }
            }
            return listadoAlumnos;

        }
        
        public void CrearAlumnoNuevo(String nombre, String dni)
        {
            String query = "insert into Alumno (NombreAlumno,DNI) values (@nombreAlumno, @DNI)";
            using (SqlConnection coneccion = new SqlConnection(coneccionString))
            {
                SqlCommand comando = new SqlCommand(query, coneccion);
                comando.Parameters.AddWithValue("@nombreAlumno", nombre);
                comando.Parameters.AddWithValue("@DNI", dni);
                try
                {
                    coneccion.Open();
                    comando.ExecuteNonQuery();
                    coneccion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error al crear un alumno nuevo" + ex.Message);
                }

            }
        }

        public void EditarAlumno(Int32 idAlumno, String nombre, String dni)
        {
            String query = "update Alumno set NombreAlumno = @nombreAlumno, DNI = @DNI where idAlumno = @idAlumno";
            using (SqlConnection coneccion = new SqlConnection(coneccionString))
            {
                SqlCommand comando = new SqlCommand(query, coneccion);
                comando.Parameters.AddWithValue("@nombreAlumno", nombre);
                comando.Parameters.AddWithValue("@DNI", dni);
                comando.Parameters.AddWithValue("@idAlumno", idAlumno);

                try
                {
                    coneccion.Open();
                    comando.ExecuteNonQuery();
                    coneccion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error al crear un alumno nuevo" + ex.Message);
                }

            }
        }
        public void EliminarAlumno(Int32 idAlumno)
        {
            String query = "delete from Alumno where idAlumno = @idAlumno";
            using (SqlConnection coneccion = new SqlConnection(coneccionString))
            {
                SqlCommand comando = new SqlCommand(query, coneccion);
                comando.Parameters.AddWithValue("@idAlumno", idAlumno);

                try
                {
                    coneccion.Open();
                    comando.ExecuteNonQuery();
                    coneccion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error al crear un alumno nuevo" + ex.Message);
                }

            }
        }

    }
}
