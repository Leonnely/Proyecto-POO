namespace Proyecto_Integrador.Formularios
{
    partial class IfrmProyectos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEncargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNICliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEncargado,
            this.colDNICliente,
            this.colNombre,
            this.colPrCode,
            this.colPr,
            this.clFechaInicio,
            this.clFechaEntrega,
            this.clCosto});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 543);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEncargado
            // 
            this.btnEncargado.HeaderText = "Encargado Proyecto";
            this.btnEncargado.Name = "btnEncargado";
            this.btnEncargado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEncargado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDNICliente
            // 
            this.colDNICliente.HeaderText = "DNI Cliente";
            this.colDNICliente.Name = "colDNICliente";
            this.colDNICliente.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre Cliente";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colPrCode
            // 
            this.colPrCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrCode.HeaderText = "Codigo Proyecto";
            this.colPrCode.Name = "colPrCode";
            this.colPrCode.ReadOnly = true;
            this.colPrCode.Width = 101;
            // 
            // colPr
            // 
            this.colPr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPr.HeaderText = "Nombre Proyecto";
            this.colPr.Name = "colPr";
            this.colPr.ReadOnly = true;
            this.colPr.Width = 105;
            // 
            // clFechaInicio
            // 
            this.clFechaInicio.HeaderText = "Fecha de Inicio";
            this.clFechaInicio.Name = "clFechaInicio";
            // 
            // clFechaEntrega
            // 
            this.clFechaEntrega.HeaderText = "Fecha de Entrega";
            this.clFechaEntrega.Name = "clFechaEntrega";
            // 
            // clCosto
            // 
            this.clCosto.HeaderText = "Costo de Proyecto";
            this.clCosto.Name = "clCosto";
            // 
            // IfrmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "IfrmProyectos";
            this.Size = new System.Drawing.Size(840, 543);
            this.Load += new System.EventHandler(this.frmProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnEncargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNICliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCosto;
    }
}
