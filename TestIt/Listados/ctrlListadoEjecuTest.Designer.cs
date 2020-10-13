namespace TestIt.Listados
{
    partial class ctrlListadoEjecuTest
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
            this.dataSetListadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetListados = new TestIt.DataSets.DataSetListados();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.cboTest = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.rpvEjecuciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EjecucionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListados)).BeginInit();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EjecucionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetListadosBindingSource
            // 
            this.dataSetListadosBindingSource.DataSource = this.dataSetListados;
            this.dataSetListadosBindingSource.Position = 0;
            // 
            // dataSetListados
            // 
            this.dataSetListados.DataSetName = "DataSetListados";
            this.dataSetListados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.lblTest);
            this.grpFiltros.Controls.Add(this.cboTest);
            this.grpFiltros.Controls.Add(this.btnFiltrar);
            this.grpFiltros.Controls.Add(this.dtpHasta);
            this.grpFiltros.Controls.Add(this.lblFechaHasta);
            this.grpFiltros.Controls.Add(this.dtpDesde);
            this.grpFiltros.Controls.Add(this.lblFechaDesde);
            this.grpFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.ForeColor = System.Drawing.Color.LightGray;
            this.grpFiltros.Location = new System.Drawing.Point(28, 204);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Size = new System.Drawing.Size(287, 244);
            this.grpFiltros.TabIndex = 7;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(77, 141);
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
            this.cboTest.Location = new System.Drawing.Point(128, 138);
            this.cboTest.Name = "cboTest";
            this.cboTest.Size = new System.Drawing.Size(138, 24);
            this.cboTest.TabIndex = 19;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFiltrar.Location = new System.Drawing.Point(86, 200);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(114, 23);
            this.btnFiltrar.TabIndex = 18;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(128, 85);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(138, 23);
            this.dtpHasta.TabIndex = 15;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(21, 88);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(91, 17);
            this.lblFechaHasta.TabIndex = 14;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(128, 39);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(138, 23);
            this.dtpDesde.TabIndex = 13;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(21, 42);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(94, 17);
            this.lblFechaDesde.TabIndex = 12;
            this.lblFechaDesde.Text = "Fecha desde:";
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
            this.rpvEjecuciones.LocalReport.ReportEmbeddedResource = "TestIt.Listados.repEjecuTestListado.rdlc";
            this.rpvEjecuciones.Location = new System.Drawing.Point(341, 33);
            this.rpvEjecuciones.Name = "rpvEjecuciones";
            this.rpvEjecuciones.ServerReport.BearerToken = null;
            this.rpvEjecuciones.Size = new System.Drawing.Size(680, 616);
            this.rpvEjecuciones.TabIndex = 20;
            // 
            // ctrlListadoEjecuTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.rpvEjecuciones);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpFiltros);
            this.Name = "ctrlListadoEjecuTest";
            this.Size = new System.Drawing.Size(1047, 677);
            this.Load += new System.EventHandler(this.ctrlListadoEjecuTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListados)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EjecucionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource dataSetTestItBindingSource;
        private System.Windows.Forms.BindingSource EjecucionesBindingSource;
        private System.Windows.Forms.BindingSource dataSetListadosBindingSource;
        private DataSets.DataSetListados dataSetListados;
        private Microsoft.Reporting.WinForms.ReportViewer rpvEjecuciones;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ComboBox cboTest;
    }
}
