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
using System.IO;
using FileHelpers;

namespace Proyecto_Integrador.Formularios
{
    [DelimitedRecord(";")]
    public partial class frmEmpleados : UserControl
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void CargarEmpleados()
        {
            try
            {
                FileStream FS = new FileStream("RegistroEmpleados.txt",FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                
                zDatos.Empleados.Clear();

                while (!SR.EndOfStream)
                {
                    string line = SR.ReadLine();
                    string[] values = line.Split(';');
                    EmpGral empleado = new EmpGral(values[0], values[1], values[2]);
                    zDatos.Empleados.AddLast(empleado);
                }
                SR.Close();
                FS.Close();
                dataGridView1.DataSource = zDatos.getEmpleados();
            }
            catch (Exception )
            {
                
                
            }
        }
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            string codeEmp = txtCodEmp.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            EmpGral empleado = new EmpGral(codeEmp, nombre, apellido);
            //zDatos.Empleados.AddLast(empleado);


            ///
            ///**********VALIDACIONES********
            ///

            if (File.Exists("RegistroEmpleados.txt"))
            {
                FileStream FS = new FileStream("RegistroEmpleados.txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                FileStream FS2 = new FileStream("RegistroEmpleadosAux.txt", FileMode.Append);
                StreamWriter SW = new StreamWriter(FS2);

                string linea; 

                while (SR.Peek() != -1)
                {
                    linea = SR.ReadLine();
                    string[] dato = linea.Split(';');
                    SW.WriteLine(dato[0] + ';' + dato[1] + ';' + dato[2] + ';');
                }
                string DatosEmpleado = txtCodEmp.Text +';' + txtNombre.Text + ';' + txtApellido.Text;
                SW.WriteLine(DatosEmpleado);
                SR.Close();
                SW.Close();
                FS.Close();
                FS2.Close();
                File.Delete("RegistroEmpleados.txt");
                File.Move("RegistroEmpleadosAux.txt", "RegistroEmpleados.txt");
            }
            else
            {
                FileStream FS = new FileStream("RegistroEmpleados.txt", FileMode.Append);
                StreamWriter RW = new StreamWriter(FS);
                string DatosEmpleado = txtCodEmp.Text +';'+ txtNombre.Text + ';' + txtApellido.Text;
                RW.WriteLine(DatosEmpleado);
                RW.Close();
                FS.Close();
            }


            MessageBox.Show("Empleado agregado correctamente!");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                CargarEmpleados();
                //dataGridView1.DataSource = zDatos.getEmpleados();
            }
        }
    }
}
