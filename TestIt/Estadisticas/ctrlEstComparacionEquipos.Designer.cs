namespace TestIt.Estadisticas
{
    partial class ctrlEstComparacionEquipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.grdEquipos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTest = new System.Windows.Forms.Label();
            this.cboTest = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtpAnio = new System.Windows.Forms.DateTimePicker();
            this.lblAnio = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.rpvEjecuciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpMes = new System.Windows.Forms.DateTimePicker();
            this.lblMes = new System.Windows.Forms.Label();
            this.dataSetEstadisticas = new TestIt.DataSets.DataSetEstadisticas();
            this.ejecEquiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejecEquiposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.lblMes);
            this.grpFiltros.Controls.Add(this.dtpMes);
            this.grpFiltros.Controls.Add(this.grdEquipos);
            this.grpFiltros.Controls.Add(this.lblTest);
            this.grpFiltros.Controls.Add(this.cboTest);
            this.grpFiltros.Controls.Add(this.btnFiltrar);
            this.grpFiltros.Controls.Add(this.dtpAnio);
            this.grpFiltros.Controls.Add(this.lblAnio);
            this.grpFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.ForeColor = System.Drawing.Color.LightGray;
            this.grpFiltros.Location = new System.Drawing.Point(28, 33);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Size = new System.Drawing.Size(283, 560);
            this.grpFiltros.TabIndex = 7;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // grdEquipos
            // 
            this.grdEquipos.AllowUserToAddRows = false;
            this.grdEquipos.AllowUserToDeleteRows = false;
            this.grdEquipos.AllowUserToResizeColumns = false;
            this.grdEquipos.AllowUserToResizeRows = false;
            this.grdEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEquipos.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grdEquipos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.equipoCol,
            this.colCheck});
            this.grdEquipos.Location = new System.Drawing.Point(24, 185);
            this.grdEquipos.Margin = new System.Windows.Forms.Padding(4);
            this.grdEquipos.MultiSelect = false;
            this.grdEquipos.Name = "grdEquipos";
            this.grdEquipos.ReadOnly = true;
            this.grdEquipos.RowHeadersVisible = false;
            this.grdEquipos.RowHeadersWidth = 51;
            this.grdEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEquipos.Size = new System.Drawing.Size(242, 286);
            this.grdEquipos.TabIndex = 23;
            this.grdEquipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEquipos_CellClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // equipoCol
            // 
            this.equipoCol.HeaderText = "Equipo";
            this.equipoCol.MinimumWidth = 6;
            this.equipoCol.Name = "equipoCol";
            this.equipoCol.ReadOnly = true;
            // 
            // colCheck
            // 
            this.colCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCheck.HeaderText = "";
            this.colCheck.Name = "colCheck";
            this.colCheck.ReadOnly = true;
            this.colCheck.Width = 5;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(77, 131);
            this.lblTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 17);
            this.lblTest.TabIndex = 20;
            this.lblTest.Text = "Test:";
            // 
            // cboTest
            // 
            this.cboTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTest.FormattingEnabled = true;
            this.cboTest.Location = new System.Drawing.Point(128, 128);
            this.cboTest.Name = "cboTest";
            this.cboTest.Size = new System.Drawing.Size(138, 24);
            this.cboTest.TabIndex = 19;
            this.cboTest.SelectedIndexChanged += new System.EventHandler(this.cboTest_SelectedIndexChanged_1);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFiltrar.Location = new System.Drawing.Point(86, 520);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(114, 23);
            this.btnFiltrar.TabIndex = 18;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // dtpAnio
            // 
            this.dtpAnio.CustomFormat = "yyyy";
            this.dtpAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnio.Location = new System.Drawing.Point(128, 85);
            this.dtpAnio.Name = "dtpAnio";
            this.dtpAnio.Size = new System.Drawing.Size(138, 23);
            this.dtpAnio.TabIndex = 15;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(74, 88);
            this.lblAnio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(38, 17);
            this.lblAnio.TabIndex = 14;
            this.lblAnio.Text = "Año:";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVolver.Location = new System.Drawing.Point(114, 621);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 28);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // rpvEjecuciones
            // 
            this.rpvEjecuciones.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.ejecEquiposBindingSource, "id_equipo", true));
            this.rpvEjecuciones.LocalReport.ReportEmbeddedResource = "TestIt.Estadisticas.repComparacionEquipos.rdlc";
            this.rpvEjecuciones.Location = new System.Drawing.Point(341, 33);
            this.rpvEjecuciones.Name = "rpvEjecuciones";
            this.rpvEjecuciones.ServerReport.BearerToken = null;
            this.rpvEjecuciones.Size = new System.Drawing.Size(680, 616);
            this.rpvEjecuciones.TabIndex = 20;
            // 
            // dtpMes
            // 
            this.dtpMes.CustomFormat = "MM";
            this.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMes.Location = new System.Drawing.Point(128, 41);
            this.dtpMes.Name = "dtpMes";
            this.dtpMes.Size = new System.Drawing.Size(138, 23);
            this.dtpMes.TabIndex = 24;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(74, 46);
            this.lblMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(36, 17);
            this.lblMes.TabIndex = 25;
            this.lblMes.Text = "Mes:";
            // 
            // dataSetEstadisticas
            // 
            this.dataSetEstadisticas.DataSetName = "DataSetEstadisticas";
            this.dataSetEstadisticas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejecEquiposBindingSource
            // 
            this.ejecEquiposBindingSource.DataMember = "EjecEquipos";
            this.ejecEquiposBindingSource.DataSource = this.dataSetEstadisticas;
            // 
            // ctrlEstComparacionEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.rpvEjecuciones);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpFiltros);
            this.Name = "ctrlEstComparacionEquipos";
            this.Size = new System.Drawing.Size(1047, 677);
            this.Load += new System.EventHandler(this.ctrlEstComparacionEquipos_Load);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejecEquiposBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker dtpAnio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource dataSetTestItBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rpvEjecuciones;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ComboBox cboTest;
        private System.Windows.Forms.DataGridView grdEquipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.DateTimePicker dtpMes;
        private System.Windows.Forms.BindingSource ejecEquiposBindingSource;
        private DataSets.DataSetEstadisticas dataSetEstadisticas;
    }
}
