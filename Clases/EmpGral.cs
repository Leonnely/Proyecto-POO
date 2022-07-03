using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Clases
{
    class EmpGral : Persona
    {
        public EmpGral(string CodEmp,string Nombre, string Apellido,string Cargo) :base(Nombre,Apellido)
        {
            this.CodEmp = CodEmp;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Cargo = Cargo;
        }

        private string codemp;
        public string CodEmp
        {
            get { return codemp; }
            set { codemp = value; }
        }

        private string cargo;
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        private Proyectos[] proyectos;
        public Proyectos[] Proyectos
        {
            get { return proyectos; }
            set { proyectos = value; }
        }

        private EmpGral equipo;
        public EmpGral Equipos
        {
            get { return equipo; }
            set { equipo = value; }
        }


    }
}
