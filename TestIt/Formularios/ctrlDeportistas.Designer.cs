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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDeportistas = new System.Windows.Forms.DataGridView();
            this.deportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboDeporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpEdicion = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblNacimientoDet = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblSexoDet = new System.Windows.Forms.Label();
            this.lblPesoDet = new System.Windows.Forms.Label();
            this.lblAlturaDet = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblApellidoDet = new System.Windows.Forms.Label();
            this.lblDNIDet = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDeportistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.grpFiltros.Controls.Add(this.comboBox2);
            this.grpFiltros.Controls.Add(this.lblEquipo);
            this.grpFiltros.Controls.Add(this.comboBox1);
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
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(455, 56);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 24);
            this.comboBox2.TabIndex = 15;
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(455, 101);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 13;
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
            this.grpEdicion.Controls.Add(this.dateTimePicker1);
            this.grpEdicion.Controls.Add(this.lblNacimientoDet);
            this.grpEdicion.Controls.Add(this.comboBox6);
            this.grpEdicion.Controls.Add(this.comboBox5);
            this.grpEdicion.Controls.Add(this.comboBox4);
            this.grpEdicion.Controls.Add(this.comboBox3);
            this.grpEdicion.Controls.Add(this.lblSexoDet);
            this.grpEdicion.Controls.Add(this.lblPesoDet);
            this.grpEdicion.Controls.Add(this.lblAlturaDet);
            this.grpEdicion.Controls.Add(this.textBox5);
            this.grpEdicion.Controls.Add(this.lblApellidoDet);
            this.grpEdicion.Controls.Add(this.lblDNIDet);
            this.grpEdicion.Controls.Add(this.textBox4);
            this.grpEdicion.Controls.Add(this.textBox3);
            this.grpEdicion.Controls.Add(this.textBox2);
            this.grpEdicion.Controls.Add(this.textBox1);
            this.grpEdicion.Controls.Add(this.label2);
            this.grpEdicion.Controls.Add(this.label3);
            this.grpEdicion.Controls.Add(this.label4);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(455, 91);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 22);
            this.dateTimePicker1.TabIndex = 32;
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
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Enabled = false;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(455, 237);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(197, 24);
            this.comboBox6.TabIndex = 30;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Enabled = false;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(455, 187);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(197, 24);
            this.comboBox5.TabIndex = 29;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(455, 138);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(197, 24);
            this.comboBox4.TabIndex = 28;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(116, 91);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(197, 24);
            this.comboBox3.TabIndex = 27;
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
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(455, 47);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(197, 23);
            this.textBox5.TabIndex = 22;
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
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(116, 237);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 23);
            this.textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(116, 187);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 23);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(116, 138);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 23);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(116, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 23);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Equipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Categoría:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Deporte:";
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboDeporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grpEdicion;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblSexoDet;
        private System.Windows.Forms.Label lblPesoDet;
        private System.Windows.Forms.Label lblAlturaDet;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblApellidoDet;
        private System.Windows.Forms.Label lblDNIDet;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombreDet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblNacimientoDet;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
