using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Integrador.Clases;

namespace Proyecto_Integrador.Formularios
{
    public partial class frmEmpleados : UserControl
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            frmAddEmp frmEmp = new frmAddEmp();
            frmEmp.ShowDialog();
            
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = zDatos.getEmpleados();
        }
    }
}
