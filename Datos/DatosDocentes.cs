using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DatosDocentes : DatosConexionBD
    {
        #region Metodos
        /* 
         abmDocentes que recibe dos parámetros, un string que llamamos accion que me va a indicar qué es lo que queremos hacer con el objeto Docente enviado, si accion es 
        igual a “Agregar” lo agregaremos a la base de datos, si es igual a “Modificar”, lo modificaremos al existente y si es “Eliminar” lo eliminaremos de la tabla. 
        El método devuelve un entero, si devuelve -1 indica que no pudo realizar la acción solicitado.
         */

        public int abmDocentes(string accion, Docente objDocente)
        {
            int resultado = -1;
            string orden = string.Empty;
           //AGREGAR
            if (accion == "Agregar")
                orden = "insert into Personas values (" + objDocente.Dni + ",'" + objDocente.Nombre + "','" + objDocente.Apellido + "','" + objDocente.FechNac + "','" + objDocente.Sexo + "' ); " +
            "insert into Docentes values (" + objDocente.Dni + ",'" + objDocente.Materia + "','" + objDocente.Legajo + "');";
            //MODIFICAR
            if (accion == "Modificar")
                orden = "update Personas set " +
                    " nombre ='" + objDocente.Nombre +
                    "', apellido ='" + objDocente.Apellido +
                    "', fechNac ='" + objDocente.FechNac +
                    "', sexo ='" + objDocente.Sexo +
                   "' where dni = " + objDocente.Dni + "; "+

                    "update Docentes set " + 
                    "materia ='" + objDocente.Materia +
                    "', legajo =" + objDocente.Legajo +
                    " where dni = " + objDocente.Dni + "; ";
            //ELIMINAR
            if (accion == "Eliminar")
                orden = "DELETE FROM  Docentes where dni = " + objDocente.Dni + "; " +
            "DELETE FROM  Personas where dni = " + objDocente.Dni + "; ";
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
         Este método  listadoDocentes devuelve un DataSet con los registros solicitados, recibe un string que indica el código que deseo buscar, o si sesolicitan “Todos”.
         */

        public DataSet listadoDocentes(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Docentes where dni = " + cual + ";";
            else
                orden = "select nombre, apellido,Personas.dni, fechNac, sexo, materia, legajo " +
                        "from Personas , Docentes " +
                        "where Personas.dni = Docentes.dni;";
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
                throw new Exception("Error al listar Docentes", e);
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
