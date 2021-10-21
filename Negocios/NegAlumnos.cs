using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegAlumnos
    {
        #region Atributos
        DatosAlumnos objDatosAlumnos = new DatosAlumnos();
        #endregion
        #region Metodos
        //para Alumnos
        public int ambAlumnos(string accion, Alumno objAlumnos)
        {
            return objDatosAlumnos.abmAlumnos(accion, objAlumnos);
        }
        //para Alumnos
        public DataSet listadoAlumnos(string cual)
        {
            return objDatosAlumnos.listadoAlumnos(cual);
        }
        #endregion
    }
}
