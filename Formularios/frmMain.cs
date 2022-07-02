using Proyecto_Integrador.Clases;
using Proyecto_Integrador.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            ShowInterfazUser(new IfrmMain());
        }
        private void ShowInterfazUser(UserControl varControl)
        {
            if (panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            varControl.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(varControl);
            this.panelContenedor.Tag = varControl;
            varControl.Show();
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowInterfazUser(new IfrmMain());
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ShowInterfazUser(new IfrmUsuario());
        }
        private void Empleados_Click(object sender, EventArgs e)
        {
            ShowInterfazUser(new IfrmEmpleados());
        }
        private void btnProyectos_Click(object sender, EventArgs e)
        {
            ShowInterfazUser(new IfrmProyectos());
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Cerrar Programa?", "Cerrar Programa", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes) this.Close();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

    }
}
