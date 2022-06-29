using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Clases
{
    class EmpGral : Persona
    {
        /// <summary>
        /// CONSTRUCTOR PARA FUNCIONAMIENTO DE PRUEBA
        /// **** ESTADO INCOMPLETO ****
        /// </summary>
        public EmpGral(string Nombre, string Apellido,string CodEmp) :base(Nombre,Apellido)
        {
            this.CodEmp = CodEmp;
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
