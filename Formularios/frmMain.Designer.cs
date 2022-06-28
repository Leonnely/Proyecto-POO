
namespace Proyecto_Integrador
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.Empleados = new System.Windows.Forms.Button();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 66);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.panel4.Controls.Add(this.btnProyectos);
            this.panel4.Controls.Add(this.Empleados);
            this.panel4.Controls.Add(this.btnRegistrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 521);
            this.panel4.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(152, 63);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar Servicio";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.UseWaitCursor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Silver;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(152, 66);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(849, 521);
            this.panelContenedor.TabIndex = 5;
            // 
            // Empleados
            // 
            this.Empleados.BackColor = System.Drawing.Color.Transparent;
            this.Empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.Empleados.FlatAppearance.BorderSize = 0;
            this.Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empleados.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleados.ForeColor = System.Drawing.Color.White;
            this.Empleados.Location = new System.Drawing.Point(0, 63);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(152, 63);
            this.Empleados.TabIndex = 1;
            this.Empleados.Text = "Empleados";
            this.Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empleados.UseVisualStyleBackColor = false;
            this.Empleados.UseWaitCursor = true;
            // 
            // btnProyectos
            // 
            this.btnProyectos.BackColor = System.Drawing.Color.Transparent;
            this.btnProyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProyectos.FlatAppearance.BorderSize = 0;
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectos.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectos.ForeColor = System.Drawing.Color.White;
            this.btnProyectos.Location = new System.Drawing.Point(0, 126);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(152, 63);
            this.btnProyectos.TabIndex = 2;
            this.btnProyectos.Text = "Proyectos";
            this.btnProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyectos.UseVisualStyleBackColor = false;
            this.btnProyectos.UseWaitCursor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 587);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnProyectos;
        private System.Windows.Forms.Button Empleados;
    }
}

