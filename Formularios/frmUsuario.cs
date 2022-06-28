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
    public partial class frmUsuario : UserControl
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {   
            //Variables del cliente
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string estado = cboxEstado.SelectedItem.ToString();
            string relacion = cboxRelacion.SelectedItem.ToString();

            //Variables del proyecto
            string nombreProyecto = txtNombreProyecto.Text;
            string cod_proy = txtCodPr.Text;
            DateTime fechaSuscr = dtSuscripcion.Value;
            DateTime fechaEntr = dtEntrega.Value;
            string costo = txtCosto.Text;
            string lang = "c#";

            ///
            /// TODO : Validar controles
            ///

            //Creacion de las clases
            Cliente cliente = new Cliente(nombre, apellido, estado, relacion);
            Proyectos proyecto = new Proyectos(nombreProyecto, cod_proy, fechaSuscr, costo, fechaEntr, lang);

        }
    }
}
