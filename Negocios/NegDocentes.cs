using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegDocentes
    {
        #region Atributos
        DatosDocentes objDatosDocentes = new DatosDocentes();
        #endregion

        #region Metodos
        /*/para personas
        public int abmPersonas(string accion, Persona objPersona)
        {
            return objDatosPersona.abmPersonas(accion, objPersona);
        }
        //para personas
        public DataSet listadoPersonas(string cual)
        {
            return objDatosPersona.listadoPersonas(cual);
        }

        */
        //para docentes
        public int ambDocentes(string accion, Docente objDocentes)
        {
            return objDatosDocentes.abmDocentes(accion, objDocentes);
        }
        //para docentes
        public DataSet listadoDocentes(string cual)
        {
            return objDatosDocentes.listadoDocentes(cual);
        }
        #endregion
    }
}
