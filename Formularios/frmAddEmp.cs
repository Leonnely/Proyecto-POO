using Proyecto_Integrador.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador.Formularios
{
    public partial class frmAddEmp : Form
    {
        public frmAddEmp()
        {
            InitializeComponent();
        }

        private void btnConfirmarEmp_Click(object sender, EventArgs e)
        {
            string codeEmp = txtCodEmp.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            
            EmpGral empleado = new EmpGral(codeEmp, nombre, apellido);
            zDatos.Empleados.AddLast(empleado);
            
        }
    }
}
