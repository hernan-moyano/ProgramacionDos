using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Persona //: indica la herencia
    {
        private string materia;
        private long legajo;

        #region Propiedades
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public long Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        #endregion

        #region Constructores
        public Docente() { }
        public Docente(string Nom, string Ape, long Du, DateTime FecNac, char Sex, string mat, long Leg) : base(Nom, Ape, Du, FecNac, Sex)
        {
            materia = mat;
            Legajo = Leg;
        }
        #endregion
    }

}
