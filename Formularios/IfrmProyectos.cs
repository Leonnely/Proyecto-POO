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
    public partial class IfrmProyectos : UserControl
    {
        public IfrmProyectos()
        {
            InitializeComponent();
        }

        private void frmProyectos_Load(object sender, EventArgs e)
        {
            try
            {   
                FileStream FScl = new FileStream("DatosClientes.txt", FileMode.Open);
                StreamReader SRcl = new StreamReader(FScl);

                FileStream FS = new FileStream("DatosProyectos.txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);

                zDatos.Proyectos.Clear();

                while (!SRcl.EndOfStream)
                {
                    string line = SRcl.ReadLine();
                    string[] values = line.Split(';');
                    Cliente client = new Cliente(values[0], values[1], values[2], values[3], values[4]);
                   

                    //while (!SR.EndOfStream)
                    //{
                        string lineProyecto = SR.ReadLine();
                        string[] valuesProyecto = lineProyecto.Split(';');
                        client.Proyect = new Proyectos(valuesProyecto[0], valuesProyecto[1], valuesProyecto[2], valuesProyecto[3], valuesProyecto[4], valuesProyecto[5]);
                        
                        int n = dataGridView1.Rows.Add();   
                        dataGridView1.Rows[n].Cells[0].Value = client.DNI;
                        dataGridView1.Rows[n].Cells[1].Value = client.Nombre;
                        dataGridView1.Rows[n].Cells[2].Value = client.Proyect.CodeProyect;
                        dataGridView1.Rows[n].Cells[3].Value = client.Proyect.Nombre;
                       
                        //zDatos.Proyectos.AddLast(client.Proyect);
                        //zDatos.Clientes.AddLast(client);
                    //}
                     
                }
                
                SR.Close();
                FS.Close();
                SRcl.Close();
                FScl.Close();

                //dataGridView1.DataSource = zDatos.getClientes();

            }
            catch (Exception)
            {


            }
        }
    }
}
