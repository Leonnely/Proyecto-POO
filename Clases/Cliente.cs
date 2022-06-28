using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Clases
{
    class Cliente : Persona
    {
        public Cliente(string Nombre,string Apellido,string Estado,string Relacion) : base(Nombre,Apellido)
        {
              this.Nombre = Nombre;
              this.Apellido = Apellido;
              this.Estado = Estado;
              this.Relacion = Relacion;
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
    }
}
