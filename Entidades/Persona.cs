using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private long dni;
        private DateTime fechNac;
        private char sexo;
        #endregion
        //
        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public DateTime FechNac
        {
            get { return fechNac; }
            set { fechNac = value; }
        }
        public Char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        #endregion
        #region Constructores
        public Persona()//por defecto
        { }
        public Persona(string Nom, string Ape, long Du, DateTime FecNac, char Sex)
        {
            Nombre = Nom;
            Apellido = Ape;
            Dni = Du;
            FechNac = FecNac;
            Sexo = Sex;
        }
        #endregion
        #region Metodos
        public int Edad()
        {
            int edad;
            edad = FechNac.Year - DateTime.Now.Year;
            return edad;
        }
        #endregion
    }
}
        
    
