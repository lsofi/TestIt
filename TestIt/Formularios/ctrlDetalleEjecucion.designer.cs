namespace TestIt.Formularios
{
    partial class ctrlDetalleEjecucion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlDetalleEjecucion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumeroDet = new System.Windows.Forms.Label();
            this.grpEjecucion = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboDeportista = new System.Windows.Forms.ComboBox();
            this.cboTest = new System.Windows.Forms.ComboBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblDeportistaDet = new System.Windows.Forms.Label();
            this.grdMediciones = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMediciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEjecucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMediciones)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(801, 548);
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
            this.btnAceptar.Location = new System.Drawing.Point(733, 548);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(45, 40);
            this.btnAceptar.TabIndex = 12;
            this.toolTip.SetToolTip(this.btnAceptar, "Aceptar");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(610, 547);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 40);
            this.btnEditar.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(148, 47);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.MaxLength = 20;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(197, 23);
            this.txtNumero.TabIndex = 9;
            // 
            // lblNumeroDet
            // 
            this.lblNumeroDet.AutoSize = true;
            this.lblNumeroDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDet.Location = new System.Drawing.Point(58, 51);
            this.lblNumeroDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDet.Name = "lblNumeroDet";
            this.lblNumeroDet.Size = new System.Drawing.Size(64, 17);
            this.lblNumeroDet.TabIndex = 7;
            this.lblNumeroDet.Text = "Número:";
            // 
            // grpEjecucion
            // 
            this.grpEjecucion.Controls.Add(this.txtObservacion);
            this.grpEjecucion.Controls.Add(this.lblObservacion);
            this.grpEjecucion.Controls.Add(this.lblFecha);
            this.grpEjecucion.Controls.Add(this.dtpFecha);
            this.grpEjecucion.Controls.Add(this.cboDeportista);
            this.grpEjecucion.Controls.Add(this.cboTest);
            this.grpEjecucion.Controls.Add(this.lblTest);
            this.grpEjecucion.Controls.Add(this.txtNumero);
            this.grpEjecucion.Controls.Add(this.lblNumeroDet);
            this.grpEjecucion.Controls.Add(this.lblDeportistaDet);
            this.grpEjecucion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEjecucion.ForeColor = System.Drawing.Color.LightGray;
            this.grpEjecucion.Location = new System.Drawing.Point(98, 81);
            this.grpEjecucion.Margin = new System.Windows.Forms.Padding(4);
            this.grpEjecucion.Name = "grpEjecucion";
            this.grpEjecucion.Padding = new System.Windows.Forms.Padding(4);
            this.grpEjecucion.Size = new System.Drawing.Size(387, 351);
            this.grpEjecucion.TabIndex = 14;
            this.grpEjecucion.TabStop = false;
            this.grpEjecucion.Text = "Ejecución";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtObservacion.Enabled = false;
            this.txtObservacion.Location = new System.Drawing.Point(148, 245);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacion.MaxLength = 20;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(197, 79);
            this.txtObservacion.TabIndex = 17;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.Location = new System.Drawing.Point(32, 248);
            this.lblObservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(94, 17);
            this.lblObservacion.TabIndex = 16;
            this.lblObservacion.Text = "Observación:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(71, 198);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 17);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(148, 193);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(197, 23);
            this.dtpFecha.TabIndex = 14;
            // 
            // cboDeportista
            // 
            this.cboDeportista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDeportista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDeportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeportista.Enabled = false;
            this.cboDeportista.FormattingEnabled = true;
            this.cboDeportista.Location = new System.Drawing.Point(148, 143);
            this.cboDeportista.Name = "cboDeportista";
            this.cboDeportista.Size = new System.Drawing.Size(197, 24);
            this.cboDeportista.TabIndex = 13;
            // 
            // cboTest
            // 
            this.cboTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTest.Enabled = false;
            this.cboTest.FormattingEnabled = true;
            this.cboTest.Location = new System.Drawing.Point(148, 92);
            this.cboTest.Name = "cboTest";
            this.cboTest.Size = new System.Drawing.Size(197, 24);
            this.cboTest.TabIndex = 10;
            this.cboTest.SelectedIndexChanged += new System.EventHandler(this.cboTest_SelectedIndexChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(87, 95);
            this.lblTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 17);
            this.lblTest.TabIndex = 7;
            this.lblTest.Text = "Test:";
            // 
            // lblDeportistaDet
            // 
            this.lblDeportistaDet.AutoSize = true;
            this.lblDeportistaDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeportistaDet.Location = new System.Drawing.Point(43, 146);
            this.lblDeportistaDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeportistaDet.Name = "lblDeportistaDet";
            this.lblDeportistaDet.Size = new System.Drawing.Size(79, 17);
            this.lblDeportistaDet.TabIndex = 12;
            this.lblDeportistaDet.Text = "Deportista:";
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
            this.colMediciones,
            this.colValor,
            this.colUnidad});
            this.grdMediciones.Enabled = false;
            this.grdMediciones.Location = new System.Drawing.Point(610, 90);
            this.grdMediciones.Margin = new System.Windows.Forms.Padding(4);
            this.grdMediciones.MultiSelect = false;
            this.grdMediciones.Name = "grdMediciones";
            this.grdMediciones.RowHeadersVisible = false;
            this.grdMediciones.RowHeadersWidth = 51;
            this.grdMediciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMediciones.Size = new System.Drawing.Size(381, 413);
            this.grdMediciones.TabIndex = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVolver.Location = new System.Drawing.Point(916, 548);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 39);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colMediciones
            // 
            this.colMediciones.HeaderText = "Mediciones";
            this.colMediciones.MinimumWidth = 6;
            this.colMediciones.Name = "colMediciones";
            this.colMediciones.ReadOnly = true;
            // 
            // colValor
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colValor.DefaultCellStyle = dataGridViewCellStyle2;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            // 
            // colUnidad
            // 
            this.colUnidad.HeaderText = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.ReadOnly = true;
            // 
            // ctrlDetalleEjecucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grdMediciones);
            this.Controls.Add(this.grpEjecucion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnEditar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlDetalleEjecucion";
            this.Size = new System.Drawing.Size(1047, 677);
            this.Load += new System.EventHandler(this.ctrlDetalleEjecucion_Load);
            this.grpEjecucion.ResumeLayout(false);
            this.grpEjecucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMediciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumeroDet;
        private System.Windows.Forms.GroupBox grpEjecucion;
        private System.Windows.Forms.Label lblDeportistaDet;
        private System.Windows.Forms.DataGridView grdMediciones;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ComboBox cboTest;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboDeportista;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMediciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
    }
}
