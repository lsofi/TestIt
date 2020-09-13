namespace TestIt.Formularios
{
    partial class ctrlDeportistas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDeportistas = new System.Windows.Forms.DataGridView();
            this.deportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.txtEquipo = new System.Windows.Forms.ComboBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboDeporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpEdicion = new System.Windows.Forms.GroupBox();
            this.dtpDetNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNacimientoDet = new System.Windows.Forms.Label();
            this.cboDetCategoria = new System.Windows.Forms.ComboBox();
            this.cboDetEquipo = new System.Windows.Forms.ComboBox();
            this.cboDetDeporte = new System.Windows.Forms.ComboBox();
            this.cboDetSexo = new System.Windows.Forms.ComboBox();
            this.lblSexoDet = new System.Windows.Forms.Label();
            this.lblPesoDet = new System.Windows.Forms.Label();
            this.lblAlturaDet = new System.Windows.Forms.Label();
            this.txtDetApellido = new System.Windows.Forms.TextBox();
            this.lblApellidoDet = new System.Windows.Forms.Label();
            this.lblDNIDet = new System.Windows.Forms.Label();
            this.txtDetPeso = new System.Windows.Forms.TextBox();
            this.txtDetAltura = new System.Windows.Forms.TextBox();
            this.txtDetDNI = new System.Windows.Forms.TextBox();
            this.txtDetNombre = new System.Windows.Forms.TextBox();
            this.lblEquipoDet = new System.Windows.Forms.Label();
            this.lblCategoriaDet = new System.Windows.Forms.Label();
            this.lblDeporteDet = new System.Windows.Forms.Label();
            this.lblNombreDet = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdDeportistas)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.grpEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDeportistas
            // 
            this.grdDeportistas.AllowUserToAddRows = false;
            this.grdDeportistas.AllowUserToDeleteRows = false;
            this.grdDeportistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDeportistas.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grdDeportistas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDeportistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDeportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeportistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deportista});
            this.grdDeportistas.Location = new System.Drawing.Point(37, 47);
            this.grdDeportistas.Margin = new System.Windows.Forms.Padding(4);
            this.grdDeportistas.MultiSelect = false;
            this.grdDeportistas.Name = "grdDeportistas";
            this.grdDeportistas.ReadOnly = true;
            this.grdDeportistas.RowHeadersVisible = false;
            this.grdDeportistas.RowHeadersWidth = 51;
            this.grdDeportistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDeportistas.Size = new System.Drawing.Size(242, 582);
            this.grdDeportistas.TabIndex = 3;
            // 
            // deportista
            // 
            this.deportista.HeaderText = "Deportista";
            this.deportista.MinimumWidth = 6;
            this.deportista.Name = "deportista";
            this.deportista.ReadOnly = true;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.txtEquipo);
            this.grpFiltros.Controls.Add(this.lblEquipo);
            this.grpFiltros.Controls.Add(this.txtCategoria);
            this.grpFiltros.Controls.Add(this.lblCategoria);
            this.grpFiltros.Controls.Add(this.cboDeporte);
            this.grpFiltros.Controls.Add(this.label1);
            this.grpFiltros.Controls.Add(this.txtNombre);
            this.grpFiltros.Controls.Add(this.lblNombre);
            this.grpFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.ForeColor = System.Drawing.Color.LightGray;
            this.grpFiltros.Location = new System.Drawing.Point(316, 47);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Size = new System.Drawing.Size(695, 161);
            this.grpFiltros.TabIndex = 6;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros de Búsqueda";
            // 
            // txtEquipo
            // 
            this.txtEquipo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEquipo.FormattingEnabled = true;
            this.txtEquipo.Location = new System.Drawing.Point(455, 56);
            this.txtEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(197, 24);
            this.txtEquipo.TabIndex = 15;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(373, 59);
            this.lblEquipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(57, 17);
            this.lblEquipo.TabIndex = 14;
            this.lblEquipo.Text = "Equipo:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.Location = new System.Drawing.Point(455, 101);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(197, 24);
            this.txtCategoria.TabIndex = 13;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(351, 105);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(79, 17);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cboDeporte
            // 
            this.cboDeporte.BackColor = System.Drawing.SystemColors.Menu;
            this.cboDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeporte.FormattingEnabled = true;
            this.cboDeporte.Location = new System.Drawing.Point(116, 101);
            this.cboDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeporte.Name = "cboDeporte";
            this.cboDeporte.Size = new System.Drawing.Size(197, 24);
            this.cboDeporte.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Deporte:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNombre.Location = new System.Drawing.Point(116, 55);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 23);
            this.txtNombre.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(33, 59);
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
            // grpEdicion
            // 
            this.grpEdicion.Controls.Add(this.dtpDetNacimiento);
            this.grpEdicion.Controls.Add(this.lblNacimientoDet);
            this.grpEdicion.Controls.Add(this.cboDetCategoria);
            this.grpEdicion.Controls.Add(this.cboDetEquipo);
            this.grpEdicion.Controls.Add(this.cboDetDeporte);
            this.grpEdicion.Controls.Add(this.cboDetSexo);
            this.grpEdicion.Controls.Add(this.lblSexoDet);
            this.grpEdicion.Controls.Add(this.lblPesoDet);
            this.grpEdicion.Controls.Add(this.lblAlturaDet);
            this.grpEdicion.Controls.Add(this.txtDetApellido);
            this.grpEdicion.Controls.Add(this.lblApellidoDet);
            this.grpEdicion.Controls.Add(this.lblDNIDet);
            this.grpEdicion.Controls.Add(this.txtDetPeso);
            this.grpEdicion.Controls.Add(this.txtDetAltura);
            this.grpEdicion.Controls.Add(this.txtDetDNI);
            this.grpEdicion.Controls.Add(this.txtDetNombre);
            this.grpEdicion.Controls.Add(this.lblEquipoDet);
            this.grpEdicion.Controls.Add(this.lblCategoriaDet);
            this.grpEdicion.Controls.Add(this.lblDeporteDet);
            this.grpEdicion.Controls.Add(this.lblNombreDet);
            this.grpEdicion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEdicion.ForeColor = System.Drawing.Color.LightGray;
            this.grpEdicion.Location = new System.Drawing.Point(316, 253);
            this.grpEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.grpEdicion.Name = "grpEdicion";
            this.grpEdicion.Padding = new System.Windows.Forms.Padding(4);
            this.grpEdicion.Size = new System.Drawing.Size(695, 299);
            this.grpEdicion.TabIndex = 8;
            this.grpEdicion.TabStop = false;
            this.grpEdicion.Text = "Deportista";
            // 
            // dtpDetNacimiento
            // 
            this.dtpDetNacimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDetNacimiento.Enabled = false;
            this.dtpDetNacimiento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDetNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDetNacimiento.Location = new System.Drawing.Point(455, 91);
            this.dtpDetNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDetNacimiento.Name = "dtpDetNacimiento";
            this.dtpDetNacimiento.Size = new System.Drawing.Size(197, 22);
            this.dtpDetNacimiento.TabIndex = 32;
            // 
            // lblNacimientoDet
            // 
            this.lblNacimientoDet.AutoSize = true;
            this.lblNacimientoDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimientoDet.Location = new System.Drawing.Point(342, 94);
            this.lblNacimientoDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacimientoDet.Name = "lblNacimientoDet";
            this.lblNacimientoDet.Size = new System.Drawing.Size(88, 17);
            this.lblNacimientoDet.TabIndex = 31;
            this.lblNacimientoDet.Text = "Nacimiento:";
            // 
            // cboDetCategoria
            // 
            this.cboDetCategoria.BackColor = System.Drawing.SystemColors.Menu;
            this.cboDetCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDetCategoria.Enabled = false;
            this.cboDetCategoria.FormattingEnabled = true;
            this.cboDetCategoria.Location = new System.Drawing.Point(455, 237);
            this.cboDetCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cboDetCategoria.Name = "cboDetCategoria";
            this.cboDetCategoria.Size = new System.Drawing.Size(197, 24);
            this.cboDetCategoria.TabIndex = 30;
            // 
            // cboDetEquipo
            // 
            this.cboDetEquipo.BackColor = System.Drawing.SystemColors.Menu;
            this.cboDetEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDetEquipo.Enabled = false;
            this.cboDetEquipo.FormattingEnabled = true;
            this.cboDetEquipo.Location = new System.Drawing.Point(455, 187);
            this.cboDetEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.cboDetEquipo.Name = "cboDetEquipo";
            this.cboDetEquipo.Size = new System.Drawing.Size(197, 24);
            this.cboDetEquipo.TabIndex = 29;
            // 
            // cboDetDeporte
            // 
            this.cboDetDeporte.BackColor = System.Drawing.SystemColors.Menu;
            this.cboDetDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDetDeporte.Enabled = false;
            this.cboDetDeporte.FormattingEnabled = true;
            this.cboDetDeporte.Location = new System.Drawing.Point(455, 138);
            this.cboDetDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.cboDetDeporte.Name = "cboDetDeporte";
            this.cboDetDeporte.Size = new System.Drawing.Size(197, 24);
            this.cboDetDeporte.TabIndex = 28;
            // 
            // cboDetSexo
            // 
            this.cboDetSexo.BackColor = System.Drawing.SystemColors.Menu;
            this.cboDetSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDetSexo.Enabled = false;
            this.cboDetSexo.FormattingEnabled = true;
            this.cboDetSexo.Location = new System.Drawing.Point(116, 91);
            this.cboDetSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cboDetSexo.Name = "cboDetSexo";
            this.cboDetSexo.Size = new System.Drawing.Size(197, 24);
            this.cboDetSexo.TabIndex = 27;
            // 
            // lblSexoDet
            // 
            this.lblSexoDet.AutoSize = true;
            this.lblSexoDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoDet.Location = new System.Drawing.Point(57, 94);
            this.lblSexoDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexoDet.Name = "lblSexoDet";
            this.lblSexoDet.Size = new System.Drawing.Size(41, 17);
            this.lblSexoDet.TabIndex = 26;
            this.lblSexoDet.Text = "Sexo:";
            // 
            // lblPesoDet
            // 
            this.lblPesoDet.AutoSize = true;
            this.lblPesoDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoDet.Location = new System.Drawing.Point(56, 240);
            this.lblPesoDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesoDet.Name = "lblPesoDet";
            this.lblPesoDet.Size = new System.Drawing.Size(42, 17);
            this.lblPesoDet.TabIndex = 24;
            this.lblPesoDet.Text = "Peso:";
            // 
            // lblAlturaDet
            // 
            this.lblAlturaDet.AutoSize = true;
            this.lblAlturaDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlturaDet.Location = new System.Drawing.Point(48, 190);
            this.lblAlturaDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlturaDet.Name = "lblAlturaDet";
            this.lblAlturaDet.Size = new System.Drawing.Size(50, 17);
            this.lblAlturaDet.TabIndex = 23;
            this.lblAlturaDet.Text = "Altura:";
            // 
            // txtDetApellido
            // 
            this.txtDetApellido.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDetApellido.Enabled = false;
            this.txtDetApellido.Location = new System.Drawing.Point(455, 47);
            this.txtDetApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetApellido.Name = "txtDetApellido";
            this.txtDetApellido.Size = new System.Drawing.Size(197, 23);
            this.txtDetApellido.TabIndex = 22;
            // 
            // lblApellidoDet
            // 
            this.lblApellidoDet.AutoSize = true;
            this.lblApellidoDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoDet.Location = new System.Drawing.Point(365, 54);
            this.lblApellidoDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoDet.Name = "lblApellidoDet";
            this.lblApellidoDet.Size = new System.Drawing.Size(65, 17);
            this.lblApellidoDet.TabIndex = 21;
            this.lblApellidoDet.Text = "Apellido:";
            // 
            // lblDNIDet
            // 
            this.lblDNIDet.AutoSize = true;
            this.lblDNIDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIDet.Location = new System.Drawing.Point(63, 141);
            this.lblDNIDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNIDet.Name = "lblDNIDet";
            this.lblDNIDet.Size = new System.Drawing.Size(35, 17);
            this.lblDNIDet.TabIndex = 20;
            this.lblDNIDet.Text = "DNI:";
            // 
            // txtDetPeso
            // 
            this.txtDetPeso.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDetPeso.Enabled = false;
            this.txtDetPeso.Location = new System.Drawing.Point(116, 237);
            this.txtDetPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetPeso.Name = "txtDetPeso";
            this.txtDetPeso.Size = new System.Drawing.Size(197, 23);
            this.txtDetPeso.TabIndex = 19;
            // 
            // txtDetAltura
            // 
            this.txtDetAltura.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDetAltura.Enabled = false;
            this.txtDetAltura.Location = new System.Drawing.Point(116, 187);
            this.txtDetAltura.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetAltura.Name = "txtDetAltura";
            this.txtDetAltura.Size = new System.Drawing.Size(197, 23);
            this.txtDetAltura.TabIndex = 18;
            // 
            // txtDetDNI
            // 
            this.txtDetDNI.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDetDNI.Enabled = false;
            this.txtDetDNI.Location = new System.Drawing.Point(116, 138);
            this.txtDetDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetDNI.Name = "txtDetDNI";
            this.txtDetDNI.Size = new System.Drawing.Size(197, 23);
            this.txtDetDNI.TabIndex = 17;
            // 
            // txtDetNombre
            // 
            this.txtDetNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDetNombre.Enabled = false;
            this.txtDetNombre.Location = new System.Drawing.Point(116, 47);
            this.txtDetNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetNombre.Name = "txtDetNombre";
            this.txtDetNombre.Size = new System.Drawing.Size(197, 23);
            this.txtDetNombre.TabIndex = 16;
            // 
            // lblEquipoDet
            // 
            this.lblEquipoDet.AutoSize = true;
            this.lblEquipoDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoDet.Location = new System.Drawing.Point(373, 190);
            this.lblEquipoDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipoDet.Name = "lblEquipoDet";
            this.lblEquipoDet.Size = new System.Drawing.Size(57, 17);
            this.lblEquipoDet.TabIndex = 14;
            this.lblEquipoDet.Text = "Equipo:";
            // 
            // lblCategoriaDet
            // 
            this.lblCategoriaDet.AutoSize = true;
            this.lblCategoriaDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaDet.Location = new System.Drawing.Point(351, 240);
            this.lblCategoriaDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaDet.Name = "lblCategoriaDet";
            this.lblCategoriaDet.Size = new System.Drawing.Size(79, 17);
            this.lblCategoriaDet.TabIndex = 12;
            this.lblCategoriaDet.Text = "Categoría:";
            // 
            // lblDeporteDet
            // 
            this.lblDeporteDet.AutoSize = true;
            this.lblDeporteDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporteDet.Location = new System.Drawing.Point(365, 141);
            this.lblDeporteDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeporteDet.Name = "lblDeporteDet";
            this.lblDeporteDet.Size = new System.Drawing.Size(65, 17);
            this.lblDeporteDet.TabIndex = 10;
            this.lblDeporteDet.Text = "Deporte:";
            // 
            // lblNombreDet
            // 
            this.lblNombreDet.AutoSize = true;
            this.lblNombreDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDet.Location = new System.Drawing.Point(33, 50);
            this.lblNombreDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDet.Name = "lblNombreDet";
            this.lblNombreDet.Size = new System.Drawing.Size(65, 17);
            this.lblNombreDet.TabIndex = 7;
            this.lblNombreDet.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::TestIt.Properties.Resources._032_cancel__Personalizado_;
            this.btnCancelar.Location = new System.Drawing.Point(875, 589);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 40);
            this.btnCancelar.TabIndex = 13;
            this.toolTip.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Image = global::TestIt.Properties.Resources._008_tick__Personalizado_;
            this.btnAceptar.Location = new System.Drawing.Point(809, 589);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(45, 40);
            this.btnAceptar.TabIndex = 12;
            this.toolTip.SetToolTip(this.btnAceptar, "Aceptar");
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::TestIt.Properties.Resources._202_delete_user__Personalizado_;
            this.btnEliminar.Location = new System.Drawing.Point(568, 589);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(45, 40);
            this.btnEliminar.TabIndex = 11;
            this.toolTip.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::TestIt.Properties.Resources._203_user_3__Personalizado_;
            this.btnEditar.Location = new System.Drawing.Point(503, 589);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 40);
            this.btnEditar.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::TestIt.Properties.Resources._198_add_user__Personalizado_1;
            this.btnAgregar.Location = new System.Drawing.Point(437, 589);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 40);
            this.btnAgregar.TabIndex = 9;
            this.toolTip.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // ctrlDeportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpEdicion);
            this.Controls.Add(this.grdDeportistas);
            this.Controls.Add(this.grpFiltros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlDeportistas";
            this.Size = new System.Drawing.Size(1047, 677);
            this.Load += new System.EventHandler(this.ctrlDeportistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDeportistas)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.grpEdicion.ResumeLayout(false);
            this.grpEdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdDeportistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn deportista;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.ComboBox txtEquipo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ComboBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboDeporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grpEdicion;
        private System.Windows.Forms.ComboBox cboDetSexo;
        private System.Windows.Forms.Label lblSexoDet;
        private System.Windows.Forms.Label lblPesoDet;
        private System.Windows.Forms.Label lblAlturaDet;
        private System.Windows.Forms.TextBox txtDetApellido;
        private System.Windows.Forms.Label lblApellidoDet;
        private System.Windows.Forms.Label lblDNIDet;
        private System.Windows.Forms.TextBox txtDetPeso;
        private System.Windows.Forms.TextBox txtDetAltura;
        private System.Windows.Forms.TextBox txtDetDNI;
        private System.Windows.Forms.TextBox txtDetNombre;
        private System.Windows.Forms.Label lblEquipoDet;
        private System.Windows.Forms.Label lblCategoriaDet;
        private System.Windows.Forms.Label lblDeporteDet;
        private System.Windows.Forms.Label lblNombreDet;
        private System.Windows.Forms.DateTimePicker dtpDetNacimiento;
        private System.Windows.Forms.Label lblNacimientoDet;
        private System.Windows.Forms.ComboBox cboDetCategoria;
        private System.Windows.Forms.ComboBox cboDetEquipo;
        private System.Windows.Forms.ComboBox cboDetDeporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
