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

        static public LinkedList<Cliente> Clientes = new LinkedList<Cliente>();
        static public List<Cliente> getClientes()
        {
            List<Cliente> lista = Clientes.ToList();
            return lista;
        }

        static public LinkedList<Proyectos> Proyectos = new LinkedList<Proyectos>();
        static public List<Proyectos> getProyectos()
        {
            List<Proyectos> lista = Proyectos.ToList();
            return lista;
        }
    }
}
