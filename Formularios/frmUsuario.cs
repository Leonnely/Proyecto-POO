﻿using Proyecto_Integrador.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


            // Hacer un condicional donde se validen los datos y si todo es correcto se ejecute el siguiente codigo
            if (File.Exists("DatosClientes.txt"))
            {
                FileStream fs = new FileStream("DatosClientes.txt", FileMode.Open);

                StreamReader sr = new StreamReader(fs);
                FileStream fs2 = new FileStream("DatosClientesAux.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs2);
                string datas2;

                while (sr.Peek() != -1)
                {
                    datas2 = sr.ReadLine();
                    string[] datos2 = datas2.Split('-');
                    sw.WriteLine(datos2[0] + "-" + datos2[1] + "-" + datos2[2] + "-" + datos2[3] + "-" + datos2[4] + "-" + datos2[5]);
                }
                string Datoscliente = txtNombre.Text + "-" + txtApellido.Text + "-" + txtDNI.Text + "-" + cboxEstado.Text + "-" + cboxRelacion.Text + "-" + txtCodPr.Text;
                sw.WriteLine(Datoscliente);
                sr.Close();
                sw.Close();
                fs.Close();
                fs2.Close();
                File.Delete("DatosClientes.txt");
                File.Move("DatosClientesAux.txt", "DatosClientes.txt");
            }
            else
            {
                FileStream fs = new FileStream("DatosClientes.txt", FileMode.Append);
                StreamWriter RW = new StreamWriter(fs);
                string DatosCliente = txtNombre.Text + "-" + txtApellido.Text + "-" + txtDNI.Text + "-" + cboxEstado.Text + "-" + cboxRelacion.Text + "-" + txtCodPr.Text;
                RW.WriteLine(DatosCliente);
                RW.Close();
                fs.Close();
            }

            if (File.Exists("DatosProyectos.txt"))
            {

                FileStream fs = new FileStream("DatosProyectos.txt", FileMode.Open);

                StreamReader sr = new StreamReader(fs);
                FileStream fs2 = new FileStream("DatosProyectosAux.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs2);
                string datas1;

                while (sr.Peek() != -1)
                {
                    datas1 = sr.ReadLine();
                    string[] datos1 = datas1.Split('-');
                    sw.WriteLine(datos1[0] + "-" + datos1[1] + "-" + datos1[2] + "-" + datos1[3] + "-" + datos1[4] + "-" + datos1[5]);

                }
                string DatosProyecto = txtNombreProyecto.Text + "-" + textBox4.Text + "-" + txtCodPr.Text + "-" + dtSuscripcion.Text + "-" + dtEntrega.Text + "-" + txtCosto.Text;
                sw.WriteLine(DatosProyecto);
                sr.Close();
                sw.Close();
                fs.Close();
                fs2.Close();
                File.Delete("DatosProyectos.txt");
                File.Move("DatosProyectosAux.txt", "DatosProyectos.txt");

            }
            else
            {
                FileStream fs = new FileStream("DatosProyectos.txt", FileMode.Append);
                StreamWriter RW = new StreamWriter(fs);
                string DatosProyecto = txtNombreProyecto.Text + "-" + textBox4.Text + "-" + txtCodPr.Text + "-" + dtSuscripcion.Text + "-" + dtEntrega.Text + "-" + txtCosto.Text;
                RW.WriteLine(DatosProyecto);
                RW.Close();
                fs.Close();
            }
        }
    }
}
