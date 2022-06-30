namespace Proyecto_Integrador.Formularios
{
    partial class IfrmUsuario
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxRelacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtEntrega = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtSuscripcion = new System.Windows.Forms.DateTimePicker();
            this.txtCodPr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtLenguaje = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(28, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(28, 98);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "hola"});
            this.cboxEstado.Location = new System.Drawing.Point(28, 204);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(100, 21);
            this.cboxEstado.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado";
            // 
            // cboxRelacion
            // 
            this.cboxRelacion.FormattingEnabled = true;
            this.cboxRelacion.Items.AddRange(new object[] {
            "a"});
            this.cboxRelacion.Location = new System.Drawing.Point(28, 258);
            this.cboxRelacion.Name = "cboxRelacion";
            this.cboxRelacion.Size = new System.Drawing.Size(100, 21);
            this.cboxRelacion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Relacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxRelacion);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Location = new System.Drawing.Point(99, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 322);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(28, 151);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtLenguaje);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCosto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtEntrega);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtSuscripcion);
            this.groupBox2.Controls.Add(this.txtCodPr);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNombreProyecto);
            this.groupBox2.Location = new System.Drawing.Point(308, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 322);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proyecto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Descripcion Breve";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(48, 98);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(160, 182);
            this.txtDescripcion.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Costo Final Proyecto";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(254, 258);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(138, 20);
            this.txtCosto.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha Entrega Estimada";
            // 
            // dtEntrega
            // 
            this.dtEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntrega.Location = new System.Drawing.Point(254, 206);
            this.dtEntrega.Name = "dtEntrega";
            this.dtEntrega.Size = new System.Drawing.Size(135, 20);
            this.dtEntrega.TabIndex = 6;
            this.dtEntrega.Value = new System.DateTime(2022, 6, 30, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha Suscripcion";
            this.label7.Visible = false;
            // 
            // dtSuscripcion
            // 
            this.dtSuscripcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSuscripcion.Location = new System.Drawing.Point(254, 151);
            this.dtSuscripcion.Name = "dtSuscripcion";
            this.dtSuscripcion.Size = new System.Drawing.Size(135, 20);
            this.dtSuscripcion.TabIndex = 4;
            this.dtSuscripcion.Value = new System.DateTime(2022, 6, 30, 8, 42, 38, 0);
            // 
            // txtCodPr
            // 
            this.txtCodPr.Location = new System.Drawing.Point(254, 45);
            this.txtCodPr.Name = "txtCodPr";
            this.txtCodPr.Size = new System.Drawing.Size(135, 20);
            this.txtCodPr.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Codigo Proyecto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre Proyecto";
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Location = new System.Drawing.Point(48, 45);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(160, 20);
            this.txtNombreProyecto.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(637, 413);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 23);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtLenguaje
            // 
            this.txtLenguaje.Location = new System.Drawing.Point(254, 98);
            this.txtLenguaje.Name = "txtLenguaje";
            this.txtLenguaje.Size = new System.Drawing.Size(135, 20);
            this.txtLenguaje.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Lenguaje de Programacion";
            // 
            // IfrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IfrmUsuario";
            this.Size = new System.Drawing.Size(839, 494);
            this.Load += new System.EventHandler(this.IfrmUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxRelacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtEntrega;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtSuscripcion;
        private System.Windows.Forms.TextBox txtCodPr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLenguaje;
    }
}
