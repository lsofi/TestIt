namespace TestIt.Formularios
{
    partial class ctrlTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlTest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdTest = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grpTest = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionDet = new System.Windows.Forms.Label();
            this.grdMediciones = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMediciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarMediciones = new System.Windows.Forms.TextBox();
            this.btnModificarMediciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.grpTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMediciones)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTest
            // 
            this.grdTest.AllowUserToAddRows = false;
            this.grdTest.AllowUserToDeleteRows = false;
            this.grdTest.AllowUserToResizeColumns = false;
            this.grdTest.AllowUserToResizeRows = false;
            this.grdTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTest.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grdTest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTest});
            this.grdTest.Location = new System.Drawing.Point(37, 47);
            this.grdTest.Margin = new System.Windows.Forms.Padding(4);
            this.grdTest.MultiSelect = false;
            this.grdTest.Name = "grdTest";
            this.grdTest.ReadOnly = true;
            this.grdTest.RowHeadersVisible = false;
            this.grdTest.RowHeadersWidth = 51;
            this.grdTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTest.Size = new System.Drawing.Size(207, 582);
            this.grdTest.TabIndex = 3;
            this.grdTest.SelectionChanged += new System.EventHandler(this.grdTest_SelectionChanged);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colTest
            // 
            this.colTest.HeaderText = "Test";
            this.colTest.MinimumWidth = 6;
            this.colTest.Name = "colTest";
            this.colTest.ReadOnly = true;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.txtNombre);
            this.grpFiltros.Controls.Add(this.lblNombre);
            this.grpFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.ForeColor = System.Drawing.Color.LightGray;
            this.grpFiltros.Location = new System.Drawing.Point(301, 85);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Size = new System.Drawing.Size(387, 107);
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
            this.txtNombre.Size = new System.Drawing.Size(197, 23);
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
            this.lblNombre.Size = new System.Drawing.Size(65, 17);
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
            this.btnCancelar.Location = new System.Drawing.Point(643, 488);
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
            this.btnAceptar.Location = new System.Drawing.Point(575, 488);
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
            this.btnEliminar.Location = new System.Drawing.Point(434, 488);
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
            this.btnEditar.Location = new System.Drawing.Point(369, 488);
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
            this.btnAgregar.Location = new System.Drawing.Point(303, 488);
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
            this.txtDetNombre.Size = new System.Drawing.Size(197, 23);
            this.txtDetNombre.TabIndex = 9;
            // 
            // lblNombreDet
            // 
            this.lblNombreDet.AutoSize = true;
            this.lblNombreDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDet.Location = new System.Drawing.Point(65, 45);
            this.lblNombreDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDet.Name = "lblNombreDet";
            this.lblNombreDet.Size = new System.Drawing.Size(65, 17);
            this.lblNombreDet.TabIndex = 7;
            this.lblNombreDet.Text = "Nombre:";
            // 
            // grpTest
            // 
            this.grpTest.Controls.Add(this.txtDescripcion);
            this.grpTest.Controls.Add(this.lblDescripcionDet);
            this.grpTest.Controls.Add(this.txtDetNombre);
            this.grpTest.Controls.Add(this.lblNombreDet);
            this.grpTest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTest.ForeColor = System.Drawing.Color.LightGray;
            this.grpTest.Location = new System.Drawing.Point(301, 249);
            this.grpTest.Margin = new System.Windows.Forms.Padding(4);
            this.grpTest.Name = "grpTest";
            this.grpTest.Padding = new System.Windows.Forms.Padding(4);
            this.grpTest.Size = new System.Drawing.Size(387, 198);
            this.grpTest.TabIndex = 14;
            this.grpTest.TabStop = false;
            this.grpTest.Text = "Test";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(148, 89);
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
            this.lblDescripcionDet.Location = new System.Drawing.Point(43, 93);
            this.lblDescripcionDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionDet.Name = "lblDescripcionDet";
            this.lblDescripcionDet.Size = new System.Drawing.Size(87, 17);
            this.lblDescripcionDet.TabIndex = 12;
            this.lblDescripcionDet.Text = "Descripción:";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMediciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdMediciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMediciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colSeleccion,
            this.colMediciones});
            this.grdMediciones.Enabled = false;
            this.grdMediciones.Location = new System.Drawing.Point(757, 128);
            this.grdMediciones.Margin = new System.Windows.Forms.Padding(4);
            this.grdMediciones.MultiSelect = false;
            this.grdMediciones.Name = "grdMediciones";
            this.grdMediciones.ReadOnly = true;
            this.grdMediciones.RowHeadersVisible = false;
            this.grdMediciones.RowHeadersWidth = 51;
            this.grdMediciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMediciones.Size = new System.Drawing.Size(246, 450);
            this.grdMediciones.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // colSeleccion
            // 
            this.colSeleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSeleccion.HeaderText = "";
            this.colSeleccion.Name = "colSeleccion";
            this.colSeleccion.ReadOnly = true;
            this.colSeleccion.Width = 5;
            // 
            // colMediciones
            // 
            this.colMediciones.HeaderText = "Mediciones";
            this.colMediciones.MinimumWidth = 6;
            this.colMediciones.Name = "colMediciones";
            this.colMediciones.ReadOnly = true;
            // 
            // txtBuscarMediciones
            // 
            this.txtBuscarMediciones.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBuscarMediciones.Enabled = false;
            this.txtBuscarMediciones.Location = new System.Drawing.Point(757, 81);
            this.txtBuscarMediciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarMediciones.Name = "txtBuscarMediciones";
            this.txtBuscarMediciones.Size = new System.Drawing.Size(246, 22);
            this.txtBuscarMediciones.TabIndex = 16;
            this.txtBuscarMediciones.Text = "Buscar mediciones...";
            this.txtBuscarMediciones.Click += new System.EventHandler(this.txtBuscarMediciones_Click);
            this.txtBuscarMediciones.TextChanged += new System.EventHandler(this.txtBuscarMediciones_TextChanged);
            this.txtBuscarMediciones.Leave += new System.EventHandler(this.txtBuscarMediciones_Leave);
            // 
            // btnModificarMediciones
            // 
            this.btnModificarMediciones.Location = new System.Drawing.Point(797, 597);
            this.btnModificarMediciones.Name = "btnModificarMediciones";
            this.btnModificarMediciones.Size = new System.Drawing.Size(167, 32);
            this.btnModificarMediciones.TabIndex = 17;
            this.btnModificarMediciones.Text = "Modificar mediciones";
            this.btnModificarMediciones.UseVisualStyleBackColor = true;
            this.btnModificarMediciones.Click += new System.EventHandler(this.btnModificarMediciones_Click);
            // 
            // ctrlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.btnModificarMediciones);
            this.Controls.Add(this.txtBuscarMediciones);
            this.Controls.Add(this.grdMediciones);
            this.Controls.Add(this.grpTest);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grdTest);
            this.Controls.Add(this.grpFiltros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlTest";
            this.Size = new System.Drawing.Size(1047, 677);
            this.Load += new System.EventHandler(this.ctrlTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.grpTest.ResumeLayout(false);
            this.grpTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMediciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdTest;
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
        private System.Windows.Forms.GroupBox grpTest;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcionDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTest;
        private System.Windows.Forms.DataGridView grdMediciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMediciones;
        private System.Windows.Forms.TextBox txtBuscarMediciones;
        private System.Windows.Forms.Button btnModificarMediciones;
    }
}
