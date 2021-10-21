using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosConexionBD
    {
        #region atributos
        public SqlConnection conexion;
        public string cadenaConexion = @"Data Source=DESKTOP-3H5AFF1;Initial Catalog=programaciondos-capas;Integrated Security=True";
        #endregion

        #region Constructor
        public DatosConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        #endregion

        #region Metodos
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }

        #endregion

    }
}
