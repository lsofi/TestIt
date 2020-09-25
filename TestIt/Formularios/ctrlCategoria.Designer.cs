﻿namespace TestIt.Formularios
{
    partial class ctrlCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlCategoria));
            this.grdCategoría = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtNombreDet = new System.Windows.Forms.TextBox();
            this.lblNombreDet = new System.Windows.Forms.Label();
            this.grpCategoria = new System.Windows.Forms.GroupBox();
            this.txtEdadMinDet = new System.Windows.Forms.TextBox();
            this.lbEdadMinDet = new System.Windows.Forms.Label();
            this.txtEdadMaxDet = new System.Windows.Forms.TextBox();
            this.lblEdadMaxDet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoría)).BeginInit();
            this.grpCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCategoría
            // 
            this.grdCategoría.AllowUserToAddRows = false;
            this.grdCategoría.AllowUserToDeleteRows = false;
            this.grdCategoría.AllowUserToResizeColumns = false;
            this.grdCategoría.AllowUserToResizeRows = false;
            this.grdCategoría.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCategoría.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grdCategoría.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCategoría.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdCategoría.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategoría.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCategoria});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCategoría.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdCategoría.Location = new System.Drawing.Point(37, 47);
            this.grdCategoría.Margin = new System.Windows.Forms.Padding(4);
            this.grdCategoría.MultiSelect = false;
            this.grdCategoría.Name = "grdCategoría";
            this.grdCategoría.ReadOnly = true;
            this.grdCategoría.RowHeadersVisible = false;
            this.grdCategoría.RowHeadersWidth = 51;
            this.grdCategoría.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCategoría.Size = new System.Drawing.Size(242, 582);
            this.grdCategoría.TabIndex = 3;
            this.grdCategoría.SelectionChanged += new System.EventHandler(this.grdCategoría_SelectionChanged_1);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.MinimumWidth = 6;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
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
            this.btnCancelar.Location = new System.Drawing.Point(821, 443);
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
            this.btnAceptar.Location = new System.Drawing.Point(755, 443);
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
            this.btnEliminar.Location = new System.Drawing.Point(567, 443);
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
            this.btnEditar.Location = new System.Drawing.Point(502, 443);
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
            this.btnAgregar.Location = new System.Drawing.Point(436, 443);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 40);
            this.btnAgregar.TabIndex = 9;
            this.toolTip.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombreDet
            // 
            this.txtNombreDet.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNombreDet.Enabled = false;
            this.txtNombreDet.Location = new System.Drawing.Point(148, 41);
            this.txtNombreDet.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDet.Name = "txtNombreDet";
            this.txtNombreDet.Size = new System.Drawing.Size(197, 23);
            this.txtNombreDet.TabIndex = 9;
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
            // grpCategoria
            // 
            this.grpCategoria.Controls.Add(this.txtEdadMinDet);
            this.grpCategoria.Controls.Add(this.lbEdadMinDet);
            this.grpCategoria.Controls.Add(this.txtEdadMaxDet);
            this.grpCategoria.Controls.Add(this.lblEdadMaxDet);
            this.grpCategoria.Controls.Add(this.txtNombreDet);
            this.grpCategoria.Controls.Add(this.lblNombreDet);
            this.grpCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategoria.ForeColor = System.Drawing.Color.LightGray;
            this.grpCategoria.Location = new System.Drawing.Point(433, 173);
            this.grpCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategoria.Name = "grpCategoria";
            this.grpCategoria.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategoria.Size = new System.Drawing.Size(433, 219);
            this.grpCategoria.TabIndex = 14;
            this.grpCategoria.TabStop = false;
            this.grpCategoria.Text = "Categoría";
            // 
            // txtEdadMinDet
            // 
            this.txtEdadMinDet.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEdadMinDet.Enabled = false;
            this.txtEdadMinDet.Location = new System.Drawing.Point(148, 152);
            this.txtEdadMinDet.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdadMinDet.Name = "txtEdadMinDet";
            this.txtEdadMinDet.Size = new System.Drawing.Size(197, 23);
            this.txtEdadMinDet.TabIndex = 13;
            // 
            // lbEdadMinDet
            // 
            this.lbEdadMinDet.AutoSize = true;
            this.lbEdadMinDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdadMinDet.Location = new System.Drawing.Point(31, 156);
            this.lbEdadMinDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEdadMinDet.Name = "lbEdadMinDet";
            this.lbEdadMinDet.Size = new System.Drawing.Size(99, 17);
            this.lbEdadMinDet.TabIndex = 12;
            this.lbEdadMinDet.Text = "Edad mínima:";
            // 
            // txtEdadMaxDet
            // 
            this.txtEdadMaxDet.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEdadMaxDet.Enabled = false;
            this.txtEdadMaxDet.Location = new System.Drawing.Point(148, 96);
            this.txtEdadMaxDet.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdadMaxDet.Name = "txtEdadMaxDet";
            this.txtEdadMaxDet.Size = new System.Drawing.Size(197, 23);
            this.txtEdadMaxDet.TabIndex = 11;
            // 
            // lblEdadMaxDet
            // 
            this.lblEdadMaxDet.AutoSize = true;
            this.lblEdadMaxDet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadMaxDet.Location = new System.Drawing.Point(27, 100);
            this.lblEdadMaxDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdadMaxDet.Name = "lblEdadMaxDet";
            this.lblEdadMaxDet.Size = new System.Drawing.Size(103, 17);
            this.lblEdadMaxDet.TabIndex = 10;
            this.lblEdadMaxDet.Text = "Edad máxima:";
            // 
            // ctrlCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.grpCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grdCategoría);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlCategoria";
            this.Size = new System.Drawing.Size(1047, 677);
            this.Load += new System.EventHandler(this.ctrlCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoría)).EndInit();
            this.grpCategoria.ResumeLayout(false);
            this.grpCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdCategoría;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtNombreDet;
        private System.Windows.Forms.Label lblNombreDet;
        private System.Windows.Forms.GroupBox grpCategoria;
        private System.Windows.Forms.TextBox txtEdadMinDet;
        private System.Windows.Forms.Label lbEdadMinDet;
        private System.Windows.Forms.TextBox txtEdadMaxDet;
        private System.Windows.Forms.Label lblEdadMaxDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
    }
}
