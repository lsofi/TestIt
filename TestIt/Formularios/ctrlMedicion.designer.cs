namespace TestIt.Formularios
{
    partial class ctrlMedicion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlMedicion));
            this.grdMediciones = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDetNombre = new System.Windows.Forms.TextBox();
            this.lblNombreDet = new System.Windows.Forms.Label();
            this.grpMedicion = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionDet = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.lblUnidadDet = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMediciones)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.grpMedicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdMediciones
            // 
            this.grdMediciones.AllowUserToAddRows = false;
            this.grdMediciones.AllowUserToDeleteRows = false;
            this.grdMediciones.AllowUserToResizeColumns = false;
            this.grdMediciones.AllowUserToResizeRows = false;
            this.grdMediciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMediciones.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grdMediciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMediciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMediciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMediciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colMedicion});
            this.grdMediciones.Location = new System.Drawing.Point(37, 47);
            this.grdMediciones.Margin = new System.Windows.Forms.Padding(4);
            this.grdMediciones.MultiSelect = false;
            this.grdMediciones.Name = "grdMediciones";
            this.grdMediciones.ReadOnly = true;
            this.grdMediciones.RowHeadersVisible = false;
            this.grdMediciones.RowHeadersWidth = 51;
            this.grdMediciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMediciones.Size = new System.Drawing.Size(242, 582);
            this.grdMediciones.TabIndex = 3;
            this.grdMediciones.SelectionChanged += new System.EventHandler(this.grdMediciones_SelectionChanged);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colMedicion
            // 
            this.colMedicion.HeaderText = "Medicion";
            this.colMedicion.MinimumWidth = 6;
            this.colMedicion.Name = "colMedicion";
            this.colMedicion.ReadOnly = true;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.txtNombre);
            this.grpFiltros.Controls.Add(this.lblNombre);
            this.grpFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.ForeColor = System.Drawing.Color.LightGray;
            this.grpFiltros.Location = new System.Drawing.Point(425, 55);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Size = new System.Drawing.Size(433, 107);
            this.grpFiltros.TabIndex = 6;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros de Búsqueda";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNombre.Location = new System.Drawing.Point(148, 43);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 27);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(65, 47);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 21);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::TestIt.Properties.Resources._032_cancel__Personalizado_;
            this.btnCancelar.Location = new System.Drawing.Point(810, 552);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 40);
            this.btnCancelar.TabIndex = 13;
            this.toolTip.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Image = global::TestIt.Properties.Resources._008_tick__Personalizado_;
            this.btnAceptar.Location = new System.Drawing.Point(744, 552);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(45, 40);
            this.btnAceptar.TabIndex = 12;
            this.toolTip.SetToolTip(this.btnAceptar, "Aceptar");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(556, 552);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(45, 40);
            this.btnEliminar.TabIndex = 11;
            this.toolTip.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(491, 552);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 40);
            this.btnEditar.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(425, 552);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 40);
            this.btnAgregar.TabIndex = 9;
            this.toolTip.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDetNombre
            // 
            this.txtDetNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDetNombre.Enabled = false;
            this.txtDetNombre.Location = new System.Drawing.Point(148, 41);
            this.txtDetNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetNombre.MaxLength = 20;
            this.txtDetNombre.Name = "txtDetNombre";
            this.txtDetNombre.Size = new System.Drawing.Size(197, 27);
            this.txtDetNombre.TabIndex = 9;
            // 
            // lblNombreDet
            // 
            this.lblNombreDet.AutoSize = true;
            this.lblNombreDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDet.Location = new System.Drawing.Point(65, 45);
            this.lblNombreDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDet.Name = "lblNombreDet";
            this.lblNombreDet.Size = new System.Drawing.Size(82, 21);
            this.lblNombreDet.TabIndex = 7;
            this.lblNombreDet.Text = "Nombre:";
            // 
            // grpMedicion
            // 
            this.grpMedicion.Controls.Add(this.txtDescripcion);
            this.grpMedicion.Controls.Add(this.lblDescripcionDet);
            this.grpMedicion.Controls.Add(this.txtUnidad);
            this.grpMedicion.Controls.Add(this.lblUnidadDet);
            this.grpMedicion.Controls.Add(this.txtDetNombre);
            this.grpMedicion.Controls.Add(this.lblNombreDet);
            this.grpMedicion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMedicion.ForeColor = System.Drawing.Color.LightGray;
            this.grpMedicion.Location = new System.Drawing.Point(425, 219);
            this.grpMedicion.Margin = new System.Windows.Forms.Padding(4);
            this.grpMedicion.Name = "grpMedicion";
            this.grpMedicion.Padding = new System.Windows.Forms.Padding(4);
            this.grpMedicion.Size = new System.Drawing.Size(433, 263);
            this.grpMedicion.TabIndex = 14;
            this.grpMedicion.TabStop = false;
            this.grpMedicion.Text = "Medicion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(148, 152);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(197, 73);
            this.txtDescripcion.TabIndex = 13;
            // 
            // lblDescripcionDet
            // 
            this.lblDescripcionDet.AutoSize = true;
            this.lblDescripcionDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDet.Location = new System.Drawing.Point(43, 156);
            this.lblDescripcionDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionDet.Name = "lblDescripcionDet";
            this.lblDescripcionDet.Size = new System.Drawing.Size(112, 21);
            this.lblDescripcionDet.TabIndex = 12;
            this.lblDescripcionDet.Text = "Descripción:";
            // 
            // txtUnidad
            // 
            this.txtUnidad.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUnidad.Enabled = false;
            this.txtUnidad.Location = new System.Drawing.Point(148, 96);
            this.txtUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnidad.MaxLength = 20;
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(197, 27);
            this.txtUnidad.TabIndex = 11;
            // 
            // lblUnidadDet
            // 
            this.lblUnidadDet.AutoSize = true;
            this.lblUnidadDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadDet.Location = new System.Drawing.Point(72, 100);
            this.lblUnidadDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidadDet.Name = "lblUnidadDet";
            this.lblUnidadDet.Size = new System.Drawing.Size(76, 21);
            this.lblUnidadDet.TabIndex = 10;
            this.lblUnidadDet.Text = "Unidad:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(915, 552);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 39);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ctrlMedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpMedicion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grdMediciones);
            this.Controls.Add(this.grpFiltros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlMedicion";
            this.Size = new System.Drawing.Size(1047, 677);
            this.Load += new System.EventHandler(this.ctrlMedicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMediciones)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.grpMedicion.ResumeLayout(false);
            this.grpMedicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdMediciones;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtDetNombre;
        private System.Windows.Forms.Label lblNombreDet;
        private System.Windows.Forms.GroupBox grpMedicion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcionDet;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label lblUnidadDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedicion;
        private System.Windows.Forms.Button btnVolver;
    }
}
