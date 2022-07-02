using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Clases
{
    class Proyectos
    {
        public Proyectos(string codeProyecto,string nombreProyecto)
        {
            this.CodeProyect = codeProyecto;
            this.Nombre = nombreProyecto;
        }
        
        public Proyectos(string nombreProyecto,string codeProyecto,string fechaSuscripcion,string costo, string fechaEntrega,string lenguajePr)
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

        private string fechaSuscripcion;
        public string FechaSuscripcion
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


        private string fechaEntrega;
        public string FechaEntrega
        {
            get { return fechaEntrega; }
            set { fechaEntrega = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        private string langProgram;
        public string LangProgram
        {
            get { return langProgram; }
            set { langProgram = value; }
        }

        

    }
}
