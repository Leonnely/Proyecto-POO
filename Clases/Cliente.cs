using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Clases
{
    class Cliente : Persona
    {
        public Cliente(string Nombre,string Apellido,string dni,string Estado,string Relacion) : base(Nombre,Apellido)
        {
              this.Nombre = Nombre;
              this.Apellido = Apellido;
              this.DNI = dni;
              this.Estado = Estado;
              this.Relacion = Relacion;
        }

        private string dni;

        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        //nuevo /frecuente 
        private string estado;
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string relacion;
        public string Relacion
        {
            get { return relacion; }
            set { relacion = value; }
        }
        private Proyectos proyect;
        public Proyectos Proyect
        {
            get { return proyect; }
            set { proyect = value; }
        }

    }
}
