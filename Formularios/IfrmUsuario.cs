using Proyecto_Integrador.Clases;
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
    public partial class IfrmUsuario : UserControl
    {
        public IfrmUsuario()
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
            
            DateTime dateTime = DateTime.Now;
            string fechaSuscr = dateTime.ToString();
            string fechaEntr = dtEntrega.Value.ToString();
            string descripcion = txtDescripcion.Text;
            string costo = txtCosto.Text;
            string lang = cboxLenguaje.SelectedText;

            

            Cliente cliente = new Cliente(nombre, apellido,dni, estado, relacion);
            Proyectos proyecto = new Proyectos(nombreProyecto, cod_proy, fechaSuscr, costo, fechaEntr, lang);
            cliente.Proyect = proyecto;


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
                    string[] datos2 = datas2.Split(';');
                    sw.WriteLine(datos2[0] + ";" + datos2[1] + ";" + datos2[2] + ";" + datos2[3] + ";" + datos2[4] + ";" + datos2[5]);
                }
                string Datoscliente = txtNombre.Text + ";" + txtApellido.Text + ";" + txtDNI.Text + ";" + cboxEstado.Text + ";" + cboxRelacion.Text + ";" + txtCodPr.Text;
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
                string DatosCliente = txtNombre.Text + ";" + txtApellido.Text + ";" + txtDNI.Text + ";" + cboxEstado.Text + ";" + cboxRelacion.Text + ";" + txtCodPr.Text;
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
                    string[] datos1 = datas1.Split(';');
                    sw.WriteLine(datos1[0] + ";" + datos1[1] + ";" + datos1[2] + ";" + datos1[3] + ";" + datos1[4] + ";" + datos1[5]);

                }
                string DatosProyecto = txtNombreProyecto.Text + ";" + txtCodPr.Text + ";" + txtFechaInicio.Text + ";" + txtCosto.Text + ";" + dtEntrega.Text + ";" + cboxLenguaje.SelectedText; 
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
                string DatosProyecto = txtNombreProyecto.Text + ";" + txtCodPr.Text + ";" + txtFechaInicio.Text+ ";" + txtCosto.Text + ";" + dtEntrega.Text + ";" + cboxLenguaje.SelectedText;
                RW.WriteLine(DatosProyecto);
                RW.Close();
                fs.Close();
            }
        }

        private void IfrmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream FS = new FileStream("DatosProyectos.txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);
            
                int contador = 0;
                while (!SR.EndOfStream)
                {
                    SR.ReadLine();
                    if (SR.EndOfStream == false)
                    {
                        contador++;
                    }
                }
                contador += 2;
                txtCodPr.Text = "0" + contador.ToString();
                SR.Close();
                FS.Close();
            }
            catch (Exception)
            {
                txtCodPr.Text = "01";
            }
            

            //contador += 1;

            txtFechaInicio.Text = DateTime.Now.ToShortDateString();

            string[] estado = { "Nuevo", "Frecuente"};
            for (int i = 0; i < estado.Length; i++)
            {
                cboxEstado.Items.Add(estado[i]);
            }
            cboxEstado.SelectedIndex = 0;

            string[] relacion = { "Buena", "Neutral", "Mala"};
            for (int i = 0; i < relacion.Length; i++)
            {
                cboxRelacion.Items.Add(relacion[i]);
            }
            cboxRelacion.SelectedIndex = 0;

            string[] lenguaje = {"Python","Flutter","C","C++","C#","F#","Java","JavaScript"};
            for (int i = 0; i < lenguaje.Length; i++) 
            { 
                cboxLenguaje.Items.Add(lenguaje[i]);
            } 
            cboxLenguaje.SelectedIndex = 4;
        }
    }
}
