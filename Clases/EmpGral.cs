using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Clases
{
    class EmpGral : Persona
    {
        public EmpGral(string Nombre, string Apellido) :base(Nombre,Apellido)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
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


    }
}
