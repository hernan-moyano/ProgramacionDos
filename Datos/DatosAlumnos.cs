using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO: FALTA HACER
namespace Datos
{
   public class DatosAlumnos : DatosConexionBD
    {
        #region Metodos
        /* 
         abmAlumnos que recibe dos parámetros, un string que llamamos accion que me va a indicar qué es lo que queremos hacer con el objeto Alumno enviado, si accion es 
        igual a “Agregar” lo agregaremos a la base de datos, si es igual a “Modificar”, lo modificaremos al existente y si es “Eliminar” lo eliminaremos de la tabla. 
        El método devuelve un entero, si devuelve -1 indica que no pudo realizar la acción solicitado.
         */

        public int abmAlumnos(string accion, Alumno objAlumno)
        {
            int resultado = -1;
            string orden = string.Empty;
            //AGREGAR
            if (accion == "Agregar")
                orden = "insert into Personas values (" + objAlumno.Dni + ",'" + objAlumno.Nombre + "','" + objAlumno.Apellido + "','" + objAlumno.FechNac + "','" + objAlumno.Sexo + "' ); " +
            "insert into Alumnos values (" + objAlumno.Dni + ",'" + objAlumno.Carrera + "','" + objAlumno.Legajo + "');";
            //MODIFICAR
            if (accion == "Modificar")
                orden = "update Personas set " +
                    " nombre ='" + objAlumno.Nombre +
                    "', apellido ='" + objAlumno.Apellido +
                    "', fechNac ='" + objAlumno.FechNac +
                    "', sexo ='" + objAlumno.Sexo +
                   "' where dni = " + objAlumno.Dni + "; " +

                    "update Alumnos set " +
                    "carrera ='" + objAlumno.Carrera +
                    "', legajo =" + objAlumno.Legajo +
                    " where dni = " + objAlumno.Dni + "; ";
            //ELIMINAR
            if (accion == "Eliminar")
                orden = "DELETE FROM  Alumnos where dni = " + objAlumno.Dni + "; " +
            "DELETE FROM  Personas where dni = " + objAlumno.Dni + "; ";
            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }
        /*
         Este método  listadoAlumnos devuelve un DataSet con los registros solicitados, recibe un string que indica el código que deseo buscar, o si sesolicitan “Todos”.
         */

        public DataSet listadoAlumnos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Alumnos where dni = " + cual + ";";
            else
                orden = "select nombre, apellido,Personas.dni, fechNac, sexo, carrera, legajo " +
                        "from Personas , Alumnos " +
                        "where Personas.dni = Alumnos.dni;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Alumnos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        #endregion
    }
}
