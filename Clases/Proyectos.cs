using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Clases
{
    class Proyectos
    {
        public Proyectos(string nombreProyecto,string codeProyecto,DateTime fechaSuscripcion,string costo, DateTime fechaEntrega,string lenguajePr)
        {
            this.Nombre = nombreProyecto;
            this.CodeProyect = codeProyecto;
            this.FechaSuscripcion = fechaSuscripcion;
            this.Costo = costo;
            this.FechaEntrega = fechaEntrega;
            this.LangProgram = lenguajePr;
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string codeProyect;
        public string CodeProyect
        {
            get { return codeProyect; }
            set { codeProyect = value; }
        }

        private DateTime fechaSuscripcion;
        public DateTime FechaSuscripcion
        {
            get { return fechaSuscripcion; }
            set { fechaSuscripcion = value; }
        }

        private string costo;

        public string Costo
        {
            get { return costo; }
            set { costo = value; }
        }


        private DateTime fechaEntrega;
        public DateTime FechaEntrega
        {
            get { return fechaEntrega; }
            set { fechaEntrega = value; }
        }

        private string langProgram;
        public string LangProgram
        {
            get { return langProgram; }
            set { langProgram = value; }
        }

    }
}
