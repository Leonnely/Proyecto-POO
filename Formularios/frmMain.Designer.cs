
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
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.Empleados = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 89);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.panel4.Controls.Add(this.btnAcercaDe);
            this.panel4.Controls.Add(this.btnProyectos);
            this.panel4.Controls.Add(this.Empleados);
            this.panel4.Controls.Add(this.btnRegistrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 532);
            this.panel4.TabIndex = 4;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.BackColor = System.Drawing.Color.Transparent;
            this.btnAcercaDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcercaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(126)))), ((int)(((byte)(173)))));
            this.btnAcercaDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.Color.White;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 210);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(168, 70);
            this.btnAcercaDe.TabIndex = 3;
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnProyectos
            // 
            this.btnProyectos.BackColor = System.Drawing.Color.Transparent;
            this.btnProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProyectos.FlatAppearance.BorderSize = 0;
            this.btnProyectos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(126)))), ((int)(((byte)(173)))));
            this.btnProyectos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectos.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectos.ForeColor = System.Drawing.Color.White;
            this.btnProyectos.Location = new System.Drawing.Point(0, 140);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(168, 70);
            this.btnProyectos.TabIndex = 2;
            this.btnProyectos.Text = "Proyectos";
            this.btnProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyectos.UseVisualStyleBackColor = false;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // Empleados
            // 
            this.Empleados.BackColor = System.Drawing.Color.Transparent;
            this.Empleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.Empleados.FlatAppearance.BorderSize = 0;
            this.Empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(126)))), ((int)(((byte)(173)))));
            this.Empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empleados.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleados.ForeColor = System.Drawing.Color.White;
            this.Empleados.Location = new System.Drawing.Point(0, 70);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(168, 70);
            this.Empleados.TabIndex = 1;
            this.Empleados.Text = "Empleados";
            this.Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empleados.UseVisualStyleBackColor = false;
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(126)))), ((int)(((byte)(173)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(168, 70);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar Servicio";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(126)))), ((int)(((byte)(173)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(168, 89);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1021, 532);
            this.panelContenedor.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 621);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.Button btnAcercaDe;
    }
}

