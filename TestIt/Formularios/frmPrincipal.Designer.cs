namespace TestIt.Formularios
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.btnEjecuciones = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnTests = new System.Windows.Forms.Button();
            this.btnDeportes = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnDeportistas = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnTests1 = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.panelMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelTitulo.Controls.Add(this.lblBienvenido);
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1920, 66);
            this.panelTitulo.TabIndex = 0;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.LightGray;
            this.lblBienvenido.Location = new System.Drawing.Point(16, 14);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(155, 30);
            this.lblBienvenido.TabIndex = 9;
            this.lblBienvenido.Text = "Bienvenido ";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.AutoSize = true;
            this.btnMinimizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.LightGray;
            this.btnMinimizar.Location = new System.Drawing.Point(1845, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 28);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Location = new System.Drawing.Point(1876, 14);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 28);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "x";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenuVertical.Controls.Add(this.btnTests1);
            this.panelMenuVertical.Controls.Add(this.btnEjecuciones);
            this.panelMenuVertical.Controls.Add(this.btnListado);
            this.panelMenuVertical.Controls.Add(this.btnTests);
            this.panelMenuVertical.Controls.Add(this.btnDeportes);
            this.panelMenuVertical.Controls.Add(this.btnCategoria);
            this.panelMenuVertical.Controls.Add(this.btnEquipos);
            this.panelMenuVertical.Controls.Add(this.imgLogo);
            this.panelMenuVertical.Controls.Add(this.btnDeportistas);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 66);
            this.panelMenuVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(350, 1040);
            this.panelMenuVertical.TabIndex = 1;
            // 
            // btnEjecuciones
            // 
            this.btnEjecuciones.FlatAppearance.BorderSize = 0;
            this.btnEjecuciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnEjecuciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecuciones.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecuciones.ForeColor = System.Drawing.Color.LightGray;
            this.btnEjecuciones.Location = new System.Drawing.Point(6, 495);
            this.btnEjecuciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEjecuciones.Name = "btnEjecuciones";
            this.btnEjecuciones.Size = new System.Drawing.Size(336, 49);
            this.btnEjecuciones.TabIndex = 6;
            this.btnEjecuciones.Text = "Ejecuciones";
            this.btnEjecuciones.UseVisualStyleBackColor = true;
            this.btnEjecuciones.Click += new System.EventHandler(this.btnEjecuciones_Click);
            // 
            // btnListado
            // 
            this.btnListado.FlatAppearance.BorderSize = 0;
            this.btnListado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListado.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.ForeColor = System.Drawing.Color.LightGray;
            this.btnListado.Location = new System.Drawing.Point(4, 613);
            this.btnListado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(336, 49);
            this.btnListado.TabIndex = 5;
            this.btnListado.Text = "Listados";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnTests
            // 
            this.btnTests.Location = new System.Drawing.Point(0, 0);
            this.btnTests.Name = "btnTests";
            this.btnTests.Size = new System.Drawing.Size(75, 23);
            this.btnTests.TabIndex = 7;
            // 
            // btnDeportes
            // 
            this.btnDeportes.FlatAppearance.BorderSize = 0;
            this.btnDeportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnDeportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeportes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeportes.ForeColor = System.Drawing.Color.LightGray;
            this.btnDeportes.Location = new System.Drawing.Point(4, 428);
            this.btnDeportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeportes.Name = "btnDeportes";
            this.btnDeportes.Size = new System.Drawing.Size(336, 49);
            this.btnDeportes.TabIndex = 3;
            this.btnDeportes.Text = "Deportes";
            this.btnDeportes.UseVisualStyleBackColor = true;
            this.btnDeportes.Click += new System.EventHandler(this.btnDeportes_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.LightGray;
            this.btnCategoria.Location = new System.Drawing.Point(4, 369);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(336, 49);
            this.btnCategoria.TabIndex = 2;
            this.btnCategoria.Text = "Categorías";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnEquipos
            // 
            this.btnEquipos.FlatAppearance.BorderSize = 0;
            this.btnEquipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipos.ForeColor = System.Drawing.Color.LightGray;
            this.btnEquipos.Location = new System.Drawing.Point(4, 311);
            this.btnEquipos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(336, 49);
            this.btnEquipos.TabIndex = 1;
            this.btnEquipos.Text = "Equipos";
            this.btnEquipos.UseVisualStyleBackColor = true;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::TestIt.Properties.Resources.imgLogo__Personalizado_;
            this.imgLogo.Location = new System.Drawing.Point(102, 62);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(152, 137);
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // btnDeportistas
            // 
            this.btnDeportistas.FlatAppearance.BorderSize = 0;
            this.btnDeportistas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnDeportistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeportistas.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeportistas.ForeColor = System.Drawing.Color.LightGray;
            this.btnDeportistas.Location = new System.Drawing.Point(4, 252);
            this.btnDeportistas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeportistas.Name = "btnDeportistas";
            this.btnDeportistas.Size = new System.Drawing.Size(336, 49);
            this.btnDeportistas.TabIndex = 0;
            this.btnDeportistas.Text = "Deportistas";
            this.btnDeportistas.UseVisualStyleBackColor = true;
            this.btnDeportistas.Click += new System.EventHandler(this.btnDeportistas_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(350, 66);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1570, 1040);
            this.panelContenedor.TabIndex = 2;
            // 
            // btnTests1
            // 
            this.btnTests1.FlatAppearance.BorderSize = 0;
            this.btnTests1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnTests1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTests1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTests1.ForeColor = System.Drawing.Color.LightGray;
            this.btnTests1.Location = new System.Drawing.Point(4, 554);
            this.btnTests1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTests1.Name = "btnTests1";
            this.btnTests1.Size = new System.Drawing.Size(336, 49);
            this.btnTests1.TabIndex = 8;
            this.btnTests1.Text = "Tests";
            this.btnTests1.UseVisualStyleBackColor = true;
            this.btnTests1.Click += new System.EventHandler(this.btnTests1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1920, 1106);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuVertical);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label btnMinimizar;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Button btnDeportistas;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnDeportes;
        private System.Windows.Forms.Button btnTests;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnEjecuciones;
        private System.Windows.Forms.Button btnTests1;
    }
}