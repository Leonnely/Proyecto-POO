using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Clases
{
    static class zDatos
    {
        static public LinkedList<EmpGral> Empleados = new LinkedList<EmpGral>();
        static public List<EmpGral> getEmpleados()
        {
            List<EmpGral> lista = Empleados.ToList();
            return lista;
        }
    }
}
